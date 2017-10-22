using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Button> browned = new List<Button>();
        private void semi(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
               
                    // MessageBox.Show("Browned!");
                
                if (clickedButton.BackColor == SystemColors.Control)
                {
                    
                    browned.Add(clickedButton);
                    clickedButton.BackColor = Color.Black;
                    clickedButton.ForeColor = Color.White;
                }
                   
                else if(clickedButton.BackColor==Color.Black)
                {
                    clickedButton.BackColor = SystemColors.Control;
                //MessageBox.Show("dcbj");
                clickedButton.ForeColor = Color.Black;
                browned.Remove(clickedButton);
                   }
                   
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Button i in browned)
            {
                i.BackColor = Color.Red;
            }
            MessageBox.Show("Browned!");
        }
    }
}
