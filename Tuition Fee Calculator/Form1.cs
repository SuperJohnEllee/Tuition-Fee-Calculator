using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Fee_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtName.Clear();
            cmbStat.ResetText();
            lblTuition.ResetText();
            txtUnits.Clear();
            numericYear.ResetText();
            lblResult.ResetText();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            if (txtName.Text == "" || cmbStat.Text == "" || txtUnits.Text == "0" || numericYear.Value == 0)
            {
                MessageBox.Show("Please input all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                s.StudentName = txtName.Text;
                s.Status = cmbStat.Text;
                s.Units = int.Parse(txtUnits.Text);
                s.Year = Convert.ToInt32(numericYear.Value);

                lblTuition.Text = s.getTotalTuition().ToString();
                lblResult.Text = s.StudentName + " is a " + s.Status + " " + s.Year + "rd year student takes " +
                s.Units + " units ";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}