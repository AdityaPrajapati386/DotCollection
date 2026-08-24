using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float SpinSpeed;
    [SerializeField] bool isSpinning;
    [SerializeField] Text coinText;
    private int coinCount;
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

    // public void OnTriggerEnter2D(Collider2D other)
    // {   
    //     if(other.gameObject.CompareTag("coin")&& Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
    //     {
    //         Destroy(other.gameObject);
    //         coinCount++;
    //         coinText.text = coinCount.ToString(); 
    //     }

    // }
      public void OnTriggerStay2D(Collider2D other)
    {   
        if(other.gameObject.CompareTag("coin")&& Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Destroy(other.gameObject);
            coinCount++;
            coinText.text = coinCount.ToString(); 
        }

    }
    //   public void OnTriggerExit2D(Collider2D other)
    // {   
    //     if(other.gameObject.CompareTag("coin")&& Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
    //     {
    //         Destroy(other.gameObject);
    //         coinCount++;
    //         coinText.text = coinCount.ToString(); 
    //     }

    // }

}
