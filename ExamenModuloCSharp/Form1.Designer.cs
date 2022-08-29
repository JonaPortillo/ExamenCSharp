namespace ExamenModuloCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCotizar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPrecioCantidad = new System.Windows.Forms.GroupBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecioUni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupCalidad = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandar = new System.Windows.Forms.RadioButton();
            this.groupPrenda = new System.Windows.Forms.GroupBox();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblNomApeVende = new System.Windows.Forms.Label();
            this.lblDirTienda = new System.Windows.Forms.Label();
            this.lblNomTienda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupDatosIniciales = new System.Windows.Forms.GroupBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.formCodVend = new System.Windows.Forms.TextBox();
            this.formApeVend = new System.Windows.Forms.TextBox();
            this.formNomVend = new System.Windows.Forms.TextBox();
            this.formNomTienda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formDirTienda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCotizar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPrecioCantidad.SuspendLayout();
            this.groupCalidad.SuspendLayout();
            this.groupPrenda.SuspendLayout();
            this.groupDatosIniciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCotizar
            // 
            this.tabCotizar.Controls.Add(this.tabPage1);
            this.tabCotizar.Controls.Add(this.tabPage2);
            this.tabCotizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCotizar.Location = new System.Drawing.Point(-1, 1);
            this.tabCotizar.Name = "tabCotizar";
            this.tabCotizar.SelectedIndex = 0;
            this.tabCotizar.Size = new System.Drawing.Size(415, 361);
            this.tabCotizar.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.lblNomApeVende);
            this.tabPage1.Controls.Add(this.lblDirTienda);
            this.tabPage1.Controls.Add(this.lblNomTienda);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cotizar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(268, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo Vendedor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.lblStockDisponible);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.groupPrecioCantidad);
            this.splitContainer1.Panel1.Controls.Add(this.groupCalidad);
            this.splitContainer1.Panel1.Controls.Add(this.groupPrenda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnCotizar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(406, 244);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 12;
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(215, 153);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(19, 18);
            this.lblStockDisponible.TabIndex = 9;
            this.lblStockDisponible.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Unidades de stock disponibles:";
            // 
            // groupPrecioCantidad
            // 
            this.groupPrecioCantidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPrecioCantidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupPrecioCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupPrecioCantidad.Controls.Add(this.tbCantidad);
            this.groupPrecioCantidad.Controls.Add(this.label5);
            this.groupPrecioCantidad.Controls.Add(this.tbPrecioUni);
            this.groupPrecioCantidad.Controls.Add(this.label4);
            this.groupPrecioCantidad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPrecioCantidad.Location = new System.Drawing.Point(184, 94);
            this.groupPrecioCantidad.Name = "groupPrecioCantidad";
            this.groupPrecioCantidad.Size = new System.Drawing.Size(212, 50);
            this.groupPrecioCantidad.TabIndex = 7;
            this.groupPrecioCantidad.TabStop = false;
            this.groupPrecioCantidad.Text = "Precio Unitario, Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(160, 18);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(36, 26);
            this.tbCantidad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad:";
            // 
            // tbPrecioUni
            // 
            this.tbPrecioUni.Location = new System.Drawing.Point(34, 18);
            this.tbPrecioUni.Name = "tbPrecioUni";
            this.tbPrecioUni.Size = new System.Drawing.Size(36, 26);
            this.tbPrecioUni.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "$:";
            // 
            // groupCalidad
            // 
            this.groupCalidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupCalidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupCalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupCalidad.Controls.Add(this.rbPremium);
            this.groupCalidad.Controls.Add(this.rbStandar);
            this.groupCalidad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCalidad.Location = new System.Drawing.Point(12, 94);
            this.groupCalidad.Name = "groupCalidad";
            this.groupCalidad.Size = new System.Drawing.Size(166, 50);
            this.groupCalidad.TabIndex = 6;
            this.groupCalidad.TabStop = false;
            this.groupCalidad.Text = "Calidad de Penda";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPremium.Location = new System.Drawing.Point(80, 25);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(76, 17);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbStandar
            // 
            this.rbStandar.AutoSize = true;
            this.rbStandar.Checked = true;
            this.rbStandar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStandar.Location = new System.Drawing.Point(6, 25);
            this.rbStandar.Name = "rbStandar";
            this.rbStandar.Size = new System.Drawing.Size(70, 17);
            this.rbStandar.TabIndex = 0;
            this.rbStandar.TabStop = true;
            this.rbStandar.Text = "Standar";
            this.rbStandar.UseVisualStyleBackColor = true;
            // 
            // groupPrenda
            // 
            this.groupPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupPrenda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupPrenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupPrenda.Controls.Add(this.cbChupin);
            this.groupPrenda.Controls.Add(this.cbCuelloMao);
            this.groupPrenda.Controls.Add(this.cbMangaCorta);
            this.groupPrenda.Controls.Add(this.rbPantalon);
            this.groupPrenda.Controls.Add(this.rbCamisa);
            this.groupPrenda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPrenda.Location = new System.Drawing.Point(12, 14);
            this.groupPrenda.Name = "groupPrenda";
            this.groupPrenda.Size = new System.Drawing.Size(384, 74);
            this.groupPrenda.TabIndex = 5;
            this.groupPrenda.TabStop = false;
            this.groupPrenda.Text = "Prenda";
            // 
            // cbChupin
            // 
            this.cbChupin.AutoSize = true;
            this.cbChupin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbChupin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChupin.Location = new System.Drawing.Point(127, 49);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(78, 17);
            this.cbChupin.TabIndex = 4;
            this.cbChupin.Text = "¿Chupín?";
            this.cbChupin.UseVisualStyleBackColor = false;
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbCuelloMao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuelloMao.Location = new System.Drawing.Point(256, 26);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(101, 17);
            this.cbCuelloMao.TabIndex = 3;
            this.cbCuelloMao.Text = "¿Cuello Mao?";
            this.cbCuelloMao.UseVisualStyleBackColor = false;
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbMangaCorta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMangaCorta.Location = new System.Drawing.Point(127, 26);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(108, 17);
            this.cbMangaCorta.TabIndex = 2;
            this.cbMangaCorta.Text = "¿Manga corta?";
            this.cbMangaCorta.UseVisualStyleBackColor = false;
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPantalon.Location = new System.Drawing.Point(6, 48);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(74, 17);
            this.rbPantalon.TabIndex = 1;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Checked = true;
            this.rbCamisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCamisa.Location = new System.Drawing.Point(6, 25);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(68, 17);
            this.rbCamisa.TabIndex = 0;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(263, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 29);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "$__________";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Blue;
            this.btnCotizar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCotizar.Location = new System.Drawing.Point(18, 19);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(150, 36);
            this.btnCotizar.TabIndex = 0;
            this.btnCotizar.Text = "¡Cotizar!";
            this.btnCotizar.UseVisualStyleBackColor = false;
            // 
            // lblNomApeVende
            // 
            this.lblNomApeVende.AutoSize = true;
            this.lblNomApeVende.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomApeVende.ForeColor = System.Drawing.Color.Navy;
            this.lblNomApeVende.Location = new System.Drawing.Point(-3, 62);
            this.lblNomApeVende.Margin = new System.Windows.Forms.Padding(0);
            this.lblNomApeVende.Name = "lblNomApeVende";
            this.lblNomApeVende.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblNomApeVende.Size = new System.Drawing.Size(215, 24);
            this.lblNomApeVende.TabIndex = 11;
            this.lblNomApeVende.Text = "Nombre y Apellido Vendedor";
            // 
            // lblDirTienda
            // 
            this.lblDirTienda.AutoSize = true;
            this.lblDirTienda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirTienda.ForeColor = System.Drawing.Color.Navy;
            this.lblDirTienda.Location = new System.Drawing.Point(265, 34);
            this.lblDirTienda.Margin = new System.Windows.Forms.Padding(0);
            this.lblDirTienda.Name = "lblDirTienda";
            this.lblDirTienda.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblDirTienda.Size = new System.Drawing.Size(141, 28);
            this.lblDirTienda.TabIndex = 10;
            this.lblDirTienda.Text = "Nombre Tienda";
            // 
            // lblNomTienda
            // 
            this.lblNomTienda.AutoSize = true;
            this.lblNomTienda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTienda.ForeColor = System.Drawing.Color.Navy;
            this.lblNomTienda.Location = new System.Drawing.Point(-7, 34);
            this.lblNomTienda.Margin = new System.Windows.Forms.Padding(0);
            this.lblNomTienda.Name = "lblNomTienda";
            this.lblNomTienda.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblNomTienda.Size = new System.Drawing.Size(141, 28);
            this.lblNomTienda.TabIndex = 9;
            this.lblNomTienda.Text = "Nombre Tienda";
            this.lblNomTienda.Click += new System.EventHandler(this.lblNomTienda_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cotizador C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial Cotizaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupDatosIniciales
            // 
            this.groupDatosIniciales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupDatosIniciales.Controls.Add(this.formDirTienda);
            this.groupDatosIniciales.Controls.Add(this.label11);
            this.groupDatosIniciales.Controls.Add(this.btnComenzar);
            this.groupDatosIniciales.Controls.Add(this.formCodVend);
            this.groupDatosIniciales.Controls.Add(this.formApeVend);
            this.groupDatosIniciales.Controls.Add(this.formNomVend);
            this.groupDatosIniciales.Controls.Add(this.formNomTienda);
            this.groupDatosIniciales.Controls.Add(this.label10);
            this.groupDatosIniciales.Controls.Add(this.label9);
            this.groupDatosIniciales.Controls.Add(this.label7);
            this.groupDatosIniciales.Controls.Add(this.label3);
            this.groupDatosIniciales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatosIniciales.Location = new System.Drawing.Point(-1, 1);
            this.groupDatosIniciales.Name = "groupDatosIniciales";
            this.groupDatosIniciales.Size = new System.Drawing.Size(411, 361);
            this.groupDatosIniciales.TabIndex = 9;
            this.groupDatosIniciales.TabStop = false;
            this.groupDatosIniciales.Text = "Datos de la Tienda y del Vendedor";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(259, 307);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(120, 34);
            this.btnComenzar.TabIndex = 8;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            this.btnComenzar.Validated += new System.EventHandler(this.btnComenzar_Validated);
            // 
            // formCodVend
            // 
            this.formCodVend.Location = new System.Drawing.Point(203, 262);
            this.formCodVend.Name = "formCodVend";
            this.formCodVend.Size = new System.Drawing.Size(176, 27);
            this.formCodVend.TabIndex = 7;
            this.formCodVend.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // formApeVend
            // 
            this.formApeVend.Location = new System.Drawing.Point(203, 205);
            this.formApeVend.Name = "formApeVend";
            this.formApeVend.Size = new System.Drawing.Size(176, 27);
            this.formApeVend.TabIndex = 6;
            this.formApeVend.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // formNomVend
            // 
            this.formNomVend.Location = new System.Drawing.Point(203, 145);
            this.formNomVend.Name = "formNomVend";
            this.formNomVend.Size = new System.Drawing.Size(176, 27);
            this.formNomVend.TabIndex = 5;
            this.formNomVend.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // formNomTienda
            // 
            this.formNomTienda.Location = new System.Drawing.Point(203, 35);
            this.formNomTienda.Name = "formNomTienda";
            this.formNomTienda.Size = new System.Drawing.Size(176, 27);
            this.formNomTienda.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "*Código Vendedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "*Apellido Vendedor:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "*Nombre Vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Nombre Tienda:";
            // 
            // formDirTienda
            // 
            this.formDirTienda.Location = new System.Drawing.Point(203, 87);
            this.formDirTienda.Name = "formDirTienda";
            this.formDirTienda.Size = new System.Drawing.Size(176, 27);
            this.formDirTienda.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dirección Tienda:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 359);
            this.Controls.Add(this.groupDatosIniciales);
            this.Controls.Add(this.tabCotizar);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico: Cotizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCotizar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPrecioCantidad.ResumeLayout(false);
            this.groupPrecioCantidad.PerformLayout();
            this.groupCalidad.ResumeLayout(false);
            this.groupCalidad.PerformLayout();
            this.groupPrenda.ResumeLayout(false);
            this.groupPrenda.PerformLayout();
            this.groupDatosIniciales.ResumeLayout(false);
            this.groupDatosIniciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCotizar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupPrecioCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrecioUni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupCalidad;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbStandar;
        private System.Windows.Forms.GroupBox groupPrenda;
        private System.Windows.Forms.CheckBox cbChupin;
        private System.Windows.Forms.CheckBox cbCuelloMao;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblNomApeVende;
        private System.Windows.Forms.Label lblDirTienda;
        private System.Windows.Forms.Label lblNomTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupDatosIniciales;
        private System.Windows.Forms.TextBox formCodVend;
        private System.Windows.Forms.TextBox formApeVend;
        private System.Windows.Forms.TextBox formNomVend;
        private System.Windows.Forms.TextBox formNomTienda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox formDirTienda;
        private System.Windows.Forms.Label label11;
    }
}

