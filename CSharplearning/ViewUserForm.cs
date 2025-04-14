using CSharpLearning.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharplearning
{
    public partial class ViewUserForm : Form
    {
        private readonly UserCrudService _crudService;
        public ViewUserForm()
        {
            InitializeComponent();
            _crudService = new UserCrudService();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var users = await _crudService.GetAllAsync();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading users:\n" + ex.Message);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async void ViewUserForm_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
