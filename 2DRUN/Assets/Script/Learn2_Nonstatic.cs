using UnityEngine;

public class Learn2_Nonstatic : MonoBehaviour
{
    public GameObject ninja;

    public Transform ninjaTran;

    public Camera cam;

    public ParticleSystem ps;

    //存取
    //非靜態屬性

    private void Start()
    {
        print(ninja.tag);
        print(ninja.layer);

        //存放
        ninjaTran.position = new Vector3(0, 7, 0);
    }

}
