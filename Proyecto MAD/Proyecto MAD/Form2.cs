﻿using System;
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

namespace Proyecto_MAD
{
    public partial class Form2 : Form
    {
        public string alumno { get; set; }
        public string carrera {  get; set; }
        public string asignatura {  get; set; }
        public string grupo {  get; set; }
        public string docente {  get; set; }
        public string incidencia {  get; set; }
        public string aula {  get; set; }


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
            RegistroReporte formularioReporte = new RegistroReporte();
            formularioReporte.Show();
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
