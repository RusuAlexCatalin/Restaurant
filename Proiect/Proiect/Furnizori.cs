using Proiect.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Furnizori : Form
    {
        public Furnizori()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A1();

        }
        private void A1()
        {
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            A3();
            
        }
        private void A2()
        {
            configureazaButoane(false);
            dataGridView1.ReadOnly = true;
            txtNume.Text = "";
        }

        private void A3()
        {
            configureazaButoane(true);
            lblOp.Text = "";
            dataGridView1.ReadOnly = true;
        }
        private void A4()
        {
            if(lblOp.Text=="ADAUGARE")
            {
                if (!validare()) return;
                adauga_inregistrare();
                golireCampuri();
                refresh_grid(furnizoriBindingSource.Position);
            }    
            if(lblOp.Text=="STERGERE")
            {
                if (!validare()) return;
                stergere_inregistrare();
                golireCampuri();
                refresh_grid(furnizoriBindingSource.Position);

            }
            if(lblOp.Text=="MODIFICARE")
            {
                furnizoriTableAdapter.Update(dataSet1.Furnizori);
                MessageBox.Show("Modificare Realizata!");
            }
        }

        private void A6()
        {
            configureazaButoane(false);
            dataGridView1.ReadOnly = false;
        }
        private void A7()
        {
            configureazaButoane(false);
            dataGridView1.ReadOnly = true;
            txtNume.Text = "";

        }
        private void stergere_inregistrare()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM FURNIZORI WHERE DFurnizor='" + txtNume.Text + "'";
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(furnizoriBindingSource.Position);
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
        }

        private bool validare()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati numele furnizorului!");
                txtNume.Focus();
                return false;
            }
            return true;
        }

        private void refresh_grid(int p)
        {
            dataSet1.Furnizori.Clear();
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            furnizoriBindingSource.Position = p;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DFurnizor";
            listaValori = txtNume.Text;

            cmd.CommandText = "Insert into Furnizori(" + listaCampuri + ") Select '" + listaValori+"'";
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            lblOp.Text = "ADAUGARE";
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtNume.Visible = false;
            lblOp.Text = "MODIFICARE";
            A6();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            lblOp.Text = "STERGERE";
            A7();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtNume.Visible = true;
            A3();
        }

    }
}
