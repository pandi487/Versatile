using UnityEngine;

public class Long : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float distance = Vector3.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position);

        transform.localScale = new Vector3(5, 5) / distance;

    }

}

