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
        public Registro_Nuevo()
        {
            InitializeComponent();
        }

        private void textBoxNuevoAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNuevaCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoAlumno=textBoxNuevoAlumno.Text;
            string nuevaCarrera=textBoxNuevaCarrera.Text;
            string nuevaAsignatura=textBoxNuevaAsignatura.Text; 
            string nuevoGrupo=textBoxNuevoGrupo.Text;
            string nuevoDocente=textBoxNuevoDocente.Text;
            string nuevaIncidenia=textBoxNuevaIncidencia.Text;
            string nuevaAula=textBoxNuevaAula.Text;

            try
            {
                conexion.Open();
                string query = "SELECT Alumno,Carrera,Asignatura,Grupo,Docente,Incidencia,Aula FORM  generacion de reporte WHERE Alumno LIKE @fitro OR Carrera LIKE @filtro OR "
            }
        }
    }
}
