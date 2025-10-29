namespace pryFerreyraSP4
{
    partial class frmBarLaMilanga
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarLaMilanga));
            dgvVentas = new DataGridView();
            colMozo = new DataGridViewTextBoxColumn();
            colComida = new DataGridViewTextBoxColumn();
            colBebidaSAlch = new DataGridViewTextBoxColumn();
            colBebidasCAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            lstTotales = new ListBox();
            gbResultados = new GroupBox();
            lblImporte = new Label();
            lblMozo = new Label();
            btnMozoDelDia = new Button();
            lblTituloResultado = new Label();
            btnNuevoDia = new Button();
            btnMostrarTotales = new Button();
            btnValidarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            gbResultados.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozo, colComida, colBebidaSAlch, colBebidasCAlcohol, colPostres });
            dgvVentas.GridColor = Color.GhostWhite;
            dgvVentas.Location = new Point(12, 10);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(504, 167);
            dgvVentas.TabIndex = 0;
            // 
            // colMozo
            // 
            colMozo.HeaderText = "Mozo";
            colMozo.Name = "colMozo";
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebidaSAlch
            // 
            colBebidaSAlch.HeaderText = "Bebidas Sin Alcohol";
            colBebidaSAlch.Name = "colBebidaSAlch";
            // 
            // colBebidasCAlcohol
            // 
            colBebidasCAlcohol.HeaderText = "Bebidas Con Alcohol";
            colBebidasCAlcohol.Name = "colBebidasCAlcohol";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // lstTotales
            // 
            lstTotales.FormattingEnabled = true;
            lstTotales.ItemHeight = 15;
            lstTotales.Location = new Point(28, 229);
            lstTotales.Name = "lstTotales";
            lstTotales.Size = new Size(199, 229);
            lstTotales.TabIndex = 8;
            lstTotales.SelectedIndexChanged += lstTotales_SelectedIndexChanged;
            // 
            // gbResultados
            // 
            gbResultados.BackColor = SystemColors.Window;
            gbResultados.Controls.Add(lblImporte);
            gbResultados.Controls.Add(lblMozo);
            gbResultados.Controls.Add(btnMozoDelDia);
            gbResultados.Controls.Add(lblTituloResultado);
            gbResultados.Location = new Point(298, 229);
            gbResultados.Name = "gbResultados";
            gbResultados.Size = new Size(199, 229);
            gbResultados.TabIndex = 9;
            gbResultados.TabStop = false;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            lblImporte.Location = new Point(6, 79);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(0, 15);
            lblImporte.TabIndex = 17;
            // 
            // lblMozo
            // 
            lblMozo.AutoSize = true;
            lblMozo.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMozo.Location = new Point(6, 49);
            lblMozo.Name = "lblMozo";
            lblMozo.Size = new Size(0, 15);
            lblMozo.TabIndex = 16;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.BackColor = SystemColors.MenuText;
            btnMozoDelDia.ForeColor = SystemColors.Window;
            btnMozoDelDia.Location = new Point(102, 187);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(91, 29);
            btnMozoDelDia.TabIndex = 13;
            btnMozoDelDia.Text = "Visualizar";
            btnMozoDelDia.UseVisualStyleBackColor = false;
            btnMozoDelDia.Click += btnMozoDelDia_Click_1;
            // 
            // lblTituloResultado
            // 
            lblTituloResultado.AutoSize = true;
            lblTituloResultado.Location = new Point(6, 19);
            lblTituloResultado.Name = "lblTituloResultado";
            lblTituloResultado.Size = new Size(135, 15);
            lblTituloResultado.TabIndex = 15;
            lblTituloResultado.Text = "Mozo con mayor venta: ";
            // 
            // btnNuevoDia
            // 
            btnNuevoDia.BackColor = SystemColors.MenuText;
            btnNuevoDia.ForeColor = SystemColors.Window;
            btnNuevoDia.Location = new Point(118, 183);
            btnNuevoDia.Name = "btnNuevoDia";
            btnNuevoDia.Size = new Size(91, 29);
            btnNuevoDia.TabIndex = 15;
            btnNuevoDia.Text = "Nuevo Día";
            btnNuevoDia.UseVisualStyleBackColor = false;
            btnNuevoDia.Click += btnNuevoDia_Click_1;
            // 
            // btnMostrarTotales
            // 
            btnMostrarTotales.BackColor = SystemColors.MenuText;
            btnMostrarTotales.ForeColor = SystemColors.Window;
            btnMostrarTotales.Location = new Point(127, 416);
            btnMostrarTotales.Name = "btnMostrarTotales";
            btnMostrarTotales.Size = new Size(91, 29);
            btnMostrarTotales.TabIndex = 14;
            btnMostrarTotales.Text = "Total Ventas";
            btnMostrarTotales.UseVisualStyleBackColor = false;
            btnMostrarTotales.Click += btnMostrarTotales_Click_1;
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.BackColor = SystemColors.MenuText;
            btnValidarDatos.ForeColor = SystemColors.Window;
            btnValidarDatos.Location = new Point(12, 183);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(91, 29);
            btnValidarDatos.TabIndex = 12;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = false;
            btnValidarDatos.Click += btnValidarDatos_Click_1;
            // 
            // frmBarLaMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(527, 501);
            Controls.Add(btnNuevoDia);
            Controls.Add(btnMostrarTotales);
            Controls.Add(btnValidarDatos);
            Controls.Add(gbResultados);
            Controls.Add(lstTotales);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(10, 10);
            MaximizeBox = false;
            Name = "frmBarLaMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colMozo;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaSAlch;
        private DataGridViewTextBoxColumn colBebidasCAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private ListBox lstTotales;
        private GroupBox gbResultados;
        private Label lblImporte;
        private Label lblMozo;
        private Button btnMozoDelDia;
        private Label lblTituloResultado;
        private Button btnNuevoDia;
        private Button btnMostrarTotales;
        private Button btnValidarDatos;
    }
}
