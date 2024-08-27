using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Detect_Duplicates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ints = new int[3];
           
            ints[0] = (int)numericUpDown1.Value;
            ints[1] = (int)numericUpDown2.Value;
            ints[2] = (int)numericUpDown3.Value;
            
            if (DetectDuplicates(ints))
            {
                MessageBox.Show("Det finns dubletter!");
            }
            else
            {
                MessageBox.Show("Alla tal är unika!");
            }
        }

        private bool DetectDuplicates(int[] intarray)
        {
            
            for (int i = 0; i < intarray.Length; i++)
            {
                for (int j = i; j < intarray.Length - 1; j++)
                {

                    if (intarray[j] == intarray[j + 1])
                    { 
                    
                        return true;
                    
                    }
                }

            }

            return false;

        }

    }
}

