using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    public GameObject cardPrefab;      // Prefab de la carta
    public Transform cardParent;      // Contenedor para las cartas en la escena
    public List<Sprite> cardImages;   // Lista de imágenes de las cartas
    private List<GameObject> deck;    // Lista de objetos carta

    void Start()
    {
        // Crear el mazo
        CreateDeck();

        // Mostrar cartas antes de barajar
        DisplayDeck();

        // Barajar el mazo
        ShuffleDeck();

        // Mostrar cartas después de barajar
        DisplayDeck();
    }

    // Crear el mazo con nombres e imágenes
    void CreateDeck()
    {
        deck = new List<GameObject>();
        for (int i = 0; i < cardImages.Count; i++)
        {
            GameObject card = Instantiate(cardPrefab, cardParent);
            string cardName = "Carta " + (i + 1);
            card.GetComponent<Card>().SetCard(cardName, cardImages[i]);
            deck.Add(card);
        }
    }

    // Barajar el mazo usando Fisher-Yates
    void ShuffleDeck()
    {
        System.Random rng = new System.Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            // Intercambiar cartas en la lista
            GameObject temp = deck[n];
            deck[n] = deck[k];
            deck[k] = temp;
        }
    }

    // Mostrar las cartas en la escena
    void DisplayDeck()
    {
        float offset = 2.0f; // Espaciado entre cartas
        for (int i = 0; i < deck.Count; i++)
        {
            deck[i].transform.position = new Vector3(i * offset, 0, 0);
        }
    }
}
