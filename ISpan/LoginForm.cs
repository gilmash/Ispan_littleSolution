using ISpan.Infra.Extensions;
using ISpan.Model.Servives;
using ISpan.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            
        }


     

        private void loginButton_Click(object sender, EventArgs e)
        {
            //將表單欄位值繫結到view model
            LoginVM model = new LoginVM()
            {
                Account = accountTextBox.Text,
                Password = passwordTextBox.Text
            };

            //驗證欄位輸入是否正確
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Account", accountTextBox},
                {"Password", passwordTextBox},
            };
            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;




            bool result = new UserService().Authenticate(model);
            if (result == false)
            {
                MessageBox.Show("帳號或密碼錯誤");
                return;
            }
            accountTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;

            var frm = new MainForm();
            frm.Owner = this;

            frm.Show();
            this.Hide();


        }

        private void Button_Click(object sender, EventArgs e)
        {
            var frm = new CreateUserForm();
            DialogResult result = frm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
