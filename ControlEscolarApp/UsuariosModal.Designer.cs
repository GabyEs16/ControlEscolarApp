namespace ControlEscolarApp
{
    partial class UsuariosModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosModal));
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidoPaterno = new System.Windows.Forms.Label();
            this.LblApellidoMaterno = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombre.Location = new System.Drawing.Point(69, 63);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellidoPaterno
            // 
            this.LblApellidoPaterno.AutoSize = true;
            this.LblApellidoPaterno.BackColor = System.Drawing.Color.Transparent;
            this.LblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoPaterno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblApellidoPaterno.Location = new System.Drawing.Point(69, 102);
            this.LblApellidoPaterno.Name = "LblApellidoPaterno";
            this.LblApellidoPaterno.Size = new System.Drawing.Size(100, 13);
            this.LblApellidoPaterno.TabIndex = 0;
            this.LblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // LblApellidoMaterno
            // 
            this.LblApellidoMaterno.AutoSize = true;
            this.LblApellidoMaterno.BackColor = System.Drawing.Color.Transparent;
            this.LblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoMaterno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblApellidoMaterno.Location = new System.Drawing.Point(69, 140);
            this.LblApellidoMaterno.Name = "LblApellidoMaterno";
            this.LblApellidoMaterno.Size = new System.Drawing.Size(102, 13);
            this.LblApellidoMaterno.TabIndex = 0;
            this.LblApellidoMaterno.Text = "Apellido Materno";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(56, 78);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(314, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(56, 117);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(317, 20);
            this.TxtApellidoPaterno.TabIndex = 1;
            this.TxtApellidoPaterno.TextChanged += new System.EventHandler(this.TxtApellidoPaterno_TextChanged);
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(56, 155);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(317, 20);
            this.TxtApellidoMaterno.TabIndex = 1;
            this.TxtApellidoMaterno.TextChanged += new System.EventHandler(this.TxtApellidoMaterno_TextChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(334, 211);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(39, 45);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(383, 211);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(39, 45);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // UsuariosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 258);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtApellidoMaterno);
            this.Controls.Add(this.TxtApellidoPaterno);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblApellidoMaterno);
            this.Controls.Add(this.LblApellidoPaterno);
            this.Controls.Add(this.LblNombre);
            this.Name = "UsuariosModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar / Modificar Usuarios";
            this.Load += new System.EventHandler(this.UsuariosModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidoPaterno;
        private System.Windows.Forms.Label LblApellidoMaterno;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}