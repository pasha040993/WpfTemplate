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
using WpfTemplate.Models;

namespace WpfTemplate.Views
{
    /// <summary>
    /// Логика взаимодействия для MessageView.xaml
    /// </summary>
    public partial class MessageView : UserControl
    {
        public MessageView()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static DependencyProperty MessageProperty =
           DependencyProperty.Register("Message", typeof(string), typeof(MessageView));

        public StateModes State
        {
            get { return (StateModes)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static DependencyProperty StateProperty =
           DependencyProperty.Register("State", typeof(StateModes), typeof(MessageView));
    }
}
