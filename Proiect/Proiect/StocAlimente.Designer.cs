namespace Proiect
{
    partial class StocAlimente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.stocTableAdapter = new Proiect.DataSet1TableAdapters.StocTableAdapter();
            this.btnStocInitial = new System.Windows.Forms.Button();
            this.btnIntrari = new System.Windows.Forms.Button();
            this.btnIesiri = new System.Windows.Forms.Button();
            this.btnInitializare = new System.Windows.Forms.Button();
            this.dAlimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAlimentDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // stocBindingSource
            // 
            this.stocBindingSource.DataMember = "Stoc";
            this.stocBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocTableAdapter
            // 
            this.stocTableAdapter.ClearBeforeFill = true;
            // 
            // btnStocInitial
            // 
            this.btnStocInitial.Location = new System.Drawing.Point(340, 57);
            this.btnStocInitial.Name = "btnStocInitial";
            this.btnStocInitial.Size = new System.Drawing.Size(75, 23);
            this.btnStocInitial.TabIndex = 1;
            this.btnStocInitial.Text = "StocInitial";
            this.btnStocInitial.UseVisualStyleBackColor = true;
            this.btnStocInitial.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // btnIntrari
            // 
            this.btnIntrari.Location = new System.Drawing.Point(340, 86);
            this.btnIntrari.Name = "btnIntrari";
            this.btnIntrari.Size = new System.Drawing.Size(75, 23);
            this.btnIntrari.TabIndex = 2;
            this.btnIntrari.Text = "Intrari";
            this.btnIntrari.UseVisualStyleBackColor = true;
            this.btnIntrari.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // btnIesiri
            // 
            this.btnIesiri.Location = new System.Drawing.Point(340, 115);
            this.btnIesiri.Name = "btnIesiri";
            this.btnIesiri.Size = new System.Drawing.Size(75, 23);
            this.btnIesiri.TabIndex = 3;
            this.btnIesiri.Text = "Iesiri";
            this.btnIesiri.UseVisualStyleBackColor = true;
            this.btnIesiri.Click += new System.EventHandler(this.btnIesiri_Click);
            // 
            // btnInitializare
            // 
            this.btnInitializare.Location = new System.Drawing.Point(340, 4);
            this.btnInitializare.Name = "btnInitializare";
            this.btnInitializare.Size = new System.Drawing.Size(75, 47);
            this.btnInitializare.TabIndex = 4;
            this.btnInitializare.Text = "Initializeaza Alimente";
            this.btnInitializare.UseVisualStyleBackColor = true;
            this.btnInitializare.Click += new System.EventHandler(this.btnInitializare_Click);
            // 
            // dAlimentDataGridViewTextBoxColumn
            // 
            this.dAlimentDataGridViewTextBoxColumn.DataPropertyName = "DAliment";
            this.dAlimentDataGridViewTextBoxColumn.HeaderText = "DAliment";
            this.dAlimentDataGridViewTextBoxColumn.Name = "dAlimentDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            dataGridViewCellStyle1.NullValue = "0";
            this.cantitateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // StocAlimente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInitializare);
            this.Controls.Add(this.btnIesiri);
            this.Controls.Add(this.btnIntrari);
            this.Controls.Add(this.btnStocInitial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StocAlimente";
            this.Text = "StocAlimente";
            this.Load += new System.EventHandler(this.StocAlimente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource stocBindingSource;
        private DataSet1TableAdapters.StocTableAdapter stocTableAdapter;
        private System.Windows.Forms.Button btnStocInitial;
        private System.Windows.Forms.Button btnIntrari;
        private System.Windows.Forms.Button btnIesiri;
        private System.Windows.Forms.Button btnInitializare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAlimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
    }
}