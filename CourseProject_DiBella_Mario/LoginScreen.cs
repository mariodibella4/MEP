using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMEP
{
    public partial class LoginScreen : BaseForm
    {
        private static string userName;
        public LoginScreen()
        {
            InitializeComponent();
        }

        public static string UserName { get => userName; set => userName = value; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Profile emp = new Profile();
            UserName = userNameTextBox.Text;
            emp.userNameLabel.Text = UserName;
            emp.ShowDialog();
           
        }
        
    }
}
