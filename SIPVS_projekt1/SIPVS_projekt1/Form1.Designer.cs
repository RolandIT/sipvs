
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
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priezvisko";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(37, 167);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(260, 38);
            this.CustomerName.TabIndex = 2;
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Location = new System.Drawing.Point(424, 167);
            this.CustomerSurname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.Size = new System.Drawing.Size(260, 38);
            this.CustomerSurname.TabIndex = 3;
            this.CustomerSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveBtn.Location = new System.Drawing.Point(24, 961);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(325, 148);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Uložiť";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 746);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(527, 38);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 708);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dátum";
            // 
            // MovieDataGrid
            // 
            this.MovieDataGrid.AllowUserToAddRows = false;
            this.MovieDataGrid.AllowUserToDeleteRows = false;
            this.MovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGrid.Location = new System.Drawing.Point(45, 362);
            this.MovieDataGrid.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MovieDataGrid.Name = "MovieDataGrid";
            this.MovieDataGrid.RowHeadersWidth = 51;
            this.MovieDataGrid.Size = new System.Drawing.Size(1053, 305);
            this.MovieDataGrid.TabIndex = 11;
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(400, 1054);
            this.validateBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(325, 55);
            this.validateBtn.TabIndex = 12;
            this.validateBtn.Text = "Validovať";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(771, 1054);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(325, 55);
            this.generateBtn.TabIndex = 13;
            this.generateBtn.Text = "Generovať";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // errorLab
            // 
            this.errorLab.AutoSize = true;
            this.errorLab.ForeColor = System.Drawing.Color.Red;
            this.errorLab.Location = new System.Drawing.Point(32, 1121);
            this.errorLab.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.errorLab.Name = "errorLab";
            this.errorLab.Size = new System.Drawing.Size(93, 32);
            this.errorLab.TabIndex = 30;
            this.errorLab.Text = "label3";
            this.errorLab.Visible = false;
            // 
            // Coupon
            // 
            this.Coupon.Location = new System.Drawing.Point(832, 830);
            this.Coupon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Coupon.Name = "Coupon";
            this.Coupon.Size = new System.Drawing.Size(260, 38);
            this.Coupon.TabIndex = 16;
            this.Coupon.Visible = false;
            // 
            // couponLb
            // 
            this.couponLb.AutoSize = true;
            this.couponLb.Location = new System.Drawing.Point(707, 839);
            this.couponLb.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.couponLb.Name = "couponLb";
            this.couponLb.Size = new System.Drawing.Size(106, 32);
            this.couponLb.TabIndex = 17;
            this.couponLb.Text = "Kupón:";
            this.couponLb.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.Location = new System.Drawing.Point(37, 274);
            this.MovieName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(260, 38);
            this.MovieName.TabIndex = 18;
            // 
            // MovieDays
            // 
            this.MovieDays.Location = new System.Drawing.Point(424, 274);
            this.MovieDays.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MovieDays.Name = "MovieDays";
            this.MovieDays.Size = new System.Drawing.Size(260, 38);
            this.MovieDays.TabIndex = 19;
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.Location = new System.Drawing.Point(771, 269);
            this.addEntryBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addEntryBtn.Name = "addEntryBtn";
            this.addEntryBtn.Size = new System.Drawing.Size(200, 55);
            this.addEntryBtn.TabIndex = 20;
            this.addEntryBtn.Text = "Pridať";
            this.addEntryBtn.UseVisualStyleBackColor = true;
            this.addEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Názov filmu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
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
            this.chooseFile.Location = new System.Drawing.Point(400, 961);
            this.chooseFile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(696, 91);
            this.chooseFile.TabIndex = 14;
            this.chooseFile.Text = "Vybrať súbor";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // couponBtn
            // 
            this.couponBtn.AutoSize = true;
            this.couponBtn.Location = new System.Drawing.Point(45, 830);
            this.couponBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.couponBtn.Name = "couponBtn";
            this.couponBtn.Size = new System.Drawing.Size(303, 36);
            this.couponBtn.TabIndex = 32;
            this.couponBtn.Text = "Máte zlavový kupón";
            this.couponBtn.UseVisualStyleBackColor = true;
            this.couponBtn.CheckedChanged += new System.EventHandler(this.couponBtn_CheckedChanged);
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSign.ForeColor = System.Drawing.Color.Black;
            this.buttonSign.Location = new System.Drawing.Point(771, 1173);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(325, 91);
            this.buttonSign.TabIndex = 33;
            this.buttonSign.Text = "Podpísať teraz";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(227, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(583, 75);
            this.label3.TabIndex = 34;
            this.label3.Text = "Objednávka filmov";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timestampBtn
            // 
            this.timestampBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timestampBtn.ForeColor = System.Drawing.Color.Black;
            this.timestampBtn.Location = new System.Drawing.Point(400, 1173);
            this.timestampBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.timestampBtn.Name = "timestampBtn";
            this.timestampBtn.Size = new System.Drawing.Size(325, 91);
            this.timestampBtn.TabIndex = 35;
            this.timestampBtn.Text = "Časová  pečiatka";
            this.timestampBtn.UseVisualStyleBackColor = true;
            this.timestampBtn.Click += new System.EventHandler(this.timestampBtn_Click);
            // 
            // overPodpisyBtn
            // 
            this.overPodpisyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.overPodpisyBtn.ForeColor = System.Drawing.Color.Black;
            this.overPodpisyBtn.Location = new System.Drawing.Point(400, 1278);
            this.overPodpisyBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.overPodpisyBtn.Name = "overPodpisyBtn";
            this.overPodpisyBtn.Size = new System.Drawing.Size(325, 91);
            this.overPodpisyBtn.TabIndex = 36;
            this.overPodpisyBtn.Text = "Over elektronické podpisy";
            this.overPodpisyBtn.UseVisualStyleBackColor = true;
            this.overPodpisyBtn.Click += new System.EventHandler(this.overPodpisyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 1418);
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
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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

