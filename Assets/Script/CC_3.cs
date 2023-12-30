using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_3 : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0f, 2f, -1f);
    }
    // Update is called once per frame  
    void Update()
    {
        //transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        transform.position = player.transform.position + offset;
    }
}
