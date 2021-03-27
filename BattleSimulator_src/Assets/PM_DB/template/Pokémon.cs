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

    //---------------------------------------------------

    //informazioni generali
    public string NOME {
        get { return nome; }
    }
    public int N_DEX {
        get { return numPokédex; }
    }
    public Sprite F_SPRITE{
        get { return FrontSprite; }
    }
    public Sprite B_SPRITE{
        get { return BackSprite; }
    }
    public List<Tipo> TIPI {
        get { return tipi; }
    }
    public List<Mossa> MOVESET {
        get { return mosseImparabili; }
    }

    //statistiche
    public int HP {
        get { return HPBase; }
    }
    public int ATT {
        get { return attFisicoBase; }
    }
    public int DEF{
        get { return difFisicaBase; }
    }
    public int SP_ATT {
        get { return attSpecialeBase; }
    }
    public int SP_DEF{
        get { return difSpecialeBase; }
    }
    public int SPE {
        get { return velocitàBase; }
    }
}
