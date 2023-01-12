namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS
{
    partial class REGISTRAR_VENTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRAR_VENTA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.anadirProductoButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataVenta = new System.Windows.Forms.DataGridView();
            this.eliminar_columna = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAnadirLista = new System.Windows.Forms.Panel();
            this.cerrarPanel = new System.Windows.Forms.PictureBox();
            this.combo_lotes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unidad_producto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_precio_unit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_productos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anadirLista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonRegistrarVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_total_venta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).BeginInit();
            this.panelAnadirLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_unit)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(873, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.anadirProductoButton);
            this.panel3.Controls.Add(this.dataVenta);
            this.panel3.Location = new System.Drawing.Point(12, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 492);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // anadirProductoButton
            // 
            this.anadirProductoButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirProductoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirProductoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anadirProductoButton.BorderRadius = 0;
            this.anadirProductoButton.ButtonText = "Añadir producto";
            this.anadirProductoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anadirProductoButton.DisabledColor = System.Drawing.Color.Gray;
            this.anadirProductoButton.Iconcolor = System.Drawing.Color.Transparent;
            this.anadirProductoButton.Iconimage = null;
            this.anadirProductoButton.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("anadirProductoButton.Iconimage_right")));
            this.anadirProductoButton.Iconimage_right_Selected = null;
            this.anadirProductoButton.Iconimage_Selected = null;
            this.anadirProductoButton.IconMarginLeft = 0;
            this.anadirProductoButton.IconMarginRight = 0;
            this.anadirProductoButton.IconRightVisible = true;
            this.anadirProductoButton.IconRightZoom = 0D;
            this.anadirProductoButton.IconVisible = true;
            this.anadirProductoButton.IconZoom = 50D;
            this.anadirProductoButton.IsTab = false;
            this.anadirProductoButton.Location = new System.Drawing.Point(776, 426);
            this.anadirProductoButton.Name = "anadirProductoButton";
            this.anadirProductoButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirProductoButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirProductoButton.OnHoverTextColor = System.Drawing.Color.White;
            this.anadirProductoButton.selected = false;
            this.anadirProductoButton.Size = new System.Drawing.Size(195, 48);
            this.anadirProductoButton.TabIndex = 9;
            this.anadirProductoButton.Text = "Añadir producto";
            this.anadirProductoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anadirProductoButton.Textcolor = System.Drawing.Color.White;
            this.anadirProductoButton.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirProductoButton.Click += new System.EventHandler(this.anadirProductoButton_Click);
            // 
            // dataVenta
            // 
            this.dataVenta.AllowUserToAddRows = false;
            this.dataVenta.AllowUserToDeleteRows = false;
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar_columna,
            this.nombre_producto,
            this.pedido,
            this.cantidad,
            this.unidad,
            this.precio_unitario,
            this.precio_total});
            this.dataVenta.Location = new System.Drawing.Point(-8, 0);
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.ReadOnly = true;
            this.dataVenta.Size = new System.Drawing.Size(988, 420);
            this.dataVenta.TabIndex = 3;
            // 
            // eliminar_columna
            // 
            this.eliminar_columna.FillWeight = 40F;
            this.eliminar_columna.HeaderText = "";
            this.eliminar_columna.Image = ((System.Drawing.Image)(resources.GetObject("eliminar_columna.Image")));
            this.eliminar_columna.Name = "eliminar_columna";
            this.eliminar_columna.ReadOnly = true;
            this.eliminar_columna.Width = 40;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // pedido
            // 
            this.pedido.HeaderText = "Lote";
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // precio_total
            // 
            this.precio_total.HeaderText = "Precio Total";
            this.precio_total.Name = "precio_total";
            this.precio_total.ReadOnly = true;
            // 
            // panelAnadirLista
            // 
            this.panelAnadirLista.Controls.Add(this.cerrarPanel);
            this.panelAnadirLista.Controls.Add(this.combo_lotes);
            this.panelAnadirLista.Controls.Add(this.label2);
            this.panelAnadirLista.Controls.Add(this.txt_unidad_producto);
            this.panelAnadirLista.Controls.Add(this.label5);
            this.panelAnadirLista.Controls.Add(this.txt_cantidad);
            this.panelAnadirLista.Controls.Add(this.txt_precio_unit);
            this.panelAnadirLista.Controls.Add(this.label6);
            this.panelAnadirLista.Controls.Add(this.label4);
            this.panelAnadirLista.Controls.Add(this.combo_productos);
            this.panelAnadirLista.Controls.Add(this.label7);
            this.panelAnadirLista.Controls.Add(this.anadirLista);
            this.panelAnadirLista.Location = new System.Drawing.Point(285, 106);
            this.panelAnadirLista.Name = "panelAnadirLista";
            this.panelAnadirLista.Size = new System.Drawing.Size(488, 371);
            this.panelAnadirLista.TabIndex = 5;
            this.panelAnadirLista.Visible = false;
            this.panelAnadirLista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cerrarPanel
            // 
            this.cerrarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPanel.Image = ((System.Drawing.Image)(resources.GetObject("cerrarPanel.Image")));
            this.cerrarPanel.Location = new System.Drawing.Point(451, 12);
            this.cerrarPanel.Name = "cerrarPanel";
            this.cerrarPanel.Size = new System.Drawing.Size(27, 18);
            this.cerrarPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarPanel.TabIndex = 29;
            this.cerrarPanel.TabStop = false;
            this.cerrarPanel.Click += new System.EventHandler(this.cerrarPanel_Click);
            // 
            // combo_lotes
            // 
            this.combo_lotes.DisplayMember = "Text";
            this.combo_lotes.Enabled = false;
            this.combo_lotes.FormattingEnabled = true;
            this.combo_lotes.Location = new System.Drawing.Point(237, 140);
            this.combo_lotes.Name = "combo_lotes";
            this.combo_lotes.Size = new System.Drawing.Size(219, 21);
            this.combo_lotes.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lote";
            // 
            // txt_unidad_producto
            // 
            this.txt_unidad_producto.Enabled = false;
            this.txt_unidad_producto.Location = new System.Drawing.Point(237, 89);
            this.txt_unidad_producto.Name = "txt_unidad_producto";
            this.txt_unidad_producto.ReadOnly = true;
            this.txt_unidad_producto.Size = new System.Drawing.Size(219, 20);
            this.txt_unidad_producto.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Unidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.DecimalPlaces = 2;
            this.txt_cantidad.Location = new System.Drawing.Point(237, 190);
            this.txt_cantidad.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(219, 20);
            this.txt_cantidad.TabIndex = 24;
            // 
            // txt_precio_unit
            // 
            this.txt_precio_unit.DecimalPlaces = 2;
            this.txt_precio_unit.Location = new System.Drawing.Point(237, 227);
            this.txt_precio_unit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_precio_unit.Name = "txt_precio_unit";
            this.txt_precio_unit.Size = new System.Drawing.Size(219, 20);
            this.txt_precio_unit.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad";
            // 
            // combo_productos
            // 
            this.combo_productos.DisplayMember = "Text";
            this.combo_productos.FormattingEnabled = true;
            this.combo_productos.Location = new System.Drawing.Point(237, 46);
            this.combo_productos.Name = "combo_productos";
            this.combo_productos.Size = new System.Drawing.Size(219, 21);
            this.combo_productos.TabIndex = 20;
            this.combo_productos.SelectedIndexChanged += new System.EventHandler(this.combo_productos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seleccione Producto";
            // 
            // anadirLista
            // 
            this.anadirLista.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anadirLista.BorderRadius = 0;
            this.anadirLista.ButtonText = "Añadir a la lista";
            this.anadirLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anadirLista.DisabledColor = System.Drawing.Color.Gray;
            this.anadirLista.Iconcolor = System.Drawing.Color.Transparent;
            this.anadirLista.Iconimage = null;
            this.anadirLista.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("anadirLista.Iconimage_right")));
            this.anadirLista.Iconimage_right_Selected = null;
            this.anadirLista.Iconimage_Selected = null;
            this.anadirLista.IconMarginLeft = 0;
            this.anadirLista.IconMarginRight = 0;
            this.anadirLista.IconRightVisible = true;
            this.anadirLista.IconRightZoom = 0D;
            this.anadirLista.IconVisible = true;
            this.anadirLista.IconZoom = 50D;
            this.anadirLista.IsTab = false;
            this.anadirLista.Location = new System.Drawing.Point(156, 296);
            this.anadirLista.Name = "anadirLista";
            this.anadirLista.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirLista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.anadirLista.OnHoverTextColor = System.Drawing.Color.White;
            this.anadirLista.selected = false;
            this.anadirLista.Size = new System.Drawing.Size(195, 48);
            this.anadirLista.TabIndex = 11;
            this.anadirLista.Text = "Añadir a la lista";
            this.anadirLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anadirLista.Textcolor = System.Drawing.Color.White;
            this.anadirLista.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirLista.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.botonRegistrarVenta);
            this.panel4.Controls.Add(this.txt_total_venta);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(226, 636);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 76);
            this.panel4.TabIndex = 4;
            // 
            // botonRegistrarVenta
            // 
            this.botonRegistrarVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.botonRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.botonRegistrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonRegistrarVenta.BorderRadius = 0;
            this.botonRegistrarVenta.ButtonText = "Registrar Venta";
            this.botonRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRegistrarVenta.DisabledColor = System.Drawing.Color.Gray;
            this.botonRegistrarVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.botonRegistrarVenta.Iconimage = null;
            this.botonRegistrarVenta.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("botonRegistrarVenta.Iconimage_right")));
            this.botonRegistrarVenta.Iconimage_right_Selected = null;
            this.botonRegistrarVenta.Iconimage_Selected = null;
            this.botonRegistrarVenta.IconMarginLeft = 0;
            this.botonRegistrarVenta.IconMarginRight = 0;
            this.botonRegistrarVenta.IconRightVisible = true;
            this.botonRegistrarVenta.IconRightZoom = 0D;
            this.botonRegistrarVenta.IconVisible = true;
            this.botonRegistrarVenta.IconZoom = 50D;
            this.botonRegistrarVenta.IsTab = false;
            this.botonRegistrarVenta.Location = new System.Drawing.Point(319, 16);
            this.botonRegistrarVenta.Name = "botonRegistrarVenta";
            this.botonRegistrarVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.botonRegistrarVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.botonRegistrarVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.botonRegistrarVenta.selected = false;
            this.botonRegistrarVenta.Size = new System.Drawing.Size(205, 48);
            this.botonRegistrarVenta.TabIndex = 10;
            this.botonRegistrarVenta.Text = "Registrar Venta";
            this.botonRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrarVenta.Textcolor = System.Drawing.Color.White;
            this.botonRegistrarVenta.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarVenta.Click += new System.EventHandler(this.botonRegistrarVenta_Click);
            // 
            // txt_total_venta
            // 
            this.txt_total_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_venta.Enabled = false;
            this.txt_total_venta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_venta.Location = new System.Drawing.Point(121, 30);
            this.txt_total_venta.Name = "txt_total_venta";
            this.txt_total_venta.Size = new System.Drawing.Size(138, 20);
            this.txt_total_venta.TabIndex = 1;
            this.txt_total_venta.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total";
            // 
            // REGISTRAR_VENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 724);
            this.Controls.Add(this.panelAnadirLista);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTRAR_VENTA";
            this.Text = "REGISTRAR_VENTA";
            this.Load += new System.EventHandler(this.REGISTRAR_VENTA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).EndInit();
            this.panelAnadirLista.ResumeLayout(false);
            this.panelAnadirLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_unit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_total_venta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAnadirLista;
        private System.Windows.Forms.DataGridView dataVenta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton anadirLista;
        private Bunifu.Framework.UI.BunifuFlatButton anadirProductoButton;
        private Bunifu.Framework.UI.BunifuFlatButton botonRegistrarVenta;
        private System.Windows.Forms.ComboBox combo_lotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_unidad_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_cantidad;
        private System.Windows.Forms.NumericUpDown txt_precio_unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_productos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox cerrarPanel;
        private System.Windows.Forms.DataGridViewImageColumn eliminar_columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_total;
    }
}