using UnityEngine;

enum Categoria {
    Fisico,
    Speciale,
    Stato
}

[CreateAssetMenu(fileName = "Nuova mossa", menuName = "Pokémon/Mossa")]
public class Mossa : ScriptableObject
{
    [SerializeField] string nome;
    [SerializeField] Tipo tipo;
    [SerializeField] Categoria categoria;

    [SerializeField] int pp;
    [SerializeField] int dannoBase;
    [SerializeField] int precisione;
}
