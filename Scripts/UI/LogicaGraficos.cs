using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaGraficos : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public int graficos;
    // Start is called before the first frame update
    void Start()
    {
        graficos = PlayerPrefs.GetInt("numeroDeGraficos", 3);
        dropdown.value = graficos;
        AjustarGraficos();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AjustarGraficos()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeGraficos", dropdown.value);
        graficos = dropdown.value;
    }
}
