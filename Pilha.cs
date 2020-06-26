using System;

namespace EstruturaDoPrograma
{
    public class Pilha
    {
        class Ordenacao
        {
            public Ordenacao proximo;
            public object item;
            public Ordenacao(Ordenacao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }


        Ordenacao primeiro;
        public void Empilha(object item) 
        {
            primeiro = new Ordenacao(primeiro, item);
        }

        public object Desempilha() 
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A Pilha está Vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }
        
        
    }
}