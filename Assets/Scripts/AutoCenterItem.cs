using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoCenterItem : MonoBehaviour
{
    // Start is called before the first frame update
    public Button _ItemBtn;

    public Image _ItemImage;

    public int _ItemIndex;

    //��l�ƨ�����ե�
    public void InitAutoCenterItem()
    {
        _ItemImage = GetComponent<Image>();
        _ItemBtn = GetComponent<Button>();
    }
}
