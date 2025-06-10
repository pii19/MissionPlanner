using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MissionPlanner.Utilities;
using Newtonsoft.Json;
using static MAVLink;

namespace FlightPlanningSoftware
{
    /// <summary>
    /// DataGridView 上でコマンドの追加／挿入、値の取得などを担当するクラスです。
    /// 使用する DataGridView の各列名は、指定した接頭辞(prefix) により決まります。
    /// 例：
    ///   - ウェイポイント用：prefix = "colWp" → "colWpCommand", "colWpParam1", … 
    ///   - フェンス用：prefix = "colFence" → "colFenceCommand", "colFenceParam1", … 
    ///   - ラリーポイント用：prefix = "colRally" → "colRallyCommand", "colRallyParam1", … 
    /// </summary>
    public class CommandManager
    {
        private DataGridView _grid;
        private string _prefix;

        private int colCommand;
        private int colParam1;
        private int colParam2;
        private int colParam3;
        private int colParam4;
        private int colLat;
        private int colLon;
        private int colAlt;
        private int colFrame;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="grid">対象の DataGridView</param>
        /// <param name="prefix">
        /// 使用する列の接頭辞。たとえばウェイポイント用なら "colWp"、
        /// フェンス用なら "colFence"、ラリーポイント用なら "colRally" を指定してください。
        /// </param>
        public CommandManager(DataGridView grid, string prefix)
        {
            _grid = grid;
            _prefix = prefix;
            // 各列名からインデックスを取得
            colCommand = grid.Columns[$"{prefix}Command"].Index;
            colParam1 = grid.Columns[$"{prefix}Param1"].Index;
            colParam2 = grid.Columns[$"{prefix}Param2"].Index;
            colParam3 = grid.Columns[$"{prefix}Param3"].Index;
            colParam4 = grid.Columns[$"{prefix}Param4"].Index;
            colLat = grid.Columns[$"{prefix}Lat"].Index;
            colLon = grid.Columns[$"{prefix}Lon"].Index;
            colAlt = grid.Columns[$"{prefix}Alt"].Index;
            colFrame = grid.Columns[$"{prefix}Frame"].Index;
        }

        public void AddCommand(MAV_CMD cmd, double p1, double p2, double p3, double p4,
                               double x, double y, double z, object tag = null)
        {
            int rowIndex = _grid.Rows.Add();
            FillCommand(rowIndex, cmd, p1, p2, p3, p4, x, y, z, tag);
        }

        public void InsertCommand(int rowIndex, MAV_CMD cmd, double p1, double p2, double p3, double p4,
                                  double x, double y, double z, object tag = null)
        {
            if (_grid.Rows.Count <= rowIndex)
            {
                AddCommand(cmd, p1, p2, p3, p4, x, y, z, tag);
                return;
            }
            _grid.Rows.Insert(rowIndex);
            FillCommand(rowIndex, cmd, p1, p2, p3, p4, x, y, z, tag);
        }

        private void FillCommand(int rowIndex, MAV_CMD cmd, double p1, double p2, double p3, double p4,
                                 double x, double y, double z, object tag = null)
        {
            _grid.Rows[rowIndex].Cells[colCommand].Value = cmd.ToString();
            _grid.Rows[rowIndex].Cells[colCommand].Tag = tag;
            _grid.Rows[rowIndex].Cells[colParam1].Value = p1;
            _grid.Rows[rowIndex].Cells[colParam2].Value = p2;
            _grid.Rows[rowIndex].Cells[colParam3].Value = p3;
            _grid.Rows[rowIndex].Cells[colParam4].Value = p4;
            _grid.Rows[rowIndex].Cells[colLat].Value = y;
            _grid.Rows[rowIndex].Cells[colLon].Value = x;
            _grid.Rows[rowIndex].Cells[colAlt].Value = z;
            _grid.Rows[rowIndex].Cells[colFrame].Value = (byte)MAV_FRAME.GLOBAL_RELATIVE_ALT;
        }

        /// <summary>
        /// DataGridView の全行を Locationwp オブジェクトリストに変換して返します。
        /// </summary>
        public List<Locationwp> GetCommandList()
        {
            List<Locationwp> commands = new List<Locationwp>();
            for (int i = 0; i < _grid.Rows.Count; i++)
            {
                try
                {
                    Locationwp temp = DataViewToLocationwp(i);
                    commands.Add(temp);
                }
                catch (FormatException ex)
                {
                    throw new Exception("Error parsing row " + (i + 1).ToString(), ex);
                }
            }
            return commands;
        }

        private Locationwp DataViewToLocationwp(int rowIndex)
        {
            var row = _grid.Rows[rowIndex];
            Locationwp temp = new Locationwp();
            string cmdStr = row.Cells[colCommand].Value.ToString();
            if (cmdStr.Contains("UNKNOWN"))
            {
                temp.id = (ushort)row.Cells[colCommand].Tag;
            }
            else
            {
                temp.id = GetCmdID(cmdStr);
            }
            temp.p1 = float.Parse(row.Cells[colParam1].Value.ToString());
            temp.alt = (float)(double.Parse(row.Cells[colAlt].Value.ToString()));
            temp.lat = double.Parse(row.Cells[colLat].Value.ToString());
            temp.lng = double.Parse(row.Cells[colLon].Value.ToString());
            temp.p2 = float.Parse(row.Cells[colParam2].Value.ToString());
            temp.p3 = float.Parse(row.Cells[colParam3].Value.ToString());
            temp.p4 = float.Parse(row.Cells[colParam4].Value.ToString());
            temp.Tag = row.Cells[colCommand].Tag;
            temp.frame = (byte)row.Cells[colFrame].Value;
            return temp;
        }

        public ushort GetCmdID(string cmdName)
        {
            if (Enum.IsDefined(typeof(MAV_CMD), cmdName))
            {
                return (ushort)Enum.Parse(typeof(MAV_CMD), cmdName, false);
            }
            var configCommands = JsonConvert.DeserializeObject<Dictionary<string, ushort>>(Settings.Instance["PlannerExtraCommandIDs"]);
            return configCommands[cmdName];
        }

        public void ClearCommands()
        {
            _grid.Rows.Clear();
        }

        public void ReindexCommands()
        {
            int total = _grid.Rows.Count;
            for (int i = 0; i < total; i++)
            {
                _grid.Rows[i].Cells[colParam1].Value = i;    // 0-based に設定（必要なら i+1 など調整）
                _grid.Rows[i].Cells[colParam2].Value = total;  // 総件数
            }
        }

    }
}
