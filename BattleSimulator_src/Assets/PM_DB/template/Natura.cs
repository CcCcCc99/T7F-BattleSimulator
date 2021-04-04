using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum stat
{
    attacco,
    difesa,
    spAttacco,
    spDifesa,
    velocità
}

[CreateAssetMenu(fileName = "Nuova mossa attacco", menuName = "Pokémon/Natura")]
public class Natura : ScriptableObject
{
    [SerializeField] string nome;
    [SerializeField] stat statAumentata;
    [SerializeField] stat statDiminuita;

    public float varazioneNatura(stat statistica) 
    {
        if (statistica == statAumentata)
            return 1.1f;
        if (statistica == statDiminuita)
            return 0.9f;
        return 1f;
    }
}
