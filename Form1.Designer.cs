namespace Prueba_azteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIndice = new Label();
            TxtClientes = new Label();
            txtIndiceBusqueda = new TextBox();
            cmbClientes = new ComboBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            CON_SHORT_NAME = new DataGridViewTextBoxColumn();
            CON_NAME = new DataGridViewTextBoxColumn();
            STA_ID = new DataGridViewTextBoxColumn();
            CON_BEGIN_DATE = new DataGridViewTextBoxColumn();
            CON_AMOUNT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtIndice
            // 
            txtIndice.AutoSize = true;
            txtIndice.Location = new Point(43, 35);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(110, 15);
            txtIndice.TabIndex = 0;
            txtIndice.Text = "Indice de busqueda";
            txtIndice.Click += label1_Click;
            // 
            // TxtClientes
            // 
            TxtClientes.AutoSize = true;
            TxtClientes.Location = new Point(43, 63);
            TxtClientes.Name = "TxtClientes";
            TxtClientes.Size = new Size(49, 15);
            TxtClientes.TabIndex = 1;
            TxtClientes.Text = "Clientes";
            TxtClientes.Click += TxtClientes_Click;
            // 
            // txtIndiceBusqueda
            // 
            txtIndiceBusqueda.Location = new Point(169, 28);
            txtIndiceBusqueda.Name = "txtIndiceBusqueda";
            txtIndiceBusqueda.Size = new Size(161, 23);
            txtIndiceBusqueda.TabIndex = 2;
            txtIndiceBusqueda.TextChanged += txtIndiceBusqueda_TextChanged;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(118, 60);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(144, 23);
            cmbClientes.TabIndex = 3;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(356, 27);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CON_SHORT_NAME, CON_NAME, STA_ID, CON_BEGIN_DATE, CON_AMOUNT });
            dataGridView1.Location = new Point(43, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(542, 318);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CON_SHORT_NAME
            // 
            CON_SHORT_NAME.HeaderText = "Contrato";
            CON_SHORT_NAME.Name = "CON_SHORT_NAME";
            // 
            // CON_NAME
            // 
            CON_NAME.HeaderText = "Descripcion";
            CON_NAME.Name = "CON_NAME";
            // 
            // STA_ID
            // 
            STA_ID.HeaderText = "Estacion";
            STA_ID.Name = "STA_ID";
            // 
            // CON_BEGIN_DATE
            // 
            CON_BEGIN_DATE.HeaderText = "Fecha Inicial";
            CON_BEGIN_DATE.Name = "CON_BEGIN_DATE";
            // 
            // CON_AMOUNT
            // 
            CON_AMOUNT.HeaderText = "Monto del Contrato";
            CON_AMOUNT.Name = "CON_AMOUNT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(cmbClientes);
            Controls.Add(txtIndiceBusqueda);
            Controls.Add(TxtClientes);
            Controls.Add(txtIndice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIndice;
        private Label TxtClientes;
        private TextBox txtIndiceBusqueda;
        private ComboBox cmbClientes;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CON_SHORT_NAME;
        private DataGridViewTextBoxColumn CON_NAME;
        private DataGridViewTextBoxColumn STA_ID;
        private DataGridViewTextBoxColumn CON_BEGIN_DATE;
        private DataGridViewTextBoxColumn CON_AMOUNT;
    }
}
