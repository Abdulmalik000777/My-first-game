using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour

{

    int hits = 0;
    private void OnCollisionEnter(Collision other) 
 {
    if(other.gameObject.tag != "Hit" ) // != means doesnt equal
    hits ++ ; // i can simply write hits++ too instead of hits = hits +1
    Debug.Log ("You are hitting the walls so many times :" + hits);   
 
 }
}
