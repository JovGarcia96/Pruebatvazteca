using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_azteca.Model
{
    public class Contract
    {
        public int CUS_ID { get; set; }
        public int CON_ID { get; set; }
        public string CON_SHORT_NAME { get; set; }
        public int STA_ID { get; set; }
        public decimal CON_AMOUNT { get; set; }
        public string CON_NAME { get; set; }
        public DateTime CON_BEGIN_DATE { get; set; } = DateTime.Now;
    }
}
