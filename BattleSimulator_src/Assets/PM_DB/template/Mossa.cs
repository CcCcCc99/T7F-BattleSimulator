using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mossa : ScriptableObject
{
    [SerializeField] string nome;
    [SerializeField] Tipo tipo;
    [SerializeField] int puntiPotere;
    [SerializeField] int precisione;

    public string NOME {
        get { return nome; }
    }
    public Tipo TIPO{
        get { return tipo; }
    }
    public int PP{
        get { return puntiPotere; }
    }
    public int PRECISIONE {
        get { return precisione; }
    }
}
