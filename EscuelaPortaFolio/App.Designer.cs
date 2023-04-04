
namespace EscuelaPortaFolio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUnidad = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 436);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 134);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de calificaciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscuelaPortaFolio.Properties.Resources.school_FILL0_wght600_GRAD200_opsz48;
            this.pictureBox1.Location = new System.Drawing.Point(48, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.button3);
            this.pMenu.Controls.Add(this.btnUnidad);
            this.pMenu.Controls.Add(this.btnMateria);
            this.pMenu.Controls.Add(this.btnAlumno);
            this.pMenu.Location = new System.Drawing.Point(12, 167);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(201, 262);
            this.pMenu.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Image = global::EscuelaPortaFolio.Properties.Resources.assignment_add_FILL0_wght500_GRAD200_opsz48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "   Examen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUnidad
            // 
            this.btnUnidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnidad.FlatAppearance.BorderSize = 0;
            this.btnUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnidad.Image = global::EscuelaPortaFolio.Properties.Resources.bookmarks_FILL0_wght500_GRAD200_opsz48;
            this.btnUnidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidad.Location = new System.Drawing.Point(0, 122);
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.Size = new System.Drawing.Size(201, 61);
            this.btnUnidad.TabIndex = 2;
            this.btnUnidad.Text = "   Unidad";
            this.btnUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnidad.UseVisualStyleBackColor = true;
            this.btnUnidad.Click += new System.EventHandler(this.btnUnidad_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMateria.FlatAppearance.BorderSize = 0;
            this.btnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMateria.Image = global::EscuelaPortaFolio.Properties.Resources.local_library_FILL0_wght500_GRAD200_opsz48;
            this.btnMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMateria.Location = new System.Drawing.Point(0, 61);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(201, 61);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "   Materia";
            this.btnMateria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMateria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumno.FlatAppearance.BorderSize = 0;
            this.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlumno.Image = global::EscuelaPortaFolio.Properties.Resources.groups_FILL0_wght500_GRAD200_opsz48;
            this.btnAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumno.Location = new System.Drawing.Point(0, 0);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(201, 61);
            this.btnAlumno.TabIndex = 0;
            this.btnAlumno.Text = "   Alumno";
            this.btnAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPrincipal.AutoSize = true;
            this.pPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(228, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(633, 436);
            this.pPrincipal.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 436);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUnidad;
        private System.Windows.Forms.Button btnMateria;
        public System.Windows.Forms.Panel pPrincipal;
    }
}

