using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum Screen { Home, Watch, Sound, TV, Light };

    [SerializeField] private GameObject _home;
    [SerializeField] private GameObject _watch;
    [SerializeField] private GameObject _sound;
    [SerializeField] private GameObject _tv;
    [SerializeField] private GameObject _light;

    public TextMeshProUGUI _w1;
    public TextMeshProUGUI _w1s;
    public TextMeshProUGUI _w1b;
    public TextMeshProUGUI _w1bl;
    public TextMeshProUGUI _w1c;
    public TextMeshProUGUI _w1se;

    public TextMeshProUGUI _cw1;
    public TextMeshProUGUI _cw1s;
    public TextMeshProUGUI _cw1b;
    public TextMeshProUGUI _cw1bl;
    public TextMeshProUGUI _cw1c;

    public Screen currentScreen = Screen.Home;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region ScreenCheck
        if (currentScreen == Screen.Home)
        {
            _home.SetActive(true);
        }
        else { _home.SetActive(false); }

        if (currentScreen == Screen.Watch)
        {
            _watch.SetActive(true);
        }else { _watch.SetActive(false); }

        if (currentScreen == Screen.Sound)
        {
            _sound.SetActive(true);
        }else { _sound.SetActive(false); }

        if (currentScreen == Screen.TV)
        {
            _tv.SetActive(true);
        }else { _tv.SetActive(false); }

        if(currentScreen == Screen.Light)
        {
            _light.SetActive(true);
        }else { _light.SetActive(false); }
        #endregion
    }

    #region ScreenFunctions
    public void HomeScreen()
    {
        currentScreen = Screen.Home;
    }

    public void WatchScreen()
    {
        currentScreen = Screen.Watch;
    }

    public void SoundScreen()
    {
        currentScreen = Screen.Sound;
    }

    public void TVScreen()
    {
        currentScreen = Screen.TV;
    }

    public void LightScreen()
    {
        currentScreen = Screen.Light;
    }
    #endregion



}
