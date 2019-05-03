using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace ComandosViaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            //abrir coisas
            //Process.Start(@"c:\\windows\\notepad.exe");

            //desligar
            //Process.Start("shutdown", "-f -r");

           

            var lerArquivo = new StreamReader("Contas.txt", Encoding.UTF8);

            while (!lerArquivo.EndOfStream)
            {
                //Atribuir a linha de registro à variável
                string registro = lerArquivo.ReadLine();

                Process.Start(registro);

            }
            lerArquivo.Close();

            
        }
    }
}
