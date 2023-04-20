using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace LT_6
{
    public partial class Form1 : Form
    {

        public class Items
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        }

        private readonly HttpClient _httpClient = new HttpClient();
        private List<Items> users = new List<Items>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void buttoncall_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                users = JsonConvert.DeserializeObject<List<Items>>(json);

                dgvData.DataSource = new BindingSource { DataSource = users };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }  
}
