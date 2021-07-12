
namespace Formularios
{
    partial class FrmFabrica
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
            this.btn_Recortar = new System.Windows.Forms.Button();
            this.btn_LijarMadera = new System.Windows.Forms.Button();
            this.btn_PintarYArmar = new System.Windows.Forms.Button();
            this.btn_Terminacion = new System.Windows.Forms.Button();
            this.lstMueblesEspera = new System.Windows.Forms.ListBox();
            this.btn_DetallePedido = new System.Windows.Forms.Button();
            this.lstMueblesElaborados = new System.Windows.Forms.ListBox();
            this.lstMueblesProceso = new System.Windows.Forms.ListBox();
            this.lbl_MuebleEnProceso = new System.Windows.Forms.Label();
            this.lbl_MueblesElaborados = new System.Windows.Forms.Label();
            this.lbl_MueblesEspera = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarFabricacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Construccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Recortar
            // 
            this.btn_Recortar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Recortar.Location = new System.Drawing.Point(19, 37);
            this.btn_Recortar.Name = "btn_Recortar";
            this.btn_Recortar.Size = new System.Drawing.Size(166, 29);
            this.btn_Recortar.TabIndex = 0;
            this.btn_Recortar.Text = "RECORTAR MADERA";
            this.btn_Recortar.UseVisualStyleBackColor = true;
            this.btn_Recortar.Click += new System.EventHandler(this.btn_Recortar_Click);
            // 
            // btn_LijarMadera
            // 
            this.btn_LijarMadera.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btn_LijarMadera.Location = new System.Drawing.Point(206, 37);
            this.btn_LijarMadera.Name = "btn_LijarMadera";
            this.btn_LijarMadera.Size = new System.Drawing.Size(171, 29);
            this.btn_LijarMadera.TabIndex = 1;
            this.btn_LijarMadera.Text = "LIJAR MADERA";
            this.btn_LijarMadera.UseVisualStyleBackColor = true;
            this.btn_LijarMadera.Click += new System.EventHandler(this.btn_LijarMadera_Click);
            // 
            // btn_PintarYArmar
            // 
            this.btn_PintarYArmar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btn_PintarYArmar.Location = new System.Drawing.Point(396, 37);
            this.btn_PintarYArmar.Name = "btn_PintarYArmar";
            this.btn_PintarYArmar.Size = new System.Drawing.Size(172, 29);
            this.btn_PintarYArmar.TabIndex = 2;
            this.btn_PintarYArmar.Text = "PINTAR Y ARMAR MUEBLE";
            this.btn_PintarYArmar.UseVisualStyleBackColor = true;
            this.btn_PintarYArmar.Click += new System.EventHandler(this.btn_PintarYArmar_Click);
            // 
            // btn_Terminacion
            // 
            this.btn_Terminacion.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Terminacion.Location = new System.Drawing.Point(585, 37);
            this.btn_Terminacion.Name = "btn_Terminacion";
            this.btn_Terminacion.Size = new System.Drawing.Size(175, 29);
            this.btn_Terminacion.TabIndex = 3;
            this.btn_Terminacion.Text = "TERMINACION MUEBLE";
            this.btn_Terminacion.UseVisualStyleBackColor = true;
            this.btn_Terminacion.Click += new System.EventHandler(this.btn_Terminacion_Click);
            // 
            // lstMueblesEspera
            // 
            this.lstMueblesEspera.FormattingEnabled = true;
            this.lstMueblesEspera.Location = new System.Drawing.Point(20, 22);
            this.lstMueblesEspera.Name = "lstMueblesEspera";
            this.lstMueblesEspera.Size = new System.Drawing.Size(465, 69);
            this.lstMueblesEspera.TabIndex = 4;
            // 
            // btn_DetallePedido
            // 
            this.btn_DetallePedido.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DetallePedido.Location = new System.Drawing.Point(518, 22);
            this.btn_DetallePedido.Name = "btn_DetallePedido";
            this.btn_DetallePedido.Size = new System.Drawing.Size(185, 22);
            this.btn_DetallePedido.TabIndex = 5;
            this.btn_DetallePedido.Text = "DETALLE DEL PEDIDO";
            this.btn_DetallePedido.UseVisualStyleBackColor = true;
            this.btn_DetallePedido.Click += new System.EventHandler(this.btn_DetallePedido_Click);
            // 
            // lstMueblesElaborados
            // 
            this.lstMueblesElaborados.FormattingEnabled = true;
            this.lstMueblesElaborados.Location = new System.Drawing.Point(396, 27);
            this.lstMueblesElaborados.Name = "lstMueblesElaborados";
            this.lstMueblesElaborados.Size = new System.Drawing.Size(346, 147);
            this.lstMueblesElaborados.TabIndex = 7;
            // 
            // lstMueblesProceso
            // 
            this.lstMueblesProceso.FormattingEnabled = true;
            this.lstMueblesProceso.Location = new System.Drawing.Point(19, 27);
            this.lstMueblesProceso.Name = "lstMueblesProceso";
            this.lstMueblesProceso.Size = new System.Drawing.Size(347, 147);
            this.lstMueblesProceso.TabIndex = 8;
            // 
            // lbl_MuebleEnProceso
            // 
            this.lbl_MuebleEnProceso.AutoSize = true;
            this.lbl_MuebleEnProceso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MuebleEnProceso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MuebleEnProceso.Location = new System.Drawing.Point(15, 5);
            this.lbl_MuebleEnProceso.Name = "lbl_MuebleEnProceso";
            this.lbl_MuebleEnProceso.Size = new System.Drawing.Size(146, 19);
            this.lbl_MuebleEnProceso.TabIndex = 9;
            this.lbl_MuebleEnProceso.Text = "Muebles en Proceso";
            // 
            // lbl_MueblesElaborados
            // 
            this.lbl_MueblesElaborados.AutoSize = true;
            this.lbl_MueblesElaborados.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MueblesElaborados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MueblesElaborados.Location = new System.Drawing.Point(392, 5);
            this.lbl_MueblesElaborados.Name = "lbl_MueblesElaborados";
            this.lbl_MueblesElaborados.Size = new System.Drawing.Size(147, 19);
            this.lbl_MueblesElaborados.TabIndex = 10;
            this.lbl_MueblesElaborados.Text = "Muebles Elaborados";
            // 
            // lbl_MueblesEspera
            // 
            this.lbl_MueblesEspera.AutoSize = true;
            this.lbl_MueblesEspera.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MueblesEspera.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MueblesEspera.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_MueblesEspera.Location = new System.Drawing.Point(19, 0);
            this.lbl_MueblesEspera.Name = "lbl_MueblesEspera";
            this.lbl_MueblesEspera.Size = new System.Drawing.Size(137, 19);
            this.lbl_MueblesEspera.TabIndex = 11;
            this.lbl_MueblesEspera.Text = "Muebles en Espera";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnIniciarFabricacion);
            this.panel1.Controls.Add(this.lbl_MueblesEspera);
            this.panel1.Controls.Add(this.btn_DetallePedido);
            this.panel1.Controls.Add(this.lstMueblesEspera);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 109);
            this.panel1.TabIndex = 12;
            // 
            // btnIniciarFabricacion
            // 
            this.btnIniciarFabricacion.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarFabricacion.Location = new System.Drawing.Point(518, 67);
            this.btnIniciarFabricacion.Name = "btnIniciarFabricacion";
            this.btnIniciarFabricacion.Size = new System.Drawing.Size(185, 24);
            this.btnIniciarFabricacion.TabIndex = 12;
            this.btnIniciarFabricacion.Text = "INICIAR FABRICACION";
            this.btnIniciarFabricacion.UseVisualStyleBackColor = true;
            this.btnIniciarFabricacion.Click += new System.EventHandler(this.btnIniciarFabricacion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_Construccion);
            this.panel2.Controls.Add(this.btn_PintarYArmar);
            this.panel2.Controls.Add(this.btn_Recortar);
            this.panel2.Controls.Add(this.btn_Terminacion);
            this.panel2.Controls.Add(this.btn_LijarMadera);
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 80);
            this.panel2.TabIndex = 12;
            // 
            // lbl_Construccion
            // 
            this.lbl_Construccion.AutoSize = true;
            this.lbl_Construccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Construccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Construccion.Location = new System.Drawing.Point(17, 0);
            this.lbl_Construccion.Name = "lbl_Construccion";
            this.lbl_Construccion.Size = new System.Drawing.Size(98, 19);
            this.lbl_Construccion.TabIndex = 0;
            this.lbl_Construccion.Text = "Construccion";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_MueblesElaborados);
            this.panel3.Controls.Add(this.lbl_MuebleEnProceso);
            this.panel3.Controls.Add(this.lstMueblesProceso);
            this.panel3.Controls.Add(this.lstMueblesElaborados);
            this.panel3.Location = new System.Drawing.Point(12, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 191);
            this.panel3.TabIndex = 13;
            // 
            // FrmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seccion Fabrica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFabrica_FormClosing);
            this.Load += new System.EventHandler(this.FrmFabrica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Recortar;
        private System.Windows.Forms.Button btn_LijarMadera;
        private System.Windows.Forms.Button btn_PintarYArmar;
        private System.Windows.Forms.Button btn_Terminacion;
        private System.Windows.Forms.ListBox lstMueblesEspera;
        private System.Windows.Forms.Button btn_DetallePedido;
        private System.Windows.Forms.ListBox lstMueblesElaborados;
        private System.Windows.Forms.ListBox lstMueblesProceso;
        private System.Windows.Forms.Label lbl_MuebleEnProceso;
        private System.Windows.Forms.Label lbl_MueblesElaborados;
        private System.Windows.Forms.Label lbl_MueblesEspera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Construccion;
        private System.Windows.Forms.Button btnIniciarFabricacion;
    }
}