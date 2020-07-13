using UnityEngine;


public class DrawSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;

    [SerializeField]
    private GameObject myObjects;

    [SerializeField]
    private float gameObjectAmount = 2;

    public Transform[] Points => points;

    void Start()
    {
     SpawnDraws(myObjects, (int)gameObjectAmount);
    }

    public void SpawnDraws(GameObject original, int howMany)
        {
        original = myObjects;
            howMany++;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = 1; j < howMany; j++)
                {
                    Vector3 position = points[i].position + j * (points[i + 1].position - points[i].position) / howMany;
                    Instantiate(original, position, Quaternion.identity);
                }
            }
        }
    
}
