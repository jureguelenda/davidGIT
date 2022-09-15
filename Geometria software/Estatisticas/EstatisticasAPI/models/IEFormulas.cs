namespace EstatisticasAPI.Models
{
    public interface IEstatisticas
    {
        double Media(string[] valores);
        double Moda(string[] valores);
        double Media(string[] valores);
        double Mediana(string[] valores);
        double Maior(string[] valores);
        double Menor(string[] valores);
        double DP(string[] valores);

    }
}