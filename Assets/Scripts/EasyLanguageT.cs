using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyLanguageT : MonoBehaviour
{

    public string m_Key;
    private Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_text = GetComponent<Text>();

        EasyLanguage.GetInstance().RegisterELT(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLanguageChanged(){

        m_text.text = EasyLanguage.GetInstance().GetTextByKey(m_Key);
    }
}
