﻿using System;
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

namespace WPF_Presentation.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }
     
        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber.Text; }
            set { contactNumber.Text = value; }
        
        }




    }
}
