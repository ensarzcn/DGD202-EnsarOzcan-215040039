using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//Created with ai.
//Düþman tanký, kendi tankýmýza temas edice oyunun yeniden baþlamasýný saðlar.

public class TankCollision : MonoBehaviour
{
    // Çarpýþma algýlandýðýnda çaðrýlýr
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tank")) // Oyuncunun tankýna "PlayerTank" tag'i eklemelisiniz
        {
            Destroy(collision.gameObject); // Oyuncunun tankýný yok et
            RestartGame(); // Oyunu yeniden baþlat
        }
    }

    // Oyunu yeniden baþlatma iþlemi
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Geçerli sahneyi yeniden yükler
    }
}
