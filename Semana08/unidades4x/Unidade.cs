using System;

namespace Unidades4X
{
    public abstract class Unidade 
    { 
       
      private int movimento;
      
        public virtual int Vida { get; set; }
        public
        public Unidade(int movimento, int vida) 
        {
            this.movimento = movimento;
            Vida = vida;
        }

        public void Mover()
        {
            Console.WriteLine($"Unidade andou {movimento} blocos");
        }
    }
}