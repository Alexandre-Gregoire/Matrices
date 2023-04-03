using System;

namespace _5TTI_Matrices_Gregoire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mat1;
            int[,] Mat2;
            int[,] Mat3;
            string Reponse;
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            string choix;
            Console.WriteLine("Bienvenue dans ce programme d'adiotion et multiplications de matrices");
            Console.WriteLine("Que voulez vous faire ? \n1. generer une matrice aleatoire \n2. aditionner 2 tableaux generer aléatoirement \n3. mutliplier 2 tableaux generer aléatoirement");
            choix = Console.ReadLine();
            if (choix == "1")
            {
                mesOutils.CreationTab(out Mat1);
                mesOutils.stringMatrices(Mat1, out Reponse);
                Console.WriteLine(Reponse);
            }
            else if (choix == "2")
            {
                Console.WriteLine("Tableaux 1 :");
                mesOutils.CreationTab(out Mat1);
                mesOutils.stringMatrices(Mat1, out Reponse);
                Console.WriteLine(Reponse);
                Console.WriteLine("Tableaux 2 :");
                mesOutils.CreationTab(out Mat2);
                mesOutils.stringMatrices(Mat2, out Reponse);
                Console.WriteLine(Reponse + "-------------------------------");
                mesOutils.Addition_Matrices(Mat1, Mat2, out Mat3);
                mesOutils.stringMatrices(Mat3, out Reponse);
                Console.WriteLine(Reponse);
            }
            else if (choix == "3")
            {
                Console.WriteLine("Tableaux 1 :");
                mesOutils.CreationTab(out Mat1);
                mesOutils.stringMatrices(Mat1, out Reponse);
                Console.WriteLine(Reponse);
                Console.WriteLine("Tableaux 2 :");
                mesOutils.CreationTab(out Mat2);
                mesOutils.stringMatrices(Mat2, out Reponse);
                Console.WriteLine(Reponse + "-------------------------------");

                mesOutils.MultiplicationsMatrice(Mat1, Mat2, out Mat3);
                mesOutils.stringMatrices(Mat3, out Reponse);
                Console.WriteLine(Reponse);
            }
            else
            {

            }





        }
       
    }
}
