using System;
namespace EXERCICIO_02___ESTRUTURA_FOR{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Mostre quantos destes valores X estão dentro do intervalo [10,20].");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            Console.Write("Digite o tamanho do intervalo: ");
            int n = int.Parse(Console.ReadLine()); //------> Tamanho do intervalo 
            int cont_in = 0;
            int cont_out = 0;
            
            for(int i = 0; i < n; i++){ 
                int x = int.Parse(Console.ReadLine()); //------> X é os números do intervalo

                if (x >= 10 && x <= 20){
                    cont_in = cont_in + 1; //------> Contador de números dentro
                }
                else{
                    cont_out = cont_out + 1; //------> Contador de números fora
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
