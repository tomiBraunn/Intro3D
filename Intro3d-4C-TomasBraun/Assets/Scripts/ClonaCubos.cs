using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;

    public void ClonarCubo()
    {
        Instantiate(cuboPrefab);
    }
}
