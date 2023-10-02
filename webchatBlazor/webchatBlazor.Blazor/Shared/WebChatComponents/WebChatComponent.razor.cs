using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;

namespace webchatBlazor.Blazor.Shared.WebChatComponents
{
    public partial class WebChatComponent
    {
        [Inject] 
        public IWebChatService webChatService {get; set;}


        [Parameter]
        public string TituloChat { get; set; }

       private List<string> Mensagens {get; set;}

       public string mensagem = "";

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Mensagens = new List<string>();
        }

        private void SendMessage()
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                Mensagens.Add($"Você: {mensagem}");
               
                WebChat chat = webChatService.BuscarConversaPorPergunta(mensagem);
                Mensagens.Add($"API: {chat.Resposta}");

                mensagem = ""; // Limpar a caixa de entrada após o envio
            }
        }
    }
}
