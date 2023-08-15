namespace colmado1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            lblcodigo = new Label();
            lblnombre = new Label();
            lblprecio = new Label();
            lblcantidad = new Label();
            txtcodigo = new TextBox();
            txtnombre = new TextBox();
            txtprecio = new TextBox();
            textBox4 = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            bntfacturar = new Button();
            lblsubtotal = new Label();
            lblitbis = new Label();
            lbltotal = new Label();
            lblpago = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            btndevolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(517, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(834, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(517, 432);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(834, 144);
            dataGridView2.TabIndex = 1;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.BackColor = Color.Orange;
            lblcodigo.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblcodigo.Location = new Point(12, 106);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(137, 37);
            lblcodigo.TabIndex = 2;
            lblcodigo.Text = "codigo";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.Orange;
            lblnombre.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.ForeColor = Color.Black;
            lblnombre.Location = new Point(2, 204);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(147, 37);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "nombre";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.BackColor = Color.Orange;
            lblprecio.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblprecio.Location = new Point(12, 294);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(132, 37);
            lblprecio.TabIndex = 4;
            lblprecio.Text = "precio";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.BackColor = Color.Orange;
            lblcantidad.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblcantidad.Location = new Point(12, 366);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(174, 37);
            lblcantidad.TabIndex = 5;
            lblcantidad.Text = "cantidad";
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = Color.WhiteSmoke;
            txtcodigo.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodigo.ForeColor = SystemColors.ActiveCaptionText;
            txtcodigo.Location = new Point(179, 103);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(144, 45);
            txtcodigo.TabIndex = 6;
            txtcodigo.TextChanged += txtcodigo_TextChanged_1;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = SystemColors.HighlightText;
            txtnombre.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.ForeColor = SystemColors.ActiveCaptionText;
            txtnombre.Location = new Point(179, 196);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(144, 45);
            txtnombre.TabIndex = 7;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = SystemColors.ButtonHighlight;
            txtprecio.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.ActiveCaptionText;
            txtprecio.Location = new Point(179, 286);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(144, 45);
            txtprecio.TabIndex = 8;
            txtprecio.TextChanged += txtprecio_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonFace;
            textBox4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(197, 358);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 45);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Yellow;
            btnAgregar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(329, 103);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 73);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(329, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(182, 73);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // bntfacturar
            // 
            bntfacturar.BackColor = Color.Lime;
            bntfacturar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bntfacturar.Location = new Point(1382, 464);
            bntfacturar.Name = "bntfacturar";
            bntfacturar.Size = new Size(186, 112);
            bntfacturar.TabIndex = 12;
            bntfacturar.Text = "facturar";
            bntfacturar.UseVisualStyleBackColor = false;
            bntfacturar.Click += BtnFacturar_Click;
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.BackColor = Color.Orange;
            lblsubtotal.CausesValidation = false;
            lblsubtotal.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblsubtotal.Location = new Point(517, 593);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(175, 37);
            lblsubtotal.TabIndex = 13;
            lblsubtotal.Text = "subtotal";
            // 
            // lblitbis
            // 
            lblitbis.AutoSize = true;
            lblitbis.BackColor = Color.Orange;
            lblitbis.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblitbis.Location = new Point(902, 593);
            lblitbis.Name = "lblitbis";
            lblitbis.Size = new Size(101, 37);
            lblitbis.TabIndex = 14;
            lblitbis.Text = "itbis";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Orange;
            lbltotal.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(1115, 593);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(250, 37);
            lbltotal.TabIndex = 15;
            lbltotal.Text = "total a pagar";
            // 
            // lblpago
            // 
            lblpago.AutoSize = true;
            lblpago.BackColor = Color.Orange;
            lblpago.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblpago.Location = new Point(1357, 120);
            lblpago.Name = "lblpago";
            lblpago.Size = new Size(275, 37);
            lblpago.TabIndex = 16;
            lblpago.Text = "pago / efectivo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1371, 160);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(197, 27);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1371, 276);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 27);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(517, 644);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 27);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(902, 644);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(107, 27);
            textBox8.TabIndex = 21;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1200, 644);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(151, 27);
            textBox9.TabIndex = 22;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // btndevolver
            // 
            btndevolver.BackColor = Color.Yellow;
            btndevolver.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btndevolver.Location = new Point(1371, 216);
            btndevolver.Name = "btndevolver";
            btndevolver.Size = new Size(197, 54);
            btndevolver.TabIndex = 23;
            btndevolver.Text = "DEVOLVER";
            btndevolver.UseVisualStyleBackColor = false;
            btndevolver.Click += btndevolver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1569, 683);
            Controls.Add(btndevolver);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(lblpago);
            Controls.Add(lbltotal);
            Controls.Add(lblitbis);
            Controls.Add(lblsubtotal);
            Controls.Add(bntfacturar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox4);
            Controls.Add(txtprecio);
            Controls.Add(txtnombre);
            Controls.Add(txtcodigo);
            Controls.Add(lblcantidad);
            Controls.Add(lblprecio);
            Controls.Add(lblnombre);
            Controls.Add(lblcodigo);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lblcodigo;
        private Label lblnombre;
        private Label lblprecio;
        private Label lblcantidad;
        private TextBox txtcodigo;
        private TextBox txtnombre;
        private TextBox txtprecio;
        private TextBox textBox4;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button bntfacturar;
        private Label lblsubtotal;
        private Label lblitbis;
        private Label lbltotal;
        private Label lblpago;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button btndevolver;
    }


    // diseño y ubicacion de los botones no lo toques 
}
