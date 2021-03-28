using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsAndBehaviour : MonoBehaviour
{
    public Pokémon specie;
    [SerializeField] int livello;
    [SerializeField] Mossa[] moveSet = new Mossa[4];

    [SerializeField] int iv_hp;
    [SerializeField] int iv_att;
    [SerializeField] int iv_def;
    [SerializeField] int iv_spAtt;
    [SerializeField] int iv_spDef;
    [SerializeField] int iv_spe;

    [SerializeField] int ev_hp;
    [SerializeField] int ev_att;
    [SerializeField] int ev_def;
    [SerializeField] int ev_spAtt;
    [SerializeField] int ev_spDef;
    [SerializeField] int ev_spe;

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
        getStats();
    }

    void getStats()
    {
        HP = Mathf.FloorToInt(0.01f * (2 * specie.HP + iv_hp + Mathf.FloorToInt(0.25f * ev_hp)) * livello) + livello + 10;
        attFisico = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.ATT + iv_att + Mathf.FloorToInt(0.25f * ev_att)) * livello) + 5) * 1;
        difFisica = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.DEF + iv_def + Mathf.FloorToInt(0.25f * ev_def)) * livello) + 5) * 1;
        attSpeciale = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SP_ATT + iv_spAtt + Mathf.FloorToInt(0.25f * ev_spAtt)) * livello) + 5) * 1;
        difSpeciale = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SP_DEF + iv_spDef + Mathf.FloorToInt(0.25f * ev_spDef)) * livello) + 5) * 1;
        velocità = Mathf.FloorToInt(Mathf.Floor(0.01f * (2 * specie.SPE + iv_spe + Mathf.FloorToInt(0.25f * ev_spe)) * livello) + 5) * 1;
    }
}
