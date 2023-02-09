using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobilecarcontroller : MonoBehaviour {
   int n;
    public PrometeoCarController PCC;


   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
        PCC.GoForward();  
}
}
