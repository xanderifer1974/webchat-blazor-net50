using System;
using System.Collections.Generic;
using System.Linq;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;

namespace webchatBlazor.Data.Repository
{
    public class WebChatRepositorio : IWebChatRepositorio
    {

        private List<WebChat> webChats;

        public WebChatRepositorio()
        {
            webChats = new List<WebChat>();
            WebChat conversa1 = new WebChat(01, "01", $"<h6>Alterar Pacotes de Canais:</h6>" +
                       $"<ul><li>101 – Pacote Full</li>" +
                       $"<li>102 – Pacote Filmes</li>" +
                       $"<li>103 -  Pacote Básico</li>" +
                       $"</ul>");
            WebChat conversa2 = new WebChat(2, "101", "Você escolheu o <b>Pacote Full</b>. Iremos providenciar a alteração.");
            WebChat conversa3 = new WebChat(3, "102", "Você escolheu o <b>Pacote Filmes</b>. Iremos providenciar a alteração.");
            WebChat conversa4 = new WebChat(4, "103", "Você escolheu o <b>Pacote Básico</b>. Iremos providenciar a alteração.");
            WebChat conversa5 = new WebChat(5, "02", $"<h6>Alterar dados cadastrais:</h6>" +
                        $"<ul><li>201 – Nome</li>" +
                        $"<li>202 – RG</li>" +
                        $"<li>203 - CPF</li>" +
                        $"<li>204 - Telefone</li>" +
                        $"<li>205 - Endereço</li>" +
                        $"</ul>");
            WebChat conversa6 = new WebChat(6, "201", "Você escolheu o <b> Alteração do Nome</b>.Iremos prosseguir com a alteração.");
            WebChat conversa7 = new WebChat(7, "202", "Você escolheu o <b> Alteração do RG</b>.Iremos prosseguir com a alteração.");
            WebChat conversa8 = new WebChat(8, "203", "Você escolheu o <b> Alteração do CPF</b>.Iremos prosseguir com a alteração.");
            WebChat conversa9 = new WebChat(9, "204", "Você escolheu o <b> Alteração do Telefone</b>.Iremos prosseguir com a alteração.");
            WebChat conversa10 = new WebChat(10, "205", "Você escolheu o <b> Alteração do Endereço</b>.Iremos prosseguir com a alteração.");
            WebChat conversa11 = new WebChat(11, "Sim", "Iremos te encaminhar para um atendente, aguarde...");
            WebChat conversa12 = new WebChat(12, "Não", "Obrigado por entrar em contato. Qualquer coisa, estamos a sua disposição.");
            WebChat conversa13 = new WebChat(13, "Gostaria de atualizar os dados de cadastro.", "Favor nos enviar os dados em arquivo. ");

            webChats.Add(conversa1);
            webChats.Add(conversa2);
            webChats.Add(conversa3);
            webChats.Add(conversa4);
            webChats.Add(conversa5);
            webChats.Add(conversa6);
            webChats.Add(conversa7);
            webChats.Add(conversa8);
            webChats.Add(conversa9);
            webChats.Add(conversa10);
            webChats.Add(conversa11);
            webChats.Add(conversa12);
            webChats.Add(conversa13);

        }

        public WebChat BuscarConversaPorPergunta(string pergunta)
        {
            WebChat chat = new WebChat();
            chat.Pergunta = pergunta;
            string nomeArquivo = "";

            if (pergunta.StartsWith("Arquivo selecionado:"))
            {
                int indiceDoisPontos = pergunta.IndexOf(':');

                if (indiceDoisPontos != -1 && indiceDoisPontos < pergunta.Length - 1)
                {
                    nomeArquivo = pergunta.Substring(indiceDoisPontos + 1).Trim();

                }

                chat.Pergunta = pergunta;
                chat.Resposta = $"Recebemos o arquivo {nomeArquivo} com sucesso!";

            }
            else
            {
                chat = pesquisarPergunta(chat);

            }


            return chat;
        }

        public IEnumerable<WebChat> BuscarConversas(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return webChats;

            return webChats.Where(x => x.Pergunta.ToLower().Contains(filter.ToLower()));
        }

        private WebChat pesquisarPergunta(WebChat chat)
        {
            var result = webChats.Where(e => e.Pergunta.ToUpper().Equals(chat.Pergunta.ToUpper())).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            else
            {
                chat.Resposta = "Opção escolhida inválida, deseja falar com um atendente?";
                return chat;
            }

        }
    }
}
