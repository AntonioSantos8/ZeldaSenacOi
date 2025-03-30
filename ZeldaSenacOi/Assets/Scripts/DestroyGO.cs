using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGO : MonoBehaviour
{
    public float timeToDestroy;
    private IEnumerator Start()
    {

        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }

}
