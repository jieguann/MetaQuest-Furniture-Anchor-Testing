using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorCube : MonoBehaviour
{
    public GameObject respawnPrefab;
    public GameObject respawn;
    public string tagNema;
    void Start()
    {
            var prefabPosition = new Vector3(respawn.transform.position.x, respawn.transform.position.y, respawn.transform.position.z);

            GameObject InitObject = Instantiate(respawnPrefab);

        InitObject.transform.position = prefabPosition;
        
    }
}
