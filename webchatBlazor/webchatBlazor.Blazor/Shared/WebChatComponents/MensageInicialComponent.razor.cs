using System;

namespace webchatBlazor.Blazor.Shared.WebChatComponents
{
    public partial class MensageInicialComponent
    {
        public string Saudacao
        {
            get
            {

                var diaHoje = DateTime.Now;

                var hora = diaHoje.Hour;

                if (hora >= 5 && hora < 12)
                {
                    return "Bom dia";
                }
                else if (hora >= 12 && hora < 18)
                {
                    return "Boa tarde";
                }
                else
                {
                    return "Boa noite";
                }

            }
        }

        public string HoraComMinuto
        {
            get
            {
                var horaAtual = DateTime.Now;
                string formatoPersonalizado = "HH:mm";
                string horaEMinuto = horaAtual.ToString(formatoPersonalizado);
                return horaEMinuto;
            }
        }


    }
}


