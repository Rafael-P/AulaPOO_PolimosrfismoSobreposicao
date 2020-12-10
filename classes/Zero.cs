namespace POO_Polimorfismo_Sobreposicao.classes
{
    public class Zero : Player
    {
        //Atributos
        private string sword;
        public string Sword{
            get{return "Sword";}
        }

        //Metodos
        public override string Pular()
        {
            return "Dar um pulo e um Dash para frente";
        }

    }
}