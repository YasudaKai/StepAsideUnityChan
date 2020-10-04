using System.Collections;
using UnityEngine;

public class ItemRemove : MonoBehaviour
{

    public GameObject mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");   
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.z < this.mainCamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
