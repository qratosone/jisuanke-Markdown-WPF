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
using System.IO;
namespace jisuanke_Markdown_WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public info infoMain;

        public MainWindow()
        {
            infoMain = new info();
            InitializeComponent();
        }
        public String text = "";
        private String _FileName = "";
        public String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
                //在赋值时同步更新窗体标题
                Title = System.IO.Path.GetFileName(value) + "-jisuanke Markdown Editor";
            }
        }
        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            Code code = new Code();
            code.update = infoMain;
            code.Show();
        }
    }
}
