using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BitGo : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -GameManager.Instance.speed * 1f * Time.deltaTime, 0);
        if (transform.position.y < -3)
        {
            GameManager.Instance.Score++;
            Destroy(gameObject);
        }
    }
}
