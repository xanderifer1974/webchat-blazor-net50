﻿using System.Collections.Generic;
using webchatBlazor.Business.Clientes.Interfaces;
using webchatBlazor.Business.Conversas.Interfaces;
using webchatBlazor.Core.Entities;
using webchatBlazor.Service.Interface;
using webchatBlazor.Util;

namespace webchatBlazor.Service
{
    public class WebChatService : IWebChatService
    {
       
        private readonly IConversaManager _conversaManager;
        private readonly IClienteManager _clienteManager;

        public WebChatService( IConversaManager conversaManager, IClienteManager cliente)
        {       
         
            _conversaManager = conversaManager;
            _clienteManager = cliente;

        }

        public bool AdicionarConversa(WebChat conversa)
        {
            return _conversaManager.AdicionarConversa(conversa);
        }

        public bool AtualizarConversa(WebChat conversaAtualizada)
        {
            return _conversaManager.AtualizarConversa(conversaAtualizada);
        }

        public WebChat BuscarConversaPorPergunta(string pergunta)
        {
            WebChat webChat = new();
            Cliente cliente = new();
            string nome = string.Empty;
            string resposta = string.Empty;

            if (Validacao.ValidarCPF(pergunta))
            {
                long cpf = long.Parse(pergunta);
                cliente = _clienteManager.BuscarClientePorCPF(cpf);

                if (cliente != null)
                {
                    nome = cliente.Nome;

                    resposta = $"Funny: <h6>Olá <b>{nome}</b>, escolha uma das opções abaixo.</h6>" +
                        $"<ul><li>01 – Alterar pacote de canais</li>" +
                        $"<li>02 – Alterar dados cadastrais</li>" +
                        $"<li>03 – Solicitar um novo ponto</li>" +
                        $"<li>04 – Alterar endereço da assinatura</li>" +
                        $"<li>05 – Solicitar segunda via da fatura</li>" +
                        $"<li>06 – Renegociar dívida</li>" +
                        $"<li>07 – Cancelar assinatura</li>" +
                        $"<li>08 - Falar com um atendente</li></ul>";

                    webChat.Resposta = resposta;
                }
                else
                {
                    resposta = "Funny: Não encontramos seu CPF em nossas bases de cadastro. Favor informar um CPF válido.";
                    webChat.Resposta = resposta;
                }

            }
            else
            {
                webChat = _conversaManager.RealizaPergunta(pergunta);
            }

            return webChat;
        }

        public IEnumerable<WebChat> BuscarConversas(string filter = null)
        {
           return _conversaManager.ProcuraConversa(filter);
        }

        public bool DeletarConversa(int id)
        {
           return _conversaManager.DeletarConversa(id);
        }
    }
}
