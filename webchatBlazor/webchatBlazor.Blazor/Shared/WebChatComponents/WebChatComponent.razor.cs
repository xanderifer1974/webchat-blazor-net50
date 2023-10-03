using Microsoft.AspNetCore.Components;
using System;
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

       //private List<string> Mensagens {get; set;}

       private List<WebChat> ListaMensagens { get; set;}


       private string HoraMensagem { get; set; }

       public string mensagem = "";

        protected override void OnInitialized()
        {
            base.OnInitialized();
            //Mensagens = new List<string>();
            ListaMensagens = new List<WebChat>();
        }

        private void EnviarMensagem()
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                ListaMensagens.Add(new WebChat { Pergunta = $"Você: {mensagem}", InteracaoUsuario = true });            
                             
                WebChat chat = webChatService.BuscarConversaPorPergunta(mensagem);
                ListaMensagens.Add(chat);
                                
                //DateTime agora = DateTime.Now;
                //string formatoPersonalizado = "HH:mm"; // HH para horas em formato de 24 horas e mm para minutos
                //string horaEMinuto = agora.ToString(formatoPersonalizado);
                //HoraMensagem = horaEMinuto;
                mensagem = ""; // Limpar a caixa de entrada após o envio
            }
        }
    }
}
