/*
 * Created by: Perry Martin
 * Created on: 03-11-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-04
 * This program displays Grade in percent
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class frmGardeCal : Form
    {
        private int GradeCalculat(string grade)
        {
            int percentGrade = 0;

            if (grade == "NE")
            {
                percentGrade = 0;
            }
            else if (grade == "R")
            {
                percentGrade = 30;
            }
            else if (grade == "1-")
            {
                percentGrade = 52;
            }
            else if (grade == "1")
            {
                percentGrade = 55;
            }
            else if (grade == "1+")
            {
                percentGrade = 57;
            }
            else if (grade == "2-")
            {
                percentGrade = 62;
            }
            else if (grade == "2")
            {
                percentGrade = 65;
            }
            else if (grade == "2+")
            {
                percentGrade = 67;
            }
            else if (grade == "3-")
            {
                percentGrade = 72;
            }
            else if (grade == "3")
            {
                percentGrade = 75;
            }
            else if (grade == "3+")
            {
                percentGrade = 77;
            }
            else if (grade == "4-")
            {
                percentGrade = 85;
            }
            else if (grade == "4")
            {
                percentGrade = 90;
            }
            else if (grade == "4+")
            {
                percentGrade = 95;
            }
            else
            {
                percentGrade = -9999;
            } 

            return percentGrade;
        }

        public frmGardeCal()
        {
            InitializeComponent();
        }

        private void btnCalculater_Click(object sender, EventArgs e)
        {
            string gradeInput = this.txtGrade.Text;
            int percentGrade;

            percentGrade = GradeCalculat(gradeInput);

            this.lblOuput.Text = Convert.ToString(percentGrade);
        }
    }
}
