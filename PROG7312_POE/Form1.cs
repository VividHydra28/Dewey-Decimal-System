using PROG7312_POE.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReplaceBooks_btn_Click(object sender, EventArgs e)
        {
            ReplaceBooks_Form replaceBooksForm = new ReplaceBooks_Form();

            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Hide();
            }

            replaceBooksForm.FormClosed += (s, args) =>
            {
                if (parentForm != null)
                {
                    parentForm.Show();
                }
            };
            replaceBooksForm.ShowDialog();
        }

        private void IdentifyingAreas_Click(object sender, EventArgs e)
        {
            IdentifyingAreas_Form areas_Form = new IdentifyingAreas_Form();
            Form parentForm = this.FindForm();



            if (parentForm != null)
            {
                parentForm.Hide();
            }

            areas_Form.FormClosed += (s, args) =>
            {
                if (parentForm != null)
                {
                    parentForm.Show();
                }
            };
            areas_Form.ShowDialog();
        }

        private void FindingCallNumbers_btn_Click(object sender, EventArgs e)
        {
           FindingCallNumbers_Form areas_Form = new FindingCallNumbers_Form();
            Form parentForm = this.FindForm();



            if (parentForm != null)
            {
                parentForm.Hide();
            }

            areas_Form.FormClosed += (s, args) =>
            {
                if (parentForm != null)
                {
                    parentForm.Show();
                }
            };
            areas_Form.ShowDialog();
        }
    }
}

//-------------------------------------------------END OF CODE----------------------------------------------------------------------//