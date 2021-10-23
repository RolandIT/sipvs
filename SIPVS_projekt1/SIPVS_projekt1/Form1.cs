using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Threading;

namespace SIPVS_projekt1
{
    public partial class Form1 : Form
    {
        private string s;
        private string s1;
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
            try { 
            log.addMovie(MovieName.Text, int.Parse(MovieDays.Text));
            }
            catch
            {
                errorLab.Visible = true;
                errorLab.Text = "Pocet dni musi byt cele cislo";
                return;
            }

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
            log.setCustomer(CustomerName.Text, CustomerSurname.Text, couponBtn.Checked, Coupon.Text);
            log.saveXML();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            this.errorLab.Visible = true;
            this.errorLab.Text = "HTML súbor sa zobrazí vo Vami využívanom webovom prehliadači!";
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("generate_xml.xsl");
            xslt.Transform(this.s, "html_output.html");
            System.Diagnostics.Process.Start("html_output.html");
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
                log.setFileName(s);
            }
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                log.validate();
                errorLab.Visible = true;
                errorLab.Text = "Dokument je validny";
            }
            catch(Exception err)
            {
                errorLab.Text = err.Message;
                errorLab.Visible = true;
                return;
            }
        }

        private void couponBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (couponBtn.Checked)
            {
                couponLb.Visible = true;
                Coupon.Visible = true;
            }
            else
            {
                couponLb.Visible = false;
                Coupon.Visible = false;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            log.signDocumentAsync();
        }
    }
}
