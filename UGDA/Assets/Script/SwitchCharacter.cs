using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject Caracter1;
    public GameObject Caracter2;
    public GameObject Caracter3;
    public void SwitchCharaterTo1()
    {
        Caracter1.SetActive(true);
        Caracter2.SetActive(false);
        Caracter3.SetActive(false);
    }
    public void SwitchCharaterTo2()
    {
        Caracter2.SetActive(true);
        Caracter1.SetActive(false);
        Caracter3.SetActive(false);
    }
    public void SwitchCharaterTo3()
    {
        Caracter3.SetActive(true);
        Caracter2.SetActive(false);
        Caracter1.SetActive(false);
    }
}
