using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;  // Nombre de la carta (ej: "As de Corazones")
    public Sprite cardImage; // Imagen de la carta

    // Método para configurar la carta
    public void SetCard(string name, Sprite image)
    {
        cardName = name;
        cardImage = image;
        GetComponent<SpriteRenderer>().sprite = cardImage;
    }
}