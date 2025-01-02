using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour {
    public GameObject feed_benar, feed_salah;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    public void jawaban(bool jawab) {
        if (jawab) {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            feed_salah.SetActive(false);
            int skor = PlayerPrefs.GetInt("skor") + 20;
            PlayerPrefs.SetInt("skor", skor);
        } else {
            feed_benar.SetActive(false);
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") - 20;
            PlayerPrefs.SetInt("skor", skor);
            if (skor < 0) {
                skor = 0;
            }
            PlayerPrefs.SetInt("skor", skor);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild (gameObject.transform.GetSiblingIndex () + 1).gameObject.SetActive(true);
    }
    // Misalnya di dalam skrip yang menangani soal

    // Update is called once per frame
    void Update() {
        
    }
}