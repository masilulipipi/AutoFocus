using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace AutoFocus
{
    
    
    public partial class Form1 : Form
    {
        private string numeroip1,numeroip2;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            numeroip1 = txtip1.Text;
            numeroip2 = txtip2.Text;
                      
            System.Diagnostics.Process.Start("http://admin:admin@172.21."+numeroip1+"."+numeroip2+"/command/focuszoom.cgi?FzMove=focus,auto,2");
           

        }

        private void txtip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Tab))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeroip1 = txtip1.Text;
            numeroip2 = txtip2.Text;

            System.Diagnostics.Process.Start("http://admin:admin@172.21." + numeroip1 + "." + numeroip2 + "/command/main.cgi?system=reboot");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                numeroip1 = txtip1.Text;
                numeroip2 = txtip2.Text;

                System.Diagnostics.Process.Start("http://admin:admin@172.21." + numeroip1 + "." + numeroip2 + "/command/focuszoom.cgi?FzMove=focus,auto,2");
            }

            
        }
    }
}
