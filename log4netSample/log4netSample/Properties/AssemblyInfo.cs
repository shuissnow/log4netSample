using log4net.Config;
using System.Reflection;
using System.Runtime.InteropServices;

// アセンブリに関する一般的な情報は、次の方法で制御されます。
// 制御されます。アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更します。
[assembly: AssemblyTitle("log4netSample")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("log4netSample")]
[assembly: AssemblyCopyright("Copyright ©  2025")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定します。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("9141bfcd-d5fc-4021-b4ff-7bd666b43de0")]

// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      リビジョン
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
// Watch → trueの時は設定ファイルを監視する。ファイルが変更されるたびに設定を再読み込みする。
[assembly: XmlConfigurator(Watch = true, ConfigFile = "log4net.config")]