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
        // Singleton deseni ile bu script'in tek bir instance olmas�n� sa�la
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
        // ESC tu�una bas�ld���nda i�lemleri kontrol et
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
        SceneManager.LoadScene(0); // Ana men� sahnesine ge�
    }

    void ResumeGame()
    {
        SceneManager.LoadScene(previousSceneIndex); // �nceki sahneye d�n
    }

    // Sahne y�klendi�inde �a�r�lacak
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
            // E�er sahne geri y�klendiyse, zaman� yeniden ba�lat
            Time.timeScale = 1f;
            isPaused = false;
        }
        else if (scene.buildIndex == 0 && isPaused)
        {
            // E�er ana men� sahnesine ge�tiysek, zaman� durdurmaya devam et
            Time.timeScale = 0f;
        }
    }
}
