using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
namespace Sanita_Ticket
{
    public partial class MainForm : Form
    {
        private Ticket ticket;
        //private BindingSource productsDgvBs = new BindingSource();
        private DataSet sanitaFileDataSet = new DataSet();
        private BindingSource sanitaFileBindingSource = new BindingSource();

        private BindingSource ticketProductsBindingSource = new BindingSource();

        private SanitaConfig sanitaConfig = SanitaConfig.LoadConfig();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sanitaDS.lista' Puede moverla o quitarla según sea necesario.
            this.init();
        }

        private void init(int numero = 0)
        {
            this.initFilters();
            this.initTicket(numero);
            this.initTicketDgv();
            this.initReport();
            this.initReportViewer();
            this.tryInitDgv();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            var field = this.filterBySelect.SelectedItem;
            this.sanitaFileBindingSource.Filter = $"{field} LIKE '%{this.searchTb.Text}%'";
        }

        private void productsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddProduct();
            this.RefreshReport();
        }

        private void initTicket(int newNumber = 0)
        {
            int lastTicketNumber = 0;
            try
            {
                lastTicketNumber = int.Parse(this.sanitaConfig.lastTicketNumber);
            } catch {
            }
            var numero = lastTicketNumber > newNumber ? lastTicketNumber : newNumber;
            this.ticket = new Ticket() { Numero = numero };
            this.ticketNumberTxt.Text = numero.ToString();
        }

        private void initFilters()
        {
            this.filterBySelect.SelectedItem = this.filterBySelect.Items[0];
        }
        private void initReport()
        {
            var ds = new ReportDataSource() { Name = "TicketDS", Value = this.ticket.Products };
            this.ticketRv.LocalReport.DataSources.Clear();
            this.ticketRv.LocalReport.DataSources.Add(ds);
            var reportParams = new ReportParameter[]
            {
                new ReportParameter("total", "0.00"),
                new ReportParameter("numero", this.ticket.Numero.ToString()),
                new ReportParameter("fecha", this.ticket.Date.ToString("dd/MM/yyyy")),
            };
            this.ticketRv.LocalReport.SetParameters(reportParams);
            this.ticketRv.RefreshReport();
        }

        private void initReportViewer()
        {
            this.ticketRv.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void AddProduct() {
            var selectedRow = (DataRowView)this.productsDgv.CurrentRow.DataBoundItem;
            var product = new Product()
            {
                codigo = selectedRow.Row["codigo"].ToString(),
                descripcion = selectedRow.Row["descripcion"].ToString(),
                precio = selectedRow.Row["precio"].ToString(),
                quantity = 1,
            };
            this.ticket.Products.Add(product);
            this.productBindingSource1.Add(product);
        }

        private void RefreshReport()
        {
            var reportParams = new ReportParameter[]
            {
                new ReportParameter("total", this.ticket.Total),
                new ReportParameter("numero", this.ticket.Numero.ToString()),
                new ReportParameter("fecha", this.ticket.Date.ToString("dd/MM/yyyy")),

            };
            this.ticketRv.LocalReport.SetParameters(reportParams);
            this.ticketRv.RefreshReport();
        }

        private void ticketNumberTxt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.ticket.Numero = decimal.ToInt32(this.ticketNumberTxt.Value);
            }
            catch
            {
                this.ticket.Numero = 0;
            } finally
            {
                this.RefreshReport();
            }
        }

        private void newTicket_Click(object sender, EventArgs e)
        {
            this.init(this.ticket.Numero + 1);
            this.RefreshReport();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //this.LoadDataGrid(this.openFileDialog.FileName);
                this.initDgv(this.openFileDialog.FileName);
            }
        }

        private void tryInitDgv()
        {
            try
            {
                if (File.Exists(this.sanitaConfig.lastSanitaPath))
                {
                    this.initDgv(this.sanitaConfig.lastSanitaPath);
                }
            } catch { }
        }

        private void initDgv(string path)
        {

            // Connection object
            var conn = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path}");
            var sql = "SELECT codigo, descripcion, precio FROM lista";

            // Create data adapter object
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, conn);

            // Create a dataset object and fill with data using data adapter’s Fill method
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "lista");

            // Attach dataset’s DefaultView to the datagrid control
            this.sanitaFileBindingSource.DataSource = dataSet.Tables["lista"].DefaultView;
            this.productsDgv.DataSource = this.sanitaFileBindingSource.DataSource;

            this.sanitaConfig.lastSanitaPath = path;
            //this.productsDgv.DataSource = dataSet.Tables["lista"].DefaultView;
        }

        private void initTicketDgv()
        {
            //this.ticketProductsBindingSource.DataSource = this.ticket.Products;
            //this.ticketProductsBindingSource.Add(new Product());
            //var bindingList = new BindingList<Product>(this.ticket.Products);
            //this.ticketProductsBindingSource.DataSource = new BindingSource(bindingList, null);
            //this.ticketProductsDgv.DataSource = bindingList;
            this.ticketProductsDgv.DataSource = this.productBindingSource1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.sanitaConfig.lastTicketNumber = this.ticket.Numero.ToString();
            this.sanitaConfig.Save();
        }

        private void ticketProductsDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var product = (Product) this.productBindingSource1[e.RowIndex];
            this.updateAddedProduct(product);
            this.RefreshReport();
        }

        private void updateAddedProduct(Product updatedProduct) {
            var index = this.ticket.Products.FindIndex(p => p.codigo == updatedProduct.codigo);
            this.ticket.Products[index] = updatedProduct;
        }
    }
}
