namespace ShowSaveImagesApp
{
    partial class ShowSave
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSave = new System.Windows.Forms.TabPage();
            this.btnClearImg = new System.Windows.Forms.Button();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.picBoxSave = new System.Windows.Forms.PictureBox();
            this.txtSaveEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaveName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabShow = new System.Windows.Forms.TabPage();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.picBoxShow = new System.Windows.Forms.PictureBox();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.txtShowSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSave)).BeginInit();
            this.tabShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show and Save Images From Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSave);
            this.tabControl1.Controls.Add(this.tabShow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(185, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 498);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSave
            // 
            this.tabSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabSave.Controls.Add(this.btnClearImg);
            this.tabSave.Controls.Add(this.btnBrowseImg);
            this.tabSave.Controls.Add(this.btnClearData);
            this.tabSave.Controls.Add(this.btnSaveData);
            this.tabSave.Controls.Add(this.picBoxSave);
            this.tabSave.Controls.Add(this.txtSaveEmail);
            this.tabSave.Controls.Add(this.label3);
            this.tabSave.Controls.Add(this.txtSaveName);
            this.tabSave.Controls.Add(this.label2);
            this.tabSave.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSave.Location = new System.Drawing.Point(4, 46);
            this.tabSave.Name = "tabSave";
            this.tabSave.Padding = new System.Windows.Forms.Padding(3);
            this.tabSave.Size = new System.Drawing.Size(1057, 448);
            this.tabSave.TabIndex = 0;
            this.tabSave.Text = "Save Image";
            this.tabSave.Click += new System.EventHandler(this.tabSave_Click);
            // 
            // btnClearImg
            // 
            this.btnClearImg.Location = new System.Drawing.Point(893, 345);
            this.btnClearImg.Name = "btnClearImg";
            this.btnClearImg.Size = new System.Drawing.Size(137, 43);
            this.btnClearImg.TabIndex = 8;
            this.btnClearImg.Text = "Clear";
            this.btnClearImg.UseVisualStyleBackColor = true;
            this.btnClearImg.Click += new System.EventHandler(this.btnClearImg_Click);
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Location = new System.Drawing.Point(733, 345);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(137, 43);
            this.btnBrowseImg.TabIndex = 7;
            this.btnBrowseImg.Text = "Browse";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(330, 231);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(137, 43);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(162, 231);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(137, 43);
            this.btnSaveData.TabIndex = 5;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // picBoxSave
            // 
            this.picBoxSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSave.Location = new System.Drawing.Point(531, 30);
            this.picBoxSave.Name = "picBoxSave";
            this.picBoxSave.Size = new System.Drawing.Size(499, 288);
            this.picBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSave.TabIndex = 4;
            this.picBoxSave.TabStop = false;
            // 
            // txtSaveEmail
            // 
            this.txtSaveEmail.Location = new System.Drawing.Point(162, 148);
            this.txtSaveEmail.Name = "txtSaveEmail";
            this.txtSaveEmail.Size = new System.Drawing.Size(305, 42);
            this.txtSaveEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtSaveName
            // 
            this.txtSaveName.Location = new System.Drawing.Point(162, 77);
            this.txtSaveName.Name = "txtSaveName";
            this.txtSaveName.Size = new System.Drawing.Size(305, 42);
            this.txtSaveName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // tabShow
            // 
            this.tabShow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabShow.Controls.Add(this.btnShowReport);
            this.tabShow.Controls.Add(this.picBoxShow);
            this.tabShow.Controls.Add(this.txtShowName);
            this.tabShow.Controls.Add(this.label4);
            this.tabShow.Controls.Add(this.txtShowEmail);
            this.tabShow.Controls.Add(this.label5);
            this.tabShow.Controls.Add(this.btnShowSearch);
            this.tabShow.Controls.Add(this.txtShowSearch);
            this.tabShow.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShow.Location = new System.Drawing.Point(4, 46);
            this.tabShow.Name = "tabShow";
            this.tabShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabShow.Size = new System.Drawing.Size(1057, 448);
            this.tabShow.TabIndex = 1;
            this.tabShow.Text = "Show Image";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(150, 347);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(205, 43);
            this.btnShowReport.TabIndex = 15;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // picBoxShow
            // 
            this.picBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxShow.Location = new System.Drawing.Point(482, 102);
            this.picBoxShow.Name = "picBoxShow";
            this.picBoxShow.Size = new System.Drawing.Size(499, 288);
            this.picBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxShow.TabIndex = 14;
            this.picBoxShow.TabStop = false;
            // 
            // txtShowName
            // 
            this.txtShowName.Location = new System.Drawing.Point(150, 102);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(305, 42);
            this.txtShowName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // txtShowEmail
            // 
            this.txtShowEmail.Location = new System.Drawing.Point(150, 173);
            this.txtShowEmail.Name = "txtShowEmail";
            this.txtShowEmail.Size = new System.Drawing.Size(305, 42);
            this.txtShowEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // btnShowSearch
            // 
            this.btnShowSearch.Location = new System.Drawing.Point(581, 22);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(205, 43);
            this.btnShowSearch.TabIndex = 9;
            this.btnShowSearch.Text = "Search By ID";
            this.btnShowSearch.UseVisualStyleBackColor = true;
            this.btnShowSearch.Click += new System.EventHandler(this.btnShowSearch_Click);
            // 
            // txtShowSearch
            // 
            this.txtShowSearch.Location = new System.Drawing.Point(249, 22);
            this.txtShowSearch.Name = "txtShowSearch";
            this.txtShowSearch.Size = new System.Drawing.Size(305, 42);
            this.txtShowSearch.TabIndex = 4;
            this.txtShowSearch.TextChanged += new System.EventHandler(this.txtShowSearch_TextChanged);
            // 
            // ShowSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show & Save Images";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSave.ResumeLayout(false);
            this.tabSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSave)).EndInit();
            this.tabShow.ResumeLayout(false);
            this.tabShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSave;
        private System.Windows.Forms.TabPage tabShow;
        private System.Windows.Forms.Button btnClearImg;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.PictureBox picBoxSave;
        private System.Windows.Forms.TextBox txtSaveEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaveName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxShow;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShowEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.TextBox txtShowSearch;
        private System.Windows.Forms.Button btnShowReport;
    }
}

