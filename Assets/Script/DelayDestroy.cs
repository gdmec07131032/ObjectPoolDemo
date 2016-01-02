using UnityEngine;
using System.Collections;

public class DelayDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Init();
	}

    public void Init()
    {
        StartCoroutine(ReturnPool());
    }

    IEnumerator ReturnPool()
    {
        yield return new WaitForSeconds(2f);
        ObjectPool.instance.ReturnObject(this.gameObject);
    }
}
