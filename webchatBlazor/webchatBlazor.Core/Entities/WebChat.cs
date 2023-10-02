namespace webchatBlazor.Core.Entities
{
    public class WebChat
    {
        public int? IdChat { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public bool ArquivoEmAnexo { get; set; } = false;

        public WebChat() { }


        public WebChat(int idChat, string pergunta, string resposta)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
        }

        public WebChat(int idChat, string pergunta, string resposta, bool anexo)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
            ArquivoEmAnexo = anexo;
        }

        public string StatusArquivoEmAnexo

        {
            get
            {
                return ArquivoEmAnexo == true ? "Sim" : "Não";
            }
        }
    }
}
