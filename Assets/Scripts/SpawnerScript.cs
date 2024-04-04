using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnerScript : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int counter;
    public GameObject[] myObjects;
    

    public void butoon(){
        counter++;
        numberText.text = counter + "";
    }
    
    public void Press(){
        
        int randomIndex = Random.Range(0,myObjects.Length);
        Instantiate(myObjects[randomIndex],transform.position,Quaternion.identity);
        //myObjects[randomIndex].XRGrabInteractable
    }
}
