using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuovo tipo", menuName = "Pokémon/Tipo")]
public class Tipo : ScriptableObject
{
    [SerializeField] string nome;
    [SerializeField] Color colore;

    [SerializeField] List<Tipo> immunità;
    [SerializeField] List<Tipo> resistenze;
    [SerializeField] List<Tipo> debolezze;

    public float relazioneTipo(Tipo att)
    {
        if (immunità.Contains(att)) return 0f;
        else if (resistenze.Contains(att)) return 0.5f;
        else if (debolezze.Contains(att)) return 2f;
        else return 1f;
    }
}
