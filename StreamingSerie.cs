using System;

	class Program
	{
  	  static void Main()
  	  {
        string resposta;
        do
        {
            Console.WriteLine("Você possui assinatura streaming? (sim/não) ");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "não")
            {
                Console.WriteLine("Resposta inválida. Digite apenas 'sim' ou 'não'.");
            }

        } while (resposta != "sim" && resposta != "não");
        

        

  	     if (resposta == "sim")
    	    {
        	Console.WriteLine("Você já assistiu a primeira temporada? ");
        	resposta = Console.ReadLine();
        	
   		     if (resposta == "sim")
      	      {     	           
                Console.WriteLine("Ótimo, agora você pode assistir à nova temporada");
      	      }
            else
       	     {
                
                Console.WriteLine("Infelizmente, você não pode assistir à nova temporada, assista a anterior.");
     	       }
     	   }
     	   else
     	   {
            
       	     Console.WriteLine("Ok, você precisa ser assinante para assistir nosso conteúdo!");
     	   }
       		 Console.ReadKey(true);
   		 }
	}
