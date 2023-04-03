using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTI_Matrices_Gregoire
{
    public struct MethodesDuProjet
    {
        public void GenerationTableau(int nbLigne, int nbColonne,out int[,] MatricesAlea)
        {
            var Alea = new Random();
            MatricesAlea = new int[nbLigne, nbColonne];
            for (int ligne = 0; ligne < nbLigne; ligne++)
            {
                for (int colonne = 0; colonne < nbColonne; colonne++)
                {
                    MatricesAlea[ligne, colonne] = Alea.Next(0, 20);
                }
            }
        }
        public void stringMatrices(int[,] Matrices, out string stringTab)
        {
            stringTab = "";
            for (int ligne = 0; ligne < Matrices.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < Matrices.GetLength(1); colonne++)
                {
                    if (Matrices[ligne, colonne] < 10)
                    {
                        stringTab += Matrices[ligne, colonne] + " |";
                    }
                    else
                    {
                        stringTab += Matrices[ligne, colonne] + "|";
                    }
                    

                }
                stringTab += "\n";
            }
        }
        public void Addition_Matrices(int[,] Matrices1, int[,] Matrices2,out int[,] Matrices3)
        {
            Matrices3 = new int[Matrices1.GetLength(0), Matrices1.GetLength(1)]; 
            for (int ligne = 0; ligne < Matrices1.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < Matrices1.GetLength(1); colonne++)
                {
                    Matrices3[ligne, colonne] = Matrices1[ligne, colonne] + Matrices2[ligne, colonne];
                }
            }
        }
        public void MultiplicationsMatrice(int[,] Matrices1, int[,] Matrices2,out int[,] matriceMulti)
        {
            matriceMulti = new int[Matrices1.GetLength(1), Matrices2.GetLength(0)];
            for (int ligne = 0; ligne < Matrices2.GetLength(1); ligne++)
            {
                for (int colonne = 0; colonne < Matrices2.GetLength(1); colonne++)
                {
                    matriceMulti[ligne, colonne] = 0;
                    for (int i = 0; i < Matrices1.GetLength(1); i++)
                    {
                        matriceMulti[ligne, colonne] += Matrices1[ligne, i] * Matrices2[i, colonne];
                    }
                }
            }
        }
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                Console.Write(question);
                nUser = Console.ReadLine();
            }

        }
        public void CreationTab(out int[,] Mat)
        {
            int nbLi;
            int nbCol;

            LireReel("Combiens voulez vous de lignes ?", out nbLi);
            Console.WriteLine();
            LireReel("Combiens voulez vous de colonne ?", out nbCol);
            Console.WriteLine();
            GenerationTableau(nbLi, nbCol, out Mat);

        }
    }
}
