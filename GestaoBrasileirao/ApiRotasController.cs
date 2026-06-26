using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBrasileirao
{
    public static class ApiRotasController
    {
        private static readonly string baseUrl = "";

        public static string ConsultarSerieA => $"{baseUrl}/SerieA";
        public static string ConsultarSerieB => $"{baseUrl}/SerieB";
        public static string ConsultarSerieC => $"{baseUrl}/SerieC";
        public static string ConsultarSerieD => $"{baseUrl}/SerieD";
    }
}
