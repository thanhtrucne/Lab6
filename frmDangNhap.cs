using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibrary.Presentation
{
    public partial class frmdangnhap : Form
    {
        //CtrDangNhap ctrDangNhap = new CtrDangNhap();

        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
        private bool validateData()
        {
            errorProvider1.SetError(txtusername,(txtusername.Text == "")?"Hay nhap UserName":"");
            errorProvider1.SetError(txtpassword, (txtpassword.Text == "") ? "Hay nhap PassWord" : "");
            return (txtusername.Text != "" && txtpassword.Text != "");
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                return;
            }
            //bool isAutheticated = 
        }
    }
}
