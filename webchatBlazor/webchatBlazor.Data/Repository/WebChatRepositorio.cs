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
            WebChat conversa1 = new(01, "01", $"Funny: <h6>Alterar Pacotes de Canais:</h6>" +
                       $"<ul><li>101 – Pacote Full</li>" +
                       $"<li>102 – Pacote Filmes</li>" +
                       $"<li>103 -  Pacote Básico</li>" +
                       $"</ul>");
            WebChat conversa2 = new(2, "101", "Funny: Você escolheu o <b>Pacote Full</b>. Iremos providenciar a alteração.");
            WebChat conversa3 = new(3, "102", "Funny: Você escolheu o <b>Pacote Filmes</b>. Iremos providenciar a alteração.");
            WebChat conversa4 = new(4, "103", "Funny: Você escolheu o <b>Pacote Básico</b>. Iremos providenciar a alteração.");
            WebChat conversa5 = new(5, "02", $"Funny: <h6>Alterar dados cadastrais:</h6>" +
                        $"<ul><li>201 – Nome</li>" +
                        $"<li>202 – RG</li>" +
                        $"<li>203 - CPF</li>" +
                        $"<li>204 - Telefone</li>" +
                        $"<li>205 - Endereço</li>" +
                        $"</ul>");
            WebChat conversa6 = new(6, "201", "Funny: Você escolheu o <b> Alteração do Nome</b>.Iremos prosseguir com a alteração.");
            WebChat conversa7 = new(7, "202", "Funny: Você escolheu o <b> Alteração do RG</b>.Iremos prosseguir com a alteração.");
            WebChat conversa8 = new(8, "203", "Funny: Você escolheu o <b> Alteração do CPF</b>.Iremos prosseguir com a alteração.");
            WebChat conversa9 = new(9, "204", "Funny: Você escolheu o <b> Alteração do Telefone</b>.Iremos prosseguir com a alteração.");
            WebChat conversa10 = new(10, "205", "Funny: Você escolheu o <b> Alteração do Endereço</b>.Iremos prosseguir com a alteração.");
            WebChat conversa11 = new(11, "03", "Funny: Iremos enviar um técnico para a instalação do novo ponto.");
            WebChat conversa12 = new(12, "04", $"Funny: <h6>Informe os seguintes dados para alterar endereço de assinatura:</h6>" +
                        $"<ul>" +
                        $"<li> => CEP do Novo Endereço</li>" +
                        $"<li> => Número da Rua e Dados do Novo Endereço</li>" +
                        $"<li> => Enviar o Comprovante de Residência</li>" +                       
                        $"</ul>");
            WebChat conversa13 = new(13, "Dados enviados.", "Funny: Endereço da assinatura alterado com sucesso!!");
            WebChat conversa14 = new(14, "05", "Funny: Informe o mês e ano no seguinte formato {mm/yyyy}, para que possamos enviar a seguinda via");
            WebChat conversa15 = new(15, "Mês e ano informados.", "Funny: A segunda via da fatura foi enviada para o e-mail cadastrado.");
            WebChat conversa16 = new(16, "06", "Funny: Estaremos te encaminhando para um atendente do departamento financeiro. Favor aguardar");
            WebChat conversa17 = new(17, "07", "Funny: Sua assinatura foi cancelada, enviaremos um e-mail com os dados de cancelamento");
            WebChat conversa18 = new(18, "08", "Funny: Estaremos te encaminhando para algum atendente. Favor aguardar....");          
            WebChat conversa19 = new(19, "Sim", "Funny: Iremos te encaminhar para um atendente, aguarde...");
            WebChat conversa20 = new(20, "Não", "Funny: Obrigado por entrar em contato. Qualquer coisa, estamos a sua disposição.");
           

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
            webChats.Add(conversa14);
            webChats.Add(conversa15);
            webChats.Add(conversa16);
            webChats.Add(conversa17);
            webChats.Add(conversa18);
            webChats.Add(conversa19);
            webChats.Add(conversa20);
          
           

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
                chat.Resposta = $"Funny: Recebemos o arquivo {nomeArquivo} com sucesso!";

            }
            else
            {
                chat = PesquisarPergunta(chat);

            }


            return chat;
        }

        public IEnumerable<WebChat> BuscarConversas(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return webChats;
            return webChats.Where(x => x.Pergunta.ToLower().Contains(filter.ToLower()));
           
        }

        private WebChat PesquisarPergunta(WebChat chat)
        {
            var result = webChats.Where(e => e.Pergunta.ToUpper().Equals(chat.Pergunta.ToUpper())).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            else
            {
                chat.Resposta = "Funny: Opção escolhida inválida, deseja falar com um atendente?";
                return chat;
            }

        }
    }
}
