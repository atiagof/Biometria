using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBiometria.MODEL
{
    public class Usuario : Sistema
    {
        public Int32 id_usuario { get; set; }
        public string nome { get; set; }

        public string cpf { get; set; }

        public Int32 codigo_biometria { get; set; }

        public DateTime data_cadastro { get; set; }
    }
}