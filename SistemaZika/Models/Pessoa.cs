using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Pessoa
    {
        public int CdPessoa { get; set; }
        public string NmPessoa { get; set; }
        public string DsEmail { get; set; }
        public string DsSexo { get; set; }
        public string DsEstadoCivil { get; set; }
        public bool BtRecebeSMS { get; set; }
        public bool BtRecebeEmail { get; set; }
    }
}
