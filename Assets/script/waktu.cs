using UnityEngine; 
using UnityEngine.UI; 
 
public class waktu : MonoBehaviour 
{ 
    public float timeRemaining = 60f; // Waktu mulai (1 menit) 
    public Text timeDisplay; // Untuk menampilkan waktu di UI 
    public bool isGameOver = false; // Status apakah game selesai 
    public bool isTimerStarted = true; // Kontrol apakah timer dimulai (default true untuk loop) 
 
    void Update() 
    { 
        // Timer hanya berjalan jika tidak pause, permainan belum selesai, dan timer dimulai 
        if (!PauseMenuController.isPaused && !isGameOver && isTimerStarted) 
        { 
            // Timer hanya berjalan jika waktu lebih besar dari 0 
            if (timeRemaining > 0) 
            { 
                timeRemaining -= Time.deltaTime; // Kurangi waktu setiap frame 
                DisplayTime(timeRemaining); 
            } 
            else 
            { 
                // Jika waktu habis, reset waktu dan mulai ulang 
                RestartTimer(); 
            } 
        } 
        else if (isGameOver) 
        { 
            // Jika permainan selesai, hentikan waktu 
            Time.timeScale = 0f; 
        } 
    } 
 
    void DisplayTime(float time) 
    { 
        int minutes = Mathf.FloorToInt(time / 60); 
        int seconds = Mathf.FloorToInt(time % 60); 
        timeDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
    } 
 
    public void RestartTimer() 
    { 
        timeRemaining = 60f; // Atur ulang waktu ke 60 detik 
        isGameOver = false;  // Reset status game selesai 
        Debug.Log("Timer dimulai ulang!"); 
    } 
 
    // Metode untuk menandai permainan selesai 
    public void EndGame() 
    { 
        isGameOver = true; // Set status permainan selesai 
        PauseMenuController.isPaused = true; // Hentikan permainan jika diperlukan 
        Time.timeScale = 0f; // Hentikan waktu dalam game 
        Debug.Log("Permainan selesai!"); 
    } 
}