using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class tombol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void scale(float scale) {
        transform.localScale = new Vector2(1/scale, 1*scale);
    }

    public void scane (string scane) {
        SceneManager.LoadScene(scane);
        Time.timeScale = 1f;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
