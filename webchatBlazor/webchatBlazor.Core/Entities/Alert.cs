using System.Reflection;
using webchatBlazor.Core.Enuns;

namespace webchatBlazor.Core.Entities
{
    public class Alert
    {
        public EnumAlert Tipo { get; set; }
        public string Mensagem { get; set; }
        public string Display { get; set; } = "none";
        public string ModalClasse { get; set;}
        public bool Show { get; set;}
        public string Titulo { get; set; }
        public string UrlRedirect { get; set; }

        public void ShowModal()
        {
            ModalClasse = "show";
            Display = "block";
            Show = true;
        }
    }
}
