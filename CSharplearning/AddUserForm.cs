using CSharpLearning.Data.Models;
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
    public partial class AddUserForm : Form
    {
        private UserCrudService _crudService;
        public AddUserForm()
        {
            InitializeComponent();
            _crudService = new UserCrudService();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Id = new Guid(),
                Username = txtUserName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Role = txtRole.Text.Trim(),
                CreatedAt = dtpCreatedAt.Text.Trim(),
              
            };


          var success = await _crudService.AddAsync(user);


            MessageBox.Show(success ? "✅ Book added!" : "❌ Failed to add book.");
        }
    }
}
