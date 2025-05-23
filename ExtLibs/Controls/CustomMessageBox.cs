using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using MissionPlanner.Controls;
using System.Threading;
using System.Threading.Tasks;
using MissionPlanner.Utilities;

namespace MissionPlanner.MsgBox
{
    public static class CustomMessageBox
    {
        const int FORM_Y_MARGIN = 10;
        const int FORM_X_MARGIN = 16;

       public delegate void ThemeManager(Control ctl);

        public static event ThemeManager ApplyTheme;

        static DialogResult _state = DialogResult.None;

        static Image img_ok = global::MissionPlanner.Controls.Properties.Resources.btn_ok_big;
        static Image img_cancel = global::MissionPlanner.Controls.Properties.Resources.btn_cancel_big;
        static Image img_reboot = global::MissionPlanner.Controls.Properties.Resources.btn_act_reboot;
        static Image img_confirm = global::MissionPlanner.Controls.Properties.Resources.btn_confirm;

        public static DialogResult Show(string text)
        {
            return Show(text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Show(text, caption, buttons, MessageBoxIcon.None);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, string YesText = "Yes", string NoText = "No")
        {
            DialogResult answer = DialogResult.Cancel;

            Console.WriteLine("CustomMessageBox thread calling " + System.Threading.Thread.CurrentThread.Name);

            // ensure we run this on the right thread - mono - mac
            if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
            {
                try
                {
                    Application.OpenForms[0].Invoke((Action)delegate
                    {
                        Console.WriteLine("CustomMessageBox thread running invoke " +
                                          System.Threading.Thread.CurrentThread.Name);
                        answer = ShowUI(text, caption, buttons, icon, YesText, NoText);
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // fall back
                    Console.WriteLine("CustomMessageBox thread running " + System.Threading.Thread.CurrentThread.Name);
                    answer = ShowUI(text, caption, buttons, icon, YesText, NoText);
                }
            }
            else
            {
                Console.WriteLine("CustomMessageBox thread running " + System.Threading.Thread.CurrentThread.Name);
                answer = ShowUI(text, caption, buttons, icon, YesText, NoText);
            }

            return answer;
        }

        static DialogResult ShowUI(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, string YesText = "Yes", string NoText = "No", bool label = true)
        {
            float fontmag = Settings.Instance.GetFloat("custom_msgbox_fontmag", 1.5f);
            double opacity = Settings.Instance.GetDouble("custom_msgbox_opacity", 0.85);

            DialogResult answer = DialogResult.Abort;

            if (text == null)
                text = "";

            if (caption == null)
                caption = "";

            string link = "";
            string linktext = "";


            Regex linkregex = new Regex(@"(\[link;([^\]]+);([^\]]+)\])", RegexOptions.IgnoreCase);
            Match match = linkregex.Match(text);
            if (match.Success)
            {
                link = match.Groups[2].Value;
                linktext = match.Groups[3].Value;
                text = text.Replace(match.Groups[1].Value, "");
            }

            // ensure we are always in a known state
            _state = DialogResult.None;

            // convert to nice wrapped lines.
            text = AddNewLinesToText(text);
            // get pixel width and height
            //Size textSize = TextRenderer.MeasureText(text, SystemFonts.DefaultFont);
            Font font = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size * fontmag);
            Size textSize = TextRenderer.MeasureText(text, font);
            // allow for icon
            if (icon != MessageBoxIcon.None)
                textSize.Width += SystemIcons.Question.Width;

            using (var msgBoxFrm = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowInTaskbar = true,
                StartPosition = FormStartPosition.CenterParent,
                Text = caption,
                MaximizeBox = false,
                MinimizeBox = false,
                Width = textSize.Width + 50,
                Height = textSize.Height + 125,
                TopMost = true,
                AutoScaleMode = AutoScaleMode.None,
                Opacity = opacity,
            })
            {

                Rectangle screenRectangle = msgBoxFrm.RectangleToScreen(msgBoxFrm.ClientRectangle);
                int titleHeight = screenRectangle.Top - msgBoxFrm.Top;

                Control lblMessage = null;

                if (label)
                {
                    lblMessage = new Label()
                    {
                        Left = 58,
                        Top = 15,
                        Width = textSize.Width + (int)(10 * fontmag),
                        Height = textSize.Height + 10,
                        Text = text,
                        Font = font,
                        AutoSize = true
                    };
                }
                else
                {
                    lblMessage = new TextBox()
                    {
                        ReadOnly = true,
                        Multiline = true,
                        Left = 58,
                        Top = 15,
                        Width = textSize.Width + (int)(10 * fontmag),
                        Height = Math.Min(textSize.Height + 10, 500),
                        Text = text,
                        Font = font,
                        AutoSize = true,
                        ScrollBars = ScrollBars.Vertical
                    };
                }

                msgBoxFrm.Controls.Add(lblMessage);

                msgBoxFrm.Width = lblMessage.Right + 50;

                if (link != "" && linktext != "")
                {
                    linktext = AddNewLinesToText(linktext);
                    Size textSize2 = TextRenderer.MeasureText(linktext, SystemFonts.DefaultFont);
                    var linklbl = new LinkLabel
                    {
                        Left = FORM_X_MARGIN,
                        Top = lblMessage.Bottom,
                        Width = textSize2.Width,
                        Height = textSize2.Height,
                        Text = linktext,
                        Tag = link,
                        AutoSize = true
                    };
                    linklbl.Click += (sender, args) =>
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(((LinkLabel)sender).Tag.ToString());
                        }
                        catch (Exception)
                        {
                            Show("Failed to open link " + ((LinkLabel)sender).Tag.ToString());
                        }
                    };

                    msgBoxFrm.Controls.Add(linklbl);

                    msgBoxFrm.Width = Math.Max(msgBoxFrm.Width, linklbl.Right + 16);
                }

                var actualIcon = getMessageBoxIcon(icon);

                if (actualIcon == null)
                {
                    lblMessage.Location = new Point(FORM_X_MARGIN, FORM_Y_MARGIN);
                }
                else
                {
                    var iconPbox = new PictureBox
                    {
                        Image = actualIcon.ToBitmap(),
                        Location = new Point(FORM_X_MARGIN, FORM_Y_MARGIN)
                    };
                    msgBoxFrm.Controls.Add(iconPbox);
                }


                AddButtonsToForm(msgBoxFrm, buttons, YesText, NoText);

                // display even if theme fails
                try
                {
                    if (ApplyTheme != null)
                        ApplyTheme(msgBoxFrm);
                    //ThemeManager.ApplyThemeTo(msgBoxFrm);
                }
                catch
                {
                }

                DialogResult test = msgBoxFrm.ShowDialog();

                answer = _state;
            }

