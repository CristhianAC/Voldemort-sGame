using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NodoManagment;

public class GameController : MonoBehaviour
{
    public GameObject jail;
    public Text text;
    public int turn;
    public dadoController dadoController;
    public dadoController dadoController2;
    public characterController harryPotter;
    public characterController hermione;
    CamController camController;
    public GameObject button;
    int cantidad;
    [SerializeField] private ListController listController;
    public characterController currentPlayer;
    public characterController otherPlayer;
    public Dictionary<string, string> lugares = new Dictionary<string, string>();
    int definirturnoharry = 0;
    int definirtturnohermione = 0;
    public Text selcting;
    public Text infoSite;
    public GameObject menuFinal;
    public Text Quiengana;
    public Text info;
    public GameObject pause;
    public Text plata1;
    public Text plata2;

    public Text Dias_carcel_Harry;
    public Text Dias_carcel_Hermione;

    void Start()
    {
        text.gameObject.SetActive(false);
        turn = -1;
        

        camController = gameObject.GetComponent<CamController>();
        for (int i = 0; i < listController.coords.Length; i++)
        {
            lugares.Add(listController.coords[i].name, null);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
        text.text = "Es turno del jugador " + turn.ToString();

        switch (turn)
        {
            case 1:
                currentPlayer = harryPotter;
                otherPlayer = hermione;
                break;
            case 2:
                currentPlayer = hermione;
                otherPlayer = harryPotter;
                break;

        }
        plata1.text = "Dinero de Harry: "+harryPotter.dinero;
        plata2.text = "Dinero de Hermione: "+hermione.dinero;

        Dias_carcel_Harry.text = "Dias en la carcel de Harry: " + harryPotter.dias_carcel;
        Dias_carcel_Hermione.text = "Dias en la carcel de Hermione: " + hermione.dias_carcel;

        if (harryPotter.dias_carcel == 0)
        {
            Dias_carcel_Harry.gameObject.SetActive(false); 
        }
        else 
        {
            Dias_carcel_Harry.gameObject.SetActive(true);
        }
        if (hermione.dias_carcel == 0)
        {
            Dias_carcel_Hermione.gameObject.SetActive(false);
        }
        else
        {
            Dias_carcel_Hermione.gameObject.SetActive(true);
        }

        if (!currentPlayer.free)
        {
            currentPlayer.dias_carcel--;
            cambiarDeTurno();
        }
        if (harryPotter.dinero<=0 || hermione.dinero <= 0)
        {
            button.SetActive(false);
            if (harryPotter.dinero <= 0)
            {
                Quiengana.text = "El jugador " + hermione.gameObject.name + " ha ganado.";
            }else if (hermione.dinero <= 0)
            {
                Quiengana.text =  "El jugador " + harryPotter.gameObject.name + " ha ganado.";
            }
            
            menuFinal.SetActive(true);
            
        }
    }
    public void cambiarDeTurno()
    {
        turn++;
        
   

        if (turn > 2)
        {
            turn = 1;
            
        }
        
        
    }


    public void check(Nodo current)
    {
        Sitios script = current.objeto.GetComponent<Sitios>();
        if (lugares[current.objeto.name] == null )
        {
            script.accionar();
            
        }else if (lugares[current.objeto.name] == currentPlayer.gameObject.name)
        {
            Casas casa = current.objeto.GetComponent<Casas>();
            casa.renta += 150;
        }
        else
        {
            Casas casa = current.objeto.GetComponent<Casas>();
            casa.cobrarRenta();
        }       
    }


    public void ejecutarTurno()
    {
        dadoController.movedice();
        dadoController2.movedice();
        cantidad = dadoController.dadospos + dadoController2.dadospos;
        button.SetActive(false);
        switch (turn)
        {
            case 1:
                text.gameObject.SetActive(true);
                selcting.gameObject.SetActive(false);
                camController.cameraActivate("HPCamera");
                harryPotter.setCantidadDePasos(cantidad);
                harryPotter.nextPos = true;

                break;
            case 2:
                text.gameObject.SetActive(true);
                selcting.gameObject.SetActive(false);
                camController.cameraActivate("HermioneCamera");
                hermione.setCantidadDePasos(cantidad);
                hermione.nextPos = true;
                
                break;
            default:
                

                if (turn == -1)
                {

                    definirturnoharry = dadoController.dadospos + dadoController2.dadospos;
                    cambiarDeTurno();
                    
                    
                }

                else if (turn == 0)
                {
                    
                    definirtturnohermione = dadoController.dadospos + dadoController2.dadospos;
                    cambiarDeTurno();
                    
                }

                if (definirtturnohermione > definirturnoharry)
                {
                    turn = 2;
                }
                else if (definirtturnohermione != 0 && definirturnoharry != 0)
                {
                    turn = 1;
                }

                button.SetActive(true);
                break;
        }
  
    }
    public void vender(GameObject ui)
    {
        Casas script = currentPlayer.listController.current.objeto.GetComponent<Casas>();
        string nameCurrent = currentPlayer.listController.current.objeto.name;


        currentPlayer.dinero -= script.precio;
        lugares[nameCurrent] = currentPlayer.gameObject.name;
        print("El objeto "+nameCurrent+" Le pertenece a: "+lugares[nameCurrent]);
        button.SetActive(true);
        ui.SetActive(false);
        cambiarDeTurno();
    } 
    public void noVender(GameObject ui)
    {
        ui.SetActive(false);
        button.SetActive(true);
        cambiarDeTurno();
    }
   
}
