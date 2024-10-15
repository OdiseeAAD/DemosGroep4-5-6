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

namespace UserEventDemo
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView : UserControl
    {
      //  public event Action<Person> addPerson;
        public DetailView()
        {
            InitializeComponent();
            AddView.addPerson += AddView_addPerson;
        }

        private void AddView_addPerson(Person obj)
        {
            AddView.Visibility = Visibility.Hidden;
            ShowView.Visibility = Visibility.Visible;
           // addPerson(obj);
        }

        public void SetSelectedPerson(Person p)
        {
            ShowView.ShowSelectedPerson(p);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddView.Visibility = Visibility.Visible;
            ShowView.Visibility = Visibility.Hidden;

        }
    }
}
