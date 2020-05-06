using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu_chuong4
{
    public partial class FrmBaiTap1 : Form
    {
        public FrmBaiTap1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textA, "nhap vao so nguyen ");
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
             || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip toolTip2 = new ToolTip();
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(textB, "nhap vao so nguyen ");
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
             || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            if(textA.Text=="")
            {
                MessageBox.Show("ban chua nhap so a ");
                textA.Focus();
                return;

            }   
            if(textB.Text=="")
            {
                MessageBox.Show("ban chua nhap so b");
                textB.Focus();
                return;
            }
            int a = Convert.ToInt32(textA.Text);
            int b = Convert.ToInt32(textB.Text);
            if (a < b)
            {
                int tong = 0;
                for (int i = a; i <= b; i++) tong += i;
                Lbsobe.Text = a.ToString();
                Lbsolon.Text = b.ToString();
                Lbtong.Text = tong.ToString();
            }    
            else 
            {
                int tong1 = 0;
                for (int i = b; i <= a; i++) tong1 += i;

                Lbsobe.Text = b.ToString();
                Lbsolon.Text = a.ToString();
                Lbtong.Text = tong1.ToString();
            }    
               
        }

        private void BtnLamlai_Click(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            Lbsobe.Text = "";
            Lbsolon.Text = "";
            Lbtong.Text = "";
        }
    }
}
