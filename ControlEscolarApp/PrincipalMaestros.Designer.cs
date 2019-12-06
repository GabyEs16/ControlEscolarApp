namespace ControlEscolarApp
{
    partial class PrincipalMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMaestros));
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.dgvMaestros = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Location = new System.Drawing.Point(459, 27);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(43, 44);
            this.BtnNuevo.TabIndex = 11;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.BackgroundImage")));
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Location = new System.Drawing.Point(508, 27);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(47, 44);
            this.Btn_eliminar.TabIndex = 10;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(30, 40);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(293, 20);
            this.Txt_buscar.TabIndex = 9;
            // 
            // dgvMaestros
            // 
            this.dgvMaestros.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaestros.Location = new System.Drawing.Point(30, 77);
            this.dgvMaestros.Name = "dgvMaestros";
            this.dgvMaestros.Size = new System.Drawing.Size(529, 252);
            this.dgvMaestros.TabIndex = 8;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(30, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // PrincipalMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 346);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.dgvMaestros);
            this.Name = "PrincipalMaestros";
            this.Text = "PrincipalMaestros";
            this.Load += new System.EventHandler(this.PrincipalMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaestros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.DataGridView dgvMaestros;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}