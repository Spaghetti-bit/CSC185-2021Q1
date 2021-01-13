using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject _projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray point = Camera.main.ScreenPointToRay(Input.mousePosition);

            GameObject go = Instantiate(_projectile, transform.position, Quaternion.identity);
            go.GetComponent<Projectile>()?.Fire(point.direction);
            Destroy(go, 10);
        }

    }
}
