using System;
//using Comisariato.ServiceAutorizacion;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Drawing;
using System.Xml;
using System.IO;
using System.Net;
using Comisariato.Formularios;
using System.Data;

namespace Comisariato.Clases
{
    public class Funcion
    {
        public void AddFormInPanel(Form formHijo /*, Panel panelPrincipal*/)
        {
            //Form fh = formHijo as Form;
            //fh.TopLevel = false;
            //panelPrincipal.Controls.Add(fh);  
            ////panelPrincipal.Tag = fh;
            //int index = panelPrincipal.Controls.GetChildIndex(fh);
            //fh.BringToFront();
            //fh.Show();
            formHijo = new Form();
            //Form fh = (Form)formHijo;
            FrmPrincipal frmprincipal = new FrmPrincipal();
            if (formHijo == null || formHijo.IsDisposed)
            {
                formHijo = new Form();
                formHijo.MdiParent = frmprincipal;
                formHijo.BringToFront();
                formHijo.Show();

            }
            else { formHijo.BringToFront(); }
        }

        public static string fechaValida(string fecha)
        {
            string fecha1 = "";
            string[] vector = fecha.Split('/');
            if (vector[0].Length!=2)
            {
                vector[0] = "0" + vector[0];
            }
            if (vector[1].Length != 2)
            {
                vector[1] = "0" + vector[1];
            }
            fecha1 = vector[0] + "/" + vector[1] + "/" + vector[2];
            return fecha1;
        }

