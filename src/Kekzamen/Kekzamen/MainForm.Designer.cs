namespace Kekzamen
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxGroup = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelVRM = new System.Windows.Forms.Label();
            this.NUDRazm = new System.Windows.Forms.NumericUpDown();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRazm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(481, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 20);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 78);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(196, 94);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(139, 20);
            this.tbxName.TabIndex = 3;
            // 
            // tbxGroup
            // 
            this.tbxGroup.Location = new System.Drawing.Point(350, 94);
            this.tbxGroup.Name = "tbxGroup";
            this.tbxGroup.Size = new System.Drawing.Size(100, 20);
            this.tbxGroup.TabIndex = 4;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(12, 94);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(166, 20);
            this.tbxSurname.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(193, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(347, 75);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Группа";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(213, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Подтвердить";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelVRM
            // 
            this.labelVRM.AutoSize = true;
            this.labelVRM.Location = new System.Drawing.Point(223, 63);
            this.labelVRM.Name = "labelVRM";
            this.labelVRM.Size = new System.Drawing.Size(137, 13);
            this.labelVRM.TabIndex = 9;
            this.labelVRM.Text = "Введите размер массива";
            // 
            // NUDRazm
            // 
            this.NUDRazm.Location = new System.Drawing.Point(226, 113);
            this.NUDRazm.Name = "NUDRazm";
            this.NUDRazm.Size = new System.Drawing.Size(134, 20);
            this.NUDRazm.TabIndex = 10;
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(12, 32);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(139, 20);
            this.tbxFilePath.TabIndex = 11;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 16);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(74, 13);
            this.labelPath.TabIndex = 12;
            this.labelPath.Text = "Путь к файлу";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(185, 32);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(90, 20);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "Выбрать файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 356);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.NUDRazm);
            this.Controls.Add(this.labelVRM);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxGroup);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRazm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxGroup;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelVRM;
        private System.Windows.Forms.NumericUpDown NUDRazm;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnOpenFile;
    }
}