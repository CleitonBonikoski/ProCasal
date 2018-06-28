using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Mes
    {
        [Key]
        public int IdMes { get; set; }

        public string DiaEspecial { get; set; }

        public string NivelFelicidade { get; set; }

        public string LugarTop { get; set; }

    }
}
