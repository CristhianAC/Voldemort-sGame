using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JSONReader {

    public static compra_propiedades GetJSON(TextAsset json) {
        compra_propiedades example = JsonUtility.FromJson<compra_propiedades>(json.text);
        return example;
    
    }

}
[System.Serializable]
public class compra_propiedades {


    public int Home;
    public int Gringots;
    public int Crashed;
    public int RoomOfRequirement;
    public int Sign;
    public int Bus;
    public int DumbledoreOffice;
    public int MagicMinister;
    public int Library;
    public int LestrangeVault;
    public int GoToAzkaban;
    public int ChamberOfSecrets;
    public int FlooNetwork;
	public int Grimmauld;
    public int Olivanders;
    public int FlyingCar;
    public int Flourish;
    public int AstronomyTower;
    public int Sign2;
    public int TheThreeBroomSticks;
    public int FreeSocks;
    public int GreatHall;
    public int ShellCottage;
    public int MagicMinistery2;
    public int WeaslyWizard;
    public int Ship;
    public int QuidditchPitch;
    public int TheLeakyCuadron;
    public int OwlPost;
    public int TheBurrow;
    public int VisitPrison;
    public int HoneyDukes;
    public int HogsHeadInn;
    public int Sign3;
    public int HagridsHut;
	public int cuartos;
    public int FluffyAttack;
    public int ShriekingShack;
    public int MagicMinistery3;
    public int CupboardUnderTheStairs;
}