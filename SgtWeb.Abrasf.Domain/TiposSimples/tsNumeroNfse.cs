using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SgtWeb.Abrasf.Domain.TiposSimples
{
    public class tsNumeroNfse
    {

        [MaxLength]
        public long Value { get; set; }

        public tsNumeroNfse(long value)
        {
            Value = value;
        }

        public static implicit operator tsNumeroNfse(long value)
        {
            return new tsNumeroNfse(value);
        }

        public static implicit operator long(tsNumeroNfse value)
        {
            return value.Value;
        }
    }
}
