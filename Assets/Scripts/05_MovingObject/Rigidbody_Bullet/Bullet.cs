using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

    private Rigidbody bulletRb;
    public GameObject bloodEffect;
    public GameObject destoryEffect;
    public float destorytime;
    public float force;

    // Use this for initialization
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.forward * force, ForceMode.Impulse);
        Destroy(this.gameObject, destorytime);

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnCollisionEnter(Collision other){

        if (other.gameObject.tag == "NPC"){
            GameObject blood = Instantiate(bloodEffect, other.transform.position, Quaternion.identity) as GameObject;
            Destroy(blood, blood.GetComponent<ParticleSystem>().duration + 1f);
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Wall")
        {
            GameObject destory = Instantiate(destoryEffect, other.transform.position, Quaternion.identity) as GameObject;
            Destroy(destory, destoryEffect.GetComponent<ParticleSystem>().duration + 1f);
            Destroy(this.gameObject);
        }
    }
}

