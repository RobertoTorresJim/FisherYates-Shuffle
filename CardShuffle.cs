using UnityEngine;
using System.Collections.Generic;

public class CardShufflerExample : MonoBehaviour
{
    void Start()
    {
        // Crear un mazo de cartas (Ejemplo con maso de 60 cartas)
        List<int> deck = new List<int>();
        for (int i = 1; i <= 60; i++)
        {
            deck.Add(i);
        }

        // Mostrar el mazo antes de barajar
        Debug.Log("Antes de barajar: " + string.Join(", ", deck));

        // Barajar el mazo
        DeckShuffler.Shuffle(deck);

        // Mostrar el mazo después de barajar
        Debug.Log("Después de barajar: " + string.Join(", ", deck));
    }
}