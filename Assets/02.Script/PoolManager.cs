using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    Queue<GameObject> beatList = new Queue<GameObject>();
    public GameObject beat = null;

    [SerializeField]
    private GameObject parent;

    public void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject _beat = Instantiate(beat, transform);
            EnqueueBeat(_beat);
        }
    }

    public void EnqueueBeat(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.parent = parent.transform;
        beatList.Enqueue(obj);
    }

    public GameObject DequeueBeat()
    {
        GameObject obj = beatList.Dequeue();

        if (obj == null)
        {
            print("큐가 비어있습니다");
            return null;
        }

        obj.transform.parent = transform.parent;
        obj.SetActive(true);
        return obj;
    }
}
