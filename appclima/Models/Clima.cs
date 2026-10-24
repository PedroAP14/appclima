using System;
using System.Collections.Generic;
using System.Text;

namespace appclima.Models
{
    public class Clima
    {
        private DateTime data;
        private string condicao;
        private int min;
        private int max;
        private int indice_uv;
        private string condicao_desc;

        public DateTime Data { get => data; set => data = value; }
    }
}
