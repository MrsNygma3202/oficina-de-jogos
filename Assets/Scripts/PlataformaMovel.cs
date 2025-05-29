using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovel : MonoBehaviour
{
    public Transform PosA, PosB;
	public float speed;
	Vector3 targetPos;
    
    private void Start()
    {
        targetPos = PosB.position;
    }


    // Update is called once per frame
    private void Update()
    {
        if(Vector2.Distance(transform.position, PosA.position) < 0.05f){
            targetPos = PosB.position;
        }

        if(Vector2.Distance(transform.position, PosB.position) < 0.05f){
            targetPos = PosA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    }
}
