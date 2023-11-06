namespace VerificadorPrecios
{
    partial class Form2
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxFooter = new System.Windows.Forms.PictureBox();
            this.panelBarCode = new System.Windows.Forms.Panel();
            this.panelVerificador = new System.Windows.Forms.Panel();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcionTag = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblExistenciaTag = new System.Windows.Forms.Label();
            this.lblCodigoTag = new System.Windows.Forms.Label();
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPrecio = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioTag = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panelPromocion = new System.Windows.Forms.Panel();
            this.lblTagPrecioPromocion = new System.Windows.Forms.Label();
            this.lblPrecioPromocion = new System.Windows.Forms.Label();
            this.pbSplash = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tableLayoutContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooter)).BeginInit();
            this.panelBarCode.SuspendLayout();
            this.panelVerificador.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.tlpSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpInferior.SuspendLayout();
            this.tlpPrecio.SuspendLayout();
            this.panelPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(98)))), ((int)(((byte)(185)))));
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Arial Black", 34F);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.labelHeader.Location = new System.Drawing.Point(3, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1360, 76);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "VERIFICADOR DE PRECIOS";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutContenedor
            // 
            this.tableLayoutContenedor.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutContenedor.ColumnCount = 1;
            this.tableLayoutContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutContenedor.Controls.Add(this.labelHeader, 0, 0);
            this.tableLayoutContenedor.Controls.Add(this.pictureBoxFooter, 0, 2);
            this.tableLayoutContenedor.Controls.Add(this.panelBarCode, 0, 1);
            this.tableLayoutContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContenedor.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutContenedor.Name = "tableLayoutContenedor";
            this.tableLayoutContenedor.RowCount = 3;
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutContenedor.Size = new System.Drawing.Size(1366, 768);
            this.tableLayoutContenedor.TabIndex = 0;
            // 
            // pictureBoxFooter
            // 
            this.pictureBoxFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFooter.Image = global::VerificadorPrecios.Properties.Resources.footer;
            this.pictureBoxFooter.Location = new System.Drawing.Point(3, 655);
            this.pictureBoxFooter.Name = "pictureBoxFooter";
            this.pictureBoxFooter.Size = new System.Drawing.Size(1360, 110);
            this.pictureBoxFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFooter.TabIndex = 2;
            this.pictureBoxFooter.TabStop = false;
            this.pictureBoxFooter.Click += new System.EventHandler(this.pictureBoxFooter_Click);
            // 
            // panelBarCode
            // 
            this.panelBarCode.BackColor = System.Drawing.SystemColors.Window;
            this.panelBarCode.BackgroundImage = global::VerificadorPrecios.Properties.Resources.barras;
            this.panelBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBarCode.Controls.Add(this.panelVerificador);
            this.panelBarCode.Controls.Add(this.txtCodigo);
            this.panelBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarCode.Location = new System.Drawing.Point(3, 79);
            this.panelBarCode.Name = "panelBarCode";
            this.panelBarCode.Size = new System.Drawing.Size(1360, 570);
            this.panelBarCode.TabIndex = 3;
            // 
            // panelVerificador
            // 
            this.panelVerificador.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelVerificador.Controls.Add(this.tlpContainer);
            this.panelVerificador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVerificador.Location = new System.Drawing.Point(0, 0);
            this.panelVerificador.Name = "panelVerificador";
            this.panelVerificador.Size = new System.Drawing.Size(1360, 570);
            this.panelVerificador.TabIndex = 0;
            // 
            // tlpContainer
            // 
            this.tlpContainer.BackColor = System.Drawing.SystemColors.Window;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.tlpSuperior, 0, 0);
            this.tlpContainer.Controls.Add(this.tlpInferior, 0, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(1360, 570);
            this.tlpContainer.TabIndex = 1;
            // 
            // tlpSuperior
            // 
            this.tlpSuperior.ColumnCount = 2;
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.33826F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66174F));
            this.tlpSuperior.Controls.Add(this.pbProducto, 1, 0);
            this.tlpSuperior.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpSuperior.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSuperior.Location = new System.Drawing.Point(3, 3);
            this.tlpSuperior.Name = "tlpSuperior";
            this.tlpSuperior.RowCount = 2;
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSuperior.Size = new System.Drawing.Size(1354, 279);
            this.tlpSuperior.TabIndex = 0;
            // 
            // pbProducto
            // 
            this.pbProducto.BackColor = System.Drawing.SystemColors.Window;
            this.pbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProducto.Location = new System.Drawing.Point(996, 3);
            this.pbProducto.Name = "pbProducto";
            this.tlpSuperior.SetRowSpan(this.pbProducto, 2);
            this.pbProducto.Size = new System.Drawing.Size(355, 273);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 1;
            this.pbProducto.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcionTag, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 133);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(249, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(735, 133);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionTag
            // 
            this.lblDescripcionTag.AutoSize = true;
            this.lblDescripcionTag.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescripcionTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTag.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescripcionTag.Location = new System.Drawing.Point(3, 0);
            this.lblDescripcionTag.Name = "lblDescripcionTag";
            this.lblDescripcionTag.Size = new System.Drawing.Size(240, 133);
            this.lblDescripcionTag.TabIndex = 0;
            this.lblDescripcionTag.Text = "Descripción:";
            this.lblDescripcionTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblExistencia, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCodigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblExistenciaTag, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCodigoTag, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 142);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(987, 134);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.BackColor = System.Drawing.SystemColors.Window;
            this.lblExistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(791, 0);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(193, 134);
            this.lblExistencia.TabIndex = 5;
            this.lblExistencia.Text = "0";
            this.lblExistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(249, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(339, 134);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "1234567890123";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExistenciaTag
            // 
            this.lblExistenciaTag.AutoSize = true;
            this.lblExistenciaTag.BackColor = System.Drawing.SystemColors.Window;
            this.lblExistenciaTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExistenciaTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistenciaTag.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblExistenciaTag.Location = new System.Drawing.Point(594, 0);
            this.lblExistenciaTag.Name = "lblExistenciaTag";
            this.lblExistenciaTag.Size = new System.Drawing.Size(191, 134);
            this.lblExistenciaTag.TabIndex = 2;
            this.lblExistenciaTag.Text = "Existencia:";
            this.lblExistenciaTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodigoTag
            // 
            this.lblCodigoTag.AutoSize = true;
            this.lblCodigoTag.BackColor = System.Drawing.SystemColors.Window;
            this.lblCodigoTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoTag.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCodigoTag.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoTag.Name = "lblCodigoTag";
            this.lblCodigoTag.Size = new System.Drawing.Size(240, 134);
            this.lblCodigoTag.TabIndex = 0;
            this.lblCodigoTag.Text = "Código: ";
            this.lblCodigoTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpInferior
            // 
            this.tlpInferior.ColumnCount = 2;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Controls.Add(this.tlpPrecio, 0, 0);
            this.tlpInferior.Controls.Add(this.panelPromocion, 1, 0);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInferior.Location = new System.Drawing.Point(3, 288);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.RowCount = 1;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInferior.Size = new System.Drawing.Size(1354, 279);
            this.tlpInferior.TabIndex = 1;
            // 
            // tlpPrecio
            // 
            this.tlpPrecio.ColumnCount = 2;
            this.tlpPrecio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tlpPrecio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.5F));
            this.tlpPrecio.Controls.Add(this.lblPrecioTag, 0, 0);
            this.tlpPrecio.Controls.Add(this.lblPrecio, 1, 0);
            this.tlpPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrecio.Location = new System.Drawing.Point(3, 3);
            this.tlpPrecio.Name = "tlpPrecio";
            this.tlpPrecio.RowCount = 1;
            this.tlpPrecio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrecio.Size = new System.Drawing.Size(671, 273);
            this.tlpPrecio.TabIndex = 0;
            // 
            // lblPrecioTag
            // 
            this.lblPrecioTag.AutoSize = true;
            this.lblPrecioTag.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTag.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPrecioTag.Location = new System.Drawing.Point(3, 0);
            this.lblPrecioTag.Name = "lblPrecioTag";
            this.lblPrecioTag.Size = new System.Drawing.Size(238, 273);
            this.lblPrecioTag.TabIndex = 2;
            this.lblPrecioTag.Text = "Precio:";
            this.lblPrecioTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(247, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(421, 273);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "$9,999.99";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPromocion
            // 
            this.panelPromocion.Controls.Add(this.lblTagPrecioPromocion);
            this.panelPromocion.Controls.Add(this.lblPrecioPromocion);
            this.panelPromocion.Controls.Add(this.pbSplash);
            this.panelPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPromocion.Location = new System.Drawing.Point(680, 3);
            this.panelPromocion.Name = "panelPromocion";
            this.panelPromocion.Size = new System.Drawing.Size(671, 273);
            this.panelPromocion.TabIndex = 1;
            // 
            // lblTagPrecioPromocion
            // 
            this.lblTagPrecioPromocion.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTagPrecioPromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTagPrecioPromocion.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagPrecioPromocion.ForeColor = System.Drawing.Color.White;
            this.lblTagPrecioPromocion.Location = new System.Drawing.Point(0, 0);
            this.lblTagPrecioPromocion.Name = "lblTagPrecioPromocion";
            this.lblTagPrecioPromocion.Size = new System.Drawing.Size(671, 101);
            this.lblTagPrecioPromocion.TabIndex = 3;
            this.lblTagPrecioPromocion.Text = "PRECIO PROMOCIÓN";
            this.lblTagPrecioPromocion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTagPrecioPromocion.Click += new System.EventHandler(this.lblTagPrecioPromocion_Click);
            // 
            // lblPrecioPromocion
            // 
            this.lblPrecioPromocion.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPrecioPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioPromocion.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPromocion.ForeColor = System.Drawing.Color.White;
            this.lblPrecioPromocion.Location = new System.Drawing.Point(0, 0);
            this.lblPrecioPromocion.Name = "lblPrecioPromocion";
            this.lblPrecioPromocion.Size = new System.Drawing.Size(671, 273);
            this.lblPrecioPromocion.TabIndex = 2;
            this.lblPrecioPromocion.Text = "$9,999.99";
            this.lblPrecioPromocion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSplash
            // 
            this.pbSplash.BackColor = System.Drawing.Color.White;
            this.pbSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSplash.Image = global::VerificadorPrecios.Properties.Resources.badge_154930__4801;
            this.pbSplash.Location = new System.Drawing.Point(0, 0);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(671, 273);
            this.pbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplash.TabIndex = 0;
            this.pbSplash.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(0, 20);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDownAsync);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de Precios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.tableLayoutContenedor.ResumeLayout(false);
            this.tableLayoutContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooter)).EndInit();
            this.panelBarCode.ResumeLayout(false);
            this.panelBarCode.PerformLayout();
            this.panelVerificador.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.tlpSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpInferior.ResumeLayout(false);
            this.tlpPrecio.ResumeLayout(false);
            this.tlpPrecio.PerformLayout();
            this.panelPromocion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarCode;
        private System.Windows.Forms.Panel panelVerificador;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpSuperior;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDescripcionTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblExistenciaTag;
        private System.Windows.Forms.Label lblCodigoTag;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private System.Windows.Forms.TableLayoutPanel tlpPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel panelPromocion;
        private System.Windows.Forms.Label lblPrecioPromocion;
        private System.Windows.Forms.PictureBox pbSplash;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContenedor;
        private System.Windows.Forms.PictureBox pictureBoxFooter;
        private System.Windows.Forms.Label lblTagPrecioPromocion;
        private System.Windows.Forms.Label lblPrecioTag;
    }
}