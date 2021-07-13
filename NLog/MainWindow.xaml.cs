using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NLog
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        // Loggerクラスの宣言
        static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        // アプリケーションの実行ファイルのフォルダパスを取得
        string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        // ログファイルのフォルダパス
        string subDir = @"logs\";

        // ログファイルを保存するフルパスを作成
        string _logPath;

        public MainWindow()
        {
            InitializeComponent();

            // ログファイルを保存するフルパスを作成
            _logPath = System.IO.Path.Combine(appPath, subDir);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Infoレベルのログを書き込む
                _logger.Info("Hello World");
            }
            catch (Exception e1)
            {
                _logger.Error(e1, "Goodbye cruel world");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Warnレベルのログを書き込む
                _logger.Warn("warning Message");
            }
            catch (Exception e2)
            {
                _logger.Error(e2, "Goodbye cruel world");
            }
        }
    }
}
