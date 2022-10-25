using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCounter : MonoBehaviour
{
 private int brickcount;

 public void countbrick()
 {
  brickcount++;
  Debug.Log($"Total bricks Removed: {brickcount}");
  return;
 }
}
