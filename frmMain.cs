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

        private string LlenaXML(ref DataSet dsData)
        {

            string Retorno;
            string sCad;

            Retorno = string.Empty;

            for (int i = 0; i < dsData.Tables[0].Rows.Count - 1; i++)
            {

                Retorno = "<survey>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("wave_id").Trim();
                Retorno += "<wave_id>" + sCad + "</wave_id>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("internal_code").Trim();
                Retorno += "<internal_code>" + sCad + "</internal_code>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("email").Trim();
                Retorno += "<email>" + sCad + "</email>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("phone").Trim();
                Retorno += "<phone>" + sCad + "</phone>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("lang").Trim();
                Retorno += "<lang>" + sCad + "</lang>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("name").Trim();
                Retorno += "<name>" + sCad + "</name>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field01").Trim();
                Retorno += "<field01>" + sCad + "</field01>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field02").Trim();
                Retorno += "<field02>" + sCad + "</field02>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field03").Trim();
                Retorno += "<field03>" + sCad + "</field03>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field04").Trim();
                Retorno += "<field04>" + sCad + "</field04>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field05").Trim();
                Retorno += "<field05>" + sCad + "</field05>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field06").Trim();
                Retorno += "<field06>" + sCad + "</field06>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field07").Trim();
                Retorno += "<field07>" + sCad + "</field07>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field08").Trim();
                Retorno += "<field08>" + sCad + "</field08>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field09").Trim();
                Retorno += "<field09>" + sCad + "</field09>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("field10").Trim();
                Retorno += "<field10>" + sCad + "</field10>";
                sCad = dsData.Tables[0].Rows[i].Field<string>("internal_data_field").Trim();
                Retorno += "<internal_data_field>" + sCad + "</internal_data_field>";
                Retorno += "</survey>";

            }

            return Retorno;

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
