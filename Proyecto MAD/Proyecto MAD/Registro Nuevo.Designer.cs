namespace Proyecto_MAD
{
    partial class Registro_Nuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnActualizar = new Button();
            label9 = new Label();
            textBoxNuevoDocente = new TextBox();
            textBoxNuevaAula = new TextBox();
            label8 = new Label();
            textBoxNuevaIncidencia = new TextBox();
            textBoxNuevoGrupo = new TextBox();
            textBoxNuevaAsignatura = new TextBox();
            textBoxNuevaCarrera = new TextBox();
            textBoxNuevoAlumno = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bttnActualizar
            // 
            bttnActualizar.BackColor = SystemColors.HotTrack;
            bttnActualizar.FlatAppearance.BorderSize = 0;
            bttnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            bttnActualizar.FlatStyle = FlatStyle.Flat;
            bttnActualizar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttnActualizar.ForeColor = Color.White;
            bttnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            bttnActualizar.Location = new Point(157, 418);
            bttnActualizar.Name = "bttnActualizar";
            bttnActualizar.Size = new Size(226, 40);
            bttnActualizar.TabIndex = 37;
            bttnActualizar.Text = "Actualizar";
            bttnActualizar.UseVisualStyleBackColor = false;
            bttnActualizar.Click += bttnActualizar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(45, 75);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 36;
            label9.Text = "Alumno";
            // 
            // textBoxNuevoDocente
            // 
            textBoxNuevoDocente.Location = new Point(132, 286);
            textBoxNuevoDocente.Name = "textBoxNuevoDocente";
            textBoxNuevoDocente.Size = new Size(283, 27);
            textBoxNuevoDocente.TabIndex = 35;
            // 
            // textBoxNuevaAula
            // 
            textBoxNuevaAula.Location = new Point(566, 128);
            textBoxNuevaAula.Name = "textBoxNuevaAula";
            textBoxNuevaAula.Size = new Size(283, 27);
            textBoxNuevaAula.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(493, 128);
            label8.Name = "label8";
            label8.Size = new Size(53, 23);
            label8.TabIndex = 33;
            label8.Text = "Aula";
            // 
            // textBoxNuevaIncidencia
            // 
            textBoxNuevaIncidencia.Location = new Point(566, 71);
            textBoxNuevaIncidencia.Name = "textBoxNuevaIncidencia";
            textBoxNuevaIncidencia.Size = new Size(283, 27);
            textBoxNuevaIncidencia.TabIndex = 32;
            textBoxNuevaIncidencia.TextChanged += textBoxNuevaIncidencia_TextChanged;
            // 
            // textBoxNuevoGrupo
            // 
            textBoxNuevoGrupo.Location = new Point(132, 234);
            textBoxNuevoGrupo.Name = "textBoxNuevoGrupo";
            textBoxNuevoGrupo.Size = new Size(283, 27);
            textBoxNuevoGrupo.TabIndex = 31;
            // 
            // textBoxNuevaAsignatura
            // 
            textBoxNuevaAsignatura.Location = new Point(132, 183);
            textBoxNuevaAsignatura.Name = "textBoxNuevaAsignatura";
            textBoxNuevaAsignatura.Size = new Size(283, 27);
            textBoxNuevaAsignatura.TabIndex = 30;
            // 
            // textBoxNuevaCarrera
            // 
            textBoxNuevaCarrera.Location = new Point(132, 128);
            textBoxNuevaCarrera.Name = "textBoxNuevaCarrera";
            textBoxNuevaCarrera.Size = new Size(283, 27);
            textBoxNuevaCarrera.TabIndex = 29;
            textBoxNuevaCarrera.TextChanged += textBoxNuevaCarrera_TextChanged;
            // 
            // textBoxNuevoAlumno
            // 
            textBoxNuevoAlumno.Location = new Point(132, 71);
            textBoxNuevoAlumno.Name = "textBoxNuevoAlumno";
            textBoxNuevoAlumno.Size = new Size(283, 27);
            textBoxNuevoAlumno.TabIndex = 28;
            textBoxNuevoAlumno.TextChanged += textBoxNuevoAlumno_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(437, 71);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 27;
            label6.Text = "Incidencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 286);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 26;
            label5.Text = "Docente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 234);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 25;
            label4.Text = "Grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 187);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 24;
            label3.Text = "Asignatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 128);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 23;
            label2.Text = "Carrera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 20);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 22;
            label1.Text = "Generación de Reporte";
            // 
            // Registro_Nuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 504);
            Controls.Add(bttnActualizar);
            Controls.Add(label9);
            Controls.Add(textBoxNuevoDocente);
            Controls.Add(textBoxNuevaAula);
            Controls.Add(label8);
            Controls.Add(textBoxNuevaIncidencia);
            Controls.Add(textBoxNuevoGrupo);
            Controls.Add(textBoxNuevaAsignatura);
            Controls.Add(textBoxNuevaCarrera);
            Controls.Add(textBoxNuevoAlumno);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro_Nuevo";
            Text = "Registro_Nuevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnActualizar;
        private Label label9;
        private TextBox textBoxNuevoDocente;
        private TextBox textBoxNuevaAula;
        private Label label8;
        private TextBox textBoxNuevaIncidencia;
        private TextBox textBoxNuevoGrupo;
        private TextBox textBoxNuevaAsignatura;
        private TextBox textBoxNuevaCarrera;
        private TextBox textBoxNuevoAlumno;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}