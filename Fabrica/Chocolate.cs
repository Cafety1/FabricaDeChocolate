namespace Fabrica
{
    public class Chocolate
    {
        public string Tipo;

        public float PorcentagemDeCacau
        {
            get
            {
                return 100 - PorcentagemDeAcucar;

            }
            private set{ }
        }
        public float OrigemDoCacau { get; set; }
        public float PorcentagemDeAcucar { get; set; }
    }
}