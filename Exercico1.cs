using System;
using System.Collections.Generic;

public class ItemForja
{
    public string Nome = "Ferro";

    public int TempS{get ; set;}

    public string Tipo = "Padrão";
}

public class Program
{
    
    public static void Main()
    {
    Queue<ItemForja> forja = new Queue<ItemForja>();
    bool verificarForja = false;

    forja.Enqueue(new ItemForja{Nome = "Espada de Ferro" , TempS = 15 , Tipo = "Espada"});
    forja.Enqueue(new ItemForja{Nome = "Escudo" , TempS = 10 , Tipo = "Escudo"});
    forja.Enqueue(new ItemForja{Nome = "Pacote de Flechas" , TempS = 5 , Tipo = "Flecha"});

    while (verificarForja == false)
    {
           if (forja.Count == 0) 
        {
               verificarForja = true;
        }
        ItemForja processando = forja.Dequeue();
        Console.WriteLine($"Item fabricado com sucesso:{processando.Nome}!\n Tempo de Forja: {processando.TempS}\n");
     

        ItemForja proximo = forja.Peek();
        Console.WriteLine($" Processando:{proximo.Nome}!\n Tempo Esperado {proximo.TempS}\n Tipo:{proximo.Tipo}\n");
    }
    Console.WriteLine("Fila Vazia nenhum item para forjar.");
    }
}

        
