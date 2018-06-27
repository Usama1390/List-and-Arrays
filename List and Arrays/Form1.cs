using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_and_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Names = new List<string>();
            Names.Add("Usama");
            Names.Add("Bilal");

            Names.Add("Hey");
            for (int i = 0; i < 3; i++)
            {
             
            MessageBox.Show(Names[i]);   
            }
        }
    }
}
