namespace POO_Polimorfismo_Sobreposicao.classes
{
    public class MegaMan : Player
    {
        //Atributos
        private string buster;
        public string Buster{
            get{return "Buster";}
        }

        //Metodos
        public override string Correr()
        {
            return "correr na velocidade 2x";
        }
        
    }
}