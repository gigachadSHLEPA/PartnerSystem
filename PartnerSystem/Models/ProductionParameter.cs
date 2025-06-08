using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerSystem.Models
{
    public class ProductionParameter
    {
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public double WasteCoefficient { get; set; }
    }
}
