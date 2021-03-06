﻿using System;
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
        public bool flag = false;
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
        public void addversion()
        {
            text += "//Generated by jisuanke Markdown Editor";
            text += Environment.NewLine;
            flag = true;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (!flag)
            {
                addversion();
            }
            text += infoMain.text;
            txtEditor.Text = text;
            infoMain.text = "";
            //MessageBox.Show(infoMain.text);
        }
    }
}
