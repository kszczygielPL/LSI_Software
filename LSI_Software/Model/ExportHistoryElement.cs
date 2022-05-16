using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSI_Software.Model
    {
    public class ExportHistoryElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeOfExport { get; set; }

        public string UserName { get; set; }
        public string ExportLocalName { get; set; }

    }
}
