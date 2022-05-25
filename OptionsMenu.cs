using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    //[SerializeField] GameObject VisualsPanel;
    [SerializeField] GameObject ControlsPanel;   
    [SerializeField] GameObject SavePanel;   
    [SerializeField] GameObject MenuPanel;
    [SerializeField] PostProcessLayer MyLayer;
    public Slider LightSlider;
    
    void Start()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
        //VisualsPanel.gameObject.SetActive(true);
        ControlsPanel.gameObject.SetActive(false);
        SavePanel.gameObject.SetActive(false);
        MenuPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    // public void LightValue()
    // {
    //     RenderSettings.ambientIntensity = LightSlider.value;
    // }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1); 
    }

    // public void Visuals()
    // {
    //     VisualsPanel.gameObject.SetActive(true);
    //     ControlsPanel.gameObject.SetActive(false);
    //     SavePanel.gameObject.SetActive(false);
    //     MenuPanel.gameObject.SetActive(false);
    // }

    public void Controls()
    {
        //VisualsPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(true);
        SavePanel.gameObject.SetActive(false);
        MenuPanel.gameObject.SetActive(false);
    }

    public void Save()
    {
        //VisualsPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(false);
        SavePanel.gameObject.SetActive(true);
        MenuPanel.gameObject.SetActive(false);
    }

    public void Menu()
    {
        //VisualsPanel.gameObject.SetActive(false);
        ControlsPanel.gameObject.SetActive(false);
        SavePanel.gameObject.SetActive(false);
        MenuPanel.gameObject.SetActive(true);
    }
}
