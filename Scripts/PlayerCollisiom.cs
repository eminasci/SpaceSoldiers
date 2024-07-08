using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerCollisiom : MonoBehaviour
{
   
   Rigidbody rb;
  [SerializeField] ParticleSystem CrashVFX;
 void OnCollisionEnter(Collision other) {
   Debug.Log(this.name+"Collision with"+other.gameObject.name) ;
  OnCrashSequence();
 }
    void OnTriggerEnter(Collider other) {
    Debug.Log(this.name+"Triggered"+other.gameObject.name);
   OnCrashSequence();
 }
 void OnCrashSequence(){
  GetComponent<PlayerControls>().enabled=false;
  GetComponent<MeshRenderer>().enabled= false;
 rb= GetComponent<Rigidbody>();
 rb.useGravity=true;
 CrashVFX.Play();
  
  Invoke("ReloadLevel",1);
 }

    void ReloadLevel()
    {
       int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
     

        SceneManager.LoadScene(currenSceneIndex);
      
    }
      void LoadNextLevel()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currenSceneIndex + 1;
        if (currenSceneIndex == SceneManager.sceneCountInBuildSettings-1)
        {
            nextSceneIndex = 0;
        }
       
       
        Debug.Log(currenSceneIndex);
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        SceneManager.LoadScene(nextSceneIndex);
    }
    

 
}
