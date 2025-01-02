using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuUI; // UI Pause Menu

    public static bool isPaused = false;

    void Start()
    {
        
    }

    // Fungsi untuk melanjutkan permainan
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Reset waktu ke normal
        isPaused = false;    // Reset status pause
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;            // Pastikan waktu kembali berjalan
        isPaused = false;               // Reset status pause

        // Cari skrip waktu dan mulai ulang timer
        waktu waktu = FindObjectOfType<waktu>();
        if (waktu != null)
        {
            waktu.RestartTimer(); // Restart timer
        }
        // Reload scene untuk mengatur ulang permainan (opsional jika ingin reset penuh)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Fungsi untuk kembali ke menu utama
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Pastikan waktu berjalan normal
        isPaused = false;    // Reset status pause
        SceneManager.LoadScene("menu"); // Ganti dengan nama scene menu utama Anda
    }

    // Fungsi untuk pause game
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Memberhentikan waktu
        isPaused = true;
    }

    void Update()
    {
        // Deteksi jika tombol ESC ditekan untuk pause/unpause game
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
}