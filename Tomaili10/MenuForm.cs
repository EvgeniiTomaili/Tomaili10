using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomaili10
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            {
                InitializeComponent();
                currentUser = user;
                lblWelcome.Text = $"Добро пожаловать {user.FullName}";
                lblRole.Text = $"{user.Role}";

            }
        }
}
