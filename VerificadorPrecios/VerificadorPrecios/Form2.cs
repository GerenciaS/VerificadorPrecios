using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorPrecios
{
    public partial class Form2 : Form
    {
        // variable del ancho de la forma
        int InitialFormWidth;
        // variables de los labels
        float headerFontSize;
        float descripcionTagFontSize;
        float descripcionFontSize;
        float codigoTagFontSize;
        float codigoFontSize;
        float existenciaTagFontSize;
        float existenciaFontSize;
        float precioTagFontSize;
        float precioFontSize;
        float precioPromocionTagFontSize;
        float precioPromocionFontSize;
        // nombre para el control Window
        string windowName;

        Panel panel1 = new Panel();
        Label label1 = new Label();
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // verificar app.config existe
            if (!Conexion.FileConfigExists())
            {
                MessageBox.Show("No existe el archivo configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            // verificar keys
            else
            {
                if (!Conexion.AppKeyExists("establecimiento"))
                {
                    MessageBox.Show("No existe el Key establecimiento en el archivo de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);
                }

                if (!Conexion.AppKeyExists("dispositivo"))
                {
                    MessageBox.Show("No existe el Key dispositivo en el archivo de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);
                }

            }

            // este valor debe ser el ancho default de la forma que es 1366 (resolucion de 1366 x 768)
            InitialFormWidth = this.Width;

            // nombre de la forma
            this.Text = $"{this.Text} {Conexion.BD} - Establecimiento {Conexion.establecimiento}";

            // valores iniciales de los labels
            headerFontSize = labelHeader.Font.SizeInPoints;
            descripcionTagFontSize = lblDescripcionTag.Font.SizeInPoints;
            descripcionFontSize = lblDescripcion.Font.SizeInPoints;
            codigoTagFontSize = lblCodigoTag.Font.SizeInPoints;
            codigoFontSize = lblCodigo.Font.SizeInPoints;
            existenciaTagFontSize = lblExistenciaTag.Font.SizeInPoints;
            existenciaFontSize = lblExistencia.Font.SizeInPoints;
            precioTagFontSize = lblPrecioTag.Font.SizeInPoints;
            precioFontSize = lblPrecio.Font.SizeInPoints;
            precioPromocionFontSize = lblPrecioPromocion.Font.SizeInPoints;

            // label precio de promocion transparente 
            lblPrecioPromocion.Parent = pbSplash;
            lblPrecioPromocion.BackColor = Color.Transparent;
            lblTagPrecioPromocion.Parent = lblPrecioPromocion;
            lblTagPrecioPromocion.BackColor = Color.Transparent;
        }
        public void CrearPanelSinConexion()
        {

             panel1 = new Panel();
             label1 = new Label();


            // Initialize the Panel control.
            panel1.Size = new Size(1100, 500);

            panel1.Location = new Point(
        this.ClientSize.Width / 2 - panel1.Size.Width / 2,
        this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            // Set the Borderstyle for the Panel to three-dimensional.
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;

            // Initialize the Label controls.
            //label1.AutoSize = false;
            //label1.Location = new Point(panel1.Location.X,panel1.Location.Y);
            label1.Text = "SIN CONEXIÓN A INTERNET, FAVOR DE REVISAR LA CONEXION Y ESCANEAR DE NUEVO.";
            label1.ForeColor = Color.Red;
            //label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Size = new Size(1748, 107);
            label1.Font = new Font("Microsoft JhengHei", 15);
            label1.Location = new Point((panel1.Width / 2) - (label1.Width / 2), (panel1.Height / 2) - (label1.Height / 2));
            label1.TextAlign = ContentAlignment.MiddleCenter;


            // Add the Panel control to the form.
            this.Controls.Add(panel1);
            // Add the Label and TextBox controls to the Panel.
            panel1.Controls.Add(label1);
            panel1.BringToFront();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // ocultar el panel del verificador para dejar solo el fondo con el codigo de barras
            this.panelVerificador.Visible = false;
            // metodo para determinar si se ejecuta en dispositivo PC o Verificador
            //this.AjustarDispositivo();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // metodo para el reajuste en el resize
            this.AjustarPantalla();
            txtCodigo.Focus();

        }

        private void ObtenerPrecioExistencia()
        {
            using (SqlConnection sqlConnection = Conexion.conectar())
            {
                using (SqlCommand command = new SqlCommand("MI_VerificaPrecioExistencia_PorProducto", sqlConnection))
                {
                    try
                    {
                        if (sqlConnection.State == ConnectionState.Closed)
                        {
                            sqlConnection.Open();
                        }

                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 0;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        command.Parameters.AddWithValue("@cod_estab", Conexion.establecimiento);
                        command.Parameters.Add("@oPrecio", SqlDbType.Real).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oPrecioPromocion", SqlDbType.Real).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oExistencia", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oDescripcion", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oImagen", SqlDbType.VarBinary, -1).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oResultado", SqlDbType.SmallInt).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oTipoBonificacion", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@oDescuento", SqlDbType.Real).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();

                        if (command.Parameters["@oResultado"].Value != System.DBNull.Value)
                        {
                            // labels
                            Int16 resultado = (Int16)command.Parameters["@oResultado"].Value;
                            if (resultado == 1)
                            {
                                float precio = (float)command.Parameters["@oPrecio"].Value;
                                float precioPromocion = (float)command.Parameters["@oPrecioPromocion"].Value;
                                int existencia = (int)command.Parameters["@oExistencia"].Value;
                                string descripcion = (string)command.Parameters["@oDescripcion"].Value;

                                // imagen
                                pbProducto.Image = null;
                                pbProducto.Update();
                                if (command.Parameters["@oImagen"].Value != System.DBNull.Value)
                                {
                                    Byte[] data = new Byte[0];
                                    data = (Byte[])(command.Parameters["@oImagen"].Value);
                                    MemoryStream mem = new MemoryStream(data);
                                    pbProducto.Image = Image.FromStream(mem);
                                    pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    this.ImagenNoDisponible();
                                }

                                lblCodigo.Text = txtCodigo.Text;
                                txtCodigo.Text = string.Empty;
                                lblPrecio.Text = String.Format("{0:C}", precio);
                                lblPrecioPromocion.Text = String.Format("{0:C}", precioPromocion);

                                if (precio.Equals(precioPromocion))
                                {
                                    lblPrecioPromocion.Visible = false;
                                    pbSplash.Visible = false;
                                }
                                else
                                {
                                    lblPrecioPromocion.Visible = true;
                                    pbSplash.Visible = true;
                                }
                                lblDescripcion.Text = descripcion.ToString();
                                lblExistencia.Text = existencia.ToString();

                                // insertar registro en Bitácora BMS
                                string query = $@"INSERT INTO bitacora_BMS 
                                (fecha, equipo, usuario, cod_estab,folio, transaccion, operacion_bitacora)
                                VALUES (GETDATE(), '{Environment.MachineName}','1','{Conexion.establecimiento}','verificador_precios','','X')";
                                SqlCommand commandInsert = new SqlCommand(query, sqlConnection);
                                commandInsert.ExecuteNonQuery();

                            }
                            else
                            {
                                this.ClearForm(txtCodigo.Text, "Producto no encontrado");
                            }
                        }
                        else
                        {
                            this.ClearForm(txtCodigo.Text, "Producto no encontrado");
                        }
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Hubo un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BitacoraBMS()
        {

        }

        private void ClearForm(string codigo = "", string descripcion = "")
        {
            lblPrecio.Text = string.Empty;
            lblPrecioPromocion.Text = string.Empty;
            lblExistencia.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            lblCodigo.Text = (codigo.Equals("")) ? string.Empty : codigo;
            lblDescripcion.Text = (descripcion.Equals("")) ? string.Empty : descripcion;
            pbProducto.Image = null;
            pbProducto.Update();
            txtCodigo.Focus();
            lblPrecioPromocion.Visible = false;
            pbSplash.Visible = false;
            txtCodigo.Focus();
        }

        private void ImagenNoDisponible()
        {
            pbProducto.Image = Properties.Resources.NO_disponible_43_7;
            pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void txtCodigo_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!VerificarConexion()) return;
                
                this.txtCodigo.Enabled = false;
                this.ObtenerPrecioExistencia();
                this.panelVerificador.Visible = true;
                await Task.Delay(5000);
                this.ClearForm();
                this.panelVerificador.Visible = false;
                this.txtCodigo.Enabled = true;
                this.txtCodigo.Focus();
            }
        }

        private void AjustarPantalla()
        {
            /* Los valores de las constantes en (factor * CONSTANTE) corresponden a el tamaño de la fuente que se la asigna en las propiedades */

            float factor = (float)this.ClientSize.Width / (float)InitialFormWidth;

            // header 
            int fontSize = Convert.ToInt32(factor * headerFontSize);
            labelHeader.Font = new Font("Arial Black", fontSize);
            // descripcion
            fontSize = Convert.ToInt32(factor * descripcionTagFontSize);
            lblDescripcionTag.Font = new Font("Microsoft Sans Serif", fontSize);
            fontSize = Convert.ToInt32(factor * descripcionFontSize);
            lblDescripcion.Font = new Font("Microsoft Sans Serif", fontSize);
            // codigo
            fontSize = Convert.ToInt32(factor * codigoTagFontSize);
            lblCodigoTag.Font = new Font("Microsoft Sans Serif", fontSize);
            fontSize = Convert.ToInt32(factor * codigoFontSize);
            lblCodigo.Font = new Font("Microsoft Sans Serif", fontSize);
            // existencia
            fontSize = Convert.ToInt32(factor * existenciaTagFontSize);
            lblExistenciaTag.Font = new Font("Microsoft Sans Serif", fontSize);
            fontSize = Convert.ToInt32(factor * existenciaFontSize);
            lblExistencia.Font = new Font("Microsoft Sans Serif", fontSize);
            // precio
            fontSize = Convert.ToInt32(factor * precioTagFontSize);
            lblPrecioTag.Font = new Font("Microsoft Sans Serif", fontSize);
            fontSize = Convert.ToInt32(factor * precioFontSize);
            lblPrecio.Font = new Font("Arial Black", fontSize);
            // promocion
            fontSize = Convert.ToInt32(factor * precioPromocionTagFontSize);
            fontSize = Convert.ToInt32(factor * precioPromocionFontSize);
            lblPrecioPromocion.Font = new Font("Arial Black", fontSize);
        }
        
        private void Form2_Resize(object sender, EventArgs e)
        {
            this.AjustarPantalla();
        }

      
        private bool VerificarConexion()
        {
            DataTable Tabla = new DataTable();
            DataRow dr = Tabla.NewRow();
            DataColumn dc = new DataColumn("Conexion", typeof(Boolean));
            Tabla.Columns.Add(dc);
            try
            {
                using (SqlConnection sqlConnection = Conexion.conectar())
                {
                    string query = "SELECT 1, GETDATE()";
                    SqlCommand commandInsert = new SqlCommand(query, sqlConnection);
                    if (Convert.ToInt16(commandInsert.ExecuteScalar()) != 1)
                    {
                        throw new InvalidCastException("ERROR DE CONEXIÓN");
                    }
                    dr["Conexion"] = true;
                    Tabla.Rows.Add(dr);

                }
            }
            catch (Exception)
            {
               
                dr["Conexion"] = false;
                Tabla.Rows.Add(dr);
            }

            if (Convert.ToString(Tabla.Rows[0].ItemArray[0]) == "False")
            {
                CrearPanelSinConexion();
                return false;
            }
            else
            {
                panel1.Dispose();
                label1.Dispose();
                //ClearForm();
                return true;
            }
        }
        private void AjustarDispositivo()
        {
            // verificador
            if (Conexion.dispositivo == "verificador")
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            // se espera que sea "pc" pero se deja cualquier otra opcion de momento
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lblTagPrecioPromocion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFooter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
