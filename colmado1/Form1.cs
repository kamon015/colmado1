using Factura;

namespace colmado1
{
    public partial class Form1 : Form
    {
        private List<Articulo> inventario = new List<Articulo>();
        private List<Articulo> carrito = new List<Articulo>();

        public Form1()
        {
            InitializeComponent();
            CargarInventario();
            ConfigurarDataGridViews();
            ConfigurarBotones();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged          ;
        }



        public class Articulo
        {
            public string Codigo { get; set; } = "";
            public string Nombre { get; set; } = "";
            public double Precio { get; set; }
            public int Existencia { get; set; }
        }

        private void CargarInventario()
        {
            List<string> nombresArticulos = new List<string>
    {
        "Aceite de cocina", "Arroz", "Azúcar", "Café", "Cerveza", "Chocolate",
        "Detergente", "Embutidos", "Frutas", "Galletas", "Harina", "Huevos",
        "Leche", "Pan", "Papel higiénico", "Pastas", "Refrescos", "Sal",
        "Sopa en lata", "Vino", "Yogur", "Zanahorias", "Tostadas", "Champú",
        "Jabón", "Cepillo dental", "Pasta dental", "Queso", "Jamón", "Mantequilla",
        "Mermelada", "Miel", "Cereal", "Avena", "Harina de maíz", "Aceitunas",
        "Salsa de tomate", "Pimienta", "Canela", "Cebolla", "Ajo", "Papas",
        "Atún", "Sardinas", "Agua", "Lechuga", "Tomate", "Cebollas", "Maíz",
        "Manzanas", "Plátanos", "Naranjas", "Limones"
    };

            Random random = new Random();

            for (int i = 0; i < nombresArticulos.Count; i++)
            {
                Articulo articulo = new Articulo
                {
                    Codigo = "A-" + (i + 1).ToString("000"),
                    Nombre = nombresArticulos[i],
                    Precio = random.Next(10, 100),
                    Existencia = random.Next(10, 1000)
                };

                inventario.Add(articulo);
            }

            dataGridView1.DataSource = inventario;
        }


        private void CalcularSubtotal()
        {
            double subtotal = 0;

            foreach (var articulo in carrito)
            {
                subtotal += articulo.Precio * articulo.Existencia;
            }

            textBox7.Text = subtotal.ToString("0.00");
        }



        private void CalcularITBIS()
        {
            double totalITBIS = 0;

            foreach (Articulo articulo in carrito)
            {
                // Calcular el ITBIS para cada artículo y sumarlo al total
                double itbisArticulo = articulo.Precio * articulo.Existencia * 0.25; // ITBIS = 25% del precio * existencia
                totalITBIS += itbisArticulo;
            }

            textBox8.Text = totalITBIS.ToString("0.00");
        }

        // Método para calcular y mostrar el subtotal y total en el textBox9
        private void CalcularSubtotalYTotal()
        {
            double subtotal = 0;

            foreach (Articulo articulo in carrito)
            {
                double subtotalArticulo = articulo.Precio * articulo.Existencia;
                subtotal += subtotalArticulo;
            }

            double totalITBIS = subtotal * 0.25; // 25% de ITBIS
            double total = subtotal + totalITBIS;

            textBox7.Text = subtotal.ToString("0.00");
            textBox8.Text = totalITBIS.ToString("0.00");
            textBox9.Text = total.ToString("0.00");
        }
        private void ConfigurarDataGridViews()
        {
            // Configurar columnas para el DataGridView1...
            // Configurar columnas para el DataGridView2 (carrito)...
        }


