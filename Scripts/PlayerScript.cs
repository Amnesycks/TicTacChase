using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    [Range(0.1f, 10.0f)]
    public float speed;
    private float moveHorizontal;
    private float moveVertical;
    public GameObject panelWin;
    public GameObject panelLose;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        panelLose.SetActive(false);
        panelWin.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    { 
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }
    
    void FixedUpdate ()
    {
        rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + new Vector3(0f, moveHorizontal, 0f));
        rb.MovePosition(rb.position + transform.forward * speed * moveVertical * Time.fixedDeltaTime);
    }
    
    void OnCollisionEnter(Collision target) 
    {
        if (Time.timeSinceLevelLoad < 3)
        {
            return;
        }
        if( target.gameObject.tag.Equals("Enemy") == true ){
            Debug.Log("LOSE");
            Time.timeScale = 0;
            panelLose.SetActive(true);
        }
        
        if( target.gameObject.tag.Equals("ToFind") == true ){
            Debug.Log("WIN");
            Time.timeScale = 0;
            panelWin.SetActive(true);
        }
    }
}