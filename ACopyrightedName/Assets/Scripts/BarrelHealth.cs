using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHealth : MonoBehaviour
{
    int Health = 15;
    int Damage = 5;
    GameObject GetGameObject ;
    public ParticleSystem BarrelHitEffect;
    float cooldown =0, CoolDownTime = 1;
    public AudioSource BarrelHit;
    public AudioSource BarrelDestroy;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Health <= 0)
        {
            BarrelDestroy.Play();
            Destroy(this.gameObject);
            ScoreCounter.ScoreValue += 20;
            BarrelCounter.BarrelsDestroyed += 1;
        }
    }
 
       private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Sword") && (cooldown <0))
        {
            BarrelHit.Play();
            BarrelHitEffect.Play();
            Health -= Damage;
            cooldown = CoolDownTime;
           // print(Health);
            ScoreCounter.ScoreValue += 10;
        }
    }
}
