using UnityEngine;

public class Clock : MonoBehaviour
{
    public int Sec = 0;
    private GameObject ObjSec;
    public int Min = 0;
    private GameObject objmin;
    public int Hour = 0;
    private GameObject objhour;
    // Start is called before the first frame update
    void Start()
    {
        ObjSec = transform.Find("Second").gameObject;
        objmin = transform.Find("minute").gameObject;
        objhour = transform.Find("hour").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        Sec = System.DateTime.Now.Second;
        float RotSec = (360.0f / 60.0f) * Sec;
        ObjSec.transform.localEulerAngles = new Vector3(0.0f, RotSec, 0.0f);

        Min = System.DateTime.Now.Minute;
        float Rotmin = (360.0f / 60.0f) * Min;
        objmin.transform.localEulerAngles = new Vector3(0.0f, Rotmin, 0.0f);

        Hour = System.DateTime.Now.Hour;
        float Rothour = (360.0f / 30.0f) * Hour;
        objhour.transform.localEulerAngles = new Vector3(0.0f, Rothour, 0.0f);

    }
}
