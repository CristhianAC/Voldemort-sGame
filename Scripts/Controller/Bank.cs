using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodoManagment;

public class Bank : MonoBehaviour
{
    public GameController gameController;
    void Start()
    {
        gameController = GetComponent<GameController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void comprar(characterController personaje, Nodo current)
    {
        
    }
    public void cobrar_vivienda(characterController personaje, Nodo current)
    {
        
    }
}
