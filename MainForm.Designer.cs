namespace Sanita_Ticket
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.productsDgv = new System.Windows.Forms.DataGridView();
            this.sanitaDS = new Sanita_Ticket.SanitaDS();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketRv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.numberLbl = new System.Windows.Forms.Label();
            this.filterBySelect = new System.Windows.Forms.ComboBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.newTicket = new System.Windows.Forms.Button();
            this.ticketNumberTxt = new System.Windows.Forms.NumericUpDown();
            this.ticketProductsDgv = new System.Windows.Forms.DataGridView();
            this.listaTableAdapter1 = new Sanita_Ticket.SanitaDSTableAdapters.listaTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanitaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketNumberTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketProductsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDgv
            // 
            this.productsDgv.AllowUserToAddRows = false;
            this.productsDgv.AllowUserToDeleteRows = false;
            this.productsDgv.AllowUserToOrderColumns = true;
            this.productsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDgv.Location = new System.Drawing.Point(6, 113);
            this.productsDgv.Name = "productsDgv";
            this.productsDgv.ReadOnly = true;
            this.productsDgv.RowHeadersWidth = 51;
            this.productsDgv.RowTemplate.Height = 24;
            this.productsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDgv.Size = new System.Drawing.Size(581, 787);
            this.productsDgv.TabIndex = 0;
            this.productsDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDgv_CellDoubleClick);
            // 
            // sanitaDS
            // 
            this.sanitaDS.DataSetName = "SanitaDS";
            this.sanitaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(6, 85);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(581, 22);
            this.searchTb.TabIndex = 1;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por";
            // 
            // ticketRv
            // 
            this.ticketRv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketRv.LocalReport.ReportEmbeddedResource = "Sanita_Ticket.ticket.rdlc";
            this.ticketRv.Location = new System.Drawing.Point(0, 0);
            this.ticketRv.Name = "ticketRv";
            this.ticketRv.ServerReport.BearerToken = null;
            this.ticketRv.Size = new System.Drawing.Size(388, 903);
            this.ticketRv.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ticketRv);
            this.splitContainer1.Size = new System.Drawing.Size(1478, 903);
            this.splitContainer1.SplitterDistance = 1086;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.numberLbl);
            this.splitContainer2.Panel1.Controls.Add(this.filterBySelect);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.openFileBtn);
            this.splitContainer2.Panel1.Controls.Add(this.productsDgv);
            this.splitContainer2.Panel1.Controls.Add(this.newTicket);
            this.splitContainer2.Panel1.Controls.Add(this.searchTb);
            this.splitContainer2.Panel1.Controls.Add(this.ticketNumberTxt);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ticketProductsDgv);
            this.splitContainer2.Size = new System.Drawing.Size(1086, 903);
            this.splitContainer2.SplitterDistance = 590;
            this.splitContainer2.TabIndex = 9;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(3, 19);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(111, 16);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Numero de ticket:";
            // 
            // filterBySelect
            // 
            this.filterBySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBySelect.FormattingEnabled = true;
            this.filterBySelect.Items.AddRange(new object[] {
            "descripcion",
            "codigo"});
            this.filterBySelect.Location = new System.Drawing.Point(81, 55);
            this.filterBySelect.Name = "filterBySelect";
            this.filterBySelect.Size = new System.Drawing.Size(121, 24);
            this.filterBySelect.TabIndex = 8;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(327, 17);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 30);
            this.openFileBtn.TabIndex = 7;
            this.openFileBtn.Text = "Abrir";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // newTicket
            // 
            this.newTicket.Location = new System.Drawing.Point(246, 17);
            this.newTicket.Name = "newTicket";
            this.newTicket.Size = new System.Drawing.Size(75, 30);
            this.newTicket.TabIndex = 6;
            this.newTicket.Text = "Nuevo";
            this.newTicket.UseVisualStyleBackColor = true;
            this.newTicket.Click += new System.EventHandler(this.newTicket_Click);
            // 
            // ticketNumberTxt
            // 
            this.ticketNumberTxt.Location = new System.Drawing.Point(120, 17);
            this.ticketNumberTxt.Name = "ticketNumberTxt";
            this.ticketNumberTxt.Size = new System.Drawing.Size(120, 22);
            this.ticketNumberTxt.TabIndex = 5;
            this.ticketNumberTxt.ValueChanged += new System.EventHandler(this.ticketNumberTxt_ValueChanged);
            // 
            // ticketProductsDgv
            // 
            this.ticketProductsDgv.AllowUserToAddRows = false;
            this.ticketProductsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketProductsDgv.AutoGenerateColumns = false;
            this.ticketProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketProductsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn});
            this.ticketProductsDgv.DataSource = this.productBindingSource1;
            this.ticketProductsDgv.Location = new System.Drawing.Point(3, 113);
            this.ticketProductsDgv.Name = "ticketProductsDgv";
            this.ticketProductsDgv.RowHeadersWidth = 51;
            this.ticketProductsDgv.RowTemplate.Height = 24;
            this.ticketProductsDgv.Size = new System.Drawing.Size(486, 787);
            this.ticketProductsDgv.TabIndex = 0;
            this.ticketProductsDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketProductsDgv_CellEndEdit);
            // 
            // listaTableAdapter1
            // 
            this.listaTableAdapter1.ClearBeforeFill = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Sanita_Ticket.Product);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 903);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Sanita Ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanitaDS)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketNumberTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketProductsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDgv;
        private sanitaDataSet sanitaDataSet;
        private sanitaDataSetTableAdapters.listaTableAdapter listaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer ticketRv;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.NumericUpDown ticketNumberTxt;
        private System.Windows.Forms.Button newTicket;
        private SanitaDS sanitaDS;
        private SanitaDSTableAdapters.listaTableAdapter listaTableAdapter1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox filterBySelect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ticketProductsDgv;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}

