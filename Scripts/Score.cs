using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
  int score;

  public void ArrangeScore(int scoreUpdate){
    score+=scoreUpdate;
    Debug.Log(score);

  }
}