            return answer;
        }

        // from http://stackoverflow.com/questions/2512781/winforms-big-paragraph-tooltip/2512895#2512895
        private static int maximumSingleLineTooltipLength = 85;

        private static string AddNewLinesToText(string text)
        {
            if (text.Length < maximumSingleLineTooltipLength)
                return text;
            int lineLength = maximumSingleLineTooltipLength;
            StringBuilder sb = new StringBuilder();
            int currentLinePosition = 0;
            for (int textIndex = 0; textIndex < text.Length; textIndex++)
            {
                // If we have reached the target line length and the next      
                // character is whitespace then begin a new line.   
                if (currentLinePosition >= lineLength &&
                    char.IsWhiteSpace(text[textIndex]))
                {
                    sb.Append(Environment.NewLine);
                    currentLinePosition = 0;
                }
                // reset line lnegth counter on existing new line
                if (text[textIndex] == Environment.NewLine[Environment.NewLine.Length -1])
                {
                    currentLinePosition = 1;
                }
                // If we have just started a new line, skip all the whitespace.    
                if (currentLinePosition == 0)
                    while (textIndex < text.Length && char.IsWhiteSpace(text[textIndex]))
                        textIndex++;
                // Append the next character.     
                if (textIndex < text.Length) sb.Append(text[textIndex]);
                currentLinePosition++;
            }
            return sb.ToString();
        }

