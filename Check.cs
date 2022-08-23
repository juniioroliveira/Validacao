using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Validacao
{
    public class Check
    {
        #region VERIFICAR CONEXÃO
        //Método da API
        [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);

        // Um método que verifica se esta conectado
        public static Boolean IsConnected()
        {
            int Description;
            return InternetGetConnectedState(out Description, 0);
        }
        #endregion

        public static Tuple<Retorno, string> Update(string myPrograma = null, string currentVersion = null)
        {
            string path = Directory.GetCurrentDirectory() + "\\pooBin.dll";
            string date2 = null;

            if (IsConnected())
            {
                #region CARREGAR DADOS

                DateTime hoje = DateTime.Now;


                var Cliente = new WebClient();
                var json = Cliente.DownloadString("https://pastebin.com/raw/bYcMxLsD");

                Programas.programasList = new();
                Programas.getArquivoName = new();
                Programas.getLinkDownload = new();
                Programas.getValidade = new();
                Programas.getVersao = new();

                Programas.programasList = JsonConvert.DeserializeObject<List<Programas>>(json);

                var getVersao = Programas.getVersao[myPrograma];
                var getValidade = Programas.getValidade[myPrograma];
                var getLink = Programas.getLinkDownload[myPrograma] + ";" + Programas.getArquivoName[myPrograma];

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                if (getVersao == currentVersion)
                {
                    var resul = DateTime.Compare(hoje, Convert.ToDateTime(getValidade));
                    if (resul >= 0)
                    {
                        return new Tuple<Retorno, string>(Retorno.LicencaVencida, string.Empty);
                    }
                    else
                    {
                        return new Tuple<Retorno, string>(Retorno.Liberado, string.Empty);
                    }
                }
                else
                {
                    return new Tuple<Retorno, string>(Retorno.VersaoDesatualizada, getLink);
                }

                #endregion
            }
            else
            {
                if (File.Exists(path))
                {
                    string text = System.IO.File.ReadAllText(path);
                    date2 = text;
                }
                else
                {
                    File.Create(path).Close();

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        DateTime date = DateTime.Now.AddDays(5);
                        sw.WriteAsync(date.ToShortDateString());
                    }

                    string text = System.IO.File.ReadAllText(path);
                    date2 = text;
                }

                return new Tuple<Retorno, string>(Retorno.Liberado, string.Empty);
            }
            return new Tuple<Retorno, string>(Retorno.Liberado, string.Empty);
        }
    }


    public enum Retorno
    {
        Liberado,
        LicencaVencida,
        VersaoDesatualizada
    }
}
