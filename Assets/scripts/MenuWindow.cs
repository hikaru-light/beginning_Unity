using UnityEngine;
using System.Collections;

public class MenuWindow : MonoBehaviour {

    void OnGUI(){
        GUI.Label(new Rect(10, 10, 1000, 1000), "MenuWindow");
    }
}
