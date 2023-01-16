using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject Charater1;
    public GameObject Charater2;
    public GameObject Charater3;
    public void SwitchCharaterTo1()
    {
        //Will switch to Charater 1
        Charater1.SetActive(true);
        Charater2.SetActive(false);
        Charater3.SetActive(false);
    }
    public void SwitchCharaterTo2()
    {
        //Will switch to Charater 2
        Charater2.SetActive(true);
        Charater1.SetActive(false);
        Charater3.SetActive(false);
    }
    public void SwitchCharaterTo3()
    {
        //Will switch to Charater 3
        Charater3.SetActive(true);
        Charater2.SetActive(false);
        Charater1.SetActive(false);
    }
}
