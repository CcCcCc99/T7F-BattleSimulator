using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuovo pokémon", menuName = "Pokémon/Pokémon")]
public class Pokémon : ScriptableObject
{
    [SerializeField] string nome;
    [SerializeField] int numPokédex;
    [SerializeField] Sprite FrontSprite;
    [SerializeField] Sprite BackSprite;
    [SerializeField] List<Tipo> tipi;

    [SerializeField] int HPBase;
    [SerializeField] int attFisicoBase;
    [SerializeField] int difFisicaBase;
    [SerializeField] int attSpecialeBase;
    [SerializeField] int difSpecialeBase;
    [SerializeField] int velocitàBase;

    [SerializeField] List<Mossa> mosseImparabili;
}
