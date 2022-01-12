using UnityEngine;

public class Polar_coordinate_system : MonoBehaviour
{
    public float Speed_X;
    public float Speed_Y;
    public float Speed_Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Speed_X, Speed_Y, Speed_Z) * Time.deltaTime);
    }
}
