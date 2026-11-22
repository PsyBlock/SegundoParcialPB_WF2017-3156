namespace Examen_Cafeteria_WindfreeJFigueroa
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
            lable1 = new Label();
            txtCliente = new TextBox();
            chkFrecuente = new CheckBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            txtProducto = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            nudCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            groupBox3 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstPedido = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(28, 23);
            lable1.Name = "lable1";
            lable1.Size = new Size(50, 15);
            lable1.TabIndex = 0;
            lable1.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(95, 20);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(261, 23);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(28, 49);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(116, 19);
            chkFrecuente.TabIndex = 2;
            chkFrecuente.Text = "Cliente frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 74);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(95, 74);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(261, 23);
            dtpFecha.TabIndex = 4;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Producto: ";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(95, 115);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(261, 23);
            txtProducto.TabIndex = 6;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 151);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Precio: ";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(95, 151);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(261, 23);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 189);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Cantidad: ";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(95, 187);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(63, 23);
            nudCantidad.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Location = new Point(28, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(148, 77);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(19, 47);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(115, 19);
            rbtGrande.TabIndex = 1;
            rbtGrande.TabStop = true;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(19, 22);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(65, 19);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtLlevar);
            groupBox3.Controls.Add(rbtLocal);
            groupBox3.Location = new Point(200, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(156, 77);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Servicio";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(18, 47);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(134, 19);
            rbtLlevar.TabIndex = 14;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para Llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(18, 22);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(121, 19);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(28, 334);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(148, 19);
            chkPorcionExtra.TabIndex = 14;
            chkPorcionExtra.Text = "Porcion Extra (+RD$30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 387);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 40);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(134, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 40);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(259, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 40);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(467, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(293, 34);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(467, 74);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(0, 15);
            lblEncabezado.TabIndex = 19;
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(467, 92);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(293, 124);
            lstPedido.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 256);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 21;
            label5.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 285);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 22;
            label6.Text = "Descuento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 313);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 23;
            label7.Text = "Empaque";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 342);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "ITBIS (18%)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(451, 400);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 29;
            label9.Text = "TOTAL A PAGAR";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(571, 256);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(44, 15);
            lblSubtotal.TabIndex = 30;
            lblSubtotal.Text = "label10";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(571, 285);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(44, 15);
            lblDescuento.TabIndex = 31;
            lblDescuento.Text = "label11";
            // 
            // lblEmpaque
            // 
            lblEmpaque.AutoSize = true;
            lblEmpaque.Location = new Point(571, 313);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(44, 15);
            lblEmpaque.TabIndex = 32;
            lblEmpaque.Text = "label12";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(571, 342);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(44, 15);
            lblItbis.TabIndex = 33;
            lblItbis.Text = "label13";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(571, 400);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "label14";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lstPedido);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkPorcionExtra);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(nudCantidad);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtProducto);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Controls.Add(chkFrecuente);
            Controls.Add(txtCliente);
            Controls.Add(lable1);
            Name = "Form1";
            Text = "Cafeteria El Buen Sabor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private TextBox txtCliente;
        private CheckBox chkFrecuente;
        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private NumericUpDown nudCantidad;
        private GroupBox groupBox1;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private GroupBox groupBox3;
        private RadioButton rbtLlevar;
        private RadioButton rbtLocal;
        private CheckBox chkPorcionExtra;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstPedido;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblItbis;
        private Label lblTotal;
    }
}
