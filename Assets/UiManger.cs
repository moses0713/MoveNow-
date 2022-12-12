using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManger : MonoBehaviour
{
    private EasyLanguage m_el;

    private void Awake() {

        m_el = EasyLanguage.GetInstance();

    } 
    public void OnButtonChineseClicked(){

        m_el.ChangeLanguage(EasyLanguage.LanguageList.cn);

    }
    public void OnButtonEnglishClicked(){

        m_el.ChangeLanguage(EasyLanguage.LanguageList.en);

    }
}
