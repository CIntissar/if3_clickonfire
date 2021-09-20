using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeCheck : MonoBehaviour
{
    // faire un lien entre levelmanager et ce script...mais casse tête
    public LevelManager manager;
    public bool isTouched = false;

    void Start()
    {
        manager = GetComponent<LevelManager>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // Quand le clic gauche(=0 / 1 = droite / 2 = roulette)
        {
            Debug.Log("MEURS!");    
        }   
    }
}
