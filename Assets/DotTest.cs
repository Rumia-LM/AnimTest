using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotTest : MonoBehaviour
{
    public Transform obj;
    public GameObject obj2;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLookAt(obj.position,1f)
        .SetEase(Ease.InOutQuad)
        .OnComplete(ShowObject);
    }

    void ShowObject(){
        obj2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
