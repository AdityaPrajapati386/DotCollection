using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float SpinSpeed;
    [SerializeField] bool isSpinning;
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
        if (isSpinning==false)
        {
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, SpinSpeed * Time.deltaTime);
            if(Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Spin");
                isSpinning = true;
            }
        }
        else  if (isSpinning==true)
        {
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, -SpinSpeed * Time.deltaTime);
            if(Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Spin");
                isSpinning = false;
            }
        }
    }
}
