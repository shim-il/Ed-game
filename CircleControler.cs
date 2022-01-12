using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControler : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject camra;
    public GameObject text;
    public GameObject text_go;
    public float camreraSpeed;

    // Start is called before the first frame update
    void Start()
    {
       
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x > -1.85 && transform.position.x < 1.868 && (transform.position.y > 0.021 && transform.position.y < 0.034 || transform.position.y > 0.98 && transform.position.y < 1.0 || transform.position.y > 1.97 && transform.position.y < 1.99 || transform.position.y > 2.94 && transform.position.y < 2.96))
            {
                this.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
                
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -1.82 && transform.position.x < 1.90 && (transform.position.y > 0.021 && transform.position.y < 0.034 || transform.position.y > 0.98 && transform.position.y < 1.0 || transform.position.y > 1.97 && transform.position.y < 1.99 || transform.position.y > 2.94 && transform.position.y < 2.96))
            {
                this.transform.Translate(Vector3.right * -speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y > 0.02 && transform.position.y < 3.71 && (transform.position.x > -0.99 && transform.position.x < -0.98 || transform.position.x > -0.01 && transform.position.x < 0.02 || transform.position.x > 0.97 && transform.position.x < 0.99 || transform.position.x > 1.94 && transform.position.x < 1.96))
            {
                this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > 0.027 && transform.position.y < 3.72 && (transform.position.x > -0.99 && transform.position.x < -0.98 || transform.position.x > -0.01 && transform.position.x < 0.02 || transform.position.x > 0.97 && transform.position.x < 0.99 || transform.position.x > 1.94 && transform.position.x < 1.96))
            {
                this.transform.Translate(Vector3.up * -speed * Time.deltaTime);
            }
        }  

        if (text.gameObject.activeSelf /*|| text_go.gameObject.activeSelf*/)
        {
            if (Input.GetKey(KeyCode.S))
                {
                    if (transform.position.z > -4.8 && transform.position.z < -0.32)
                    {
                        if ((transform.position.y > 0.027 && transform.position.y < 3.72 && (transform.position.x > -0.99 && transform.position.x < -0.98 || transform.position.x > -0.01 && transform.position.x < 0.02 || transform.position.x > 0.97 && transform.position.x < 0.99 || transform.position.x > 1.94 && transform.position.x < 1.96)) ||
                        
                            (transform.position.x > -1.82 && transform.position.x < 1.90 && (transform.position.y > 0.021 && transform.position.y < 0.034 || transform.position.y > 0.98 && transform.position.y < 1.0 || transform.position.y > 1.97 && transform.position.y < 1.99 || transform.position.y > 2.94 && transform.position.y < 2.96)))
                            {
                                this.transform.Translate(Vector3.forward * -speed * Time.deltaTime);
                            }
                        
                    }
                    
                } 

                if (Input.GetKey(KeyCode.W))
                {
                    if (transform.position.z > -5 && transform.position.z < -0.345)
                    {
                        if ((transform.position.y > 0.027 && transform.position.y < 3.72 && (transform.position.x > -0.99 && transform.position.x < -0.98 || transform.position.x > -0.01 && transform.position.x < 0.02 || transform.position.x > 0.97 && transform.position.x < 0.99 || transform.position.x > 1.94 && transform.position.x < 1.96)) ||
                        
                            (transform.position.x > -1.82 && transform.position.x < 1.90 && (transform.position.y > 0.021 && transform.position.y < 0.034 || transform.position.y > 0.98 && transform.position.y < 1.0 || transform.position.y > 1.97 && transform.position.y < 1.99 || transform.position.y > 2.94 && transform.position.y < 2.96)))
                            {
                                this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
                            }
                        
                    }
                    
                }
            }
        }
        

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Target"))
        {
            Destroy(other.gameObject);
            //playerAudio.PlayOneShot(pickupSound, 0.8f);
            StartCoroutine(MoveCamra());
        }
    }

    IEnumerator MoveCamra()
    {
        while(camra.transform.position.z > 1.5)
        {
            camra.transform.Translate(Vector3.forward * Time.deltaTime * camreraSpeed);
            yield return null;
        }
    }
}
