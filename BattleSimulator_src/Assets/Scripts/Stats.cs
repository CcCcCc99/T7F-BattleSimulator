using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public Pokémon specie;
    SpriteRenderer estetica;
    [SerializeField] int livello;
    [SerializeField] Mossa[] moveSet = new Mossa[4];
    bool valid;

    IndividualValues iv = new IndividualValues();
    EffortValues ev = new EffortValues();

    // Info
    string nome;
    Sprite frontSprite;
    Sprite backSprite;
    List<Tipo> tipi;
    List<Mossa> mosseImparabili;

    // Statistiche
    int HP;
    int attFisico;
    int difFisica;
    int attSpeciale;
    int difSpeciale;
    int velocità;

    void Start()
    {
        setInfo();
        estetica = GetComponent<SpriteRenderer>();
        estetica.sprite = frontSprite;
        setStats();
        valid = checkMoveSet();
        //debugSpawn();
    }

    //-----------------------------------------------------------------------

    void setInfo()
    {
        nome = specie.NOME;
        frontSprite = specie.F_SPRITE;
        backSprite = specie.B_SPRITE;
        tipi = specie.TIPI;
        mosseImparabili = specie.MOVESET;
    }

    void setStats()
    {
        HP = calcolaHP();
        attFisico = calcolaStatistica(specie.ATT, iv.Att, ev.Att);
        difFisica = calcolaStatistica(specie.DEF, iv.Def, ev.Def);
        attSpeciale = calcolaStatistica(specie.SP_ATT, iv.SpAtt, ev.SpAtt);
        difSpeciale = calcolaStatistica(specie.SP_DEF, iv.SpDef, ev.SpDef);
        velocità = calcolaStatistica(specie.SPE, iv.Spe, ev.Spe);
    }

    bool checkMoveSet() 
    {
        foreach (Mossa x in moveSet) 
        {
            if (x.NOME!="Null" && !mosseImparabili.Contains(x))
                return false;
        }
        return true;
    }

    //-----------------------------------------------------------------------

    int calcolaHP() 
    {
        int quartoDiEv = Mathf.FloorToInt(0.25f * ev.Hp);
        int numFisso = (2 * specie.HP + iv.Hp + quartoDiEv * livello);
        return Mathf.FloorToInt(0.01f * numFisso) + livello + 10;
    }

    int calcolaStatistica(int Base, int Iv, int Ev) 
    {
        int quartoDiEv = Mathf.FloorToInt(0.25f * Ev);
        int numFisso = (2 * Base + Iv + quartoDiEv);
        float perLivello = Mathf.Floor(0.01f * numFisso * livello);
        return Mathf.FloorToInt(perLivello + 5) * 1;
    }

    //-----------------------------------------------------------------------

    void debugSpawn()
    {
        if (valid)
        {
            Debug.Log("Nome: " + nome + "\n" +
                "HP: " + HP + "\n" +
                "Attacco: " + attFisico + "\n" +
                "Difesa: " + difFisica + "\n" +
                "Attacco fisico: " + attSpeciale + "\n" +
                "Difesa fisica: " + difSpeciale + "\n" +
                "Velocità: " + velocità + "\n");
        }
        else
        {
            Debug.LogError("Pokémon invalido");
        }
    }
}
