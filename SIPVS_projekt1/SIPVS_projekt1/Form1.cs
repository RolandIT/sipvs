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
            log.Doc.Movies.AddLast(new MovieTableEntry(BookName.Text.ToString(),BookDays.Text.ToString()));
            
            dt.Rows.Add(log.Doc.Movies.Last.Value.MovieName, log.Doc.Movies.Last.Value.MovieDays);
        }

        void removeBtnHandler(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                MovieDataGrid.Columns["Odstrániť"].Index) return;

            dt.Rows.RemoveAt(e.RowIndex);
            log.Doc.Movies.Remove(log.Doc.Movies.ElementAt(e.RowIndex));
            /*for(LinkedListNode<MovieTableEntry> x = log.Doc.Movies.First; x != null;){
                Console.WriteLine(x.Value.MovieName);
                x = x.Next;
            }*/
        }
    }
}
