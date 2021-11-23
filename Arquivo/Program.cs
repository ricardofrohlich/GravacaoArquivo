using System;
using System.IO;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*StreamWriter é uma classe para leitura e escrita em arquivos
                 * inicialmente é declarado um objeto e instanciado este objeto
                 * passando por parâmetro o caminho do arquivo 
                 * Materiais de apoio: 
                 * [1] https://docs.microsoft.com/pt-br/dotnet/api/system.io.streamwriter?view=net-6.0
                 * [2] https://docs.microsoft.com/pt-br/dotnet/api/system.io.streamwriter.-ctor?view=net-6.0
                 */

                StreamWriter sw = new StreamWriter("C:\\Teste\\Teste.txt");
                /* esta classe, tem diversos métodos (funções) para manupulaçao de arquivos */
                /*writeline escreve uma linha no arquivo texto*/
                sw.WriteLine("Oi pessoal!!");
                /*vamos escrever outra linha */
                sw.WriteLine("Utilizando a classe StreamWriter");
                /*fechando o arquivo*/
                sw.Close();
            }
            /*tudo isso acima deve estar dentro de um try catch (exceções).
             * O que são Exceções? São tratamentos de erros pra evitar que algum erro ocorra na execução, como neste caso, a gravação de arquivo em algum lugar não permitido. 
             * Basicamente ele "tenta" fazer algo (try) e caso ocorra algum erro (exceção), ele entra sai da execução do try e vai para o catch apresentar o erro.
             * E ao finalizar, ele entra no finally.
             * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/try-catch
             * https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/try-catch-finally
             */
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o bloco finally.");
            }
        }
    }
}
