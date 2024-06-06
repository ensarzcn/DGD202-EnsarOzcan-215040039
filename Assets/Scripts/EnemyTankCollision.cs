using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//Created with ai.
//D��man tank�, kendi tank�m�za temas edice oyunun yeniden ba�lamas�n� sa�lar.

public class TankCollision : MonoBehaviour
{
    // �arp��ma alg�land���nda �a�r�l�r
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tank")) // Oyuncunun tank�na "PlayerTank" tag'i eklemelisiniz
        {
            Destroy(collision.gameObject); // Oyuncunun tank�n� yok et
            RestartGame(); // Oyunu yeniden ba�lat
        }
    }

    // Oyunu yeniden ba�latma i�lemi
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Ge�erli sahneyi yeniden y�kler
    }
}
