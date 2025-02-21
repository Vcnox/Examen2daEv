using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorksSpawner : MonoBehaviour
{
    public GameObject _fireWorkPrefab;
    public float SpawnFireWork = 2.0f;
    public Transform Lakitu;
    private Rigidbody2D _rb2D;

    // Start is called before the first frame update
    void Start()
    {
     
        _rb2D = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_fireWorkPrefab != null)
        {
            Vector3 spawnPosition = (Lakitu.position - transform.position);
            _rb2D.velocity = spawnPosition;
        }
    }
  
}
