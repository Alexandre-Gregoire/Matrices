using System;

namespace _5TTI_Matrices_Gregoire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mat1; //matrices n1
            int[,] Mat2; //matrices n2
            int[,] Mat3; //matrices n3
            string Reponse; //variable string qui permet de write
            bool restart = true; //permet de restart si l'utilisateur veut restart
            string choix; // contient le choix de quel programme utiliser
            while (restart)
            {
                MethodesDuProjet mesOutils = new MethodesDuProjet();
                
                Console.WriteLine("Bienvenue dans ce programme d'adiotion et multiplications de matrices");
                Console.WriteLine("Que voulez vous faire ? \n1. generer une matrice aleatoire \n2. aditionner 2 matrices generer aléatoirement \n3. mutliplier 2 matrices generer aléatoirement");
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
                    if (mesOutils.Addition_Matrices(Mat1, Mat2, out Mat3))
                    {
                        Console.WriteLine(Reponse + "-------------------------------");
                        mesOutils.stringMatrices(Mat3, out Reponse);
                        Console.WriteLine(Reponse);
                    }
                    else
                    {
                        Console.WriteLine("l'adition n'est pas possible entre 2 tableaux de cette dimensions");
                    }

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
                    if (mesOutils.MultiplicationsMatrice(Mat1, Mat2, out Mat3))
                    {
                        Console.WriteLine(Reponse + "-------------------------------");
                        mesOutils.stringMatrices(Mat3, out Reponse);
                        Console.WriteLine(Reponse);
                    }
                    else
                    {
                        Console.WriteLine("la multiplications n'est pas possible entre 2 tableaux de cette dimensions");
                    }

                }
                else
                {
                    Console.WriteLine("Veuillez entrez une valeur valide");
                }
                Console.WriteLine("Voulez vous recommencer ? oui = o / non = reste");
                Reponse = Console.ReadLine();
                if (Reponse == "o")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }
            }
           
        }
    }
}
