
namespace Formularios
{
    partial class FrmPedidos
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
            this.lstPedidosGenerados = new System.Windows.Forms.ListBox();
            this.btn_CancelarPedido = new System.Windows.Forms.Button();
            this.btn_InformacionPedido = new System.Windows.Forms.Button();
            this.pnlCancelarPedido = new System.Windows.Forms.Panel();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.btn_LeerPedido = new System.Windows.Forms.Button();
            this.ImprimirPedido = new System.Windows.Forms.Button();
            this.lbl_Gestionar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNumeroEstantes = new System.Windows.Forms.ComboBox();
            this.lbl_NumeroEstantes = new System.Windows.Forms.Label();
            this.cmbColorTapizado = new System.Windows.Forms.ComboBox();
            this.lbl_ColorTapizado = new System.Windows.Forms.Label();
            this.lbl_GenerarPedido = new System.Windows.Forms.Label();
            this.cmbTerminacionMueble = new System.Windows.Forms.ComboBox();
            this.cmbColorMueble = new System.Windows.Forms.ComboBox();
            this.cmbTipoMueble = new System.Windows.Forms.ComboBox();
            this.lbl_Terminacion = new System.Windows.Forms.Label();
            this.lbl_ColorMueble = new System.Windows.Forms.Label();
            this.lbl_TipoMueble = new System.Windows.Forms.Label();
            this.lbl_NumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.btnSerializarBinario = new System.Windows.Forms.Button();
            this.btnDeserealizarBinario = new System.Windows.Forms.Button();
            this.pnlCancelarPedido.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPedidosGenerados
            // 
            this.lstPedidosGenerados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedidosGenerados.FormattingEnabled = true;
            this.lstPedidosGenerados.ItemHeight = 19;
            this.lstPedidosGenerados.Location = new System.Drawing.Point(18, 63);
            this.lstPedidosGenerados.Name = "lstPedidosGenerados";
            this.lstPedidosGenerados.Size = new System.Drawing.Size(393, 137);
            this.lstPedidosGenerados.TabIndex = 0;
            // 
            // btn_CancelarPedido
            // 
            this.btn_CancelarPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarPedido.Location = new System.Drawing.Point(464, 70);
            this.btn_CancelarPedido.Name = "btn_CancelarPedido";
            this.btn_CancelarPedido.Size = new System.Drawing.Size(122, 46);
            this.btn_CancelarPedido.TabIndex = 1;
            this.btn_CancelarPedido.Text = "CANCELAR PEDIDO";
            this.btn_CancelarPedido.UseVisualStyleBackColor = true;
            this.btn_CancelarPedido.Click += new System.EventHandler(this.btn_CancelarPedido_Click);
            // 
            // btn_InformacionPedido
            // 
            this.btn_InformacionPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InformacionPedido.Location = new System.Drawing.Point(464, 16);
            this.btn_InformacionPedido.Name = "btn_InformacionPedido";
            this.btn_InformacionPedido.Size = new System.Drawing.Size(122, 47);
            this.btn_InformacionPedido.TabIndex = 2;
            this.btn_InformacionPedido.Text = "INFORMACION PEDIDO";
            this.btn_InformacionPedido.UseVisualStyleBackColor = true;
            this.btn_InformacionPedido.Click += new System.EventHandler(this.btn_InformacionPedido_Click);
            // 
            // pnlCancelarPedido
            // 
            this.pnlCancelarPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancelarPedido.Controls.Add(this.btnDeserealizarBinario);
            this.pnlCancelarPedido.Controls.Add(this.btnSerializarBinario);
            this.pnlCancelarPedido.Controls.Add(this.btnDeserializarXML);
            this.pnlCancelarPedido.Controls.Add(this.btnSerializarXML);
            this.pnlCancelarPedido.Controls.Add(this.btn_LeerPedido);
            this.pnlCancelarPedido.Controls.Add(this.ImprimirPedido);
            this.pnlCancelarPedido.Controls.Add(this.btn_CancelarPedido);
            this.pnlCancelarPedido.Controls.Add(this.btn_InformacionPedido);
            this.pnlCancelarPedido.Controls.Add(this.lbl_Gestionar);
            this.pnlCancelarPedido.Controls.Add(this.lstPedidosGenerados);
            this.pnlCancelarPedido.Location = new System.Drawing.Point(13, 208);
            this.pnlCancelarPedido.Name = "pnlCancelarPedido";
            this.pnlCancelarPedido.Size = new System.Drawing.Size(775, 230);
            this.pnlCancelarPedido.TabIndex = 3;
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializarXML.Location = new System.Drawing.Point(628, 122);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(122, 46);
            this.btnDeserializarXML.TabIndex = 6;
            this.btnDeserializarXML.Text = "DESERIALIZAR XML";
            this.btnDeserializarXML.UseVisualStyleBackColor = true;
            this.btnDeserializarXML.Click += new System.EventHandler(this.btnDeserializarXML_Click);
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializarXML.Location = new System.Drawing.Point(464, 122);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(122, 46);
            this.btnSerializarXML.TabIndex = 5;
            this.btnSerializarXML.Text = "SERIALIZAR XML";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // btn_LeerPedido
            // 
            this.btn_LeerPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LeerPedido.Location = new System.Drawing.Point(628, 69);
            this.btn_LeerPedido.Name = "btn_LeerPedido";
            this.btn_LeerPedido.Size = new System.Drawing.Size(126, 47);
            this.btn_LeerPedido.TabIndex = 4;
            this.btn_LeerPedido.Text = "LEER PEDIDO DESDE ARCHIVO";
            this.btn_LeerPedido.UseVisualStyleBackColor = true;
            this.btn_LeerPedido.Click += new System.EventHandler(this.btn_LeerPedido_Click);
            // 
            // ImprimirPedido
            // 
            this.ImprimirPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirPedido.Location = new System.Drawing.Point(628, 16);
            this.ImprimirPedido.Name = "ImprimirPedido";
            this.ImprimirPedido.Size = new System.Drawing.Size(126, 47);
            this.ImprimirPedido.TabIndex = 3;
            this.ImprimirPedido.Text = "IMPRIMIR PEDIDOS EN ARCHIVO";
            this.ImprimirPedido.UseVisualStyleBackColor = true;
            this.ImprimirPedido.Click += new System.EventHandler(this.ImprimirPedido_Click);
            // 
            // lbl_Gestionar
            // 
            this.lbl_Gestionar.AutoSize = true;
            this.lbl_Gestionar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gestionar.Location = new System.Drawing.Point(3, 0);
            this.lbl_Gestionar.Name = "lbl_Gestionar";
            this.lbl_Gestionar.Size = new System.Drawing.Size(88, 19);
            this.lbl_Gestionar.TabIndex = 0;
            this.lbl_Gestionar.Text = "GESTIONAR";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbNumeroEstantes);
            this.panel1.Controls.Add(this.lbl_NumeroEstantes);
            this.panel1.Controls.Add(this.cmbColorTapizado);
            this.panel1.Controls.Add(this.lbl_ColorTapizado);
            this.panel1.Controls.Add(this.lbl_GenerarPedido);
            this.panel1.Controls.Add(this.cmbTerminacionMueble);
            this.panel1.Controls.Add(this.cmbColorMueble);
            this.panel1.Controls.Add(this.cmbTipoMueble);
            this.panel1.Controls.Add(this.lbl_Terminacion);
            this.panel1.Controls.Add(this.lbl_ColorMueble);
            this.panel1.Controls.Add(this.lbl_TipoMueble);
            this.panel1.Controls.Add(this.lbl_NumeroPedido);
            this.panel1.Controls.Add(this.txtNumeroPedido);
            this.panel1.Controls.Add(this.btn_AgregarPedido);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 189);
            this.panel1.TabIndex = 4;
            // 
            // cmbNumeroEstantes
            // 
            this.cmbNumeroEstantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroEstantes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroEstantes.FormattingEnabled = true;
            this.cmbNumeroEstantes.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbNumeroEstantes.Location = new System.Drawing.Point(542, 131);
            this.cmbNumeroEstantes.Name = "cmbNumeroEstantes";
            this.cmbNumeroEstantes.Size = new System.Drawing.Size(121, 27);
            this.cmbNumeroEstantes.TabIndex = 16;
            // 
            // lbl_NumeroEstantes
            // 
            this.lbl_NumeroEstantes.AutoSize = true;
            this.lbl_NumeroEstantes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroEstantes.Location = new System.Drawing.Point(539, 100);
            this.lbl_NumeroEstantes.Name = "lbl_NumeroEstantes";
            this.lbl_NumeroEstantes.Size = new System.Drawing.Size(147, 19);
            this.lbl_NumeroEstantes.TabIndex = 15;
            this.lbl_NumeroEstantes.Text = "Numero de Estantes";
            // 
            // cmbColorTapizado
            // 
            this.cmbColorTapizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorTapizado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorTapizado.FormattingEnabled = true;
            this.cmbColorTapizado.Location = new System.Drawing.Point(542, 131);
            this.cmbColorTapizado.Name = "cmbColorTapizado";
            this.cmbColorTapizado.Size = new System.Drawing.Size(121, 27);
            this.cmbColorTapizado.TabIndex = 14;
            // 
            // lbl_ColorTapizado
            // 
            this.lbl_ColorTapizado.AutoSize = true;
            this.lbl_ColorTapizado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorTapizado.Location = new System.Drawing.Point(539, 100);
            this.lbl_ColorTapizado.Name = "lbl_ColorTapizado";
            this.lbl_ColorTapizado.Size = new System.Drawing.Size(130, 19);
            this.lbl_ColorTapizado.TabIndex = 13;
            this.lbl_ColorTapizado.Text = "Color de Tapizado";
            // 
            // lbl_GenerarPedido
            // 
            this.lbl_GenerarPedido.AutoSize = true;
            this.lbl_GenerarPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GenerarPedido.Location = new System.Drawing.Point(3, 0);
            this.lbl_GenerarPedido.Name = "lbl_GenerarPedido";
            this.lbl_GenerarPedido.Size = new System.Drawing.Size(74, 19);
            this.lbl_GenerarPedido.TabIndex = 12;
            this.lbl_GenerarPedido.Text = "GENERAR";
            // 
            // cmbTerminacionMueble
            // 
            this.cmbTerminacionMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminacionMueble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerminacionMueble.FormattingEnabled = true;
            this.cmbTerminacionMueble.Location = new System.Drawing.Point(381, 131);
            this.cmbTerminacionMueble.Name = "cmbTerminacionMueble";
            this.cmbTerminacionMueble.Size = new System.Drawing.Size(121, 27);
            this.cmbTerminacionMueble.TabIndex = 11;
            // 
            // cmbColorMueble
            // 
            this.cmbColorMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorMueble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorMueble.FormattingEnabled = true;
            this.cmbColorMueble.Location = new System.Drawing.Point(210, 131);
            this.cmbColorMueble.Name = "cmbColorMueble";
            this.cmbColorMueble.Size = new System.Drawing.Size(121, 27);
            this.cmbColorMueble.TabIndex = 10;
            // 
            // cmbTipoMueble
            // 
            this.cmbTipoMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMueble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMueble.FormattingEnabled = true;
            this.cmbTipoMueble.Items.AddRange(new object[] {
            "Mesa",
            "Silla",
            "Biblioteca"});
            this.cmbTipoMueble.Location = new System.Drawing.Point(39, 131);
            this.cmbTipoMueble.MaxDropDownItems = 3;
            this.cmbTipoMueble.Name = "cmbTipoMueble";
            this.cmbTipoMueble.Size = new System.Drawing.Size(121, 27);
            this.cmbTipoMueble.TabIndex = 9;
            this.cmbTipoMueble.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMueble_SelectedIndexChanged);
            // 
            // lbl_Terminacion
            // 
            this.lbl_Terminacion.AutoSize = true;
            this.lbl_Terminacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Terminacion.Location = new System.Drawing.Point(378, 100);
            this.lbl_Terminacion.Name = "lbl_Terminacion";
            this.lbl_Terminacion.Size = new System.Drawing.Size(93, 19);
            this.lbl_Terminacion.TabIndex = 8;
            this.lbl_Terminacion.Text = "Terminacion";
            // 
            // lbl_ColorMueble
            // 
            this.lbl_ColorMueble.AutoSize = true;
            this.lbl_ColorMueble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorMueble.Location = new System.Drawing.Point(207, 100);
            this.lbl_ColorMueble.Name = "lbl_ColorMueble";
            this.lbl_ColorMueble.Size = new System.Drawing.Size(126, 19);
            this.lbl_ColorMueble.TabIndex = 7;
            this.lbl_ColorMueble.Text = "Color del Mueble";
            // 
            // lbl_TipoMueble
            // 
            this.lbl_TipoMueble.AutoSize = true;
            this.lbl_TipoMueble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoMueble.Location = new System.Drawing.Point(36, 100);
            this.lbl_TipoMueble.Name = "lbl_TipoMueble";
            this.lbl_TipoMueble.Size = new System.Drawing.Size(116, 19);
            this.lbl_TipoMueble.TabIndex = 6;
            this.lbl_TipoMueble.Text = "Tipo de Mueble";
            // 
            // lbl_NumeroPedido
            // 
            this.lbl_NumeroPedido.AutoSize = true;
            this.lbl_NumeroPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroPedido.Location = new System.Drawing.Point(36, 41);
            this.lbl_NumeroPedido.Name = "lbl_NumeroPedido";
            this.lbl_NumeroPedido.Size = new System.Drawing.Size(138, 19);
            this.lbl_NumeroPedido.TabIndex = 2;
            this.lbl_NumeroPedido.Text = "Numero de Pedido";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedido.Location = new System.Drawing.Point(190, 33);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(100, 27);
            this.txtNumeroPedido.TabIndex = 1;
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Location = new System.Drawing.Point(585, 30);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(147, 39);
            this.btn_AgregarPedido.TabIndex = 0;
            this.btn_AgregarPedido.Text = "AGREGAR PEDIDO";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // btnSerializarBinario
            // 
            this.btnSerializarBinario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializarBinario.Location = new System.Drawing.Point(464, 174);
            this.btnSerializarBinario.Name = "btnSerializarBinario";
            this.btnSerializarBinario.Size = new System.Drawing.Size(122, 46);
            this.btnSerializarBinario.TabIndex = 7;
            this.btnSerializarBinario.Text = "SERIALIZAR BINARIO";
            this.btnSerializarBinario.UseVisualStyleBackColor = true;
            this.btnSerializarBinario.Click += new System.EventHandler(this.btnSerializarBinario_Click);
            // 
            // btnDeserealizarBinario
            // 
            this.btnDeserealizarBinario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserealizarBinario.Location = new System.Drawing.Point(628, 174);
            this.btnDeserealizarBinario.Name = "btnDeserealizarBinario";
            this.btnDeserealizarBinario.Size = new System.Drawing.Size(122, 46);
            this.btnDeserealizarBinario.TabIndex = 8;
            this.btnDeserealizarBinario.Text = "DESERIALIZAR BINARIO";
            this.btnDeserealizarBinario.UseVisualStyleBackColor = true;
            this.btnDeserealizarBinario.Click += new System.EventHandler(this.btnDeserealizarBinario_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCancelarPedido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seccion Pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCancelarPedido.ResumeLayout(false);
            this.pnlCancelarPedido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPedidosGenerados;
        private System.Windows.Forms.Button btn_CancelarPedido;
        private System.Windows.Forms.Button btn_InformacionPedido;
        private System.Windows.Forms.Panel pnlCancelarPedido;
        private System.Windows.Forms.Label lbl_Gestionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTerminacionMueble;
        private System.Windows.Forms.ComboBox cmbColorMueble;
        private System.Windows.Forms.ComboBox cmbTipoMueble;
        private System.Windows.Forms.Label lbl_Terminacion;
        private System.Windows.Forms.Label lbl_ColorMueble;
        private System.Windows.Forms.Label lbl_TipoMueble;
        private System.Windows.Forms.Label lbl_NumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.Label lbl_GenerarPedido;
        private System.Windows.Forms.ComboBox cmbColorTapizado;
        private System.Windows.Forms.Label lbl_ColorTapizado;
        private System.Windows.Forms.ComboBox cmbNumeroEstantes;
        private System.Windows.Forms.Label lbl_NumeroEstantes;
        private System.Windows.Forms.Button ImprimirPedido;
        private System.Windows.Forms.Button btn_LeerPedido;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.Button btnDeserealizarBinario;
        private System.Windows.Forms.Button btnSerializarBinario;
    }
}