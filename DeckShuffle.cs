using System;
using System.Security.Cryptography;
using System.Collections.Generic;

public class DeckShuffler
{
    // Método para barajar un mazo de cartas
    public static void Shuffle<T>(List<T> deck)
    {
        // Uso de RNGCryptoServiceProvider para generar números aleatorios seguros
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            int n = deck.Count;
            while (n > 1)
            {
                // Generar un índice aleatorio
                byte[] box = new byte[4];
                rng.GetBytes(box);
                int randomIndex = Math.Abs(BitConverter.ToInt32(box, 0)) % n;

                n--;

                // Intercambiar cartas
                T temp = deck[n];
                deck[n] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }
    }
}
