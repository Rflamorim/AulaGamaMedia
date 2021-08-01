using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1Media
{
    class Program
    {
        static void Main(string[] args)
        {

            // Mensagem de entrada;

            Console.WriteLine("Danilo é um professor muito preocupado com os seus alunos, para ajudar o seu professor, Danilo propos uma missão:Faça um programa que capture o nome e 3 notas de 4 alunos, no final do programa de o nome do aluno e a média, ou seja, para cada aluno mostre o seu nome e a sua média.\n");
            Console.WriteLine("Seja bem vindo.Aqui iremos calcula media aritmetrica entre alunos curso de matemática \n");
            Console.WriteLine(" Alunos Matriculados em Licenciatura em Matemática  ano 2021 \n");
            Console.WriteLine(" 1- Forza Horizon Xbox \n");
            Console.WriteLine(" 2- Gears \n");
            Console.WriteLine(" 3- Far Cry \n");
            Console.WriteLine("Digite nota 1 aluno Forza Horizon Xbox :\n");
            double primeiraNota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno Forza Horizon Xbox :\n");
            double segundaNota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno Forza Horizon Xbox :\n");
            double terceiraNota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma = primeiraNota1 + segundaNota2 + terceiraNota3;
            Console.WriteLine("soma das notas " + soma);
            double media = soma / 3;
            Console.WriteLine();
            Console.WriteLine("Media aluno Forza Horizon Xbox é " + media);
            Console.WriteLine();
            Console.WriteLine("Agora vamos digitar nota 1 aluno Gears:\n");
            Console.WriteLine("Digite nota 1 aluno Gears :\n");
            double primeiraNota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno Gears :\n");
            double primeiraNota5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno Gears :\n");
            double primeiraNota6 = Convert.ToDouble(Console.ReadLine());
            double soma1 = primeiraNota4 + primeiraNota5 + primeiraNota6;
            Console.WriteLine();
            Console.WriteLine("soma das notas " + soma1);
            double media1 = soma1 / 3;
            Console.WriteLine("Media de Gears é " + media1);
            Console.WriteLine();
            Console.WriteLine("Agora vamos digitar nota 1 aluno Far Cry:\n");
            Console.WriteLine("Digite nota 1 aluno Far Cry :\n");
            double primeiraNota7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 2 aluno Far Cry :\n");
            double primeiraNota8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite nota 3 aluno Far Cry :\n");
            double primeiraNota9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double soma2 = primeiraNota7 + primeiraNota8 + primeiraNota9;
            Console.WriteLine("soma das notas " + soma2);
            Console.WriteLine();
            double media2 = soma2 / 3;
            Console.WriteLine("Media aluno Far Cry é " + media2);
            Console.WriteLine();
            Console.WriteLine("Otimo agora aqui temos media de cada aluno na disciplina de Licenciatura em Matematica:\n");
            Console.WriteLine("Forza Horizon Xbox : " + media);
            Console.WriteLine();
            Console.WriteLine("Gears: " + media1);
            Console.WriteLine();
            Console.WriteLine("Far Cry: " + media2);
            Console.WriteLine();
            Console.WriteLine("Parabéns");
            Console.ReadKey();



        }
    }
}
