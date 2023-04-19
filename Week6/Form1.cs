using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

using static Week6.Form1;
using System.Security.Policy;

namespace Week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btGet_Click(object sender, EventArgs e)
        {
            var todos = await GetTodosAsync();
            foreach (var todo in todos)
            {
                tbTDL.Text += $"UserID: {todo.UserId} {Environment.NewLine}ID: {todo.Id} {Environment.NewLine}Title: {todo.Title} {Environment.NewLine}Completed: {todo.Completed} {Environment.NewLine}";
            }
        }
        private async Task<List<Todo>> GetTodosAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Todo>>(content);
            }
        }
        public class Todo
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
            public int UserId { get; set; }
        }
    }
}
