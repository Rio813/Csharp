using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace 文本文件读写
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //读文件
        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            string filepath = txtfilepath.Text;
            //string content = File.ReadAllText(filepath);
            //txtContent.Text = content;
            //
            foreach (var v in File.ReadAllLines(filepath))
                txtContent.Text += v +"\n";
        }
        //写文件
        private void WriteButton_Click(object sender, RoutedEventArgs e)
        {
            //覆盖写
            File.WriteAllText(txtfilepath.Text, txtContent.Text);
            //追加写
            //File.AppendAllText(txtfilepath.Text, txtContent.Text);

            //清空输入框
            txtContent.Text = "";
        }
        //选择文件
        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            //(1)对象实例化
            OpenFileDialog ofd = new OpenFileDialog();
            //添加文件筛选器
            ofd.Filter = "所有文件|*.*|文本文件|*.txt|word文档|*.docx";
            //打开对话框获得选择文件的路径
            if(ofd.ShowDialog()==true)
            {
                txtfilepath.Text = ofd.FileName;
            }
        }
               
           }
}
