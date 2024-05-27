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
        public string alumno {get; set; }
        public string carrera {get; set; }
        public string asignatura {get; set; }
        public string grupo {get; set; }
        public string docente {get; set; }
        public string incidencia {get; set; }
        public string aula {get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroReporte registroReporte = new RegistroReporte();
            registroReporte.Show();

            string connectionString = "server=localhost; port =3306;uid=root;pwd=;database='base de datos mad';";

            using (MySqlConnection conect = new MySqlConnection(connectionString))

            {
                try
                {
                    conect.Open();


                    // Consulta SQL para insertar datos en la tabla 'estudiantes'
                    string query = "INSERT INTO generaciondereporte (Alumno,Carrera, Asignatura,Grupo,Docente,Incidencia,Aula) VALUES (@Alumno, @Carrera, @Asignatura, @Grupo,@Docente,@Incidencia,@Aula)";

                    // Crear el comando con la consulta SQL y la conexión
                    MySqlCommand comando = new MySqlCommand(query, conect);

                    // Asignar valores a los parámetros de la consulta
                    comando.Parameters.AddWithValue("@Alumno", alumno);
                    comando.Parameters.AddWithValue("@Carrera", carrera);
                    comando.Parameters.AddWithValue("@Asignatura", asignatura);
                    comando.Parameters.AddWithValue("@Grupo", grupo);
                    comando.Parameters.AddWithValue("@Docente", docente);
                    comando.Parameters.AddWithValue("@Incidencia", incidencia);
                    comando.Parameters.AddWithValue("@Aula", aula);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Datos guardados correctamente !");

                    conect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de registro de reporte: " + ex.Message);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAulas formularioAulas = new FormAulas();
            formularioAulas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Aqui se insertan el nombre del alumno
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registro_Nuevo registro_Nuevo = new Registro_Nuevo();
            registro_Nuevo.Show(registro_Nuevo);      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Aqui se insertan los datos de la carrera del alumno
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Aqui se inserta el nombre de la carrera del alumno
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el grupo del alumno
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el nombre del docente
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Aqui se describe la incidencia que se presenta 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Aqui va el nombre del aula en donde se presento la incidencia
        }
    }
}
