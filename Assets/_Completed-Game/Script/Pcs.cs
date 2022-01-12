using UnityEngine;

public class Pcs : MonoBehaviour
{
    float R;
    float theta = 0f;
    public AnimationCurve ac;
    // Start is called before the first frame update
    void Start()
    {
        ac = new AnimationCurve();
    }

    // Update is called once per frame
    void Update()
    {
        theta = theta + Time.deltaTime;


        R = 100 * Mathf.Sin(10);
        float x = R * Mathf.Sin(theta);
        float y = R * Mathf.Cos(theta);
        transform.position = new Vector3(x, y, R * Mathf.Sin(theta));

        Keyframe key = new Keyframe(x, y);
        ac.AddKey(key);

    }
}
