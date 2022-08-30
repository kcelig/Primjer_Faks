using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Primjer_Faks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            if ((txtIme.Text == "") || (txtPrezime.Text == ""))
            {
                MessageBox.Show("Niste unijeli ime ili prezime!", 
                                "Upozorenje", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
            else {

                string spol = "";
                if (rbMuski.Checked)
                {
                    spol = "Muški";
                }
                else
                {
                    spol = "Ženski";
                }

                string smjer = "";
                smjer += cbSmjer.Text;

                string putnik = "";
                if (chkPutnik.Checked)
                {
                    putnik = "Putnik";
                }
                else
                {
                    putnik = "Nije putnik";
                }

              //  lbUcenici.DataSource = null;
              //  lbUcenici.Items.Clear();

                lbUcenici.Items.Add(txtIme.Text +
                    " - " + txtPrezime.Text +
                    " - " + dtpDatum.Value.ToShortDateString() +
                    " - " + spol +
                    " - " + smjer +
                    " - " + putnik +
                    " - " + nuRazred.Value);

                

                txtIme.Text = "";
                txtPrezime.Text = "";
                cbSmjer.ResetText();
                chkPutnik.Checked = false;
                nuRazred.Value = 1;
                txtIme.Focus();

             
            
            }


            

          
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
           
            /*
            ListBox.SelectedObjectCollection oznaceno = new ListBox.SelectedObjectCollection(lbUcenici);
            oznaceno = lbUcenici.SelectedItems;
            if (lbUcenici.SelectedIndex != -1)
            {
                for (int i = oznaceno.Count - 1; i >= 0; i--)
                {
                    lbUcenici.Items.Remove(oznaceno[i]);
                }
            }
            else {
                MessageBox.Show("Ne mož brisat!");
            }
             
             */
           /*
            foreach (string s in lbUcenici.SelectedItems.OfType<string>().ToList()) {
                lbUcenici.Items.Remove(s);
            }
            */

            while (lbUcenici.SelectedItems.Count > 0) {
                lbUcenici.Items.Remove(lbUcenici.SelectedItems[0]);
            }
 
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
           /*
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                
                foreach (var item in lbUcenici.Items) {
                    sw.WriteLine(item.ToString());         
                }
                sw.Close();
            */
                File.WriteAllLines(saveFileDialog1.FileName, lbUcenici.Items.OfType<string>());
               
            }
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string[] retci = File.ReadAllLines(openFileDialog1.FileName);
                lbUcenici.DataSource = retci;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int x = lbUcenici.Items.Count;
            label4.Text = x.ToString();
            */
        }
    }
}
