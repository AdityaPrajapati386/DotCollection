using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float SpinSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SpinArround();
    }


    void SpinArround()
    {
        // if(Input.touchCount==0)
        // {
        //     Debug.Log("Spin");
        //     transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, SpinSpeed * Time.deltaTime);
        // }
        // else 
        // if(Input.touchCount>0)
        // {
        //     Touch touch = Input.GetTouch(0);
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Spin");
                transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, SpinSpeed * Time.deltaTime);
            }
            // Debug.Log("SpinInverse");
            // transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, -SpinSpeed * Time.deltaTime);
        // }
    }
}
