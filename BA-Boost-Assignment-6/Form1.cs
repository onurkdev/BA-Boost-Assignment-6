using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Boost_Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            int lastRead;
            int firstRead;
            try
            {
                lastRead = Convert.ToInt32(lastreadbox.Text);
                firstRead = Convert.ToInt32(firstreadbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri Kontrol ediniz.");
                clearAll();
                return;
               
            }


            int consumedAmount = lastRead - firstRead;
            double multiplier=0;
            double wasteCost=0;
            double totalCost = 0;
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    multiplier = 0.3;
                    wasteCost = 0;

                }
                else if (radioButton2.Checked)
                {
                    multiplier = 0.7;
                    wasteCost = (consumedAmount * 1.3) * 0.2;
                    //burada ödevde bahsedilen tanımdan tam emin olamadım %30 fazla hesaplayıp giden suyu 0.2 TL ile çarptım.
                }
                totalCost = (consumedAmount * multiplier) + wasteCost;
                addToLists(name, consumedAmount, totalCost);
            }
            else {
                MessageBox.Show("Lütfen Kullanım Yeri Seçiniz");
     
            }
            
            clearAll();


        }

        public void addToLists(string name,double consumed, double sum ) {
            listAdSoyad.Items.Add(name);
            listFaturaTutari.Items.Add(sum);
            listSumMiktari.Items.Add(consumed);

        }

        public void clearAll() {
            lastreadbox.Clear();
            firstreadbox.Clear();
            namebox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}
