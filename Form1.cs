using Prueba_azteca.Data;
using Prueba_azteca.Model;

namespace Prueba_azteca
{
    public partial class Form1 : Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
            LoadCustomers();

            dataGridView1.Columns.Add("CON_ID", "Contrato");
            dataGridView1.Columns.Add("CON_NAME", "Descripcion");
            dataGridView1.Columns.Add("STA_SHORT_NAME", "Estación");
            dataGridView1.Columns.Add("CON_BEGIN_DATE", "Fecha Inicial");
            dataGridView1.Columns.Add("CON_AMOUNT", "Monto de Contrato");
        }

        private void LoadCustomers()
        {
            List<Customer> customers = db.GetCustomers();
            cmbClientes.DataSource = customers;
            cmbClientes.DisplayMember = "Name";
            cmbClientes.ValueMember = "CustomerId";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void LoadContracts()
        {
            if (cmbClientes.SelectedValue != null)
            {
                int customerId = (int)cmbClientes.SelectedValue;
                List<Contract> contracts = db.GetContracts(customerId);
                dataGridView1.Rows.Clear();

                foreach (var contract in contracts)
                {
                    dataGridView1.Rows.Add(contract.CON_SHORT_NAME, contract.CON_NAME, contract.STA_ID, contract.CON_BEGIN_DATE.ToShortDateString(), contract.CON_AMOUNT);
                }
            }
        }

            
        private void txtIndiceBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtClientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
