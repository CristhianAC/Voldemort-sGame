using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Specials : Sitios
{
    public Text Title;
    public Text Description;
    public GameController gameController;
    public GameObject events_menu;
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void go_azkaban()
    {
        Title.text = "Oh sh*t, here we go again";
        Description.text = "Vuelves a las manos de los dementores de azkaban";
        if (gameController.currentPlayer.no_carcel == 0)
        {
            gameController.currentPlayer.free = false;
            gameController.currentPlayer.dias_carcel = 4;
        }
        gameController.cambiarDeTurno();
    }
    public override void accionar()
    {
        string nombre = gameController.currentPlayer.listController.current.objeto.name;
        if(nombre == "GoToAzkaban")
        {
            go_azkaban(); 
        }
        else if (nombre == "Sign1" || nombre ==  "Sign2" || nombre ==  "Sign3")
        {
            sign();
        }
        else 
        {
            tesoro();
        }
        gameController.pause.SetActive(false);
        events_menu.SetActive(true);
        gameController.button.SetActive(false);
    }
    public void tesoro()
    {
        int random = Random.Range(1, 2);
        int[] sueldos = { 150, 250, 350, 450 };
        int random_precios = Random.Range(0, sueldos.Length);
        int sueldo = sueldos[random_precios];

        switch (random)
        {
            case 1:          //Dar dinero
                Title.text = "El banco Gringots hoy viene humilde";
                Description.text = "Gringots te ha dado la cantida de " + sueldo + " Galeón";
                gameController.currentPlayer.dinero += sueldo;
                gameController.cambiarDeTurno();
                break;
            case 2:         //Quitar dinero
                Title.text = "Nos descubrieron la evacion de impuestos :c";
                Description.text = "Gringots te ha quitado la cantida de " + sueldo + " Galeón";
                gameController.currentPlayer.dinero -= sueldo;
                gameController.cambiarDeTurno();
                break;
        }
    }
 
    public void sign() 
    {
        int random = Random.Range(1, 4);
        int[] sueldos = { 150, 250, 350, 450 };
        int random_precios = Random.Range(0, sueldos.Length);
        int sueldo = sueldos[random_precios];
        


        switch (random)
        {
            case 1:          //Dar dinero
                Title.text = "El banco Gringots hoy viene humilde";
                Description.text = "Gringods te ha dado la cantida de " + sueldo + " Galeón";
                gameController.currentPlayer.dinero += sueldo;
                gameController.cambiarDeTurno();
                break;
            case 2:         //Quitar dinero
                Title.text = "Nos descubrieron la evacion de impuestos :c";
                Description.text = "Gringots te ha quitado la cantida de " + sueldo + " Galeón";
                gameController.currentPlayer.dinero -= sueldo;
                gameController.cambiarDeTurno();
                break;
            case 3:         
                Title.text = "Oh sh*t, here we go again";
                Description.text = "Vuelves a las manos de los dementores de azkaban";
                if (gameController.currentPlayer.no_carcel == 0)
                {
                    gameController.currentPlayer.free = false;
                    gameController.currentPlayer.dias_carcel = 4;
                    gameController.cambiarDeTurno();
                }
                else 
                {
                    gameController.currentPlayer.no_carcel--;
                }
                break;
            case 4:
                Title.text = "Logragas escapar azkaban";
                Description.text = "Eres el nuevo sirius black de la nueva era";
                gameController.currentPlayer.no_carcel++;
                break;


        }
            

    }

}
