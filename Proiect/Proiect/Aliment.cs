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
    public partial class Aliment : Form
    {
        public Aliment()
        {
            InitializeComponent();
        }

        private void Aliment_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            alimenteTableAdapter.Fill(dataSet1.Alimente);
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
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validare()) return;
                adauga_inregistrare();
                golireCampuri();
                refresh_grid(alimenteBindingSource.Position);
            }
            if (lblOp.Text == "STERGERE")
            {
                if (!validareStergere()) return;
                stergere_inregistrare();
                golireCampuri();
                refresh_grid(alimenteBindingSource.Position);

            }
            if(lblOp.Text=="MODIFICARE")
            {
                alimenteTableAdapter.Update(dataSet1.Alimente);
                MessageBox.Show("Modificare Realizata!");
            }
        }
        private void A5()
        {
            configureazaButoane(false);
            dataGridView1.ReadOnly = true;
            golireCampuri();

        }
        private void A6()
        {
            configureazaButoane(false);
            dataGridView1.ReadOnly = false;

        }
        private void stergere_inregistrare()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = alimenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Alimente WHERE DAliment='" + txtNume.Text + "'";
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(alimenteBindingSource.Position);

        }
        private void golireCampuri()
        {
            txtNume.Text = "";
            txtPret.Text = "";
            cmbUM.SelectedValue = String.Empty;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = alimenteTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DAliment,UM,Pret";
            listaValori = "'"+txtNume.Text+"','"+cmbUM.Text+"',"+txtPret.Text;

            cmd.CommandText = "Insert into Alimente(" + listaCampuri + ") Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
           // con.Close();

           // cmd.CommandText= "INSERT INTO StocAliment(IDAliment, Cantitate) SELECT a.IDAliment,0 FROM Alimente AS a WHERE a.DAliment = '"+txtNume.Text+"'";
           // MessageBox.Show(cmd.CommandText);
           // con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private bool validareStergere()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati numele alimentului!");
                txtNume.Focus();
                return false;
            }
            return true;
        }
        private bool validare()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati numele alimentului!");
                txtNume.Focus();
                return false;
            }
            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati pretul alimentului!");
                txtPret.Focus();
                return false;
            }
            if(cmbUM.Text=="")
            {
                MessageBox.Show("Alegeti unitatea de masura!");
                cmbUM.Focus();
                return false;
            }
            return true;
        }
        private void refresh_grid(int p)
        {
            dataSet1.Furnizori.Clear();
            alimenteTableAdapter.Fill(dataSet1.Alimente);
            alimenteBindingSource.Position = p;
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            lblOp.Text = "ADAUGARE";
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtPret.Visible = false;
            cmbUM.Visible = false;
            txtNume.Visible = false;
            lblOp.Text = "MODIFICARE";
            A6();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            txtPret.Visible = false;
            cmbUM.Visible = false;
            lblOp.Text = "STERGERE";
            A5();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtNume.Visible = true;
            txtPret.Visible = true;
            cmbUM.Visible = true;
            A3();
        }

        private void txtPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // accepta o singura decimala
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
