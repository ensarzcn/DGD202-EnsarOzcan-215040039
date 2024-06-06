using UnityEngine;
using UnityEngine.SceneManagement;

//Created with ai
//Pressing the ESC key pauses the game and returns to the main menu.
public class PauseAndReturnToMenu : MonoBehaviour
{
    private static PauseAndReturnToMenu instance;
    private static bool isPaused = false;
    private static int previousSceneIndex = -1;

    void Awake()
    {
        // Singleton deseni ile bu script'in tek bir instance olmasýný saðla
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // ESC tuþuna basýldýðýnda iþlemleri kontrol et
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
        isPaused = true;
        Time.timeScale = 0f; // Oyunu durdur
        SceneManager.LoadScene(0); // Ana menü sahnesine geç
    }

    void ResumeGame()
    {
        SceneManager.LoadScene(previousSceneIndex); // Önceki sahneye dön
    }

    // Sahne yüklendiðinde çaðrýlacak
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == previousSceneIndex && isPaused)
        {
            // Eðer sahne geri yüklendiyse, zamaný yeniden baþlat
            Time.timeScale = 1f;
            isPaused = false;
        }
        else if (scene.buildIndex == 0 && isPaused)
        {
            // Eðer ana menü sahnesine geçtiysek, zamaný durdurmaya devam et
            Time.timeScale = 0f;
        }
    }
}
