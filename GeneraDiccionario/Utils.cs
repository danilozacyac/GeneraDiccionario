using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraDiccionario
{
    public class Utils
    {

        public static String StandarizaCadena(String textoOriginal)
        {
            textoOriginal = textoOriginal.Replace("á", "a");
            textoOriginal = textoOriginal.Replace("é", "e");
            textoOriginal = textoOriginal.Replace("í", "i");
            textoOriginal = textoOriginal.Replace("ó", "o");
            textoOriginal = textoOriginal.Replace("ú", "u");
            textoOriginal = textoOriginal.Replace("Á", "A");
            textoOriginal = textoOriginal.Replace("É", "E");
            textoOriginal = textoOriginal.Replace("Í", "I");
            textoOriginal = textoOriginal.Replace("Ó", "O");
            textoOriginal = textoOriginal.Replace("Ú", "U");
            textoOriginal = textoOriginal.Replace(" de ", " ");
            textoOriginal = textoOriginal.Replace(" el ", " ");
            textoOriginal = textoOriginal.Replace(" lo ", " ");
            textoOriginal = textoOriginal.Replace(" la ", " ");
            textoOriginal = textoOriginal.Replace(" un ", " ");
            textoOriginal = textoOriginal.Replace(" una ", " ");
            textoOriginal = textoOriginal.Replace(" es ", " ");
            textoOriginal = textoOriginal.Replace("[", " ");
            textoOriginal = textoOriginal.Replace("]", " ");
            textoOriginal = textoOriginal.Replace("{", " ");
            textoOriginal = textoOriginal.Replace("}", " ");
            textoOriginal = textoOriginal.Replace("^", " ");
            textoOriginal = textoOriginal.Replace("\"", " ");
            textoOriginal = textoOriginal.Replace("(", " ");
            textoOriginal = textoOriginal.Replace(")", " ");



            return textoOriginal;
        }

    }
}
