namespace POO_Polimorfismo_Sobreposicao.classes
{
    abstract public class Player
    {
        //Atributos
        private float velocidade ;
        public float Velocidade{
            get{return 1;}
            set{velocidade = value;}
        }

        private float forcaDoPulo;
        public float ForcaDoPulo{
            get{return 1;}
            set{forcaDoPulo = value;}
        }

        //Metodos
        public virtual string Correr(){
            return "correr na velocidade 1x";
        }

        public virtual string Pular(){
            return "dar um pulo";
        }

    }
}