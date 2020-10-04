using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class StocAlimente : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public StocAlimente()
        {
            InitializeComponent();
        }

        private void StocAlimente_Load(object sender, EventArgs e)
        {
            con.ConnectionString = stocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "DELETE * FROM StocAliment";
            cmd.ExecuteNonQuery();

            con.Close();

            this.stocTableAdapter.Fill(this.dataSet1.Stoc);

        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "DELETE * FROM StocAliment";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO StocAliment ( IDAliment, Cantitate) SELECT IDAliment, CantitateTotala FROM UpdateStocInitial";
            cmd.ExecuteNonQuery();
            con.Close();
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);
        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "DELETE * FROM StocAliment";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO StocAliment ( IDAliment,DAliment, Cantitate ) SELECT b.IDAliment,a.DAliment, CantitateTotala FROM UpdateStocIntrari a INNER JOIN Alimente b ON a.DAliment = b.DAliment ";
            cmd.ExecuteNonQuery();
            con.Close();
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);


        }

        private void btnIesiri_Click(object sender, EventArgs e)
        {

        }

        private void btnInitializare_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO StocAliment ( IDAliment, Cantitate ) SELECT a.IDAliment, 0 FROM Alimente AS a";
            cmd.ExecuteNonQuery();
            con.Close();
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);
        }
    }
}
