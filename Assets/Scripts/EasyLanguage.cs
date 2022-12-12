using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLanguage 
{
    private static EasyLanguage m_instance;
    public static EasyLanguage GetInstance(){

        if(m_instance == null)
        {
             m_instance = new EasyLanguage();
        }

        return m_instance;
    }


    public enum LanguageList{
        en,
        cn,
    }
    // key= StartGame , value = 開始遊戲
    public Dictionary<string , string >m_dic_elt;

    private List<EasyLanguageT> m_list_elt;

    private LanguageList m_currentLanguage; 
    EasyLanguage()
    {
        m_dic_elt = new Dictionary<string, string>();
        m_list_elt = new List<EasyLanguageT>();
        m_currentLanguage = LanguageList.cn;
        
        OnLanguageChanged();
       
    }

    public void RegisterELT (EasyLanguageT elt){

        m_list_elt.Add(elt);

    } 

    public void UnregisterELT (EasyLanguageT elt){

        m_list_elt.Remove(elt);
    }

    public void ChangeLanguage(LanguageList ll){

        m_currentLanguage = ll;
        m_dic_elt.Clear();
        OnLanguageChanged();
    }

    //語言切換
    public void OnLanguageChanged(){

        if(m_currentLanguage == LanguageList.cn)
            {

            m_dic_elt.Add("Music" ,"音樂");
            m_dic_elt.Add("Sound" ,"音效");
            
            }

            else{

            m_dic_elt.Add("Music" ,"Music");
            m_dic_elt.Add("Sound" ,"Sound");


            }
        foreach (var elt in m_list_elt){
            elt.OnLanguageChanged();
        }
    }

    public string GetTextByKey(string key){

        return m_dic_elt[key];
    }
}
