
using System;
using System.IO;

namespace SIPVS_projekt1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerSurname = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieDataGrid = new System.Windows.Forms.DataGridView();
            this.validateBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.errorLab = new System.Windows.Forms.Label();
            this.Coupon = new System.Windows.Forms.TextBox();
            this.couponLb = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.MovieDays = new System.Windows.Forms.TextBox();
            this.addEntryBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseFile = new System.Windows.Forms.Button();
            this.couponBtn = new System.Windows.Forms.CheckBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timestampBtn = new System.Windows.Forms.Button();
            this.overPodpisyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priezvisko";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(14, 70);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 2;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Location = new System.Drawing.Point(159, 70);
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.CustomerSurname.TabIndex = 3;
            this.CustomerSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveBtn.Location = new System.Drawing.Point(9, 403);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 62);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Uložiť";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dátum";
            // 
            // MovieDataGrid
            // 
            this.MovieDataGrid.AllowUserToAddRows = false;
            this.MovieDataGrid.AllowUserToDeleteRows = false;
            this.MovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGrid.Location = new System.Drawing.Point(17, 152);
            this.MovieDataGrid.Name = "MovieDataGrid";
            this.MovieDataGrid.RowHeadersWidth = 51;
            this.MovieDataGrid.Size = new System.Drawing.Size(395, 128);
            this.MovieDataGrid.TabIndex = 11;
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(150, 442);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(122, 23);
            this.validateBtn.TabIndex = 12;
            this.validateBtn.Text = "Validovať";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(289, 442);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(122, 23);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Generovať";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // errorLab
            // 
            this.errorLab.AutoSize = true;
            this.errorLab.ForeColor = System.Drawing.Color.Red;
            this.errorLab.Location = new System.Drawing.Point(12, 470);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(35, 13);
            this.errorLab.TabIndex = 30;
            this.errorLab.Text = "label3";
            this.errorLab.Visible = false;
            // 
            // Coupon
            // 
            this.Coupon.Location = new System.Drawing.Point(312, 348);
            this.Coupon.Name = "Coupon";
            this.Coupon.Size = new System.Drawing.Size(100, 20);
            this.Coupon.TabIndex = 16;
            this.Coupon.Visible = false;
            // 
            // couponLb
            // 
            this.couponLb.AutoSize = true;
            this.couponLb.Location = new System.Drawing.Point(265, 352);
            this.couponLb.Name = "couponLb";
            this.couponLb.Size = new System.Drawing.Size(41, 13);
            this.couponLb.TabIndex = 17;
            this.couponLb.Text = "Kupón:";
            this.couponLb.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(14, 115);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(100, 20);
            this.MovieName.TabIndex = 18;
            // 
            // MovieDays
            // 
            this.MovieDays.Location = new System.Drawing.Point(159, 115);
            this.MovieDays.Name = "MovieDays";
            this.MovieDays.Size = new System.Drawing.Size(100, 20);
            this.MovieDays.TabIndex = 19;
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.Location = new System.Drawing.Point(289, 113);
            this.addEntryBtn.Name = "addEntryBtn";
            this.addEntryBtn.Size = new System.Drawing.Size(75, 23);
            this.addEntryBtn.TabIndex = 20;
            this.addEntryBtn.Text = "Pridať";
            this.addEntryBtn.UseVisualStyleBackColor = true;
            this.addEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Názov filmu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Počet dní";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // chooseFile
            // 
            this.chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chooseFile.Location = new System.Drawing.Point(150, 403);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(261, 38);
            this.chooseFile.TabIndex = 14;
            this.chooseFile.Text = "Vybrať súbor";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // couponBtn
            // 
            this.couponBtn.AutoSize = true;
            this.couponBtn.Location = new System.Drawing.Point(17, 348);
            this.couponBtn.Name = "couponBtn";
            this.couponBtn.Size = new System.Drawing.Size(122, 17);
            this.couponBtn.TabIndex = 32;
            this.couponBtn.Text = "Máte zlavový kupón";
            this.couponBtn.UseVisualStyleBackColor = true;
            this.couponBtn.CheckedChanged += new System.EventHandler(this.couponBtn_CheckedChanged);
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSign.ForeColor = System.Drawing.Color.Black;
            this.buttonSign.Location = new System.Drawing.Point(289, 492);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(122, 38);
            this.buttonSign.TabIndex = 33;
            this.buttonSign.Text = "Podpísať teraz";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Objednávka filmov";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timestampBtn
            // 
            this.timestampBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timestampBtn.ForeColor = System.Drawing.Color.Black;
            this.timestampBtn.Location = new System.Drawing.Point(150, 492);
            this.timestampBtn.Name = "timestampBtn";
            this.timestampBtn.Size = new System.Drawing.Size(122, 38);
            this.timestampBtn.TabIndex = 35;
            this.timestampBtn.Text = "Časová  pečiatka";
            this.timestampBtn.UseVisualStyleBackColor = true;
            this.timestampBtn.Click += new System.EventHandler(this.timestampBtn_Click);
            // 
            // overPodpisyBtn
            // 
            this.overPodpisyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.overPodpisyBtn.ForeColor = System.Drawing.Color.Black;
            this.overPodpisyBtn.Location = new System.Drawing.Point(150, 536);
            this.overPodpisyBtn.Name = "overPodpisyBtn";
            this.overPodpisyBtn.Size = new System.Drawing.Size(122, 38);
            this.overPodpisyBtn.TabIndex = 36;
            this.overPodpisyBtn.Text = "Over elektronické podpisy";
            this.overPodpisyBtn.UseVisualStyleBackColor = true;
            this.overPodpisyBtn.Click += new System.EventHandler(this.overPodpisyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 576);
            this.Controls.Add(this.overPodpisyBtn);
            this.Controls.Add(this.timestampBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.couponBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addEntryBtn);
            this.Controls.Add(this.MovieDays);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.couponLb);
            this.Controls.Add(this.Coupon);
            this.Controls.Add(this.errorLab);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.MovieDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.CustomerSurname);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFile);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerSurname;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MovieDataGrid;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label errorLab;
        private System.Windows.Forms.TextBox Coupon;
        private System.Windows.Forms.Label couponLb;
        private System.Windows.Forms.TextBox MovieName;
        private System.Windows.Forms.TextBox MovieDays;
        private System.Windows.Forms.Button addEntryBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button chooseFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox couponBtn;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button timestampBtn;
        private System.Windows.Forms.Button overPodpisyBtn;
    }
}

