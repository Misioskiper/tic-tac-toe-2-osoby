using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        private bool czyjRuch = true; 
        //X - true O - false

        private void wstawZnak(object przycisk)
        {
            Button wcisnietyPrzycisk = (Button)przycisk;
            if (czyjRuch == true)
            {
                wcisnietyPrzycisk.Text = "X"; 
                //czyjRuch = false;
            }
            else
            {
                wcisnietyPrzycisk.Text = "O";
                //czyjRuch = true;
            }
            wcisnietyPrzycisk.Enabled = false;
            bool wynik = sprawdzCzyKtosWygral();
            if (wynik == true)
            {
                if(czyjRuch == true)
                {
                    MessageBox.Show("Wygrana X");
                }
                else
                {
                    MessageBox.Show("Wygrana Y");
                }

            }
            czyjRuch = !czyjRuch;


        }

        private bool sprawdzCzyKtosWygral()
        {
            if(b1.Text== b2.Text && b2.Text == b3.Text && b1.Text != "")
            {
                // pierwszy rząd
                return true;
            }if(b4.Text == b5.Text && b5.Text == b6.Text && b4.Text != "")
            {
                //drugi rząd
                return true;
            }if(b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != "")
            {
                //trzeci rząd
                return true;
            }if(b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != "")
            {
                //pierwsza kolumna
                return true;
            }if(b2.Text == b5.Text && b5.Text == b8.Text && b2.Text != "")
            {
                //druga kolumna
                return true;
            }if(b3.Text == b6.Text && b6.Text == b9.Text && b3.Text != "")
            {
                //trzcia kolumna
                return true;
            }
            if (b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != "")
            {
                //ukos /
                return true;
            }
            if (b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != "")
            {
                //ukos \
                return true;
            }
            return false;
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            wstawZnak(sender);
        }
    }
}
