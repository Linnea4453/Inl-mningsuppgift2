using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Presentation.Controls
{
    /// <summary>
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public string From
        {
            get { return from.Text; }
            set { from.Text = value; }
        }

        public string Description
        {
            get { return description.Text; }
            set { description.Text = value; }

        }
        public string Time
        {
            get { return time.Text; }
            set { time.Text = value; }
        }

        public string Date
        {
            get { return date.Text; }
            set { date.Text = value; }

        }

        public void Btn_messages_Click(object sender, RoutedEventArgs e)
     {

       

       }
    }


}
