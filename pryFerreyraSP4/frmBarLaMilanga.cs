namespace pryFerreyraSP4
{
    public partial class frmBarLaMilanga : Form
    {
        public frmBarLaMilanga()
        {
            InitializeComponent();
        }

        string[,] matVentas = new string[10, 5];


        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");

            dgvVentas.Rows[0].Cells[0].Style.BackColor = Color.Maroon;
            dgvVentas.Rows[1].Cells[0].Style.BackColor = Color.Maroon;
            dgvVentas.Rows[2].Cells[0].Style.BackColor = Color.Maroon;
            dgvVentas.Rows[3].Cells[0].Style.BackColor = Color.Maroon;
            dgvVentas.Rows[4].Cells[0].Style.BackColor = Color.Maroon;

            dgvVentas.Rows[0].Cells[0].Selected = false;
            dgvVentas.Rows[0].Cells[0].Selected = true;
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            bool datosValidos = true;

            for (int fila = 0; fila < dgvVentas.Rows.Count; fila++)
            {
                for (int col = 1; col < dgvVentas.Columns.Count; col++) // empieza en 1 porque la col 0 es el mozo
                {
                    var celda = dgvVentas.Rows[fila].Cells[col].Value;
                    string valor = celda == null ? "" : celda.ToString().Trim();

                    // Si está vacío, lo tratamos como error
                    if (valor == "")
                    {
                        datosValidos = false;
                        dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.LightCoral;
                        continue;
                    }

                    // Intentamos convertir a número
                    if (float.TryParse(valor, out float numero))
                    {
                        // OK, lo guardamos en la matriz
                        matVentas[fila, col] = numero.ToString();
                        dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.White;
                    }
                    else
                    {
                        datosValidos = false;
                        dgvVentas.Rows[fila].Cells[col].Style.BackColor = Color.LightCoral;
                    }
                }
            }

            if (datosValidos)
            {
                MessageBox.Show("Todos los datos son válidos.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hay celdas inválidas o vacías. Corríjalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
    }