        private static void AddButtonsToForm(Form msgBoxFrm, MessageBoxButtons buttons, string YesText = "Yes", string NoText = "No")
        {
            Rectangle screenRectangle = msgBoxFrm.RectangleToScreen(msgBoxFrm.ClientRectangle);
            int titleHeight = screenRectangle.Top - msgBoxFrm.Top;

            var t = Type.GetType("Mono.Runtime");
            if ((t != null))
                titleHeight = 25;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
//                    var but = new MyButton
                    var but = new Button
                    {
//                        Size = new Size(75, 23),
                        BackgroundImage = img_ok,
                        Size = new Size(113, 63),
//                        Text = "OK",
                        Left = msgBoxFrm.Width - 113 - FORM_X_MARGIN,
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    but.Click += delegate { _state = DialogResult.OK; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(but);
                    msgBoxFrm.AcceptButton = but;
                    break;

                case MessageBoxButtons.YesNo:

                    if (msgBoxFrm.Width < (75 * 2 + FORM_X_MARGIN * 3))
                        msgBoxFrm.Width = (75 * 2 + FORM_X_MARGIN * 3);

//                    var butyes = new MyButton
                    var butyes = new Button
                    {
//                        Size = new Size(75, 23),
                        BackgroundImage = img_ok,
                        Size = new Size(113, 63),
                        //Text = YesText,
                        Left = msgBoxFrm.Width - 113 * 2 - FORM_X_MARGIN * 2,
//                        Top = msgBoxFrm.Height - 23 - FORM_Y_MARGIN - titleHeight
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    butyes.Click += delegate { _state = DialogResult.Yes; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butyes);
                    msgBoxFrm.AcceptButton = butyes;

//                    var butno = new MyButton
                    var butno = new Button
                    {
//                        Size = new Size(75, 23),
                        BackgroundImage = img_cancel,
                        Size = new Size(113, 63),
                        //Text = NoText,
                        Left = msgBoxFrm.Width - 113 - FORM_X_MARGIN,
//                        Top = msgBoxFrm.Height - 23 - FORM_Y_MARGIN - titleHeight
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    butno.Click += delegate { _state = DialogResult.No; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butno);
                    msgBoxFrm.CancelButton = butno;
                    break;

                case MessageBoxButtons.OKCancel:

                    if (msgBoxFrm.Width < (75 * 2 + FORM_X_MARGIN * 3))
                        msgBoxFrm.Width = (75 * 2 + FORM_X_MARGIN * 3);

//                    var butok = new MyButton
                    var butok = new Button
                    {
//                        Size = new Size(75, 23),
                        BackgroundImage = img_ok,
                        Size = new Size(113, 63),
//                        Text = "OK",
                        Left = msgBoxFrm.Width - 113 * 2 - FORM_X_MARGIN * 2,
//                        Top = msgBoxFrm.Height - 23 - FORM_Y_MARGIN - titleHeight
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    butok.Click += delegate { _state = DialogResult.OK; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butok);
                    msgBoxFrm.AcceptButton = butok;

//                    var butcancel = new MyButton
                    var butcancel = new Button
                    {
//                        Size = new Size(75, 23),
                        BackgroundImage = img_cancel,
                        Size = new Size(113, 63),
//                        Text = "Cancel",
                        Left = msgBoxFrm.Width - 113 - FORM_X_MARGIN,
//                        Top = msgBoxFrm.Height - 23 - FORM_Y_MARGIN - titleHeight
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    butcancel.Click += delegate { _state = DialogResult.Cancel; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butcancel);
                    msgBoxFrm.CancelButton = butcancel;
                    break;

                case MessageBoxButtons.RetryCancel:  // @eams add
                    var butretry = new Button
                    {
                        //                        Size = new Size(75, 23),
                        BackgroundImage = img_reboot,
                        Size = new Size(130, 48),
                        Left = msgBoxFrm.Width - 135 - FORM_X_MARGIN,
                        Top = msgBoxFrm.Height - 48 - FORM_Y_MARGIN - titleHeight
                    };

                    butretry.Click += delegate { _state = DialogResult.Retry; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butretry);
                    msgBoxFrm.AcceptButton = butretry;
                    break;

                case MessageBoxButtons.AbortRetryIgnore:  // @eams add
                    var butconfirm = new Button
                    {
                        //                        Size = new Size(75, 23),
                        BackgroundImage = img_confirm,
                        Size = new Size(113, 63),
                        Left = msgBoxFrm.Width - 113 - FORM_X_MARGIN,
                        Top = msgBoxFrm.Height - 63 - FORM_Y_MARGIN - titleHeight
                    };

                    butconfirm.Click += delegate { _state = DialogResult.Retry; msgBoxFrm.Close(); };
                    msgBoxFrm.Controls.Add(butconfirm);
                    msgBoxFrm.AcceptButton = butconfirm;
                    break;

                default:
                    throw new NotImplementedException("Only MessageBoxButtons.OK and YesNo supported at this time");
            }
        }

        /// <summary>
        /// Get system icon for MessageBoxIcon.
        /// </summary>
        /// <param name="icon">The MessageBoxIcon value.</param>
        /// <returns>SystemIcon type Icon.</returns>
        private static Icon getMessageBoxIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Asterisk:
                    return SystemIcons.Asterisk;
                case MessageBoxIcon.Error:
                    return SystemIcons.Error;
                case MessageBoxIcon.Exclamation:
                    return SystemIcons.Exclamation;
                case MessageBoxIcon.Question:
                    return SystemIcons.Question;
                default:
                    return null;
            }
        }

        public static DialogResult ShowTextBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, string YesText = "Yes", string NoText = "No")
        {
            DialogResult answer = DialogResult.Cancel;

            Console.WriteLine("CustomMessageBox ShowTextBox thread calling " + System.Threading.Thread.CurrentThread.Name);

            // ensure we run this on the right thread - mono - mac
            if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
            {
                try
                {
                    Application.OpenForms[0].Invoke((Action)delegate
                    {
                        Console.WriteLine("CustomMessageBox ShowTextBox thread running invoke " +
                                          System.Threading.Thread.CurrentThread.Name);
                        answer = ShowUI(text, caption, buttons, icon, YesText, NoText, false);
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // fall back
                    Console.WriteLine("CustomMessageBox ShowTextBox thread running " + System.Threading.Thread.CurrentThread.Name);
                    answer = ShowUI(text, caption, buttons, icon, YesText, NoText, false);
                }
            }
            else
            {
                Console.WriteLine("CustomMessageBox ShowTextBox thread running " + System.Threading.Thread.CurrentThread.Name);
                answer = ShowUI(text, caption, buttons, icon, YesText, NoText, false);
            }

            return answer;
        }
    }
}