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
            // Supongamos que tienes TextBoxes para ingresar la información del reporte
            string alumno = txtAlumno.Text;
            string carrera = txtCarrera.Text;
            string asignatura = txtAsignatura.Text;
            string grupo = txtGrupo.Text;
            string docente = txtDocente.Text;
            string incidencia = txtIncidencia.Text;
            string aula = txtAula.Text;

            if (string.IsNullOrEmpty(alumno) || string.IsNullOrEmpty(carrera) || string.IsNullOrEmpty(asignatura) ||
               string.IsNullOrEmpty(grupo) || string.IsNullOrEmpty(docente) || string.IsNullOrEmpty(incidencia) ||
               string.IsNullOrEmpty(aula))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();

                // Inserta la nueva información en la base de datos
                string query = "INSERT INTO generaciondereporte (Alumno, Carrera, Asignatura, Grupo, Docente, Incidencia, Aula) " +
                               "VALUES (@Alumno, @Carrera, @Asignatura, @Grupo, @Docente, @Incidencia, @Aula)";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Alumno", alumno);
                comando.Parameters.AddWithValue("@Carrera", carrera);
                comando.Parameters.AddWithValue("@Asignatura", asignatura);
                comando.Parameters.AddWithValue("@Grupo", grupo);
                comando.Parameters.AddWithValue("@Docente", docente);
                comando.Parameters.AddWithValue("@Incidencia", incidencia);
                comando.Parameters.AddWithValue("@Aula", aula);

                comando.ExecuteNonQuery();

                // Obtener el ID del último registro insertado
                long idReporte = comando.LastInsertedId;

                MessageBox.Show("Reporte registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario con la información del reporte recién registrado
                Form2 form2Form = new Form2();
                form2Form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

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


