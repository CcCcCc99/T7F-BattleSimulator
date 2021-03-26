using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Categoria
{
    Fisico,
    Speciale
}

[CreateAssetMenu(fileName = "Nuova mossa attacco", menuName = "Pokémon/Mossa Attacco")]
public class MossaAttacco : Mossa
{
    [SerializeField] Categoria categoria;
    [SerializeField] int dannoBase;
    [SerializeField] string effettiSecondari;
}
