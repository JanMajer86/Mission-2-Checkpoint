using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 direction;
    Vector3 playerPosition;

    public Transform projectileSpawnPos;
    public GameObject projectilePrefab;
    
    void Start()
    {
        
    }

    void Update()
    {
        Rotate();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("left mouse button pressed");
            Instantiate(projectilePrefab, projectileSpawnPos.position, transform.rotation);


        }
    }



    void Rotate()
    {
        mousePosition = Input.mousePosition;
        playerPosition = Camera.main.WorldToScreenPoint(transform.position);

        direction = mousePosition - playerPosition;

        float rotationAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(-rotationAngle, Vector3.right);
    }

}
