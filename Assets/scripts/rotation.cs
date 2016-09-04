using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

    public Transform trans;
    int a = 2;

	void Update () {

        rtn();
	
	}

    void rtn(){

        trans = GetComponent<Transform>();
        trans.Rotate(new Vector3(0, 0, 1));

    }

    void Speedup(){



    }
}
