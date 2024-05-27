using System.Collections;
using System.Collections.Generic;
using Environment;
using UnityEngine;

    public class Obstacle : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("obstacle"))
            {
                GameMan.instance.EndGame();
            }
        }
    }

