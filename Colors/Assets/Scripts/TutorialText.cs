using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour {

 	//public GameObject menu; // Assign in inspector
     private bool isShowing =true;
 public Canvas CanvasObject; // Assign in inspector
     void Update() {
         if (Input.GetKeyDown("escape") ) {
          //   isShowing = !isShowing;
          // CanvasObject.enabled = !CanvasObject.enabled;
		 // Destroy(CanvasObject);
		 // CanvasObject.SetActive(isShowing);
		 CanvasObject.transform.position = new Vector3(0,0,4);
         }
     }
}




