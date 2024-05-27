using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_MAD
{
    public partial class RegistroReporte : Form
    {
        private MySqlConnection conexion;
        private string connectionString = "server=localhost;port=3306;uid=root;pwd=;database='base de datos mad';";
        public RegistroReporte()
        {
            InitializeComponent();
            conexion = new MySqlConnection(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registro_Nuevo registro_Nuevo = new Registro_Nuevo();
            registro_Nuevo.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Obtener el ID del estudiante seleccionado
            int idSeleccionado = ObtenerIdSeleccionado();

            if (idSeleccionado != -1)
            {
                // Confirmar si el usuario desea eliminar el estudiante
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este reporte?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MySqlConnection conexion = new MySqlConnection(connectionString);
                    try
                    {
                        
                        conexion.Open();

                        
                        string query = "DELETE FROM generaciondereporte  WHERE id = @id";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        comando.Parameters.AddWithValue("@id", idSeleccionado);

                       
                        int filasAfectadas = comando.ExecuteNonQuery();

                        
                        if (filasAfectadas > 0)
                        {
                            
                            MessageBox.Show("Reporte eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            CargarDatosReporte();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el Reporte.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Cerrar la conexión a la base de datos
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private int ObtenerIdSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                return Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
            }
            else
            {
                return -1;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(filtro))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Alumno, Carrera, Asignatura,Grupo,Docente,Inciencia, Aula FROM generaciondreporte WHERE Alumno LIKE @filtro OR Carrera LIKE @filtro OR Asignatura LIKE @filtro OR Grupo LIKE @filtro OR Docente LIKE @filtro OR Incidencia LIKE @filtro OR AulaLIKE @filtro";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tablageneraciondereporte = new DataTable();
                    adaptador.Fill(tablageneraciondereporte);
                    dataGridView1.DataSource = tablageneraciondereporte;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el registro de reporte  " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
            }
        }

        private void RegistroReporte_Load(object sender, EventArgs e)
        {
            CargarDatosReporte();

        }
        private int ObteneridSeleccionado()
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                return Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
            }
            else
            {
                return -1;
            }
        }
         private void CargarDatosReporte()
         {
                try
                {
                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string query = "SELECT id, Alumno,Carrera,Asignatura,Grupo,Docente,Incidencia,Aula FROM generaciondereporte";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tablageneraciondereporte= new DataTable();
                    adaptador.Fill(tablageneraciondereporte);
                    dataGridView1.DataSource = tablageneraciondereporte;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del reporte : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
         }

    }
}


