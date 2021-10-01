using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lbFirst.Text = Resource1.fullName;
            btnAdd.Text = Resource1.Add;
            btnFileWrite.Text = Resource1.WriteFile;

            lbDefault.DataSource = users;
            lbDefault.ValueMember = "ID";
            lbDefault.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                fullName = lbFirst.Text + " " + lbLast.Text
            };
            users.Add(u);
        }
    }
}
