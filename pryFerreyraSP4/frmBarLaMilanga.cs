namespace pryFerreyraSP4
{
    public partial class frmBarLaMilanga : Form
    {

        const int FILAS = 5;
        const int COLUMNAS = 5;
        string[,] matVentas = new string[FILAS, COLUMNAS];
        public frmBarLaMilanga()
        {
            InitializeComponent();
            CargarMozos();
        }

        private void CargarMozos()
        {
            dgvVentas.Rows.Clear();

            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                dgvVentas.Rows[i].Cells[0].Style.BackColor = Color.Maroon;
                dgvVentas.Rows[i].Cells[0].Style.ForeColor = Color.White;
            }
        }

        private void btnMostrarTotales_Click_1(object sender, EventArgs e)
        {
            lstTotales.Items.Clear();

            for (int fila = 0; fila < FILAS; fila++)
            {
                double suma = 0;

                for (int col = 1; col < COLUMNAS; col++)
                {
                    if (double.TryParse(dgvVentas.Rows[fila].Cells[col].Value?.ToString(), out double valor))
                    {
                        suma += valor;
                    }
                }

                string nombre = dgvVentas.Rows[fila].Cells[0].Value.ToString();
                lstTotales.Items.Add(nombre + " vendió $" + suma.ToString("N2"));
            }
        }

        private void btnValidarDatos_Click_1(object sender, EventArgs e)
        {
            bool datosCorrectos = true;

            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int col = 1; col < COLUMNAS; col++)
                {
                    object valorCelda = dgvVentas.Rows[fila].Cells[col].Value;
                    if (valorCelda == null || valorCelda.ToString() == "")
                    {
                        datosCorrectos = false;
                        dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        float valor;
                        if (float.TryParse(valorCelda.ToString(), out valor))
                        {
                            dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.White;
                            matVentas[fila, col] = valor.ToString();
                        }
                        else
                        {
                            datosCorrectos = false;
                            dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.LightCoral;
                        }
                    }
                }
            }

            if (datosCorrectos)
            {
                MessageBox.Show("Datos validados correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Existen celdas vacías o con errores.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevoDia_Click_1(object sender, EventArgs e)
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int col = 1; col < COLUMNAS; col++)
                {
                    dgvVentas.Rows[fila].Cells[col].Value = "";
                    dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.White;
                }
            }

            lstTotales.Items.Clear();
            lblMozo.Text = "";
            lblImporte.Text = "";
            MessageBox.Show("Datos limpiados correctamente.", "Nuevo Día", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMozoDelDia_Click_1(object sender, EventArgs e)
        {
            double mayorVenta = -1;
            string mozoGanador = "";

            for (int fila = 0; fila < FILAS; fila++)
            {
                double suma = 0;
                for (int col = 1; col < COLUMNAS; col++)
                {
                    if (double.TryParse(dgvVentas.Rows[fila].Cells[col].Value?.ToString(), out double valor))
                    {
                        suma += valor;
                    }
                }

                if (suma > mayorVenta)
                {
                    mayorVenta = suma;
                    mozoGanador = dgvVentas.Rows[fila].Cells[0].Value.ToString();
                }
            }

            lblMozo.Text = "Mozo del día: " + mozoGanador;
            lblImporte.Text = "Total: $" + mayorVenta.ToString("N2");
        }

        private void lstTotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

