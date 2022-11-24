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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 店家資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductsForm();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 資料更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductCategoriesForm();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 帳號管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void 登出ToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Owner.Show();
        }

        private void 登出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要登出嗎?",
                "登出",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
