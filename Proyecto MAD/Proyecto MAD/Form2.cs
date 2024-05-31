using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_MAD;
using LibreriaMAD;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace Proyecto_MAD
{
    public partial class Form2 : Form
    {
        public string Alumno { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
        public string Grupo { get; set; }
        public string Docente { get; set; }
        public string Incidencia { get; set; }
        public string Aula { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Asigna los valores de los TextBox a las propiedades antes de realizar la insercción en la base de datos.
            Alumno = textBoxAlumno.Text;
            Carrera = textBoxCarrera.Text;
            Asignatura = textBoxAsignatura.Text;
            Grupo = textBoxGrupo.Text;
            Docente = textBoxDocente.Text;
            Incidencia = textBoxIncidencia.Text;
            Aula = textBoxAula.Text;

            string connectionString = "server=localhost; port =3306;uid=root;pwd=;database=base de datos mad;";

            using (MySqlConnection conect = new MySqlConnection(connectionString))

            {
                try
                {
                    conect.Open();


                    // Consulta SQL para insertar datos en la tabla 'generacíondereporte'
                    string query = "INSERT INTO generaciondereporte (Alumno,Carrera,Asignatura,Grupo,Docente,Incidencia,Aula) VALUES (@Alumno, @Carrera, @Asignatura, @Grupo,@Docente,@Incidencia,@Aula)";

                    // Crear el comando con la consulta SQL y la conexión
                    MySqlCommand comando = new MySqlCommand(query, conect);

                    // Asignar valores a los parámetros de la consulta
                    comando.Parameters.AddWithValue("@Alumno", Alumno);
                    comando.Parameters.AddWithValue("@Carrera", Carrera);
                    comando.Parameters.AddWithValue("@Asignatura", Asignatura);
                    comando.Parameters.AddWithValue("@Grupo", Grupo);
                    comando.Parameters.AddWithValue("@Docente", Docente);
                    comando.Parameters.AddWithValue("@Incidencia", Incidencia);
                    comando.Parameters.AddWithValue("@Aula", Aula);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos guardados correctamente !");

                    RegistroReporte registroReporte = Application.OpenForms.OfType<RegistroReporte>().FirstOrDefault();
                    if (registroReporte != null)
                    {
                        registroReporte.CargarDatosReporte();
                        registroReporte.Show();
                    }


                    conect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de registro de reporte: " + ex.Message);
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormAulas formularioAulas = new FormAulas();
            formularioAulas.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Aqui se insertan el nombre del alumno

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Registro_Nuevo registroNuevo = new Registro_Nuevo();
            registroNuevo.Show();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //Aqui se insertan los datos de la carrera del alumno


        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            //Aqui se inserta el nombre de la carrera del alumno

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el grupo del alumno

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el nombre del docente

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            //Aqui se describe la incidencia que se presenta 

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el nombre del aula en donde se presento la incidencia

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Aquí debe de abrir el formulario RegistroReporte
            RegistroReporte registroReporte = new RegistroReporte();
            registroReporte.Show();
        }
    }
}
