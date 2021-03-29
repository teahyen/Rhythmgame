using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BitPrefad;
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
        /*
        term += Time.deltaTime;
        if (term >= interval)
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            Instantiate(wallPrefad[Random.Range(0, 3)], pos, transform.rotation);
            term -= interval;
        }
        */
    }

    IEnumerator RandomSpawn()
    {
        while (true)
        {
            Vector3 pos = transform.position;
            //pos.y += Random.Range(-range, range);
            Instantiate(BitPrefad, pos, transform.rotation);
            yield return new WaitForSeconds(Bit);
        }
    }
}
