# FisherYates-Shuffle

## Cómo Usarlo en Unity
Crea un mazo de cartas: Puedes usar una lista de cualquier tipo de datos (por ejemplo, cadenas para nombres de cartas, enteros para IDs, etc.).
Llama al método Shuffle para mezclar las cartas.

## Detalles del Algoritmo
### Seguridad Criptográfica:

__RNGCryptoServiceProvider__ garantiza que los números generados sean seguros y cumplan con los estándares de aleatoriedad requeridos por regulaciones estrictas.

### Generalidad:

El método `Shuffle<T>` es genérico, lo que significa que puedes usarlo para mezclar cualquier tipo de datos, no solo cartas (por ejemplo, una lista de objetos personalizados).

### Eficiencia:

El algoritmo tiene una complejidad de 𝑂(𝑛) lo que lo hace adecuado para listas grandes, como una baraja de 60 cartas.

## Configuración en Unity

### Crear las imágenes de cartas:
Agrega sprites para cada carta (por ejemplo, imágenes de una baraja estándar) a la carpeta Assets.
Crea un prefab para cada carta o un único prefab con un script que cambie la imagen según la carta asignada.
 
### Crear el prefab de carta:

Diseña un prefab con un componente SpriteRenderer para mostrar las imágenes de las cartas.
Agrega un script para manejar la asignación de valores (como el nombre de la carta o su imagen).

## Configuración del Escenario

### Prefab de carta:

__Crea un prefab que tenga:__
- Un componente SpriteRenderer para la imagen de la carta.
- El script Card para asignar el nombre y la imagen.
  
### GameObject del mazo:
- Crea un objeto vacío en la escena llamado DeckManager.
- Asigna el script DeckManager al objeto.
- Arrastra el prefab de carta al campo cardPrefab.
- Arrastra las imágenes de las cartas a la lista cardImages.
  
## #Contenedor de cartas:
- Crea un objeto vacío en la escena llamado CardParent y asigna su referencia al campo cardParent en el script DeckManager.
