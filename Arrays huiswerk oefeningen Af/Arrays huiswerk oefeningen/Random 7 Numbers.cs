using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_huiswerk_oefeningen
{
    public partial class frmRandom7Numbers : Form
    {
        List<int> lstRandomNumbers = new List<int>();

        public frmRandom7Numbers()
        {
            InitializeComponent();
        }

        private void frmRandom7Numbers_Load(object sender, EventArgs e)
        {
            int intOutput, intLimit, intMaxValue;
            int[] arrGetallen = new int[7];
            Random rdNumber = new Random();

            for (intLimit = 0; intLimit < 7; intLimit++)
            {
                arrGetallen[intLimit] = rdNumber.Next(0, 11);
                //lbxList.Items.Add(intOutput);
            }

            lbxList.DataSource = arrGetallen;
            
            txtIndex.Text = arrGetallen.GetUpperBound(0).ToString();            

            txtLength.Text = arrGetallen.Length.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form Home = new frmHome();
            Home.Show();

            Form Random7Numbers = new frmRandom7Numbers();
            this.Hide();
        }
    }
}