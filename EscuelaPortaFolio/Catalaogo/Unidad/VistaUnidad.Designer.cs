
namespace EscuelaPortaFolio.Catalaogo.Unidad
{
    partial class VistaUnidad
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
            this.pUnidadPrincipal = new System.Windows.Forms.Panel();
            this.pmenuAlumno = new System.Windows.Forms.Panel();
            this.btnACUnidad = new System.Windows.Forms.Button();
            this.btnListaAlumno = new System.Windows.Forms.Button();
            this.pmenuAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUnidadPrincipal
            // 
            this.pUnidadPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pUnidadPrincipal.AutoScroll = true;
            this.pUnidadPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUnidadPrincipal.Location = new System.Drawing.Point(3, 58);
            this.pUnidadPrincipal.Name = "pUnidadPrincipal";
            this.pUnidadPrincipal.Size = new System.Drawing.Size(622, 375);
            this.pUnidadPrincipal.TabIndex = 3;
            // 
            // pmenuAlumno
            // 
            this.pmenuAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pmenuAlumno.Controls.Add(this.btnACUnidad);
            this.pmenuAlumno.Controls.Add(this.btnListaAlumno);
            this.pmenuAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pmenuAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmenuAlumno.Location = new System.Drawing.Point(0, 0);
            this.pmenuAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmenuAlumno.Name = "pmenuAlumno";
            this.pmenuAlumno.Size = new System.Drawing.Size(633, 46);
            this.pmenuAlumno.TabIndex = 2;
            // 
            // btnACUnidad
            // 
            this.btnACUnidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnACUnidad.FlatAppearance.BorderSize = 0;
            this.btnACUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACUnidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnACUnidad.Location = new System.Drawing.Point(125, 0);
            this.btnACUnidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnACUnidad.Name = "btnACUnidad";
            this.btnACUnidad.Size = new System.Drawing.Size(125, 46);
            this.btnACUnidad.TabIndex = 1;
            this.btnACUnidad.Text = "Unidad";
            this.btnACUnidad.UseVisualStyleBackColor = true;
            this.btnACUnidad.Click += new System.EventHandler(this.btnACUnidad_Click);
            // 
            // btnListaAlumno
            // 
            this.btnListaAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListaAlumno.FlatAppearance.BorderSize = 0;
            this.btnListaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // VistaUnidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pUnidadPrincipal);
            this.Controls.Add(this.pmenuAlumno);
            this.Name = "VistaUnidad";
            this.Size = new System.Drawing.Size(633, 436);
            this.pmenuAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pUnidadPrincipal;
        private System.Windows.Forms.Panel pmenuAlumno;
        private System.Windows.Forms.Button btnACUnidad;
        private System.Windows.Forms.Button btnListaAlumno;
    }
}