        private void ConfigurarBotones()
        {
            // ... Configuración de botones ...
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Código para agregar un artículo al carrito...
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Código para eliminar un artículo del carrito...
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            ClsFactura.CreaTicket Ticket1 = new ClsFactura.CreaTicket();

            Ticket1.TextoCentro("Empresa Gamalier ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("Factura de Venta");

            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: celso santiago");
            Ticket1.TextoIzquierda("");
            ClsFactura.CreaTicket.LineasGuion();

            double totalVenta = 0;

            
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                // Verificar si Ticket1 no es nulo y si hay suficientes celdas en la fila antes de agregar artículos al ticket
                if (Ticket1 != null && r.Cells.Count >= 5)
                {
                    // PROD     // PrECIO                   CANT           TOTAL
                    string producto = r.Cells[2].Value.ToString();
                    double precio = double.Parse(r.Cells[3].Value.ToString());
                    int cantidad = int.Parse(r.Cells[4].Value.ToString());
                    double subtotalArticulo = precio * cantidad; // Cambiar el nombre de la variable

                    Ticket1.AgregaArticulo(producto, precio, cantidad, subtotalArticulo);

                    totalVenta += subtotalArticulo;
                }

                double itbis = totalVenta * 0.25; // 25 de ITBIS
                double subtotal = totalVenta - itbis;

                Ticket1.TextoIzquierda("Nombre      Precio      Cantidad  Total");
                ClsFactura.CreaTicket.LineasGuion(); // Líneas separadoras
                Ticket1.AgregaTotales("",subtotal);
                Ticket1.AgregaTotales("",subtotal);
                Ticket1.AgregaTotales("Sub-Total", subtotal);
                Ticket1.AgregaTotales("ITBIS (25%)", itbis);
                Ticket1.AgregaTotales("Total", totalVenta);

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");

                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;
                Articulo articuloSeleccionado = inventario[indiceFilaSeleccionada];

                txtcodigo.Text = articuloSeleccionado.Codigo;
                txtnombre.Text = articuloSeleccionado.Nombre;
                txtprecio.Text = articuloSeleccionado.Precio.ToString();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            BuscarArticuloPorCodigo(codigo);
        }

        private void BuscarArticuloPorCodigo(string codigo)
        {
            Articulo articuloEncontrado = inventario.Find(a => a.Codigo == codigo);

            if (articuloEncontrado != null)
            {
                txtnombre.Text = articuloEncontrado.Nombre;
                txtprecio.Text = articuloEncontrado.Precio.ToString();
            }
            else
            {
                txtnombre.Clear();
                txtprecio.Clear();
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            string nombre = txtnombre.Text;
            double precio = double.Parse(txtprecio.Text);
            int cantidad = int.Parse(textBox4.Text);

            Articulo articuloInventario = inventario.Find(a => a.Codigo == codigo);
            if (articuloInventario == null || cantidad > articuloInventario.Existencia)
            {
                MessageBox.Show("No hay suficiente existencia para agregar este artículo al carrito.");
                return;
            }

            Articulo articuloCarrito = carrito.Find(a => a.Codigo == codigo);

            if (articuloCarrito != null)
            {
                articuloCarrito.Existencia += cantidad;
            }
            else
            {
                Articulo nuevoArticuloCarrito = new Articulo
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Precio = precio,
                    Existencia = cantidad
                };
                carrito.Add(nuevoArticuloCarrito);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = carrito;

            txtcodigo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            textBox4.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int indiceFilaSeleccionada = dataGridView2.SelectedRows[0].Index;
                Articulo articuloSeleccionado = carrito[indiceFilaSeleccionada];

                carrito.RemoveAt(indiceFilaSeleccionada);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = carrito;

                MessageBox.Show($"Se ha eliminado el artículo \"{articuloSeleccionado.Nombre}\" del carrito.");

                // Calcular el subtotal después de eliminar el artículo
                CalcularSubtotal();
                CalcularITBIS();
                CalcularSubtotalYTotal();
                CalcularSubtotalYTotal();
            }
            else
            {
                MessageBox.Show("Seleccione un artículo para eliminar del carrito.");
            }
        }



        private void bntfacturar_Click(object sender, EventArgs e)
        {
            // ... Código para realizar la facturación ...
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            string nombre = txtnombre.Text;
            double precio = double.Parse(txtprecio.Text);
            int cantidad = int.Parse(textBox4.Text);

            Articulo articuloInventario = inventario.Find(a => a.Codigo == codigo);
            if (articuloInventario == null || cantidad > articuloInventario.Existencia)
            {
                MessageBox.Show("No hay suficiente existencia para agregar este artículo al carrito.");
                return;
            }

            Articulo articuloCarrito = carrito.Find(a => a.Codigo == codigo);

            if (articuloCarrito != null)
            {
                articuloCarrito.Existencia += cantidad;
            }
            else
            {
                Articulo nuevoArticuloCarrito = new Articulo
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Precio = precio,
                    Existencia = cantidad
                };
                carrito.Add(nuevoArticuloCarrito);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = carrito;

            txtcodigo.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            textBox4.Clear();
            CalcularSubtotal();
            CalcularITBIS();
            CalcularSubtotalYTotal();
            CalcularSubtotalYTotal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndevolver_Click(object sender, EventArgs e)
        {
            CalcularDevolucion();
        }

        private void CalcularDevolucion()
        {
            if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox9.Text))
            {
                double totalAPagar = Convert.ToDouble(textBox9.Text);
                double cantidadRecibida = Convert.ToDouble(textBox5.Text);
                double devolucion = cantidadRecibida - totalAPagar;

                textBox6.Text = devolucion.ToString("0.00");

                // Si la devolución es negativa, indica que falta dinero en lugar de mostrar un número negativo
                if (devolucion < 0)
                {
                    textBox6.Text = "Falta dinero";
                }
            }
            else
            {
                textBox6.Clear();
            }
        }

        private void bntfacturar_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        // ¡Asegúrate de que todas las llaves de apertura tengan su llave de cierre correspondiente!
    }
}


