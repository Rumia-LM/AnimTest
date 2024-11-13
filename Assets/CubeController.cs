using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < 3f)
        {
            Debug.Log("Update:" + Time.frameCount);
        }
    }
    IEnumerator Move()
    {
        while (transform.position.x < 2f)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            yield return null;
        }
        while (transform.position.y < 2f)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
            yield return null;
        }
        while (transform.position.x > 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            yield return null;
        }
        while (transform.position.y > 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
            yield return null;
        }
    }
}
