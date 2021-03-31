using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    float term;
    public float range = 3;
    [SerializeField]
    private float Bit =1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomSpawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator RandomSpawn()
    {
        while (true)
        {
            Vector3 pos = transform.position;
            //pos.y += Random.Range(-range, range);\
            GameObject obj = GameManager.Instance.pool.DequeueBeat();
            obj.transform.position = pos;
            obj.transform.rotation = transform.rotation;
            yield return new WaitForSeconds(Bit);
        }
    }
}
