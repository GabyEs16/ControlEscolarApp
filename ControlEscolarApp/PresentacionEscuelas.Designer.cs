namespace ControlEscolarApp
{
    partial class PresentacionEscuelas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarLogo = new System.Windows.Forms.Button();
            this.btnEliminarLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(22, 107);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(210, 20);
            this.txtDirector.TabIndex = 1;
            this.txtDirector.TextChanged += new System.EventHandler(this.TxtDirector_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(19, 43);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(19, 91);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(44, 13);
            this.Director.TabIndex = 3;
            this.Director.Text = "Director";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Location = new System.Drawing.Point(248, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 146);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(184, 184);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(265, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(346, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAgregarLogo
            // 
            this.btnAgregarLogo.Location = new System.Drawing.Point(388, 52);
            this.btnAgregarLogo.Name = "btnAgregarLogo";
            this.btnAgregarLogo.Size = new System.Drawing.Size(33, 23);
            this.btnAgregarLogo.TabIndex = 8;
            this.btnAgregarLogo.Text = "...";
            this.btnAgregarLogo.UseVisualStyleBackColor = true;
            this.btnAgregarLogo.Click += new System.EventHandler(this.BtnAgregarLogo_Click);
            // 
            // btnEliminarLogo
            // 
            this.btnEliminarLogo.Location = new System.Drawing.Point(388, 81);
            this.btnEliminarLogo.Name = "btnEliminarLogo";
            this.btnEliminarLogo.Size = new System.Drawing.Size(33, 23);
            this.btnEliminarLogo.TabIndex = 9;
            this.btnEliminarLogo.Text = "X";
            this.btnEliminarLogo.UseVisualStyleBackColor = true;
            this.btnEliminarLogo.Click += new System.EventHandler(this.BtnEliminarLogo_Click);
            // 
            // PresentacionEscuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 219);
            this.Controls.Add(this.btnEliminarLogo);
            this.Controls.Add(this.btnAgregarLogo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtNombre);
            this.Name = "PresentacionEscuelas";
            this.Text = "PresentacionEscuelas";
            this.Load += new System.EventHandler(this.PresentacionEscuelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarLogo;
        private System.Windows.Forms.Button btnEliminarLogo;
    }
}