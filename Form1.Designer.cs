namespace Calculadora
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btTantoPorCiento = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btComaDec = new System.Windows.Forms.Button();
            this.btDigito0 = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btPor = new System.Windows.Forms.Button();
            this.btDigito3 = new System.Windows.Forms.Button();
            this.btDigito2 = new System.Windows.Forms.Button();
            this.btDigito1 = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btDigito6 = new System.Windows.Forms.Button();
            this.btDigito5 = new System.Windows.Forms.Button();
            this.btDigito4 = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btBorrarEntrada = new System.Windows.Forms.Button();
            this.btDigito9 = new System.Windows.Forms.Button();
            this.btDigito8 = new System.Windows.Forms.Button();
            this.btDigito7 = new System.Windows.Forms.Button();
            this.etPantalla = new System.Windows.Forms.Label();
            this.lblITA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.etTitulo = new System.Windows.Forms.Label();
            this.NumApp = new System.Windows.Forms.Label();
            this.cbInvertirColores = new System.Windows.Forms.CheckBox();
            this.rbEstandar = new System.Windows.Forms.RadioButton();
            this.rbCientifica = new System.Windows.Forms.RadioButton();
            this.cubo = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTantoPorCiento
            // 
            this.btTantoPorCiento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btTantoPorCiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTantoPorCiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTantoPorCiento.ForeColor = System.Drawing.Color.White;
            this.btTantoPorCiento.Location = new System.Drawing.Point(111, 172);
            this.btTantoPorCiento.Name = "btTantoPorCiento";
            this.btTantoPorCiento.Size = new System.Drawing.Size(43, 40);
            this.btTantoPorCiento.TabIndex = 58;
            this.btTantoPorCiento.Text = "%";
            this.btTantoPorCiento.UseVisualStyleBackColor = false;
            this.btTantoPorCiento.Click += new System.EventHandler(this.btTantoPorCiento_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.ForeColor = System.Drawing.Color.White;
            this.btIgual.Location = new System.Drawing.Point(157, 344);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(43, 40);
            this.btIgual.TabIndex = 57;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btComaDec
            // 
            this.btComaDec.BackColor = System.Drawing.Color.DarkBlue;
            this.btComaDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btComaDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComaDec.ForeColor = System.Drawing.Color.White;
            this.btComaDec.Location = new System.Drawing.Point(111, 344);
            this.btComaDec.Name = "btComaDec";
            this.btComaDec.Size = new System.Drawing.Size(43, 40);
            this.btComaDec.TabIndex = 50;
            this.btComaDec.Text = ",";
            this.btComaDec.UseVisualStyleBackColor = false;
            this.btComaDec.Click += new System.EventHandler(this.btComaDec_Click);
            // 
            // btDigito0
            // 
            this.btDigito0.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito0.ForeColor = System.Drawing.Color.White;
            this.btDigito0.Location = new System.Drawing.Point(19, 344);
            this.btDigito0.Name = "btDigito0";
            this.btDigito0.Size = new System.Drawing.Size(89, 40);
            this.btDigito0.TabIndex = 40;
            this.btDigito0.Text = "0";
            this.btDigito0.UseVisualStyleBackColor = false;
            this.btDigito0.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito0.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btMas
            // 
            this.btMas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMas.ForeColor = System.Drawing.Color.White;
            this.btMas.Location = new System.Drawing.Point(157, 301);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(43, 40);
            this.btMas.TabIndex = 56;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = false;
            this.btMas.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btPor
            // 
            this.btPor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPor.ForeColor = System.Drawing.Color.White;
            this.btPor.Location = new System.Drawing.Point(157, 215);
            this.btPor.Name = "btPor";
            this.btPor.Size = new System.Drawing.Size(43, 40);
            this.btPor.TabIndex = 55;
            this.btPor.Text = "x";
            this.btPor.UseVisualStyleBackColor = false;
            this.btPor.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btDigito3
            // 
            this.btDigito3.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito3.ForeColor = System.Drawing.Color.White;
            this.btDigito3.Location = new System.Drawing.Point(111, 301);
            this.btDigito3.Name = "btDigito3";
            this.btDigito3.Size = new System.Drawing.Size(43, 40);
            this.btDigito3.TabIndex = 43;
            this.btDigito3.Text = "3";
            this.btDigito3.UseVisualStyleBackColor = false;
            this.btDigito3.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito3.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito2
            // 
            this.btDigito2.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito2.ForeColor = System.Drawing.Color.White;
            this.btDigito2.Location = new System.Drawing.Point(65, 301);
            this.btDigito2.Name = "btDigito2";
            this.btDigito2.Size = new System.Drawing.Size(43, 40);
            this.btDigito2.TabIndex = 42;
            this.btDigito2.Text = "2";
            this.btDigito2.UseVisualStyleBackColor = false;
            this.btDigito2.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito2.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito1
            // 
            this.btDigito1.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito1.ForeColor = System.Drawing.Color.White;
            this.btDigito1.Location = new System.Drawing.Point(19, 301);
            this.btDigito1.Name = "btDigito1";
            this.btDigito1.Size = new System.Drawing.Size(43, 40);
            this.btDigito1.TabIndex = 41;
            this.btDigito1.Text = "1";
            this.btDigito1.UseVisualStyleBackColor = false;
            this.btDigito1.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito1.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.ForeColor = System.Drawing.Color.White;
            this.btMenos.Location = new System.Drawing.Point(157, 258);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(43, 40);
            this.btMenos.TabIndex = 54;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = false;
            this.btMenos.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btDividir
            // 
            this.btDividir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.ForeColor = System.Drawing.Color.White;
            this.btDividir.Location = new System.Drawing.Point(157, 172);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(43, 40);
            this.btDividir.TabIndex = 53;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = false;
            this.btDividir.Click += new System.EventHandler(this.btOperacion_Click);
            // 
            // btDigito6
            // 
            this.btDigito6.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito6.ForeColor = System.Drawing.Color.White;
            this.btDigito6.Location = new System.Drawing.Point(111, 258);
            this.btDigito6.Name = "btDigito6";
            this.btDigito6.Size = new System.Drawing.Size(43, 40);
            this.btDigito6.TabIndex = 46;
            this.btDigito6.Text = "6";
            this.btDigito6.UseVisualStyleBackColor = false;
            this.btDigito6.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito6.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito5
            // 
            this.btDigito5.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito5.ForeColor = System.Drawing.Color.White;
            this.btDigito5.Location = new System.Drawing.Point(65, 258);
            this.btDigito5.Name = "btDigito5";
            this.btDigito5.Size = new System.Drawing.Size(43, 40);
            this.btDigito5.TabIndex = 45;
            this.btDigito5.Text = "5";
            this.btDigito5.UseVisualStyleBackColor = false;
            this.btDigito5.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito5.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito4
            // 
            this.btDigito4.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito4.ForeColor = System.Drawing.Color.White;
            this.btDigito4.Location = new System.Drawing.Point(19, 258);
            this.btDigito4.Name = "btDigito4";
            this.btDigito4.Size = new System.Drawing.Size(43, 40);
            this.btDigito4.TabIndex = 44;
            this.btDigito4.Text = "4";
            this.btDigito4.UseVisualStyleBackColor = false;
            this.btDigito4.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito4.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.Red;
            this.btIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.ForeColor = System.Drawing.Color.White;
            this.btIniciar.Location = new System.Drawing.Point(19, 172);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(43, 40);
            this.btIniciar.TabIndex = 51;
            this.btIniciar.Text = "C";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btBorrarEntrada
            // 
            this.btBorrarEntrada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btBorrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBorrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarEntrada.ForeColor = System.Drawing.Color.White;
            this.btBorrarEntrada.Location = new System.Drawing.Point(65, 172);
            this.btBorrarEntrada.Name = "btBorrarEntrada";
            this.btBorrarEntrada.Size = new System.Drawing.Size(43, 40);
            this.btBorrarEntrada.TabIndex = 52;
            this.btBorrarEntrada.Text = "CE";
            this.btBorrarEntrada.UseVisualStyleBackColor = false;
            this.btBorrarEntrada.Click += new System.EventHandler(this.btBorrarEntrada_Click);
            // 
            // btDigito9
            // 
            this.btDigito9.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito9.ForeColor = System.Drawing.Color.White;
            this.btDigito9.Location = new System.Drawing.Point(111, 215);
            this.btDigito9.Name = "btDigito9";
            this.btDigito9.Size = new System.Drawing.Size(43, 40);
            this.btDigito9.TabIndex = 49;
            this.btDigito9.Text = "9";
            this.btDigito9.UseVisualStyleBackColor = false;
            this.btDigito9.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito9.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito8
            // 
            this.btDigito8.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito8.ForeColor = System.Drawing.Color.White;
            this.btDigito8.Location = new System.Drawing.Point(65, 215);
            this.btDigito8.Name = "btDigito8";
            this.btDigito8.Size = new System.Drawing.Size(43, 40);
            this.btDigito8.TabIndex = 48;
            this.btDigito8.Text = "8";
            this.btDigito8.UseVisualStyleBackColor = false;
            this.btDigito8.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito8.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // btDigito7
            // 
            this.btDigito7.BackColor = System.Drawing.Color.DarkBlue;
            this.btDigito7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDigito7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDigito7.ForeColor = System.Drawing.Color.White;
            this.btDigito7.Location = new System.Drawing.Point(19, 215);
            this.btDigito7.Name = "btDigito7";
            this.btDigito7.Size = new System.Drawing.Size(43, 40);
            this.btDigito7.TabIndex = 47;
            this.btDigito7.Text = "7";
            this.btDigito7.UseVisualStyleBackColor = false;
            this.btDigito7.Click += new System.EventHandler(this.btDigito_Click);
            this.btDigito7.Paint += new System.Windows.Forms.PaintEventHandler(this.btComaDec_Paint);
            // 
            // etPantalla
            // 
            this.etPantalla.BackColor = System.Drawing.Color.White;
            this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPantalla.Location = new System.Drawing.Point(12, 73);
            this.etPantalla.Name = "etPantalla";
            this.etPantalla.Size = new System.Drawing.Size(200, 50);
            this.etPantalla.TabIndex = 59;
            this.etPantalla.Text = "0,";
            this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblITA
            // 
            this.lblITA.BackColor = System.Drawing.Color.DarkBlue;
            this.lblITA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITA.ForeColor = System.Drawing.Color.White;
            this.lblITA.Location = new System.Drawing.Point(0, 0);
            this.lblITA.Name = "lblITA";
            this.lblITA.Size = new System.Drawing.Size(60, 60);
            this.lblITA.TabIndex = 63;
            this.lblITA.Text = "ITA";
            this.lblITA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // etTitulo
            // 
            this.etTitulo.BackColor = System.Drawing.Color.DarkBlue;
            this.etTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTitulo.ForeColor = System.Drawing.Color.White;
            this.etTitulo.Location = new System.Drawing.Point(60, 0);
            this.etTitulo.Name = "etTitulo";
            this.etTitulo.Size = new System.Drawing.Size(165, 60);
            this.etTitulo.TabIndex = 61;
            this.etTitulo.Text = "Calculadora";
            this.etTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumApp
            // 
            this.NumApp.BackColor = System.Drawing.Color.Black;
            this.NumApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumApp.ForeColor = System.Drawing.Color.White;
            this.NumApp.Location = new System.Drawing.Point(0, 395);
            this.NumApp.Name = "NumApp";
            this.NumApp.Size = new System.Drawing.Size(225, 16);
            this.NumApp.TabIndex = 64;
            this.NumApp.Text = "Aplicacion #2";
            this.NumApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbInvertirColores
            // 
            this.cbInvertirColores.AutoSize = true;
            this.cbInvertirColores.Location = new System.Drawing.Point(102, 126);
            this.cbInvertirColores.Name = "cbInvertirColores";
            this.cbInvertirColores.Size = new System.Drawing.Size(90, 17);
            this.cbInvertirColores.TabIndex = 65;
            this.cbInvertirColores.Text = "Cambiar color";
            this.cbInvertirColores.UseVisualStyleBackColor = true;
            this.cbInvertirColores.CheckedChanged += new System.EventHandler(this.cbInvertirColores_CheckedChanged);
            // 
            // rbEstandar
            // 
            this.rbEstandar.AutoSize = true;
            this.rbEstandar.Location = new System.Drawing.Point(16, 126);
            this.rbEstandar.Name = "rbEstandar";
            this.rbEstandar.Size = new System.Drawing.Size(67, 17);
            this.rbEstandar.TabIndex = 66;
            this.rbEstandar.TabStop = true;
            this.rbEstandar.Text = "Estandar";
            this.rbEstandar.UseVisualStyleBackColor = true;
            this.rbEstandar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCientifica
            // 
            this.rbCientifica.AutoSize = true;
            this.rbCientifica.Location = new System.Drawing.Point(16, 149);
            this.rbCientifica.Name = "rbCientifica";
            this.rbCientifica.Size = new System.Drawing.Size(68, 17);
            this.rbCientifica.TabIndex = 67;
            this.rbCientifica.TabStop = true;
            this.rbCientifica.Text = "Cientifica";
            this.rbCientifica.UseVisualStyleBackColor = true;
            this.rbCientifica.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cubo
            // 
            this.cubo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cubo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cubo.ForeColor = System.Drawing.Color.White;
            this.cubo.Location = new System.Drawing.Point(305, 240);
            this.cubo.Name = "cubo";
            this.cubo.Size = new System.Drawing.Size(44, 40);
            this.cubo.TabIndex = 72;
            this.cubo.Text = "X^3";
            this.cubo.UseVisualStyleBackColor = false;
            // 
            // Cuadrado
            // 
            this.Cuadrado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuadrado.ForeColor = System.Drawing.Color.White;
            this.Cuadrado.Location = new System.Drawing.Point(255, 240);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(44, 40);
            this.Cuadrado.TabIndex = 71;
            this.Cuadrado.Text = "X^2";
            this.Cuadrado.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(224, 411);
            this.Controls.Add(this.cubo);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.rbCientifica);
            this.Controls.Add(this.rbEstandar);
            this.Controls.Add(this.cbInvertirColores);
            this.Controls.Add(this.NumApp);
            this.Controls.Add(this.lblITA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.etTitulo);
            this.Controls.Add(this.btTantoPorCiento);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btComaDec);
            this.Controls.Add(this.btDigito0);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btPor);
            this.Controls.Add(this.btDigito3);
            this.Controls.Add(this.btDigito2);
            this.Controls.Add(this.btDigito1);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btDigito6);
            this.Controls.Add(this.btDigito5);
            this.Controls.Add(this.btDigito4);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.btBorrarEntrada);
            this.Controls.Add(this.btDigito9);
            this.Controls.Add(this.btDigito8);
            this.Controls.Add(this.btDigito7);
            this.Controls.Add(this.etPantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btTantoPorCiento;
    private System.Windows.Forms.Button btIgual;
    private System.Windows.Forms.Button btComaDec;
    private System.Windows.Forms.Button btDigito0;
    private System.Windows.Forms.Button btMas;
    private System.Windows.Forms.Button btPor;
    private System.Windows.Forms.Button btDigito3;
    private System.Windows.Forms.Button btDigito2;
    private System.Windows.Forms.Button btDigito1;
    private System.Windows.Forms.Button btMenos;
    private System.Windows.Forms.Button btDividir;
    private System.Windows.Forms.Button btDigito6;
    private System.Windows.Forms.Button btDigito5;
    private System.Windows.Forms.Button btDigito4;
    private System.Windows.Forms.Button btIniciar;
    private System.Windows.Forms.Button btBorrarEntrada;
    private System.Windows.Forms.Button btDigito9;
    private System.Windows.Forms.Button btDigito8;
    private System.Windows.Forms.Button btDigito7;
    private System.Windows.Forms.Label etPantalla;
        private System.Windows.Forms.Label lblITA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.Label NumApp;
        private System.Windows.Forms.CheckBox cbInvertirColores;
        private System.Windows.Forms.RadioButton rbEstandar;
        private System.Windows.Forms.RadioButton rbCientifica;
        private System.Windows.Forms.Button cubo;
        private System.Windows.Forms.Button Cuadrado;
    }
}

