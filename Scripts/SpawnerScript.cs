using System.Collections;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Spawner; // Drag the prefab that you want to spawn
    private IEnumerator Spawn;

    private IEnumerator SpawnEnum(float repeatRate)
    {
        while (true)
        {
            GameObject instantiatedGameObject = Instantiate(Spawner, PositionRandomizer(0, 10, 0, 10), Quaternion.identity);
            instantiatedGameObject.name = "SpawnedObject";
            LumberJackAI.Instance.objects.Add(instantiatedGameObject.transform);
            yield return new WaitForSeconds(repeatRate);
        }
    }

    private void Start()
    {
        Spawn = SpawnEnum(1); //Enter the repeat rate in brackets
        StartCoroutine(Spawn);
    }
    private Vector2 PositionRandomizer(int minX, int maxX, int minY, int maxY)
    {
        Vector2 position;
        int x = Random.Range(minX, maxX);
        int y = Random.Range(minY, maxY);
        position = new Vector2(x, y);
        return position;
    }

}
