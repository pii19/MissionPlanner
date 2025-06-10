Flight Planning Software 説明書

1. はじめに
Flight Planning Software は、ドローンや航空機のフライトプラン（ウェイポイント、フェンス、緊急着陸地点など）を作成・編集・保存・読込するためのアプリケーションです。

2. システム要件
OS: Windows 7以降（.NET Framework 4.7.2 必須）
ディスプレイ: 解像度 1280×720 以上（高解像度ディスプレイに対応）
その他: GMap.NET、log4net などの外部ライブラリが組み込まれています

3. インストール方法
配布されたフォルダ内の FlightPlanningSoftware.exe を起動してください。
初回起動時は、デフォルトでフルスクリーンモードで起動します。
ユーザ設定ファイル（fps_config.xml）により各種設定が反映されます。

4. ユーザ設定（fps_config.xml）
以下の場所に配置された fps_config.xml を編集することでいくつかの項目をカスタマイズできます。
"C:\Users\<ユーザ名>\Documents\Mission Planner\fps_config.xml"

fps_config.xml の例
---------------------------------------------------------
<?xml version="1.0" encoding="utf-8" ?>
<Config>
  <default_altitude>10</default_altitude>
  <default_exclusion_radius>10</default_exclusion_radius>
  <default_wpradius>10</default_wpradius>
  <drag_threshold>5</drag_threshold>
  <fence_offset>10</fence_offset>
  <map_provider>GoogleSatelliteMap</map_provider>
  <maplast_lat>37.5525444584759</maplast_lat>
  <maplast_lng>140.958013683558</maplast_lng>
  <maplast_zoom>20</maplast_zoom>
  <fullscreen>true</fullscreen>
</Config>
---------------------------------------------------------

default_altitude: ウェイポイントのデフォルトの高度
default_wpradius: ウェイポイントのデフォルトの半径
default_exclusion_radius: 進入禁止フェンスのデフォルトの半径
drag_threshold: マウスドラッグの感度
fence_offset: 逸脱防止フェンス生成時のオフセット距離
map_provider: マッププロバイダーの種類（例：GoogleSatelliteMap）
maplast_lat, maplast_lng, maplast_zoom: 最終表示位置とズームレベル
fullscreen: 起動時の表示モード

5. 主要機能
5.1 マップ表示
地図の操作:
マップ上でクリック、ドラッグ、ズーム操作によりフライトプランの各要素（ウェイポイント、フェンス、緊急着陸地点など）を配置・編集できます。

ズーム:
ズームイン・ズームアウトボタンやマウスホイールで拡大縮小が可能です。
読み込んだフライトプラン全体が表示されるよう、自動的に最適なズームレベルに調整する機能もあります。

5.2 ウェイポイントの作成・編集
離陸地点／着陸地点:
「離陸地点」ボタンや「着陸地点」ボタンを使って、各々の特殊なウェイポイントを配置します。
ウェイポイント間の連結が自動で行われ、経路が表示されます。

ウェイポイントの移動:
マーカーをドラッグすることで位置変更が可能です。
ドラッグ操作の感度は、fps_config.xml の drag_threshold で調整されます。

5.3 フェンスの生成
逸脱防止フェンス:
ウェイポイントリストから、一定のオフセット距離（fence_offset）を使ってフェンス多角形を自動生成します。

進入禁止フェンス:
必要に応じて、進入禁止フェンスも作成可能です。

5.4 緊急着陸地点（ラリー）の設定
緊急着陸地点ボタンを用いて、緊急時の着陸地点をマップ上に配置できます。

5.5 ファイルの保存・読込
保存:
「ファイルの保存」ボタンを押すと、現在のフライトプランがテキストファイルに出力されます。
ヘッダーには「EAMS Flight Plan Format 1.0」と記載され、各セクション（WP, FENCE_INCLUTION, FENCE_EXCLUTION, RALLY）が定義されます。

読込:
「ファイル読み込み」ボタンを押すと、保存済みのフライトプランファイルから各コマンドが読み込まれ、マップ上に再現されます。
ヘッダーの値（EAMS または EAMS Flight Plan Format 1.0）は読み飛ばされます。

5.6 一括削除
ウェイポイント、フェンス、緊急着陸地点のコマンドを全て削除します。

6. 起動時の動作
初回起動:
fps_config.xml に fullscreen 設定が存在しない場合、デフォルトでフルスクリーンモードで起動します。
また、fps_config.xml の内容（マップ位置、ズーム、その他各種パラメータ）が読み込まれ、ユーザ設定が反映されます。

終了時:
現在の各種設定（マップ位置、ズーム、fullscreen 状態など）が fps_config.xml に保存されます。

7. トラブルシューティング
ログファイル出力先
C:\ProgramData\Mission Planner\FlightPlanningSoftware.log

マップやウェイポイントが正しく表示されない場合:
fps_config.xml の設定値や、マッププロバイダーの設定、ウェイポイントの座標変換処理などを確認してください。

8. 開発者向け補足
ソースコードの配置:
FlightPlanningSoftware プロジェクトに、各機能ごとのクラス（MapManager、CommandManager、FenceCalculator、FlightPlanIO など）が配置されています。
設定値は、Settings クラス経由で fps_config.xml から読み込み・保存されます。

ログ出力:
log4net を使用して、コンソールおよび RollingFile にログ出力しています。