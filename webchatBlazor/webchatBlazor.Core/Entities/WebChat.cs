using System;

namespace webchatBlazor.Core.Entities
{
    public class WebChat
    {
        public int? IdChat { get; set; }
        public string NomeCliente { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; } = false;

        public DateTime DataConversa { get; set; } = DateTime.Now;

        public bool InteracaoUsuario { get; set; } = false; 

        public WebChat() { }


        public WebChat(int idChat, string pergunta, string resposta)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
        }

        public WebChat(int idChat, string pergunta, string resposta, bool interacaoUsuario)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
            InteracaoUsuario = interacaoUsuario;
        }

        public WebChat(int idChat, string pergunta, string resposta, bool statusConversa, bool interacaoUsuario)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
            InteracaoUsuario = interacaoUsuario;
            Status = statusConversa;
        }

        public string StatusConversa

        {
            get
            {
                return Status == true ? "Sim" : "Não";
            }
        }

        public string HoraComMinuto
        {
            get
            {
                string formatoPersonalizado = "HH:mm"; 
                string horaEMinuto = DataConversa.ToString(formatoPersonalizado);
                return horaEMinuto;
            }
        }
    }
}
