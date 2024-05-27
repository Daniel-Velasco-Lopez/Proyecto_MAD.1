namespace Proyecto_MAD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            button2 = new Button();
            button1 = new Button();
            labelLogo = new Label();
            pictureBox1 = new PictureBox();
            BarraTitulo = new Panel();
            iconMinimizar = new PictureBox();
            iconRestaurar = new PictureBox();
            iconMaximizar = new PictureBox();
            iconCerrar = new PictureBox();
            btnMenu = new PictureBox();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(44, 67, 207);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(labelLogo);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 4, 4, 4);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(312, 812);
            MenuVertical.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 708);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(312, 50);
            button2.TabIndex = 0;
            button2.Text = "Conectar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 110);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(312, 50);
            button1.TabIndex = 0;
            button1.Text = "Generar Reportes";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.BackColor = Color.WhiteSmoke;
            labelLogo.Location = new Point(98, 31);
            labelLogo.Margin = new Padding(4, 0, 4, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(205, 25);
            labelLogo.TabIndex = 1;
            labelLogo.Text = "TECNOLÓGICO DE TLAX\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.WhiteSmoke;
            BarraTitulo.Controls.Add(iconMinimizar);
            BarraTitulo.Controls.Add(iconRestaurar);
            BarraTitulo.Controls.Add(iconMaximizar);
            BarraTitulo.Controls.Add(iconCerrar);
            BarraTitulo.Controls.Add(btnMenu);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(312, 0);
            BarraTitulo.Margin = new Padding(4, 4, 4, 4);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1313, 56);
            BarraTitulo.TabIndex = 2;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown_1;
            // 
            // iconMinimizar
            // 
            iconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimizar.BackColor = Color.DimGray;
            iconMinimizar.Cursor = Cursors.Hand;
            iconMinimizar.Image = (Image)resources.GetObject("iconMinimizar.Image");
            iconMinimizar.Location = new Point(1222, 15);
            iconMinimizar.Margin = new Padding(4, 4, 4, 4);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(25, 25);
            iconMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconMinimizar.TabIndex = 4;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            // 
            // iconRestaurar
            // 
            iconRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestaurar.BackColor = Color.DimGray;
            iconRestaurar.Cursor = Cursors.Hand;
            iconRestaurar.Image = (Image)resources.GetObject("iconRestaurar.Image");
            iconRestaurar.Location = new Point(1255, 15);
            iconRestaurar.Margin = new Padding(4, 4, 4, 4);
            iconRestaurar.Name = "iconRestaurar";
            iconRestaurar.Size = new Size(25, 25);
            iconRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconRestaurar.TabIndex = 3;
            iconRestaurar.TabStop = false;
            iconRestaurar.Visible = false;
            iconRestaurar.Click += iconRestaurar_Click;
            // 
            // iconMaximizar
            // 
            iconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximizar.BackColor = Color.DimGray;
            iconMaximizar.Cursor = Cursors.Hand;
            iconMaximizar.Image = (Image)resources.GetObject("iconMaximizar.Image");
            iconMaximizar.Location = new Point(1255, 15);
            iconMaximizar.Margin = new Padding(4, 4, 4, 4);
            iconMaximizar.Name = "iconMaximizar";
            iconMaximizar.Size = new Size(25, 25);
            iconMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconMaximizar.TabIndex = 2;
            iconMaximizar.TabStop = false;
            iconMaximizar.Click += iconMaximizar_Click;
            // 
            // iconCerrar
            // 
            iconCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconCerrar.BackColor = Color.DimGray;
            iconCerrar.Cursor = Cursors.Hand;
            iconCerrar.Image = (Image)resources.GetObject("iconCerrar.Image");
            iconCerrar.Location = new Point(1285, 15);
            iconCerrar.Margin = new Padding(4, 4, 4, 4);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(25, 25);
            iconCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconCerrar.TabIndex = 0;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(8, 9);
            btnMenu.Margin = new Padding(4, 4, 4, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(44, 44);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Location = new Point(312, 56);
            panelContenedor.Margin = new Padding(4, 4, 4, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1312, 756);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightPink;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(250, 188);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(711, 382);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 812);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel MenuVertical;
        private Panel BarraTitulo;
        private Panel panelContenedor;
        private PictureBox btnMenu;
        private Label labelLogo;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox iconMinimizar;
        private PictureBox iconRestaurar;
        private PictureBox iconMaximizar;
        private PictureBox iconCerrar;
        private PictureBox pictureBox2;
        private Button button2;
    }
}