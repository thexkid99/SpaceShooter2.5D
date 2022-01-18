using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float VerticalInput;
    [SerializeField] float HorizonatlInput;
    [SerializeField] float speed = 10.0f;
    [SerializeField] float xRange = 5.0f;  
    public GameObject projectilePrefab;
    public Transform canon1;
    public Transform canon2;


   
    void Start()
    {

    }

   
    void Update()
    {
        //exhustParticals.Play();         
        
        //range for x axis
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(transform.position.x, -xRange);
        }
        //if (transform.position.y > xRange)
        //{
        //    transform.position = new Vector2(transform.position.x, xRange);
        //}

        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * VerticalInput * Time.deltaTime * speed);

        HorizonatlInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizonatlInput*  Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, canon1.transform.position, projectilePrefab.transform.rotation);
            Instantiate(projectilePrefab, canon2.transform.position, projectilePrefab.transform.rotation);
        }

    }
}
