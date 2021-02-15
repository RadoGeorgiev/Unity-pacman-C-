using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D co) {
        // Do Stuff
        if (co.name == "pacman")
            Destroy(gameObject);
    }
}
