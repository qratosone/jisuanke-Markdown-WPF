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
        
        public void updateCode()
        {
            update.text += Environment.NewLine;
            update.text += "---";
            update.text += Environment.NewLine;
            if (lblStatus.Content.ToString() == "当前状态")
            {
                update.text += "### 初始化代码";
                update.text += Environment.NewLine;
                update.text += "```";
                update.text += Environment.NewLine;
                update.text += txtCode.Text;
                update.text += Environment.NewLine;
                update.text += "```";
                txtGuide.Text = "";
                txtTips.Text = "";
                lblStatus.Content = "已添加初始化代码";
                return;
            }
            if (txtTips.Text != "")
            {
                update.text += "### 第" + step.ToString() + "步";
                update.text += Environment.NewLine;
                update.text += "#### 讲解";
                update.text += Environment.NewLine;
                update.text += txtGuide.Text;
                update.text += Environment.NewLine;
                update.text += "#### 提示";
                update.text += Environment.NewLine;
                update.text += txtTips.Text;
                update.text += Environment.NewLine;
                update.text += "#### 代码";
                update.text += Environment.NewLine;
                update.text += "```";
                update.text += Environment.NewLine;
                update.text += txtCode.Text;
                update.text += Environment.NewLine;
                update.text += "```";
                lblStatus.Content = "已添加第" + step.ToString() + "步";
                step++;
                txtTips.Text = "添加提示";
            }
            else
            {
                update.text += "#### 完成讲解";
                update.text += Environment.NewLine;
                update.text += txtGuide.Text;
                lblStatus.Content = "已添加完成讲解";
            }

        }
        private void btnTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("btntitleclick");
            updateTitle();
        }

        private void btnCode_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("btncodeclick");
            updateCode();
        }
    }
}
