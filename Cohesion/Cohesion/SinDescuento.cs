using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion
{
    public class SinDescuento : ITipoCalculo
    {
        decimal ITipoCalculo.Calcular(Compra compra)
        {
            decimal result = 0;
            #region countruies values flet
            var combustibleAR = compra.valor * 0.42;
            var seguridadAR = compra.valor * 0.08;

            var combustiblePE = compra.valor * 0.45;
            var seguridadPE = compra.valor * 0.12;

            var combustibleBA = compra.valor * 0.53;
            var seguridadBA = compra.valor * 0.18;

            var combustibleCH = compra.valor * 0.48;
            var seguridadCH = compra.valor * 0.16;

            var combustibleEC = compra.valor * 0.52;
            var seguridadEC = compra.valor * 0.22;

            var combustibleBL = compra.valor * 0.42;
            var seguridadBL = compra.valor * 0.19;

            var combustibleUR = compra.valor * 0.62;
            var seguridadUR = compra.valor * 0.15;
            #endregion

            #region switch
            switch (compra.ciudadEnum)
            {
                case CiudadEnum.BuenosAires:
                    result = (decimal)(combustibleAR + seguridadAR + compra.valor);

                    break;
                case CiudadEnum.RioDeJaneiro:
                    result = (decimal)(combustibleBA + seguridadBA + compra.valor);
                    break;
                case CiudadEnum.Cusco:
                    result = (decimal)(combustiblePE + seguridadPE + compra.valor);
                    break;
                case CiudadEnum.Santiago:
                    result = (decimal)(combustibleCH + seguridadCH + compra.valor);
                    break;
                case CiudadEnum.SaoPaulo:
                    result = (decimal)(combustibleBA + seguridadBA + compra.valor);
                    break;
                case CiudadEnum.Quito:
                    result = (decimal)(combustibleEC + seguridadEC + compra.valor);
                    break;
                case CiudadEnum.LaPaz:
                    result = (decimal)(combustibleBL + seguridadBL + compra.valor);
                    break;
                case CiudadEnum.Montevideo:
                    result = (decimal)(combustibleUR + seguridadUR + compra.valor);
                    break;
                case CiudadEnum.Lima:
                    result = (decimal)(combustiblePE + seguridadPE + compra.valor);
                    break;
                default:
                    Console.WriteLine("La Ciudad ingresada no se encuentra registrada");
                    break;
            }
            #endregion

            return result;
        }
    }
}
