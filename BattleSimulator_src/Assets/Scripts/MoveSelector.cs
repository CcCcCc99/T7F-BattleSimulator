using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSelector : MonoBehaviour
{
    int mossaSelezionata = -1;
    Mossa[] moveSet;

    // da spostare nella classe per la ui
    [SerializeField] Button[] arrButton = new Button[4];
    [SerializeField] GameObject pulsanti;
    

    private void Start()
    {
        if (!GetComponent<Stats>().isAlleato)
            pulsanti.transform.position = new Vector2(0, 280); // non funziona -164.7104f
        moveSet = GetComponent<Stats>().mosse;
        for (int i = 0; i < 4; i++)
            if (moveSet[i].NOME == "Null")
                arrButton[i].interactable = false; // da implementare nello script per l'UI
    }

    public void selezionaMossa(int numMossa) 
    {
        mossaSelezionata = numMossa;
        Debug.Log("Selezionata: " + moveSet[numMossa].NOME);
    }
}
