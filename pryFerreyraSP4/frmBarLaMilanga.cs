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
            for (int indiceFilas = 0; indiceFilas < dgvVentas.Rows.Count; indiceFilas++)

            {
                for (int indiceCol = 0; indiceCol < dgvVentas.Rows.Count; ++indiceCol)
                {
                    if (dgvVentas.Rows[indiceFilas].Cells[indiceCol].Value != null)
                    {
                        float contenidoCelda =
                        float.Parse(dgvVentas.Rows[indiceFilas].Cells[indiceCol].Value.ToString());

                        if (float.IsRealNumber(contenidoCelda))
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceCol].Value = "si";
                        }
                        else
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceCol].Value = "no";
                        }
                    }
                    
                }
            }
        }
    }
}
