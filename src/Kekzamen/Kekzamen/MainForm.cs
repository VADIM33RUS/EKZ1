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
            tbxFilePath.Visible = false;
            labelPath.Visible = false;
            btnOpenFile.Visible = false;


            int razm = Convert.ToInt32(NUDRazm.Value);
        }
        private void FillData()
        {
            dataGridView1.DataSource = WorkWithFile.ReadTable();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "" && tbxGroup.Text != "" && tbxSurname.Text != "")
            {
                Student cll = new Student();
                cll.Name = tbxName.Text;
                cll.Surname = tbxSurname.Text;
                cll.Group= tbxGroup.Text;
                cll.Save();
                FillData();
                
            }
            else { MessageBox.Show("Все поля обязательны к заполнению!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
            tbxFilePath.Visible = true;
            labelPath.Visible = true;
            btnOpenFile.Visible = true;

            labelVRM.Visible = false;
            NUDRazm.Visible = false;
            btnSubmit.Visible = false;


        }


        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbxFilePath.Text = ofd.FileName;
                    WorkWithFile.FilePath = ofd.FileName;


                }
                catch
                {
                    MessageBox.Show("Формат не соответсвует требуемому.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
