using System.Collections;
using UnityEngine;
 
public class UIRootHandler : MonoBehaviour {
	void Awake () {
            UIManger.Instance.m_CanvasRoot = gameObject;
	}
}