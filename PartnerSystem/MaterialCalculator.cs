using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartnerSystem
{
    public class MaterialCalculator
    {
        public static int CalculateMaterial(int productId, int materialId, int quantity, double wasteCoefficient)
        {
            if (productId <= 0 || materialId <= 0 || quantity <= 0 || wasteCoefficient <= 0)
                return -1;

            // Пример расчета с учетом брака
            return (int)(quantity * wasteCoefficient);
        }
    }
}
