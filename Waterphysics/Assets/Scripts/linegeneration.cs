using UnityEngine;
using System.Collections;

public class linegeneration : MonoBehaviour {
  public GameObject lineprefab;
  public float num_line;
  // Use this for initialization
  void Start () {
    for(int i=0;i<num_line;i++)
      {
	Instantiate(lineprefab, Vector3.zero, Quaternion.identity);
      }
  }
  
  // Update is called once per frame
  void Update () {
    
  }
}
