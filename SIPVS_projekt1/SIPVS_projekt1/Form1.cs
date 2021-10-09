﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPVS_projekt1
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private Logic log;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Filmy");
            dt.Columns.Add("Počet dní");
            log = new Logic();

            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Text = "Odstrániť";
            removeButton.HeaderText = "";
            removeButton.Name = "Odstrániť";
            removeButton.UseColumnTextForButtonValue = true;


            MovieDataGrid.CellClick += new DataGridViewCellEventHandler(removeBtnHandler);
            MovieDataGrid.DataSource = dt;
            MovieDataGrid.Columns.Add(removeButton);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEntryBtn_Click(object sender, EventArgs e)
        {
            if (MovieName.Text == null || MovieDays.Text == null)
            {
                //handle pizdec, also probably check if MovieDays is parseable into int
                return;
            }
            log.addMovie(MovieName.Text, int.Parse(MovieDays.Text));
            
            dt.Rows.Add(MovieName.Text, MovieDays.Text);
        }

        void removeBtnHandler(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                MovieDataGrid.Columns["Odstrániť"].Index) return;

            dt.Rows.RemoveAt(e.RowIndex);
            log.removeMovie(e.RowIndex);
            /*for(LinkedListNode<MovieTableEntry> x = log.Doc.Movies.First; x != null;){
                Console.WriteLine(x.Value.MovieName);
                x = x.Next;
            }*/
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //perform checks to see if anything is empty or we
            log.setOrderDate(dateTimePicker1.Value.Date);
            log.setCustomer(CustomerName.Text, CustomerSurname.Text, couponRdBtn.Checked, Coupon.Text);
            log.saveXML();
        }
    }
}
