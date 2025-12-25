using UnityEngine;

public class yondegerleri2 : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal = " + horizontal);

        if (Input.GetKey(KeyCode.A))
            Debug.Log("A tuþuna BASILI tutuluyor!");

        if (Input.GetKey(KeyCode.D))
            Debug.Log("D tuþuna BASILI tutuluyor!");

        if (Input.GetKey(KeyCode.W))
            Debug.Log("W tuþuna BASILI tutuluyor!");

        if (Input.GetKey(KeyCode.S))
            Debug.Log("S tuþuna BASILI tutuluyor!");

        if (Input.GetKeyDown(KeyCode.A))
            Debug.Log("A tuþuna BASILDI!");

        if (Input.GetKeyDown(KeyCode.D))
            Debug.Log("D tuþuna BASILDI!");

        if (Input.GetKeyDown(KeyCode.W))
            Debug.Log("W tuþuna BASILDI!");

        if (Input.GetKeyDown(KeyCode.S))
            Debug.Log("S tuþuna BASILDI!");
    }
}
