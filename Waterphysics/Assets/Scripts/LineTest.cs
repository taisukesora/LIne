using UnityEngine;
using System.Collections;

public class LineTest : MonoBehaviour {
  public Transform[] transform;
  LineRenderer lineRenderer;
  Vector3 start, direction;
  float length, velocity, range, time;
  // Use this for initialization
  void Start () {
    lineRenderer = GetComponent<LineRenderer>();
    lineRenderer.SetVertexCount(2);
    range = 10.0f;
    start = new Vector3(Random.Range(-range,range), 
			Random.Range(-range,range),
			Random.Range(-range,range));
    direction = new Vector3(Random.Range(-range,range), 
			    Random.Range(-range,range), 
			    Random.Range(-range,range));
    direction.Normalize();
    velocity = 1.0f;

    lineRenderer.SetWidth(0.1f, 0.01f);
  }
  
  // Update is called once per frame
  void Update () {
    time += Time.deltaTime;
    
    Vector3 s = start+direction*time*velocity;
    
    //範囲外の時
    if(s.sqrMagnitude>300.0f)
      {	
        time = 0.0f;
	//
	direction = -direction;
	start = s;
//	s = start+direction*time*velocity;
      }
    Vector3 e = s + direction*1.0f;
    
    
    lineRenderer.SetPosition(0, s);
    lineRenderer.SetPosition(1, e);
    
    
  }

  
  Vector3 reset()
  {
    start = new Vector3(Random.Range(-range,range), 
			Random.Range(-range,range),
			Random.Range(-range,range));
    direction = new Vector3(Random.Range(-range,range), 
			    Random.Range(-range,range), 
			    Random.Range(-range,range));
    return (start+direction*time*velocity);
  }
  
}
