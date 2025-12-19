using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomaili10.ModelEF;
using System.Linq;

namespace Tomaili10
{
    public partial class AuthFORM : Form
    {
        public AuthFORM()
        {
            InitializeComponent();
        }

        private void AuthFORM_Load(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            using (var db = new Rent_MallEntities())
            {
                var worker = db.Workers.FirstOrDefault(w =>
                    w.Login == txtlogin.Text &&
                    w.Password == txtpassword.Text);

                if (worker == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return;
                }

                if (worker.Role == "Удален")
                {
                    MessageBox.Show("Пользователь удален");
                    return;
                }

                MenuForm menu = new MenuForm(worker);
                this.Hide();
                menu.Show();
            }
        }

    }
}
}
