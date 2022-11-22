using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NodoManagment
{
    public class Nodo
    {
        public Nodo next = null;
        public GameObject objeto;
        public float precio = 0;
        public float renta = 0;
        public Nodo(GameObject o)
        {
            next = null;
            objeto = o;
        }

    }
    class LinkedList
    {
        public Nodo jail;
        public Nodo PTR;
        private Nodo Last;
        public LinkedList ()
        {   
            jail = null;
            PTR = null;
            Last = null;
        }
        public void addnode(GameObject objetoo)
        {
            Nodo nodo = new Nodo(objetoo);
            if(PTR == null)
            {
                PTR = nodo;
                Last = nodo;
            }
            else
            {
                Last.next = nodo;
                Last = nodo;
            }
            Last.next = PTR;
        }
        public void add_jail(GameObject objetoo)
        {
            Nodo nodo = new Nodo(objetoo);
            if (PTR == null)
            {
                PTR = nodo;
                Last = nodo;
            }
            else
            {
                Last.next = nodo;
                Last = nodo;
            }
            jail= nodo;
            Last.next = PTR;
        }
        public void givemestate()
        {
            if (PTR == null)
            {
                Debug.Log("Esta vacia la lista");
            }
            else
            {
                Debug.Log("Esta llena");
            }
        }
    }
}
