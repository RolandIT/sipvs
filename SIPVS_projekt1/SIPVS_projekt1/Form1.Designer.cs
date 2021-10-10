
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
            this.button1 = new System.Windows.Forms.Button();
            this.couponBtn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priezvisko";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(15, 41);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 2;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Location = new System.Drawing.Point(160, 41);
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.CustomerSurname.TabIndex = 3;
            this.CustomerSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 374);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Uložiť";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
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
            this.MovieDataGrid.Location = new System.Drawing.Point(18, 123);
            this.MovieDataGrid.Name = "MovieDataGrid";
            this.MovieDataGrid.RowHeadersWidth = 51;
            this.MovieDataGrid.Size = new System.Drawing.Size(395, 128);
            this.MovieDataGrid.TabIndex = 11;
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(160, 413);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(75, 23);
            this.validateBtn.TabIndex = 12;
            this.validateBtn.Text = "Validovať";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(290, 413);
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
            this.errorLab.Location = new System.Drawing.Point(13, 441);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(35, 13);
            this.errorLab.TabIndex = 30;
            this.errorLab.Text = "label3";
            this.errorLab.Visible = false;
            // 
            // Coupon
            // 
            this.Coupon.Location = new System.Drawing.Point(313, 319);
            this.Coupon.Name = "Coupon";
            this.Coupon.Size = new System.Drawing.Size(100, 20);
            this.Coupon.TabIndex = 16;
            this.Coupon.Visible = false;
            // 
            // couponLb
            // 
            this.couponLb.AutoSize = true;
            this.couponLb.Location = new System.Drawing.Point(266, 323);
            this.couponLb.Name = "couponLb";
            this.couponLb.Size = new System.Drawing.Size(41, 13);
            this.couponLb.TabIndex = 17;
            this.couponLb.Text = "Kupón:";
            this.couponLb.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(15, 86);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(100, 20);
            this.MovieName.TabIndex = 18;
            // 
            // MovieDays
            // 
            this.MovieDays.Location = new System.Drawing.Point(160, 86);
            this.MovieDays.Name = "MovieDays";
            this.MovieDays.Size = new System.Drawing.Size(100, 20);
            this.MovieDays.TabIndex = 19;
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.Location = new System.Drawing.Point(290, 84);
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
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Názov filmu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 70);
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
            this.chooseFile.Location = new System.Drawing.Point(290, 374);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(122, 38);
            this.chooseFile.TabIndex = 14;
            this.chooseFile.Text = "Vybrať súbor na generovanie";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Vybrať súbor na validáciu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // couponBtn
            // 
            this.couponBtn.AutoSize = true;
            this.couponBtn.Location = new System.Drawing.Point(18, 319);
            this.couponBtn.Name = "couponBtn";
            this.couponBtn.Size = new System.Drawing.Size(122, 17);
            this.couponBtn.TabIndex = 32;
            this.couponBtn.Text = "Máte zlavový kupón";
            this.couponBtn.UseVisualStyleBackColor = true;
            this.couponBtn.CheckedChanged += new System.EventHandler(this.couponBtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 542);
            this.Controls.Add(this.couponBtn);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox couponBtn;
    }
}

