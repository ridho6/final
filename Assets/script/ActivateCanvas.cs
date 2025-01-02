using UnityEngine;

public class ActivateCanvas : MonoBehaviour
{
    public GameObject soal1;
    public GameObject selesai;
    public GameObject CanvasSelesai;

    void Update()
    {
        // Cek apakah GameObject 'selesai' aktif
        if (selesai.activeSelf && !CanvasSelesai.activeSelf)
        {
            // Aktifkan 'CanvasSelesai'
            CanvasSelesai.SetActive(true);
        }
    }

    public void HideCanvasSelesai()
    {
        selesai.SetActive(false);
        CanvasSelesai.SetActive(false);
        soal1.SetActive(true); // Ubah status GameObject'soal1' menjadi aktif kembali
    }
}
