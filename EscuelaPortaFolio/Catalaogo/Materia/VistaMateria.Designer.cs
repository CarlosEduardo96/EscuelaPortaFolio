
namespace EscuelaPortaFolio.Catalaogo.Materia
{
    partial class VistaMateria
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
            this.pMateriaPrincipal = new System.Windows.Forms.Panel();
            this.pmenuAlumno = new System.Windows.Forms.Panel();
            this.btnACMateria = new System.Windows.Forms.Button();
            this.btnListaMateria = new System.Windows.Forms.Button();
            this.pmenuAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMateriaPrincipal
            // 
            this.pMateriaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMateriaPrincipal.AutoScroll = true;
            this.pMateriaPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMateriaPrincipal.Location = new System.Drawing.Point(3, 58);
            this.pMateriaPrincipal.Name = "pMateriaPrincipal";
            this.pMateriaPrincipal.Size = new System.Drawing.Size(622, 375);
            this.pMateriaPrincipal.TabIndex = 3;
            // 
            // pmenuAlumno
            // 
            this.pmenuAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pmenuAlumno.Controls.Add(this.btnACMateria);
            this.pmenuAlumno.Controls.Add(this.btnListaMateria);
            this.pmenuAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmenuAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmenuAlumno.Location = new System.Drawing.Point(0, 0);
            this.pmenuAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmenuAlumno.Name = "pmenuAlumno";
            this.pmenuAlumno.Size = new System.Drawing.Size(633, 46);
            this.pmenuAlumno.TabIndex = 2;
            // 
            // btnACMateria
            // 
            this.btnACMateria.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnACMateria.FlatAppearance.BorderSize = 0;
            this.btnACMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACMateria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnACMateria.Location = new System.Drawing.Point(125, 0);
            this.btnACMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnACMateria.Name = "btnACMateria";
            this.btnACMateria.Size = new System.Drawing.Size(125, 46);
            this.btnACMateria.TabIndex = 1;
            this.btnACMateria.Text = "Materia";
            this.btnACMateria.UseVisualStyleBackColor = true;
            this.btnACMateria.Click += new System.EventHandler(this.btnACMateria_Click);
            // 
            // btnListaMateria
            // 
            this.btnListaMateria.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListaMateria.FlatAppearance.BorderSize = 0;
            this.btnListaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaMateria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaMateria.Location = new System.Drawing.Point(0, 0);
            this.btnListaMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListaMateria.Name = "btnListaMateria";
            this.btnListaMateria.Size = new System.Drawing.Size(125, 46);
            this.btnListaMateria.TabIndex = 0;
            this.btnListaMateria.Text = "Lista";
            this.btnListaMateria.UseVisualStyleBackColor = true;
            this.btnListaMateria.Click += new System.EventHandler(this.btnListaMateria_Click);
            // 
            // VistaMateria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pMateriaPrincipal);
            this.Controls.Add(this.pmenuAlumno);
            this.Name = "VistaMateria";
            this.Size = new System.Drawing.Size(633, 436);
            this.pmenuAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pMateriaPrincipal;
        private System.Windows.Forms.Panel pmenuAlumno;
        private System.Windows.Forms.Button btnACMateria;
        private System.Windows.Forms.Button btnListaMateria;
    }
}
