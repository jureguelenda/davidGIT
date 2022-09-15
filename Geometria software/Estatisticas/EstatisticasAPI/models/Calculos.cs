namespace EstatisticasAPI.Models
{
    public class Moda 
    {
        
        public double Media(double[] valores)
        {
            double soma=0;

            foreach(var item in valores)
            {
                soma=soma+item;
            }
            return soma/valores.Length;
        }

        public double Mediana(string[] m)
        {
            double troca;

            for (int i = 0; i < valores.length; i++)
            {
                for (int x = i+1; x < valores.length; i++)
                {
                    if(valores[i]>valores[x])
                    {
                        troca=valores[i];
                        valores[i]=valores[x];
                        valores[x]=troca;
                    }
                }
            }

             int metade = Math.Round (valores.Length/2,1);

            if (valores.Legth % 2==0)
            {
                return valores[metade-1]+valores[metade-1];
            }
            else
            {
                valores[metade];
            }
        }

        public double Moda(string[] m)
        {
            
        }

        public double DP(string[] m)
        {
            
        }

        public double Menor(string[] m)
        {
            
        }

        public double Maior(string[] m)
        {
            
        }
    }
}