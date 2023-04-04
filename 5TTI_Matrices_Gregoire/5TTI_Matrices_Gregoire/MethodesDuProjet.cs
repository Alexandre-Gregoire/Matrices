using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTI_Matrices_Gregoire
{
    public struct MethodesDuProjet
    {
        /// <summary>
        /// permet de generer une matrices aléatoire
        /// </summary>
        /// <param name="nbLigne">contient le nombre de ligne dans la matrice genere aleatoirement</param>
        /// <param name="nbColonne">contient le nombre de colonne dans la martice genere aleatoirement</param>
        /// <param name="MatricesAlea">contient la matrices générer alatoirement</param>
        public void GenerationTableau(int nbLigne, int nbColonne, out int[,] MatricesAlea)
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
        /// <summary>
        /// concatene une matrices vers une chaine de caracteres
        /// </summary>
        /// <param name="Matrices">la matrices a transformer en string</param>
        /// <param name="stringTab">le string de la matrices </param>
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
        /// <summary>
        /// permet d'aditionner deux matrices
        /// </summary>
        /// <param name="Matrices1">la matrice n1 a additioner</param>
        /// <param name="Matrices2">la matrice n2 a additioner</param>
        /// <param name="Matrices3">le resultat de l'adition des deux matrices</param>
        /// <returns>test si l'additions est possible et renvoie vrai</returns>
        public bool Addition_Matrices(int[,] Matrices1, int[,] Matrices2, out int[,] Matrices3)
        {
            Matrices3 = new int[Matrices1.GetLength(0), Matrices1.GetLength(1)];
            bool addition = true;
            if (Matrices1.GetLength(0) == Matrices2.GetLength(0) && Matrices1.GetLength(1) == Matrices2.GetLength(1))
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
            else
            {
                addition = false;
            }
            return addition;
            
        }
        /// <summary>
        /// permet de multiplier deux matrices
        /// </summary>
        /// <param name="Matrices1">la matrice n1 a multiplier</param>
        /// <param name="Matrices2">la matrice n2 a multiplier</param>
        /// <param name="matriceMulti">le resultat de la multiplications des deux matrices</param>
        /// <returns>test si la multiplications est possible et renvoie vrai </returns>
        public bool MultiplicationsMatrice(int[,] Matrices1, int[,] Matrices2, out int[,] matriceMulti)
        {
            bool multiplications = true;
            matriceMulti = new int[Matrices1.GetLength(0), Matrices2.GetLength(1)];
            if (Matrices1.GetLength(1) == Matrices2.GetLength(0))
            {
                for (int ligne = 0; ligne < Matrices2.GetLength(0); ligne++)
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
            else
            {
                multiplications = false;
            }
            return multiplications;


        }
        /// <summary>
        /// permet de verifier l'entree de l'utilisateur si jamais le nombre est bien un reel ou pas
        /// </summary>
        /// <param name="question">la question a poser</param>
        /// <param name="n">le chiffre si jamais la reponse est bien un reel</param>
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
        /// <summary>
        /// permet de racourcir la demande pour generer une matrices
        /// </summary>
        /// <param name="Mat">ressort la matrices demander</param>
        public void CreationTab(out int[,] Mat)
        {
            int nbLi;
            int nbCol;

            LireReel("Combiens voulez vous de lignes ?\n", out nbLi);
            Console.WriteLine();
            LireReel("Combiens voulez vous de colonne ?\n", out nbCol);
            Console.WriteLine();
            GenerationTableau(nbLi, nbCol, out Mat);

        }









    }
}
