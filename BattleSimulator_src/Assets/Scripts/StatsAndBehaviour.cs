using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsAndBehaviour : MonoBehaviour
{
    public Pokémon specie;
    [SerializeField] int livello;
    [SerializeField] Mossa[] moveSet = new Mossa[4];

    /*
    [SerializeField] int ivHp;
    [SerializeField] int ivAtt;
    [SerializeField] int ivDef;
    [SerializeField] int ivSpAtt;
    [SerializeField] int ivSpDef;
    [SerializeField] int ivSpe;
    */
    IndividualValues iv;

    [SerializeField] int evHp;
    [SerializeField] int evAtt;
    [SerializeField] int evDef;
    [SerializeField] int evSpAtt;
    [SerializeField] int evSpDef;
    [SerializeField] int evSpe;

    string nome;
    Sprite frontSprite;
    Sprite backSprite;
    List<Tipo> tipi;
    List<Mossa> mosseImparabili;

    int HP;
    int attFisico;
    int difFisica;
    int attSpeciale;
    int difSpeciale;
    int velocità;

    // Start is called before the first frame update
    void Start()
    {
        setStats();
    }

    void setStats()
    {
        HP = calcolaHP();
        attFisico = calcolaStatistica(specie.ATT, iv.Att, evAtt);
        difFisica = calcolaStatistica(specie.DEF, iv.Def, evDef);
        attSpeciale = calcolaStatistica(specie.SP_ATT, iv.SpAtt, evSpAtt);
        difSpeciale = calcolaStatistica(specie.SP_DEF, iv.SpDef, evSpDef);
        velocità = calcolaStatistica(specie.SPE, iv.Spe, evSpe);
    }

    int calcolaHP() 
    {
        return Mathf.FloorToInt(0.01f * (2 * specie.HP + iv.Hp + Mathf.FloorToInt(0.25f * evHp)) * livello) + livello + 10;
    }

    int calcolaStatistica(int Base, int Iv, int Ev) 
    {
        return Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * Base + Iv + Mathf.FloorToInt(0.25f * Ev)) * livello) + 5) * 1;
    }
}
