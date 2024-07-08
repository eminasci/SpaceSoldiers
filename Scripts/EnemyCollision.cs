using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;


public class EnemyCollision : MonoBehaviour
{
   [SerializeField] ParticleSystem DeathVFX;
   [SerializeField] Transform parent;

   Score score;
    void Start() {
      score= FindObjectOfType<Score>();
   }

   void OnParticleCollision(GameObject other)
   {
      Instantiate(DeathVFX, transform.position, Quaternion.identity);
      score.ArrangeScore(20);
     
      Destroy(gameObject);

   

   }
  void OnTriggerEnter(Collider other)
   {
      Instantiate(DeathVFX, transform.position, quaternion.identity);
       score.ArrangeScore(20);
      Destroy(gameObject);
    
   }


  
}
