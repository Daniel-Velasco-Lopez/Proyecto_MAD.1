namespace Proyecto_MAD
{
    partial class RegistroReporte
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
            button4 = new Button();
            label7 = new Label();
            label2 = new Label();
            button3 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button1 = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            button4.Location = new Point(730, 444);
            button4.Name = "button4";
            button4.Size = new Size(178, 40);
            button4.TabIndex = 42;
            button4.Text = "Volver a Inicio";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Cursor = Cursors.Hand;
            label7.Location = new Point(890, 26);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 41;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 67);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 35;
            label2.Text = "Datos Registrados";
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
            button3.Location = new Point(546, 445);
            button3.Name = "button3";
            button3.Size = new Size(178, 40);
            button3.TabIndex = 34;
            button3.Text = "Volver al Reporte";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(358, 26);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 31;
            label1.Text = "Registro de Reporte";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(910, 346);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 496);
            button5.Name = "button5";
            button5.Size = new Size(189, 40);
            button5.TabIndex = 45;
            button5.Text = "Modificar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(217, 496);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 46;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(483, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 32);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(625, 67);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(283, 27);
            txtBuscar.TabIndex = 48;
            // 
            // RegistroReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 548);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroReporte";
            Text = "RegistroReporte";
            Load += RegistroReporte_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label7;
        private Label label2;
        private Button button3;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button1;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}