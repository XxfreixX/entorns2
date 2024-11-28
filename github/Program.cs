using System;

class Carrera
{
    static void Main()
    {
        
        var carrera = new int[,]
        {
            { 1, 4, 3, 5, 4},
            { 2, 8, 2, 5, 7},
            { 3, 7, 4, 6, 2},
            { 4, 4, 3, 1, 3},
            { 1, 6, 2, 9, 9},
            { 2, 6, 9, 9, 5},
            { 3, 6, 1, 6, 4},
            { 4, 9, 4, 1, 6},
            { 1, 4, 4, 5, 2},
            { 2, 6, 2, 2, 1},
            { 3, 8, 6, 8, 6},
            { 4, 1, 8, 8, 1},
            { 1, 9, 7, 8, 6},
            { 2, 7, 8, 2, 3},
            { 3, 4, 1, 2, 5},
            { 4, 2, 6, 2, 9},
            { 1, 3, 3, 4, 9},
            { 2, 1, 2, 1, 5},
            { 3, 1, 3, 3, 1},
            { 4, 7, 9, 3, 2},
            { 1, 7, 1, 9, 6},
            { 2, 3, 4, 5, 7},
            { 3, 5, 3, 7, 9},
            { 4, 9, 2, 3, 2},
            { 1, 3, 8, 5, 5},
            { 2, 7, 9, 9, 6},
            { 3, 9, 6, 6, 1},
            { 4, 7, 2, 1, 4},
            { 1, 7, 8, 4, 2},
            { 2, 6, 1, 8, 3},
            { 3, 4, 4, 2, 6},
            { 4, 2, 3, 5, 2},
            { 1, 1, 5, 6, 1},
            { 2, 7, 9, 4, 3},
            { 3, 5, 4, 6, 5},
            { 4, 9, 5, 1, 7},
            { 1, 8, 9, 4, 5},
            { 2, 6, 6, 2, 2},
            { 3, 5, 2, 4, 9},
            { 4, 4, 5, 7, 6},
        };

       
        int[] avancesCorredores = new int[5]; 

        
        for (int i = 0; i < carrera.GetLength(0); i++)
        {
            int corredor = carrera[i, 0];
            int maxAvance = int.MinValue;
            int minAvance = int.MaxValue;


            for (int j = 1; j < carrera.GetLength(1); j++)
            {
                int avance = carrera[i, j];
                if (avance > maxAvance) maxAvance = avance;
                if (avance < minAvance) minAvance = avance;
            }

         
            int distancia = maxAvance - minAvance;


            avancesCorredores[corredor] += distancia;
        }

       
        
        for (int i = 1; i < avancesCorredores.Length; i++)
        {
            Console.WriteLine($"Corredor {i}: {avancesCorredores[i]} metros");
        }

        
        int corredorGanador = 1;
        int maxDistancia = avancesCorredores[1];

        for (int i = 2; i < avancesCorredores.Length; i++)
        {
            if (avancesCorredores[i] > maxDistancia)
            {
                corredorGanador = i;
                maxDistancia = avancesCorredores[i];
            }
        }

        Console.WriteLine($"\nLa carrera l'ha guanyat el corredor " + corredorGanador);
    }
}
