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
        HP = Mathf.FloorToInt(0.01f * (2 * specie.HP + iv.Hp + Mathf.FloorToInt(0.25f * evHp)) * livello) + livello + 10;
        attFisico = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.ATT + iv.Att + Mathf.FloorToInt(0.25f * evAtt)) * livello) + 5) * 1;
        difFisica = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.DEF + iv.Def + Mathf.FloorToInt(0.25f * evDef)) * livello) + 5) * 1;
        attSpeciale = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SP_ATT + iv.SpAtt + Mathf.FloorToInt(0.25f * evSpAtt)) * livello) + 5) * 1;
        difSpeciale = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SP_DEF + iv.SpDef + Mathf.FloorToInt(0.25f * evSpDef)) * livello) + 5) * 1;
        velocità = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SPE + iv.Spe + Mathf.FloorToInt(0.25f * evSpe)) * livello) + 5) * 1;
    }
}
