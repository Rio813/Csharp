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

namespace 数据库设计练习
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        A07DbEntities1 context = new A07DbEntities1();
        public MainWindow()
        {
            InitializeComponent();
            object o = new object();
            RoutedEventArgs e = new RoutedEventArgs();
            Button_Click(o, e);
        }
        //数据查询
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var q = context.Database.SqlQuery<student>("select * from student");
            datagrid.ItemsSource = q.ToList();
        }
    }
}
