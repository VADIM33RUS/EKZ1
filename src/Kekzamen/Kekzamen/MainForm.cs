using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kekzamen
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            labelGroup.Visible = false;
            labelName.Visible = false;
            labelSurname.Visible = false;
            tbxGroup.Visible = false;
            tbxName.Visible = false;
            tbxSurname.Visible = false;
            btnAdd.Visible = false;
            dataGridView1.Visible = false;


            int razm = Convert.ToInt32(NUDRazm.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelGroup.Visible = true;
            labelName.Visible = true;
            labelSurname.Visible = true;
            tbxGroup.Visible = true;
            tbxName.Visible = true;
            tbxSurname.Visible = true;
            btnAdd.Visible = true;
            dataGridView1.Visible = true;

            labelVRM.Visible = false;
            NUDRazm.Visible = false;
            btnSubmit.Visible = false;


        }
    }
}
