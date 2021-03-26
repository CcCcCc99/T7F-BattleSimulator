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

    //---------------------------------------------------

    public float relazioneTipo(Tipo att)
    {
        if (immunità.Contains(att)) return 0f;
        else if (resistenze.Contains(att)) return 0.5f;
        else if (debolezze.Contains(att)) return 2f;
        else return 1f;
    }

    //---------------------------------------------------

    public string NOME {
        get { return nome; } 
    }
    public Color COLORE {
        get { return colore; }
    }
    // TODO da testare assolutante cosa ritorna questa cosa
    // magari su un progetto separato
    public List<Tipo> IMMUNITA {
        get { return immunità; }
    }
    public List<Tipo> RESISTENZA{
        get { return resistenze; }
    }
    public List<Tipo> DEBOLEZZE{
        get { return debolezze; }
    }
}
