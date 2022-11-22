using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Casas : Sitios
{
    public GameObject menu;
    public GameController gameController;
    public int precio = 0;
    public float renta;
    public TextAsset json;
    string gameObject_name;
    
    void Start()
    {
        gameObject_name = gameObject.name;
        if(gameObject_name == "Gringots")
        {
            precio = JSONReader.GetJSON(json).Gringots;
        }else if (gameObject_name == "RoomOfRequirement")
        {
            precio = JSONReader.GetJSON(json).RoomOfRequirement;
        }
        else if (gameObject_name == "Sign")
        {
            precio = JSONReader.GetJSON(json).Sign;
        }
        else if (gameObject_name == "Bus")
        {
            precio = JSONReader.GetJSON(json).Bus;
        }
        else if (gameObject_name == "DumbledoreOffice")
        {
            precio = JSONReader.GetJSON(json).DumbledoreOffice;
        }
        else if (gameObject_name == "MagicMinister")
        {
            precio = JSONReader.GetJSON(json).MagicMinister;
        }
        else if (gameObject_name == "Library")
        {
            precio = JSONReader.GetJSON(json).Library;
        }
        else if (gameObject_name == "LestrangeVault")
        {
            precio = JSONReader.GetJSON(json).LestrangeVault;
        }
        else if (gameObject_name == "GoToAzkaban")
        {
            precio = JSONReader.GetJSON(json).GoToAzkaban;
        }
        else if (gameObject_name == "ChamberOfSecrets")
        {
            precio = JSONReader.GetJSON(json).ChamberOfSecrets;
        }
        else if (gameObject_name == "FlooNetwork")
        {
            precio = JSONReader.GetJSON(json).FlooNetwork;
        }
        else if (gameObject_name == "Grimmauld")
        {
            precio = JSONReader.GetJSON(json).Grimmauld;
        }
        else if (gameObject_name == "Olivanders")
        {
            precio = JSONReader.GetJSON(json).Olivanders;
        }
        else if (gameObject_name == "FlyingCar")
        {
            precio = JSONReader.GetJSON(json).FlyingCar;
        }
        else if (gameObject_name == "Flourish")
        {
            precio = JSONReader.GetJSON(json).Flourish;
        }
        else if (gameObject_name == "AstronomyTower")
        {
            precio = JSONReader.GetJSON(json).AstronomyTower;
        }
        else if (gameObject_name == "Sign2")
        {
            precio = JSONReader.GetJSON(json).Sign2;
        }
        else if (gameObject_name == "TheThreeBroomSticks")
        {
            precio = JSONReader.GetJSON(json).TheThreeBroomSticks;
        }
        else if (gameObject_name == "FreeSocks")
        {
            precio = JSONReader.GetJSON(json).FreeSocks;
        }
        else if (gameObject_name == "GreatHall")
        {
            precio = JSONReader.GetJSON(json).GreatHall;
        }
        else if (gameObject_name == "ShellCottage")
        {
            precio = JSONReader.GetJSON(json).ShellCottage;
        }
        else if (gameObject_name == "MagicMinistery2")
        {
            precio = JSONReader.GetJSON(json).MagicMinistery2;
        }
        else if (gameObject_name == "WeaslyWizard")
        {
            precio = JSONReader.GetJSON(json).WeaslyWizard;
        }
        else if (gameObject_name == "Ship")
        {
            precio = JSONReader.GetJSON(json).Ship;
        }
        else if (gameObject_name == "QuidditchPitch")
        {
            precio = JSONReader.GetJSON(json).QuidditchPitch;
        }
        else if (gameObject_name == "TheLeakyCuadron")
        {
            precio = JSONReader.GetJSON(json).TheLeakyCuadron;
        }
        else if (gameObject_name == "OwlPost")
        {
            precio = JSONReader.GetJSON(json).OwlPost;
        }
        else if (gameObject_name == "TheBurrow")
        {
            precio = JSONReader.GetJSON(json).TheBurrow;
        }
        else if (gameObject_name == "VisitPrison")
        {
            precio = JSONReader.GetJSON(json).VisitPrison;
        }
        else if (gameObject_name == "HoneyDukes")
        {
            precio = JSONReader.GetJSON(json).HoneyDukes;
        }
        else if (gameObject_name == "HogsHeadInn")
        {
            precio = JSONReader.GetJSON(json).HogsHeadInn;
        }
        else if (gameObject_name == "Sign3")
        {
            precio = JSONReader.GetJSON(json).Sign3;
        }
        else if (gameObject_name == "HagridsHut")
        {
            precio = JSONReader.GetJSON(json).HagridsHut;
        }
        else if (gameObject_name == "cuartos")
        {
            precio = JSONReader.GetJSON(json).cuartos;
        }
        else if (gameObject_name == "FluffyAttack")
        {
            precio = JSONReader.GetJSON(json).FluffyAttack;
        }
        else if (gameObject_name == "ShriekingShack")
        {
            precio = JSONReader.GetJSON(json).ShriekingShack;
        }
        else if (gameObject_name == "MagicMinistery3")
        {
            precio = JSONReader.GetJSON(json).MagicMinistery3;
        }
        else if (gameObject_name == "CupboardUnderTheStairs")
        {
            precio = JSONReader.GetJSON(json).CupboardUnderTheStairs;
        }



        
        renta = precio / 2;

    }

    
    void Update()
    {
        
    }
    public override void accionar () 
    {
        int casa = gameController.currentPlayer.listController.current.objeto.GetComponent<Casas>().precio;
        gameController.infoSite.text = "El lugar a comprar es " + gameController.currentPlayer.listController.current.objeto.name + " y el precio es " + 
           casa;
        if (gameController.currentPlayer.dinero >= casa)
        {
            menu.SetActive(true);
            gameController.pause.SetActive(false);
        }
        

        else {
            gameController.button.SetActive(true);
            gameController.cambiarDeTurno();
        }
        
    }
    public void cobrarRenta()
    {
        
        float renta = gameController.currentPlayer.listController.current.objeto.GetComponent<Casas>().renta;
        gameController.info.text = gameController.currentPlayer.gameObject.name + " pagó por renta " + renta + " a " + gameController.otherPlayer.gameObject.name;
        gameController.currentPlayer.dinero -= renta;
        gameController.otherPlayer.dinero += renta;

        gameController.button.SetActive(true);
        gameController.cambiarDeTurno();
    }

}
