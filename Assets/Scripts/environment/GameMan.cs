using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Environment
{


    public class GameMan : MonoBehaviour
    {
        public static GameMan instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
                //oyun yeniden yüklendiğinde obje yok olmasin
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void EndGame()
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
            //oyun sonu mensü burada gerceklesicek 
        }

        public void RestartGame()
        {
            Time.timeScale = 1; //zaman ölçegi normale dönsünn
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
