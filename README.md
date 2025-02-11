## log4net

### [log4netとは](https://logging.apache.org/log4net/)

log4netは、Apache Software Foundationが開発した、C\# (.NET Framework) アプリケーション向けのロギングライブラリです。

**特徴:**

  * **柔軟な設定:** ログの出力先、フォーマット、レベルなどを自由に設定できます。
  * **多様な出力先:** ファイル、コンソール、データベースなど、様々な場所へログを出力できます。
  * **パフォーマンス:** 高速かつ効率的なログ出力が可能です。

### log4netの導入

1. **NuGetパッケージのインストール**
    Visual StudioのNuGetパッケージマネージャーコンソールで、以下のコマンドを実行します。

    ```
    Install-Package log4net
    ```

2. **App.configに設定を追加するパターン**

    AssemblyInfo.csに以下のコードを追加することでログが出力されるようになります。

    ```C#
    [assembly: log4net.Config.XmlConfigurator(Watch = true)] 
    ```

    

3. **log4net.configに設定を追加するパターン**

   * log4netの設定ファイル (log4net.config) をプロジェクト直下に追加します。
   * AssemblyInfo.csに以下のコードを追加することでlog4netの設定ファイルをもとにログが出力されるようになります。
   * log4net.configのプロパティの出力ディレクトリにコピーします。

    ```C#
    [assembly: log4net.Config.XmlConfigurator(Watch = true, ConfigFile = "log4net.config")]
    ```



### [log4netの使い方](https://logging.apache.org/log4net/release/manual/introduction.html)

1. **ロガーの取得:**
    クラス内でロガーを取得します。

    ```csharp
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    ```

2. **ログ出力:**
    ログレベルに応じたメソッドを使ってログを出力します。

    ```csharp
    log.Debug("デバッグログ");
    log.Info("情報ログ");
    log.Warn("警告ログ");
    log.Error("エラーログ");
    log.Fatal("致命的なエラーログ");
    ```

3. **設定ファイルの読み込み:**
    設定ファイルを読み込むこともできます。

    ```csharp
    log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
    ```

### log4net.configについてもう少し詳しく

#### log4net.configとは

log4net.configは、log4netの動作を制御する設定ファイルです。ログの出力先、フォーマット、レベルなどをXML形式で記述します。

#### log4net.configの構成

log4net.configは、大きく分けて以下の要素で構成されます。

- **`<log4net>`タグ:** log4netの設定全体を囲むroot要素です。

- **`<root>`タグ:** ルートロガーの設定を行います。

- **`<appender>`タグ:** ログの出力先 (appender) を定義します。[Appender一覧](https://logging.apache.org/log4net/release/manual/introduction.html)

    - 各appenderに応じた設定をappenderタグ内で行います。

- **`<layout>`タグ:** ログのフォーマットを定義します。

    ​    

### 参考資料

  * [Apache log4net](https://logging.apache.org/log4net/index.html)
