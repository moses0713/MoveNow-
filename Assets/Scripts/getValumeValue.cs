using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class getValumeValue : MonoBehaviour
{

    void Start()
    {
        //加載新場景不會銷毀
        DontDestroyOnLoad(gameObject);
    }


    void Update()
    {
        UpdateGameobjectValue();
        GetObjectValue();
    }

    //獲取音量值
    public void UpdateGameobjectValue()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        if(activeScene.name == "Setting")
        {
            GameObject audioSlider = GameObject.FindGameObjectWithTag("GameSettingUI").transform.GetChild(2).gameObject;
            PlayerPrefs.SetFloat("audioVolumeValue" , audioSlider.GetComponent<Slider>().value);
            print(PlayerPrefs.GetFloat("audioVolumeValue"));
        }
        
    }

    //賦值
    public void GetObjectValue()
    {

        Scene activeScene = SceneManager.GetActiveScene();
        if(activeScene.name == "New Scene")

        {
            
            GameObject fishingMapAudio = GameObject.Find("audioPlayTest").transform.gameObject;
            fishingMapAudio.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("audioVolumeValue");

        }

     
        
    }
    
}
