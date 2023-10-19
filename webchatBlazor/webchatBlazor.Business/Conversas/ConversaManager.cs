using System.Collections.Generic;
using System.Text;
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

            StringBuilder respostaTratada = new StringBuilder();

            if (Regex.IsMatch(Validacao.RetirarPontosETracosCPF(pergunta), @"^\d+$"))
            {
                if (Validacao.ValidarCPFFake(pergunta) && pergunta.Length > 10)
                {
                    string cpfSemFormatacao = Validacao.RetirarPontosETracosCPF(pergunta);

                   
                    cliente = _clienteRepositorio.BuscarClientePorCPF(cpfSemFormatacao);

                    if (cliente != null)
                    {
                        nome = cliente.Nome;

                        respostaTratada.AppendLine("Funny: <h6>Olá <b>" + nome + "</b>, escolha uma das opções abaixo.</h6>");
                        respostaTratada.AppendLine("<ul><li>01 – Alterar pacote de canais</li>");
                        respostaTratada.AppendLine("<li>02 – Alterar dados cadastrais</li>");
                        respostaTratada.AppendLine("<li>03 – Solicitar um novo ponto</li>");
                        respostaTratada.AppendLine("<li>04 – Alterar endereço da assinatura</li>");
                        respostaTratada.AppendLine("<li>05 – Solicitar segunda via da fatura</li>");
                        respostaTratada.AppendLine("<li>06 – Renegociar dívida</li>");
                        respostaTratada.AppendLine("<li>07 – Cancelar assinatura</li>");
                        respostaTratada.AppendLine("<li>08 - Falar com um atendente</li></ul>");                       

                        webChat.Resposta = respostaTratada.ToString();
                    }
                    else
                    {                       
                        webChat.Resposta = "Funny: Não encontramos seu CPF em nossas bases de cadastro. Favor verificar o CPF informado.";
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
