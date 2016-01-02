using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour {
    public static ObjectPool instance;

    private static Dictionary<string, ArrayList> pool = new Dictionary<string, ArrayList>();
    void Awake()
    {
        instance = this;
    }

    public Object GetObject(string name,Vector3 position,Quaternion rotation)
    {
        string key = name + "(Clone)";
        Object o;
        if (pool.ContainsKey(key) && pool[key].Count > 0)
        {
            ArrayList list = pool[key];
            o = list[0] as Object;
            list.Remove(0);
            //重新初始化相关状态
            (o as GameObject).SetActive(true);
            (o as GameObject).transform.position = position;
            (o as GameObject).transform.rotation = rotation;
            //(o as GameObject).GetComponent<DelayDestroy>().Init();
        }
        else
        {
            o = Instantiate(Resources.Load(name), position, rotation) as Object;
        }
        DelayDestroy dd = (o as GameObject).GetComponent<DelayDestroy>();
        dd.Init();
        return o;
    }
    public Object ReturnObject(GameObject o)
    {
        string key = o.name;
        Debug.Log("key:" + key);
        if (pool.ContainsKey(key))
        {
            ArrayList list = pool[key];
            list.Add(o);
        }
        else
        {
            pool[key] = new ArrayList() { o };
        }
        o.SetActive(false);
        
        return o;
    }
}
