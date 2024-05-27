using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    public AudioSource coinFX;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("streak");
            coinFX.Play();
            ColletableController.coinCount += 1;
            
            // Puan ekle
          //  ScoreManager.instance.AddScore(1);

            // Coin'i sil
            Destroy(other.gameObject);
        }
    }
    
    
}