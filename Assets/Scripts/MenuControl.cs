using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;

    private void Start()
    {
        volume = PlayerPrefs.GetFloat("volume");
        volumeSlider.value = volume;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolume()
    {
        volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }
}
