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
using WPF_Presentation.Controls;
using WPF_Presentation.Models;

namespace WPF_Presentation.Views
{
    /// <summary>
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewControl : UserControl
    {
        public MessageViewControl()
        {
            InitializeComponent();

           
           
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Jonas Nilsson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01"});
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Johannes Nilsson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
            MessagesList.Children.Add(new Controls.MessageControl() { From = "From Malin Petterson", Description = "kort beskrivning av meddelande", Date = "2020-09-21", Time = "13:01" });
        }

    }
}
