using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Iris
{
    public partial class frmMain : Form
    {

        // Control general
        Boolean b_enviado;
        Boolean b_consulta;
        wsOpinat.appmoduleswscontrollersApiSoapControllerPortClient npsCliente;     
        DataSet dsData;
        string sToken;
        string sUsuario;
        string sPassword;
        String sds;
        int nEnviados;
        int nProcesados;
        int nRechazados;
        int nOk;

        // Mensajes
        String sCenter_id;
        String sWave_id;
        String sCampaign_id;
        String sInternal_code;
        String sEmail;
        String sPhone;
        String sCitdoc;
        String sLang;
        String sName;
        String sField01;
        String sField02;
        String sField03;
        String sField04;
        String sField05;
        String sField06;
        String sField07;
        String sField08;
        String sField09;
        String sField10;
        String sInternal_data_field;
        String sRetorno_Procesado;
                
        public frmMain()
        {
            InitializeComponent();
        }

        private void InicializarUser()
        {
            sUsuario = ConfigurationManager.AppSettings["user_opinat"].Trim();
            sPassword = ConfigurationManager.AppSettings["pass_opinat"].Trim();
        }

        private void InicializarToken()
        {
            sToken = string.Empty;

        }

        private void InicializarContadores()
        {
            nProcesados = 0;
            nOk = 0;
            nRechazados = 0;
            nEnviados = 0;
        }

        private void InicializarVariables()
        {
            b_enviado = false;
            b_consulta = false;
            sds = string.Empty;
            sCenter_id = string.Empty;
            sWave_id = string.Empty;
            sCampaign_id = string.Empty;
            sInternal_code = string.Empty;
            sEmail = string.Empty;
            sPhone = string.Empty;
            sCitdoc = string.Empty;
            sLang = string.Empty;
            sName = string.Empty;
            sField01 = string.Empty;
            sField02 = string.Empty;
            sField03 = string.Empty;
            sField04 = string.Empty;
            sField05 = string.Empty;
            sField06 = string.Empty;
            sField07 = string.Empty;
            sField08 = string.Empty;
            sField09 = string.Empty;
            sField10 = string.Empty;
            sInternal_data_field = string.Empty;
            sRetorno_Procesado = string.Empty;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - Ver. " + Application.ProductVersion;
            lblActivodesde.Text = "Activo desde: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InicializarContadores();
            InicializarVariables();
            InicializarUser();

            // Inicializa el timer en 15 segundos
            timerMain.Interval = 15000;
            timerMain.Start();
        }

        private void ActualizarContadores()
        {
            lblEnviados.Text = string.Format("{0:#,##0}", nEnviados);
            lblOk.Text = string.Format("{0:#,##0}", nOk);
            lblProcesados.Text = string.Format("{0:#,##0}", nProcesados);
            lblRechazados.Text = string.Format("{0:#,##0}", nRechazados);
        }

        private void CrearLlave()
        {

            sToken = string.Empty;
            npsCliente = new wsOpinat.appmoduleswscontrollersApiSoapControllerPortClient();

            try
            {
                // Producción
                sToken = npsCliente.apiLogin(sUsuario, sPassword);
                
                // Prueba de login
                sToken = npsCliente.apiLogin(sUsuario, sPassword);

            }
            catch (Exception e)
            {
                sToken = "No Token";
                lblEncuesta1.Text = e.InnerException.Message;
            }
            finally
            {

            }

        }

        private void EnviarEncuesta(string sXML)
        {
            string sRespuesta;
            npsCliente = new wsOpinat.appmoduleswscontrollersApiSoapControllerPortClient();

            try
            {               
                sRespuesta = npsCliente.apiTestWithoutLogin(sXML);
            }
            catch (Exception e)
            {
                sRespuesta = e.InnerException.Message;
            }
            finally
            {

            }
            
            // Para prueba
            lblEncuesta1.Text = sRespuesta;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método auxiliar para lectura y limpieza segura de datos
        private string ObtenerValorSeguro(DataRow row, string columnName)
        {
            // Si la columna es nula en la BD, retorna un string vacío
            if (row.IsNull(columnName)) return string.Empty;
        
            string valor = row.Field<string>(columnName);
            if (string.IsNullOrEmpty(valor)) return string.Empty;
        
            // Aplica Trim y escapa caracteres especiales para no romper el XML
            return System.Security.SecurityElement.Escape(valor.Trim());
        }
        
        private string LlenaXML(ref DataSet dsData)
        {
            // Usamos StringBuilder para un mejor rendimiento en el manejo de memoria
            StringBuilder Retorno = new StringBuilder();
        
            // Corrección: i < Count (eliminado el "- 1" para no omitir la última fila)
            for (int i = 0; i < dsData.Tables[0].Rows.Count; i++)
            {
                DataRow fila = dsData.Tables[0].Rows[i];
        
                // Corrección: Usamos .Append() para concatenar en lugar de sobrescribir
                Retorno.Append("<survey>");
                Retorno.Append("<wave_id>").Append(ObtenerValorSeguro(fila, "wave_id")).Append("</wave_id>");
                Retorno.Append("<internal_code>").Append(ObtenerValorSeguro(fila, "internal_code")).Append("</internal_code>");
                Retorno.Append("<email>").Append(ObtenerValorSeguro(fila, "email")).Append("</email>");
                Retorno.Append("<phone>").Append(ObtenerValorSeguro(fila, "phone")).Append("</phone>");
                Retorno.Append("<lang>").Append(ObtenerValorSeguro(fila, "lang")).Append("</lang>");
                Retorno.Append("<name>").Append(ObtenerValorSeguro(fila, "name")).Append("</name>");
                Retorno.Append("<field01>").Append(ObtenerValorSeguro(fila, "field01")).Append("</field01>");
                Retorno.Append("<field02>").Append(ObtenerValorSeguro(fila, "field02")).Append("</field02>");
                Retorno.Append("<field03>").Append(ObtenerValorSeguro(fila, "field03")).Append("</field03>");
                Retorno.Append("<field04>").Append(ObtenerValorSeguro(fila, "field04")).Append("</field04>");
                Retorno.Append("<field05>").Append(ObtenerValorSeguro(fila, "field05")).Append("</field05>");
                Retorno.Append("<field06>").Append(ObtenerValorSeguro(fila, "field06")).Append("</field06>");
                Retorno.Append("<field07>").Append(ObtenerValorSeguro(fila, "field07")).Append("</field07>");
                Retorno.Append("<field08>").Append(ObtenerValorSeguro(fila, "field08")).Append("</field08>");
                Retorno.Append("<field09>").Append(ObtenerValorSeguro(fila, "field09")).Append("</field09>");
                Retorno.Append("<field10>").Append(ObtenerValorSeguro(fila, "field10")).Append("</field10>");
                Retorno.Append("<internal_data_field>").Append(ObtenerValorSeguro(fila, "internal_data_field")).Append("</internal_data_field>");
                Retorno.Append("</survey>");
            }
        
            return Retorno.ToString();
        }

        private string TerminaXML(string sMensaje )
        {

            string Retorno;

            Retorno = string.Empty;

            // Termina el mensa<je
            Retorno = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            Retorno = "<load>" + sMensaje;
            Retorno += "</load>";            
            
            return Retorno;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CrearLlave();
            EnviarEncuesta("Esta es una prueba de envío de texto");
        }
    }
}
