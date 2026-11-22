namespace Examen_Cafeteria_WindfreeJFigueroa
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0;
        public Form1()
        {
            InitializeComponent();

            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            nudCantidad.Value = 1;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            chkFrecuente.Checked = false;
            chkPorcionExtra.Checked = false;

            subtotal = 0;

            lstPedido.Items.Clear();
            lstPedido.Font = new Font("Times New Roman", 9);



            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblEmpaque.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "" ||
                txtProducto.Text == "" ||
                txtPrecio.Text == "")
            {
                MessageBox.Show("Complete los datos del cliente y del producto.");
            }
            else
            {
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                decimal precioUnitario = precio;

                int cantidad = Convert.ToInt32(nudCantidad.Value);

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor que cero.");
                    return;
                }

                string producto = txtProducto.Text;

                if (rbtGrande.Checked == true)
                {
                    precioUnitario = precioUnitario + 25;
                    producto = producto + " (Grande)";
                }

                if (chkPorcionExtra.Checked == true)
                {
                    precioUnitario = precioUnitario + 30;
                    producto = producto + " (Extra)";
                }

                decimal totalLinea = precioUnitario * cantidad;

                string linea =
                cantidad.ToString().PadRight(6) +
                producto.PadRight(24) +
                precioUnitario.ToString("0.00").PadLeft(10) +
                totalLinea.ToString("0.00").PadLeft(12);

                lstPedido.Items.Add(linea);

                subtotal = subtotal + totalLinea;

                lblSubtotal.Text = "RD$ " + subtotal.ToString("0.00");

                txtProducto.Clear();
                txtPrecio.Clear();

                nudCantidad.Value = 1;
                rbtNormal.Checked = true;
                chkPorcionExtra.Checked = false;

                txtProducto.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("Primero debe agregar productos al pedido.");
            }
            else
            {
                decimal descuento = 0;
                decimal empaque = 0;
                decimal baseImponible = 0;
                decimal itbis = 0;
                decimal total = 0;

                if (chkFrecuente.Checked == true)
                {
                    descuento = subtotal * 0.10m;
                }

                if (rbtLlevar.Checked == true)
                {
                    empaque = 20;
                }

                baseImponible = subtotal - descuento + empaque;

                itbis = baseImponible * 0.18m;

                total = baseImponible + itbis;

                lblSubtotal.Text = "RD$ " + subtotal.ToString("0.00");
                lblDescuento.Text = "RD$ " + descuento.ToString("0.00");
                lblEmpaque.Text = "RD$ " + empaque.ToString("0.00");
                lblItbis.Text = "RD$ " + itbis.ToString("0.00");
                lblTotal.Text = "RD$ " + total.ToString("0.00");

                MessageBox.Show("Total del pedido: RD$ " + total.ToString("0.00"));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();

            dtpFecha.Value = DateTime.Today;

            chkFrecuente.Checked = false;
            chkPorcionExtra.Checked = false;

            rbtNormal.Checked = true;
            rbtLocal.Checked = true;

            nudCantidad.Value = 1;

            lstPedido.Items.Clear();

            subtotal = 0;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblEmpaque.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
