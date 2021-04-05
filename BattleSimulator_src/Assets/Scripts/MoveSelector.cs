using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelector : MonoBehaviour
{
    int mossaSelezionata = -1;
    Mossa[] moveSet = new Mossa[4];
    

    private void Start()
    {
        moveSet = GetComponent<Stats>().mosse;
        for (int i=0; i<4; i++) 
            if (moveSet[i].NOME == "Null")
                Debug.Log("Disabilito tasto"); // da implementare nello script per l'UI
    }

    public void selezionaMossa(int numMossa) 
    {
        mossaSelezionata = numMossa;
        Debug.Log("Selezionata: " + moveSet[numMossa].NOME);
    }
}