        public static bool ExportarDataGridViewExcel(DataGridView grd, int InicioDeColumna) //InicioDeColumna comienza desde 0
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    int iCol = 0;
                    foreach (DataGridViewColumn column in grd.Columns)
                        if (column.Visible)
                            hoja_trabajo.Cells[1, ++iCol] = column.HeaderText;
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 1; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = InicioDeColumna; j < grd.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i-1].Cells[j].FormattedValue;
                        }
                    }
                    //libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                                      System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false,
                                      Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, false, false,
                                      System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ValidarNumerosStock(DataGridViewCellValidatingEventArgs e, DataGridView Dgv)
        {
            int testInt;
            try
            {
                if (e.ColumnIndex == 2)
                {
                    if (e.FormattedValue.ToString().Length != 0)
                    {
                        if (!int.TryParse(e.FormattedValue.ToString(), out testInt))
                        {

                            Dgv.Rows[e.RowIndex].ErrorText = "La cantidad debe ser un número";
                            e.Cancel = true;
                        }
                        else
                        {
                            Dgv.Rows[e.RowIndex].ErrorText = string.Empty;
                            e.Cancel = false;
                        }
                    }


                }
            }
            catch (Exception ex)
            {

            }

        }

        public static void Validar_Letras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SinEspaciosEmail(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void Validar_Numeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void Validar_Numeros_Punto(KeyPressEventArgs e, string texto)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                string[] a = texto.Split('.');
                foreach (var item in a)
                {
                    if (item.Length >= 3)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                int ocurrenciasPuntos = texto.Split('.').Length;
                if (e.KeyChar == '.' && ocurrenciasPuntos <= 3)
                {

                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public static void validar_Num_Letras(KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SoloValores(KeyPressEventArgs e, string textBox1)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    if (textBox1.Contains(".") || textBox1 == "")
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (textBox1.Contains("."))
                        if (textBox1.Substring(textBox1.IndexOf('.') + 1).Length >= 6)
                        {
                            e.Handled = true;
                        }
                }

            }
            else
            {
                e.Handled = true;
            }

        }

        public static void ValidarLetrasPuntoNumero(KeyPressEventArgs e, string textBox1)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.')
                {
                    //if (textBox1.Contains(".") || textBox1 == "")
                    //{
                    e.Handled = false;
                    //}
                }
                //else
                //{
                //if (textBox1.Contains("."))
                //if (textBox1.Substring(textBox1.IndexOf('.') + 1).Length >= 2)
                //{
                //e.Handled = true;
                //}
                //}

            }
            else
            {
                e.Handled = true;
            }

        }


        //SOLO NUMEROS DGV
        private static void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // Si no es numerico y si no es espacio
            {
                // Invalidar la accion
                e.Handled = true;
                // Enviar el sonido de beep de windows
                System.Media.SystemSounds.Beep.Play();
            }

        }

        public static void Limpiarobjetos(GroupBox frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is MaskedTextBox)
                    item.Text = "";

                if (item is DataGridView)
                    item.Controls.Clear();
            }
        }

        public static byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        public static byte[] ConvertImg_Bytes(String ubicacion)
        {
            FileStream stream = new FileStream(ubicacion, FileMode.Open, FileAccess.Read);
            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(ubicacion);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] bitDataFoto = new byte[stream.Length];
            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
            stream.Read(bitDataFoto, 0, Convert.ToInt32(stream.Length));
            return bitDataFoto;
        }


        public static String reemplazarcaracter(String cadena)
        {
            if (cadena.Contains(","))
            {
                return cadena.Replace(",", ".");
            }
            else
            {
                return cadena;
            }
        }
        public static String reemplazarcaracterSignosNopermitidos(String cadena)
        {
            if (cadena.Contains("'"))
            {
                return cadena.Replace("'", "-");
            }
            else
            {
                return cadena;
            }
        }

        public static String reemplazarcaracterFecha(String cadena)
        {
                string[] fecha = cadena.Split('/');

                string FinalFecha = fecha[2] + "-" + fecha[1] + "-" + fecha[0];

                return FinalFecha;
        }


        public static String reemplazarcaracterViceversa(String cadena)
        {
            if (cadena.Contains("."))
            {
                return cadena.Replace(".", ",");
            }
            else
            {
                return cadena;
            }

        }

        /// Verificar Cedula
        public static bool VerificarCedula(string cedula)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;
            if (int.TryParse(cedula, out isNumeric) && cedula.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(cedula[0], cedula[1], string.Empty));
                var digitoTres = Convert.ToInt32(cedula[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(cedula[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(cedula[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        public static bool ValidaIP(string direccionIP)
        {
            try
            { IPAddress ip = IPAddress.Parse(direccionIP); }
            catch
            { return false; }

            return true;
        }
        public static void ValidaCeldasPrecios(DataGridView datosProductoCompra, int posicion, ref bool banderaFocoCelda)
        {
            try
            {
                float valor;
                string validaValores = Convert.ToString(datosProductoCompra.CurrentRow.Cells[posicion].Value);
                string[] s = validaValores.Split('.');
                if (validaValores.Substring(0, 1) == "." || validaValores.Substring(0, 1) == ",")
                {
                    validaValores = "0" + validaValores;
                }
                if (validaValores.Substring(validaValores.Length - 1, 1) == "." || validaValores.Substring(validaValores.Length - 1, 1) == ",")
                {
                    validaValores = validaValores + "0";
                }
                int ocurrencias, ocurrecias2, ocurrenciasComas;
                ocurrencias = validaValores.Split('.').Length - 1;
                ocurrenciasComas = validaValores.Split(',').Length - 1;
                ocurrecias2 = validaValores.Split(new String[] { ".," }, StringSplitOptions.None).Length - 1;
                if (ocurrencias > 1 || ocurrecias2 != 0)
                {
                    valor = float.Parse("a");
                }
                else if (ocurrencias == 0 && ocurrenciasComas == 0)
                {
                    validaValores = validaValores + ".0";
                }
                ocurrencias = validaValores.Split('.').Length - 1;
                ocurrenciasComas = validaValores.Split(',').Length - 1;
                if (ocurrencias == 0)
                {
                    s = validaValores.Split(',');
                }
                else if (ocurrenciasComas == 0)
                {
                    s = validaValores.Split('.');
                }
                string valor1 = s[1];
                if (valor1.Length > 6)
                {
                    valor = float.Parse("a");
                }
                valor = float.Parse(validaValores);
                datosProductoCompra.CurrentRow.Cells[posicion].Value = Funcion.reemplazarcaracter(validaValores);
                banderaFocoCelda = false;
            }
            catch (Exception errorPrecio)
            {
                //MessageBox.Show("Ingresar valores correctos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datosProductoCompra.CurrentRow.Cells[posicion].Value = "";
                //datosProductoCompra.BeginEdit(true);
                SendKeys.Send("{LEFT}");
                banderaFocoCelda = true;
            }
        }

        public static string[] leerArchivo(string ruta)
        {
            try
            {
                string line;
                string lineDatos = "";
                string[] VectorDatos;
                System.IO.StreamReader file =
                    new System.IO.StreamReader(ruta);
                while ((line = file.ReadLine()) != null)
                {
                    lineDatos += line + ";";

                }

                file.Close();
                if (lineDatos != "")
                {
                    VectorDatos = lineDatos.Split(';');
                    return VectorDatos;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        /// <summary>
        /// FirmaXml
        /// </summary>
        /// 

        

        private static Random rnd = new Random(DateTime.Now.Millisecond);
        public const string XmlDsigRSASHA1Url = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        public static void FirmaXML(string RutaXml, string nombrexml)
        {
            try
            {
                //Declaro variable XMLDocument
                XmlDocument xmlDoc = new XmlDocument();
                // Cargo el documento en el xmlDoc
                xmlDoc.PreserveWhitespace = true;
                //var PathServer = ConfigurationManager.AppSettings["XmlServidor"];
                var PathServer = @"C:\Users\Public\Documents\ArchivosXml";
                string pathXml = PathServer + @"\sonna_judith_vega_solis.p12";
                xmlDoc.Load(@RutaXml);
                //string soapSecNS = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
                //Obtengo la firma en el Certificado X509
                X509Certificate2 uidCert = new X509Certificate2(pathXml, "Sonnav67", X509KeyStorageFlags.DefaultKeySet);
                //string nombre = uidCert.GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType.DnsName,true);
                //Console.WriteLine(nombre);
                //Inicializo el RSA
                RSACryptoServiceProvider rsaKey = (RSACryptoServiceProvider)uidCert.PrivateKey;

                //Agrego el SgnedXml que permite firmar el xml
                SignedXml signedXml = new SignedXml(xmlDoc);

                // Add the key to the SignedXml document.
                signedXml.SigningKey = rsaKey;

                signedXml.Signature.Id = newID("Signature");


                //Agregamos el metodo de firmado
                signedXml.SignedInfo.SignatureMethod = XmlDsigRSASHA1Url;

                signedXml.SignedInfo.Id = newID("Signature-SignedInfo");

                // Create a reference to be signed.
                Reference reference = new Reference();
                //reference.Id = newID("#Certificate");
                reference.Uri = "";

                // Add an enveloped transformation to the reference.
                XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
                reference.AddTransform(env);

                // Add the reference to the SignedXml object.
                signedXml.AddReference(reference);


                // Add an RSAKeyValue KeyInfo (optional; helps recipient find key to validate).
                KeyInfo keyInfo = new KeyInfo();

                KeyInfoX509Data clause = new KeyInfoX509Data();
                clause.AddSubjectName(uidCert.Subject);
                clause.AddCertificate(uidCert);
                keyInfo.AddClause(clause);

                keyInfo.Id = newID("Certificate1");

                signedXml.KeyInfo = keyInfo;

                // Compute the signature.
                signedXml.ComputeSignature();


                Boolean respuesta = signedXml.CheckSignature();
                System.Console.WriteLine(respuesta);

                // Get the XML representation of the signature and save
                // it to an XmlElement object.
                XmlElement xmlDigitalSignature = signedXml.GetXml();


                //XmlElement signature = signedXml.GetXml();
                foreach (XmlNode node in xmlDigitalSignature.SelectNodes(
                    "descendant-or-self::*[namespace-uri()='http://www.w3.org/2000/09/xmldsig#']"))
                {
                    node.Prefix = "ds";
                }


                System.Console.WriteLine(signedXml.GetXml().InnerXml);
                // Append the element to the XML document.
                xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));


                //Preguntar sobre el directorio

                if (!Directory.Exists(PathServer + @"\Firmados\"))
                {
                    Directory.CreateDirectory(PathServer + @"\Firmados\");
                }


                xmlDoc.Save(@PathServer + @"\Firmados\" + @"\"+ nombrexml + ".xml");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.ReadLine();
            }
        }
        private static String newID(String prefix)
        {
            String newID = prefix + rnd.Next(1048576);
            newID = prefix + rnd.Next(1048576);
            return newID;
        }

        public static string FormarFecha(string fecha)
        {
            //Dia-Mes-Año
            string [] arregloFecha = fecha.Split('/');
            //dia
            if (arregloFecha[0].Length < 2)
            {
                arregloFecha[0] = "0" + arregloFecha[0];
            }
            //Mes
            if (arregloFecha[1].Length < 2)
            {
                arregloFecha[1] = "0" + arregloFecha[1];
            }

            return arregloFecha[0] + "/" + arregloFecha[1] + "/" + arregloFecha[2];
        }
        public static string FormarFechaGuiones(string fecha)
        {
            //Dia-Mes-Año
            string[] arregloFecha = fecha.Split('-');
            //dia
            if (arregloFecha[0].Length < 2)
            {
                arregloFecha[0] = "0" + arregloFecha[0];
            }
            //Mes
            if (arregloFecha[1].Length < 2)
            {
                arregloFecha[1] = "0" + arregloFecha[1];
            }

            return arregloFecha[2] + "-" + arregloFecha[1] + "-" + arregloFecha[0];
        }
        public static string FormarFechaperiodoFiscal(string fecha)
        {
            //Dia-Mes-Año
            string[] arregloFecha = fecha.Split('/');
            //MES
            if (arregloFecha[0].Length < 2)
            {
                arregloFecha[0] = "0" + arregloFecha[0];
            }

            return arregloFecha[0] + "/" + arregloFecha[1];
        }
        public static DataTable llenarDataTable_Datagriview(DataGridView datagrid)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Doc", typeof(int));
                dt.Columns.Add("Xml", typeof(String));
                dt.Columns.Add("Fecha", typeof(String));
                dt.Columns.Add("Procesado", typeof(String));
                dt.Columns.Add("RecepcionSRI", typeof(String));
                dt.Columns.Add("AutorizacionSRI", typeof(String));
                dt.Columns.Add("CodigoError", typeof(String));
                dt.Columns.Add("MensajeError", typeof(String));
                dt.Columns.Add("InformacionAdicional", typeof(String));
                dt.Columns.Add("EstadoAutorizacion", typeof(Boolean));

                if (datagrid.RowCount >= 1)
                {
                    foreach (DataGridViewRow rowGrid in datagrid.Rows)
                    {
                        if (rowGrid.Cells[0] != null)
                        {
                            DataRow row = dt.NewRow();
                            row["Doc"] = Convert.ToInt32(rowGrid.Cells[0].Value);
                            row["Xml"] = rowGrid.Cells[1].Value.ToString();
                            row["Fecha"] = rowGrid.Cells[2].Value.ToString();
                            row["Procesado"] = rowGrid.Cells[3].Value.ToString();
                            row["RecepcionSRI"] = rowGrid.Cells[4].Value.ToString();
                            row["AutorizacionSRI"] = rowGrid.Cells[5].Value.ToString();
                            row["CodigoError"] = rowGrid.Cells[6].Value.ToString();
                            row["MensajeError"] = rowGrid.Cells[7].Value.ToString();
                            row["InformacionAdicional"] = rowGrid.Cells[8].Value.ToString();
                            row["EstadoAutorizacion"] = Convert.ToBoolean(rowGrid.Cells[9].Value);
                            dt.Rows.Add(row);
                        }
                    }
                    return dt;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static void dosDecimales(ref DataGridView dgv, int inicio, int fin, int celdaInicial)
        {
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (Convert.ToString(dgv.Rows[i].Cells[celdaInicial].Value) != "")
                {
                    for (int j = inicio; j < fin; j++)
                    {
                        dgv.Rows[i].Cells[j].Value = Funcion.reemplazarcaracter(Math.Round(Convert.ToSingle(Funcion.reemplazarcaracterViceversa(dgv.Rows[i].Cells[j].Value.ToString())), 2).ToString("#####0.00"));
                        dgv.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (Convert.ToString(dgv.Rows[i + 1].Cells[celdaInicial].Value) == "")
                        break;
                }
            }
        }
        public static void llenarDGV(ref DataGridView dgv, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
                dgv.Rows.Add();
        }
        
        public static void ComboAutoCompletable(ComboBox cb)
        {
            Consultas consultas = new Consultas();
            DataTable dt = (DataTable)cb.DataSource;
            cb.AutoCompleteCustomSource = consultas.LoadAutoComplete(dt);
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
