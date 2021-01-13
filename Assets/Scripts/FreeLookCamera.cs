using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{

    [Range(0, 2)]public float sensitivity = 1;
    [Range(1, 5)]public float speed = 2;
    public GameObject hitMarker;
    public GameObject explosion;

    void Update()
    {

        //rotation
        if(Input.GetMouseButton(1))
        {

            Vector3 rotate = Vector3.zero;
            rotate.y = Input.GetAxis("Mouse X"); // yaw
            rotate.x = Input.GetAxis("Mouse Y"); // pitch
            // z - roll

            transform.eulerAngles += ( rotate * sensitivity );

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        ////quat
        //Vector3 direction = transform.rotation * Vector3.forward;
        //Debug.DrawRay(transform.position, direction * 100);

        //translate
        Vector3 translate = Vector3.zero;
        translate.x = Input.GetAxis("Horizontal");
        translate.z = Input.GetAxis("Vertical");

        transform.position += (transform.rotation * translate) * speed * Time.deltaTime;

        //ray cast
        //Ray ray = new Ray(transform.position, transform.forward);
        //if(Physics.Raycast(ray, out RaycastHit hitInfo))
        //{
        //    if(Input.GetMouseButtonDown(0))
        //    {
        //        GameObject go = Instantiate(explosion, hitInfo.point, Quaternion.identity);
        //        Destroy(go, 1);
        //    }
        //    //hitMarker.transform.position = hitInfo.point;
        //    //Debug.Log("Hit, Object Information : " + hitInfo.collider.gameObject.name);
        //}
    }
}
