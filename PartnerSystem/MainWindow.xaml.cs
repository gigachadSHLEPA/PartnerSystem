using PartnerSystem.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace PartnerSystem
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Partner> _partners = new ObservableCollection<Partner>();
        public ObservableCollection<Partner> Partners { get => _partners; set => _partners = value; }
        public Partner SelectedPartner { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadPartners();
        }

        private async void LoadPartners()
        {
            var partners = await OneCHelper.GetPartners();
            Partners = new ObservableCollection<Partner>(partners);
        }

        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            var addPartnerWindow = new AddPartnerWindow();
            if (addPartnerWindow.ShowDialog() == true)
            {
                LoadPartners();
            }
        }
    }
}