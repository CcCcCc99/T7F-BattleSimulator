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

    public bool isSpecial() 
    {
        if (categoria == Categoria.Speciale) return true;
        else return false;
    }

    public int DANNO {
        get { return dannoBase; }
    }
}
