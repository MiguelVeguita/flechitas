using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemi : MonoBehaviour
{
    public float veloci=100;
    float rotacionx=0f;
   public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mausex = Input.GetAxis("Mouse X") * veloci * Time.deltaTime;

        transform.localRotation = (Quaternion.Euler(rotacionx, 0f, 0f));
        player.Rotate(Vector3.up * mausex);

    }
}
