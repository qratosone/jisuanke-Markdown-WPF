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
using System.Windows.Shapes;

namespace jisuanke_Markdown_WPF
{
    /// <summary>
    /// Code.xaml 的交互逻辑
    /// </summary>
    public partial class Code 
    {
        private int step;
        public info update;
        public Code()
        {
            step = 1;
            InitializeComponent();
        }
        public void updateTitle()
        {
            update.text += ("# " + txtTitle.Text);
            update.text += Environment.NewLine;
            update.text += "---";
            update.text += Environment.NewLine;
            update.text += ("- " + txtTag.Text);
            update.text += Environment.NewLine;
            txtTitle.Text = "已更新标题";
            txtTag.Text = "已更新tag";
        }
        private void btnTitle_Click(object sender, EventArgs e)
        {
            updateTitle();
        }
    }
}
