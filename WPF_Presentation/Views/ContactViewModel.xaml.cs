using System;
using System.Collections.Generic;
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

namespace WPF_Presentation.Views
{
    /// <summary>
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public ContactViewModel()
        {
            InitializeComponent();

            var ContactList = new List<string>() {
              "",
              "",
             


            };

            foreach (var contact in ContactList)
            {
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Nikklas Nilsson", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Patrik Nilsson", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Sara Nilsson ", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Jonas Nilsson", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Malin Pettersson", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Johannes Nilsson", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Lucas Söderberg", ContactNumber = "072-1234567" });
                contactList.Children.Add(new Controls.ContactControl() { ContactName = "Theo Söderberg", ContactNumber = "072-1234567" });
            } 
        }

             




        }
    }

