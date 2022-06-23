using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohesion
{
    public class TresPorciento : ITipoCalculo
    {
        decimal ITipoCalculo.Calcular(Compra compra)    
        {

            decimal result=0;
            decimal descuentoVal;

            #region comentario calculos
            //la evaluacion se realizara en supuestos precios de combustible y seguridad 
            // combustible -> minimo: 0.38              maximo : 0.65
            // seguridad -> minimo : 0.05               maximo : 0.25
            #endregion

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

            if(compra.valor >= 1000)
            {
                #region logic switch discount
                switch (compra.ciudadEnum)
                {
                    case CiudadEnum.BuenosAires:

                        descuentoVal = (decimal)((combustibleAR + seguridadAR + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);

                        break;
                    case CiudadEnum.RioDeJaneiro:

                        descuentoVal = (decimal)((combustibleBA + seguridadBA + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);

                        break;
                    case CiudadEnum.Cusco:

                        descuentoVal = (decimal)((combustiblePE + seguridadPE + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);


                        break;
                    case CiudadEnum.Santiago:

                        descuentoVal = (decimal)((combustibleCH + seguridadCH + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);


                        break;
                    case CiudadEnum.SaoPaulo:

                        descuentoVal = (decimal)((combustibleBA + seguridadBA + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);


                        break;
                    case CiudadEnum.Quito:

                        descuentoVal = (decimal)((combustibleBL + seguridadBL + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);


                        break;
                    case CiudadEnum.LaPaz:
                        descuentoVal = (decimal)((combustibleBL + seguridadBL + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);

                        break;
                    case CiudadEnum.Montevideo:

                        descuentoVal = (decimal)((combustibleUR + seguridadUR + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);

                        break;
                    case CiudadEnum.Lima:
                        descuentoVal = (decimal)((combustiblePE + seguridadPE + compra.valor) * 0.3);
                        result = (decimal)(compra.valor - descuentoVal);
                        break;
                    default:
                        Console.WriteLine("La Ciudad ingresada no se encuentra registrada");
                        break;

                }

                #endregion
            }
            else
            {
                result = (decimal)(combustibleBA + seguridadBA + compra.valor);
            }
          
            return result;

        }
    }
}
