namespace Proyecto_MAD
{
    partial class Form2
    {
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.TextBox textBoxAsignatura;
        private System.Windows.Forms.TextBox textBoxGrupo;
        private System.Windows.Forms.TextBox textBoxDocente;
        private System.Windows.Forms.TextBox textBoxIncidencia;
        private System.Windows.Forms.TextBox textBoxAula;

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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 0;
            label1.Text = "Generación de Reporte";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 373);
            button1.Name = "button1";
            button1.Size = new Size(226, 40);
            button1.TabIndex = 1;
            button1.Text = "Registrar Reporte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(593, 434);
            button2.Name = "button2";
            button2.Size = new Size(226, 40);
            button2.TabIndex = 2;
            button2.Text = "Aulas Disponibles";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(848, 432);
            button3.Name = "button3";
            button3.Size = new Size(127, 40);
            button3.TabIndex = 3;
            button3.Text = "Inicio";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(112, 144);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 4;
            label2.Text = "Carrera";
            label2.Click += Label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 203);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 5;
            label3.Text = "Asignatura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(125, 250);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "Grupo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 302);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 7;
            label5.Text = "Docente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(504, 87);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 8;
            label6.Text = "Incidencia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += TextBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 27);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += TextBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(633, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 27);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += TextBox5_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Cursor = Cursors.Hand;
            label7.Location = new Point(1093, 12);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 14;
            label7.Text = "X";
            label7.Click += Label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(560, 144);
            label8.Name = "label8";
            label8.Size = new Size(53, 23);
            label8.TabIndex = 17;
            label8.Text = "Aula";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(633, 144);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 27);
            textBox6.TabIndex = 18;
            textBox6.TextChanged += TextBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(199, 302);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(283, 27);
            textBox7.TabIndex = 19;
            textBox7.TextChanged += TextBox7_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(112, 91);
            label9.Name = "label9";
            label9.Size = new Size(81, 23);
            label9.TabIndex = 20;
            label9.Text = "Alumno";
            label9.Click += Label9_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(256, 434);
            button4.Name = "button4";
            button4.Size = new Size(226, 40);
            button4.TabIndex = 21;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 434);
            button5.Name = "button5";
            button5.Size = new Size(226, 40);
            button5.TabIndex = 22;
            button5.Text = "Visualizar Reporte";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1123, 508);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Button button4;
        private Button button5;
    }
}