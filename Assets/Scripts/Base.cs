using UnityEngine;
public class Base : MonoBehaviour {
    public void Move (float dx,float dy) {
        gameObject.transform.position += new Vector3(dx, dy, 0);     
    } 
} 