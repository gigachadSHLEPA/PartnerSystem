public class MaterialCalculator
{
    public static int CalculateMaterial(int productId, int materialId, int quantity, double wasteCoefficient)
    {
        if (productId <= 0 || materialId <= 0 || quantity <= 0 || wasteCoefficient <= 0)
            return -1;
        return (int)(quantity * wasteCoefficient);
    }
}