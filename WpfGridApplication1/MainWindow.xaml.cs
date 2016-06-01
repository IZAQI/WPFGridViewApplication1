using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfGridApplication1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //ビルドCLRバージョン取得(.NetFramework1.0では使用不可)
            string clrVerBuild = System.Reflection.Assembly.GetExecutingAssembly().ImageRuntimeVersion;

            Console.WriteLine(clrVerBuild);

            //実行CLRバージョン取得

            string clrVerRuntime = System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion();

            Console.WriteLine(clrVerRuntime);

        }
    }
}

