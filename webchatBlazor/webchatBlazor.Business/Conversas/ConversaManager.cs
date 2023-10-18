using System.Collections.Generic;
using System.Text.RegularExpressions;
using webchatBlazor.Business.Interface.Managers;
using webchatBlazor.Business.Interface.Repositorios;
using webchatBlazor.Core.Entities;
using webchatBlazor.Util;

namespace webchatBlazor.Business.Conversas
{
    public class ConversaManager : IConversaManager
    {
        private readonly IWebChatRepositorio _conversaRepositorio;
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

            if (Regex.IsMatch(Validacao.RetirarPontosETracosCPF(pergunta), @"^\d+$"))
            {
                if (Validacao.ValidarCPFFake(pergunta))
                {
                    string cpfSemFormatacao = Validacao.RetirarPontosETracosCPF(pergunta);

                    long cpf = long.Parse(cpfSemFormatacao);
                    cliente = _clienteRepositorio.BuscarClientePorCPF(cpf);

                    if (cliente != null)
                    {
                        nome = cliente.Nome;

                        resposta = $"Funny: <h6>Olá <b>{nome}</b>, escolha uma das opções abaixo.</h6>" +
                            $"<ul><li>MN-01 – Alterar pacote de canais</li>" +
                            $"<li>MN-02 – Alterar dados cadastrais</li>" +
                            $"<li>MN-03 – Solicitar um novo ponto</li>" +
                            $"<li>MN-04 – Alterar endereço da assinatura</li>" +
                            $"<li>MN-05 – Solicitar segunda via da fatura</li>" +
                            $"<li>MN-06 – Renegociar dívida</li>" +
                            $"<li>MN-07 – Cancelar assinatura</li>" +
                            $"<li>MN-08 - Falar com um atendente</li></ul>";

                        webChat.Resposta = resposta;
                    }
                    else
                    {
                        resposta = "Funny: Não encontramos seu CPF em nossas bases de cadastro. Favor verificar o CPF informado.";
                        webChat.Resposta = resposta;
                    }
                }
                else
                {
                    webChat = _conversaRepositorio.BuscarConversaPorPergunta(pergunta);
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
