using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLogic : MonoBehaviour
{
    [SerializeField] private GameObject WoolImagePreFab;
    private GameObject WoolImageInstance;
    public GameObject ParentForIcons;
    public void CreateWoolOnClick()
    {
        WoolImageInstance = Instantiate(WoolImagePreFab, ParentForIcons.transform) as GameObject;
        WoolImageInstance.transform.position = Input.mousePosition;
        Destroy(WoolImageInstance, 0.3f);
    }
}
