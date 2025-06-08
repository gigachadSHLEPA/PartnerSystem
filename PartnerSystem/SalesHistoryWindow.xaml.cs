using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using PartnerSystem.Models;

namespace PartnerSystem
{
    public partial class SalesHistoryWindow : Window
    {
        public ObservableCollection<SalesRecord> SalesRecords { get; set; }

        public SalesHistoryWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadSalesHistory();
        }

        private async void LoadSalesHistory()
        {
            SalesRecords = new ObservableCollection<SalesRecord>();
            var response = await new HttpClient().GetAsync("http://localhost:8888/1C/v8std/odata/SalesHistoryService/GetSalesHistory");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var records = JsonSerializer.Deserialize<List<SalesRecord>>(json);

            // Замена AddRange на цикл
            foreach (var record in records)
            {
                SalesRecords.Add(record);
            }
        }
    }
}