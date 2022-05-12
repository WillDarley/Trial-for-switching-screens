using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial_for_switching_screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Welcome_screen WelcomeScreen1 = new Welcome_screen(); // when the log in button is pressed then a new form opens. ---> have not worked out how to close the other form yet
            WelcomeScreen1.ShowDialog();

          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create_new_account_screen createScreen1 = new Create_new_account_screen(); // when the create new user button is pressed then a new form opens.
            createScreen1.ShowDialog();
        }
    }
}
// in term of what needs coding
// 1. Determine if log in = successful
// 2. Link the user details to the database 
// 3. Apply the filters and get these from the database
// 4. Be able to create a new user
// 5. And basically everything else
