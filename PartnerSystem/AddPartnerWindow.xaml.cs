using System;
using System.Windows;
using PartnerSystem.Models;

namespace PartnerSystem
{
    public partial class AddPartnerWindow : Window
    {
        public AddPartnerWindow()
        {
            InitializeComponent();
            TypeComboBox.ItemsSource = Enum.GetValues(typeof(PartnerType));
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(RatingTextBox.Text) ||
                string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (TypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип партнера!");
                return;
            }

            try
            {
                var partner = new Partner
                {
                    Name = NameTextBox.Text,
                    Type = (PartnerType)TypeComboBox.SelectedIndex,
                    Phone = PhoneTextBox.Text,
                    Rating = int.Parse(RatingTextBox.Text),
                    Address = AddressTextBox.Text,
                    Director = DirectorTextBox.Text,
                    Email = EmailTextBox.Text
                };

                await OneCHelper.SavePartner(partner);
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}