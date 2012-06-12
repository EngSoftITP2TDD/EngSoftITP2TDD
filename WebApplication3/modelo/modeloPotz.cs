using System;
using System.Collections.Generic;
using System.Web;

namespace WebApplication3
{
    public class modeloPotz
    {
        public int teste(string codPotz)
        {
            //adaptado de http://stackoverflow.com/questions/7006109/get-check-digit-mod-11-implementation-in-c-sharp
            int Sum = 0;
            codPotz = codPotz.Replace("-", "");//sanitiza a entrada

            for (int i = codPotz.Length - 1, Multiplier = 2; i >= 0; i--)//multiplica pelo peso correspondente a posicao
            {
                Sum += (int)char.GetNumericValue(codPotz[i]) * Multiplier;

                if (++Multiplier == 8) Multiplier = 2;
            }
            string Validator = (11 - (Sum % 11)).ToString();

            //regra para os restos
            if (Validator == "11") Validator = "0";
            else if (Validator == "10") Validator = "X";


            //se o digito obtido for igual ao fornecido, retorna os 3 primeiros digitos
            if (codPotz.Substring(9) == Validator)
            {
                return int.Parse(codPotz.Substring(0, 2));
            }
            else //senao, retorna o codigo de erro -1
            {
                return -1;
            }           

        }
        
    }
}