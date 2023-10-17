using System.Collections.Generic;
using webchatBlazor.Business.Interface.Managers;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;
using webchatBlazor.Util;

namespace webchatBlazor.Business.Conversas
{
    public class ConversaManager : IConversaManager
    {
        private readonly IWebChatRepositorio  _conversaRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ConversaManager(IWebChatRepositorio conversaRepositorio, IClienteRepositorio clienteRepositorio)
        {
            _conversaRepositorio = conversaRepositorio;
            _clienteRepositorio = clienteRepositorio;
        }
        public bool AdicionarConversa(WebChat conversa)
        {
           return _conversaRepositorio.AdicionarConversa(conversa);
        }

        public bool AtualizarConversa(WebChat conversaAtualizada)
        {
            return _conversaRepositorio.AdicionarConversa(conversaAtualizada);
        }

        public bool DeletarConversa(int id)
        {
            return _conversaRepositorio.DeletarConversa(id);
        }

        public List<string> ComboxNomeCliente()
        {
           return _clienteRepositorio.ListarNomesClientes();
        }

        public IEnumerable<WebChat> ProcuraConversa(string filter = null)
        {
            return _conversaRepositorio.BuscarConversas(filter);
        }

        public WebChat RealizaPergunta(string pergunta)
        {
            WebChat webChat = new();
            Cliente cliente = new();
            string nome = string.Empty;
            string resposta = string.Empty;

            if (Validacao.ValidarCPF(pergunta))
            {
                long cpf = long.Parse(pergunta);
                cliente = _clienteRepositorio.BuscarClientePorCPF(cpf);

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
                webChat = _conversaRepositorio.BuscarConversaPorPergunta(pergunta);
            }

            return webChat;
        }

        public WebChat BuscarConversaPorId(int id)
        {
            return _conversaRepositorio.BuscarConversaPorId(id);
        }
    }
}
