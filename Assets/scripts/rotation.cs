using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

	void FixedUpdate () {

        rtn();
	
	}

    void rtn(){
        transform.Rotate(new Vector3(0, 0, 1));
    }

    void Speedup(){

    }
}
