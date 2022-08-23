using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacao
{
    internal class Programas
    {
        public static List<Programas> programasList = new();
        public static Dictionary<string, string> getValidade = new Dictionary<string, string>();
        public static Dictionary<string, string> getVersao = new Dictionary<string, string>();
        public static Dictionary<string, string> getLinkDownload = new Dictionary<string, string>();
        public static Dictionary<string, string> getArquivoName = new Dictionary<string, string>();

        private string _programa { get; set; }
        public string Programa
        {
            get { return _programa; }
            set { _programa = value; }
        }


        private string _versao;
        public string Versao
        {
            get { return _versao; }
            set { _versao = value; }
        }

        private string _chave;
        public string Chave
        {
            get { return _chave; }
            set { _chave = value; }
        }

        private bool _status;
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _validade;
        public string Validade
        {
            get { return _validade; }
            set { _validade = value; }
        }

        private string _linkDownload;
        public string LinkDownload
        {
            get { return _linkDownload; }
            set { _linkDownload = value; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public Programas(string programa, string versao, string chave, bool status, string validade, string linkDownload, string fileName)
        {
            if (status)
            {
                Programa = programa;
                Versao = versao;
                Chave = chave;
                Status = status;
                Validade = validade;
                LinkDownload = linkDownload;
                FileName = fileName;

                getValidade.Add(programa, validade);
                getVersao.Add(programa, versao);
                getLinkDownload.Add(programa, linkDownload);
                getArquivoName.Add(programa, fileName);
            }
        }


    }
}
