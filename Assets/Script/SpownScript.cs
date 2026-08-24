using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    [SerializeField] float SpinSpeed= 270f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCoin();
    }
    
    void spawnCoin()
    {
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.forward, SpinSpeed * Time.deltaTime);
        if (Input.touchCount==1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Instantiate(coinPrefab,transform.position, Quaternion.identity);
        }
        
    }
    

}
