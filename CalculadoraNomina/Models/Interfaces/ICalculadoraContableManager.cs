namespace CalculadoraNomina.Models.Interfaces
{
    public interface ICalculadoraContableManager
    {
        decimal CalculoInversoSalarioBrutoIsr(double salarioBruto);
        decimal CalculoSalarioNetoIsr(double salarioBruto);
    }
}
