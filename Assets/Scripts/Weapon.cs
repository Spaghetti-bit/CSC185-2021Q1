using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float fireRate = 0.1f;
    
    int ammo = 100;
    float fireTimer = 0;

    [SerializeField] GameObject _projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;


        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray point = Camera.main.ScreenPointToRay(Input.mousePosition);

            
        //}

    }

    public bool fire(Vector3 position, Vector3 direction)
    {
        if(fireTimer >= fireRate && ammo > 0)
        {
            fireTimer = 0;

            GameObject go = Instantiate(_projectile, position, Quaternion.identity);
            go.GetComponent<Projectile>()?.Fire(direction);
            Destroy(go, 10);

            ammo -= 1;

            Debug.Log($"Ammo left: {ammo}");

            return true;
        }

        return false;
    }
}
