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
            btnValidarDatos = new Button();
            btnMozoDelDia = new Button();
            btnMostrarTotales = new Button();
            btnNuevoDia = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            dgvVentas.Location = new Point(0, 0);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(504, 253);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
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
            colPostres.HeaderText = "Postes";
            colPostres.Name = "colPostres";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.Location = new Point(530, 30);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(91, 29);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = true;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Location = new Point(530, 70);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(91, 29);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo Del Día ";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTotales
            // 
            btnMostrarTotales.Location = new Point(530, 110);
            btnMostrarTotales.Name = "btnMostrarTotales";
            btnMostrarTotales.Size = new Size(91, 29);
            btnMostrarTotales.TabIndex = 3;
            btnMostrarTotales.Text = "Total Ventas";
            btnMostrarTotales.UseVisualStyleBackColor = true;
            // 
            // btnNuevoDia
            // 
            btnNuevoDia.Location = new Point(530, 150);
            btnNuevoDia.Name = "btnNuevoDia";
            btnNuevoDia.Size = new Size(91, 29);
            btnNuevoDia.TabIndex = 4;
            btnNuevoDia.Text = "Nuevo Día";
            btnNuevoDia.UseVisualStyleBackColor = true;
            // 
            // frmBarLaMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 492);
            Controls.Add(btnNuevoDia);
            Controls.Add(btnMostrarTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidarDatos);
            Controls.Add(dgvVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(10, 10);
            Name = "frmBarLaMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar La Milanga";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colMozo;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaSAlch;
        private DataGridViewTextBoxColumn colBebidasCAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnValidarDatos;
        private Button btnMozoDelDia;
        private Button btnMostrarTotales;
        private Button btnNuevoDia;
    }
}
