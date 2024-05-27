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

namespace Proyecto_MAD
{
    public partial class Registro_Nuevo : Form
    {
        private MySqlConnection conexion;
        private string connectionString = "server=localhost;port=3306;uid=root;pwd=;database='base de datos mad';";
        public Registro_Nuevo()
        {
            InitializeComponent();
            conexion = new MySqlConnection(connectionString);
        }

        private void textBoxNuevoAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNuevaCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoAlumno = textBoxNuevoAlumno.Text;
            string nuevaCarrera = textBoxNuevaCarrera.Text;
            string nuevaAsignatura = textBoxNuevaAsignatura.Text;
            string nuevoGrupo = textBoxNuevoGrupo.Text;
            string nuevoDocente = textBoxNuevoDocente.Text;
            string nuevaIncidencia = textBoxNuevaIncidencia.Text;
            string nuevaAula = textBoxNuevaAula.Text;

            try
            {
                conexion.Open();
                string queryVerificar= "SELECT COUNT(*)FORM generaciondereporte WHERE Alumno=@alumno";

                MySqlCommand comandoVerificar = new MySqlCommand(queryVerificar, conexion);
                comandoVerificar.Parameters.AddWithValue("@Alumno", nuevoAlumno);
                int count = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                if (count > 0)
                {

                    string queryActualizar = "UPDATE generaciondebasededatos SET Alumno= @alumno, Carrera = @carrera, Asignatura= @asignatura , Grupo = @grupo , Docente = @docente , Incidencia =@incidencia WHERE Aula= @aula";
                    MySqlCommand comandoActualizar = new MySqlCommand(queryActualizar, conexion);
                    comandoActualizar.Parameters.AddWithValue("@Alumno", nuevoAlumno);
                    comandoActualizar.Parameters.AddWithValue("@carrera", nuevaCarrera);
                    comandoActualizar.Parameters.AddWithValue("@Asignatura", nuevaAsignatura);
                    comandoActualizar.Parameters.AddWithValue("@Grupo", nuevoGrupo);
                    comandoActualizar.Parameters.AddWithValue("@Docente", nuevoDocente);
                    comandoActualizar.Parameters.AddWithValue("@Incidencia", nuevaIncidencia);
                    comandoActualizar.Parameters.AddWithValue("@Aula", nuevaAula);
                    comandoActualizar.ExecuteNonQuery();
                }
                else
                {
                    
                    string queryInsertar = "INSERT INTO generaciondereporte (Alumno,Carrera, Asignatura, Grupo,Docente,Incidencia, Aula) VALUES (@alumno, @carrera, @asignatura, @grupo,@docente,@aula)";
                    MySqlCommand comandoInsertar = new MySqlCommand(queryInsertar, conexion);
                    comandoInsertar.Parameters.AddWithValue("@Alumno", nuevoAlumno);
                    comandoInsertar.Parameters.AddWithValue("@Asignatura", nuevaAsignatura);
                    comandoInsertar.Parameters.AddWithValue("@carrera", nuevaCarrera);
                    comandoInsertar.Parameters.AddWithValue("@Grupo", nuevoGrupo);
                    comandoInsertar.Parameters.AddWithValue("@Docente", nuevoDocente);
                    comandoInsertar.Parameters.AddWithValue("@Incidencia", nuevaIncidencia);
                    comandoInsertar.Parameters.AddWithValue("@Aula", nuevaAula);
                    comandoInsertar.ExecuteNonQuery();
                }

                MessageBox.Show("Datos guardados correctamente.");

                // Cerrar el formulario actual
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }


        }

        private void textBoxNuevaIncidencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 