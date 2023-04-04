
namespace EscuelaPortaFolio.Catalaogo.Alumno
{
    partial class VistaAlumno
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pmenuAlumno = new System.Windows.Forms.Panel();
            this.btnACAlumno = new System.Windows.Forms.Button();
            this.btnListaAlumno = new System.Windows.Forms.Button();
            this.pAlumnoPrincipal = new System.Windows.Forms.Panel();
            this.pmenuAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pmenuAlumno
            // 
            this.pmenuAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pmenuAlumno.Controls.Add(this.btnACAlumno);
            this.pmenuAlumno.Controls.Add(this.btnListaAlumno);
            this.pmenuAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmenuAlumno.Location = new System.Drawing.Point(0, 0);
            this.pmenuAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmenuAlumno.Name = "pmenuAlumno";
            this.pmenuAlumno.Size = new System.Drawing.Size(633, 46);
            this.pmenuAlumno.TabIndex = 0;
            // 
            // btnACAlumno
            // 
            this.btnACAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnACAlumno.FlatAppearance.BorderSize = 0;
            this.btnACAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACAlumno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnACAlumno.Location = new System.Drawing.Point(125, 0);
            this.btnACAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnACAlumno.Name = "btnACAlumno";
            this.btnACAlumno.Size = new System.Drawing.Size(125, 46);
            this.btnACAlumno.TabIndex = 1;
            this.btnACAlumno.Text = "Alumno";
            this.btnACAlumno.UseVisualStyleBackColor = true;
            this.btnACAlumno.Click += new System.EventHandler(this.btnACAlumno_Click);
            // 
            // btnListaAlumno
            // 
            this.btnListaAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListaAlumno.FlatAppearance.BorderSize = 0;
            this.btnListaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAlumno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaAlumno.Location = new System.Drawing.Point(0, 0);
            this.btnListaAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListaAlumno.Name = "btnListaAlumno";
            this.btnListaAlumno.Size = new System.Drawing.Size(125, 46);
            this.btnListaAlumno.TabIndex = 0;
            this.btnListaAlumno.Text = "Lista";
            this.btnListaAlumno.UseVisualStyleBackColor = true;
            this.btnListaAlumno.Click += new System.EventHandler(this.btnListaAlumno_Click);
            // 
            // pAlumnoPrincipal
            // 
            this.pAlumnoPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAlumnoPrincipal.AutoScroll = true;
            this.pAlumnoPrincipal.Location = new System.Drawing.Point(3, 54);
            this.pAlumnoPrincipal.Name = "pAlumnoPrincipal";
            this.pAlumnoPrincipal.Size = new System.Drawing.Size(622, 375);
            this.pAlumnoPrincipal.TabIndex = 1;
            // 
            // VistaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pAlumnoPrincipal);
            this.Controls.Add(this.pmenuAlumno);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VistaAlumno";
            this.Size = new System.Drawing.Size(633, 436);
            this.pmenuAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pmenuAlumno;
        private System.Windows.Forms.Button btnACAlumno;
        private System.Windows.Forms.Button btnListaAlumno;
        public System.Windows.Forms.Panel pAlumnoPrincipal;
    }
}
