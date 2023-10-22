namespace CalculadoraNomina.Models.Interfaces
{
    public interface ITablaIsrManager
    {
        double ObtenLimiteInferior(double salarioBruto);
        double ObtenLimiteSuperior(double salarioBruto);
        double ObtenCuotaFija(double salarioBruto);
        double ObtenPorcentajeExcedenteLimiteInferior(double salarioBruto);
    }
}
