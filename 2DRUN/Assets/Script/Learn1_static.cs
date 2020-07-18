using UnityEngine;

public class Learn_static : MonoBehaviour
{
    private void Start()
    {
        print(Mathf.PI);
        print(Mathf.Deg2Rad);
        print(Mathf.Abs(-564));
        print(Random.Range(100f,500f));

    }

    private void Update()
    {
        print(Time.time);

    }
}
