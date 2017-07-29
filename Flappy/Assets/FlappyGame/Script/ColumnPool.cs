using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;

    GameObject[] columns;
    Vector2 objectPoolPosition = new Vector2(-14, 0);
    int currentColumn;
    float timeSinceLastSpawned;
    float columnMin = -2.9f;
    float columnMax = 1.4f;
    float spawXPosition = 10f;
    float spawRate;

    void Start ()
    {
        if (GameController.instance.game)
        {
            columns = new GameObject[columnPoolSize];
            for (int i = 0; i < columnPoolSize; i++)
                columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);

            SpawnColumn();
        }
    }

    void Update()
    {
        if (GameController.instance.game)
        {
            spawRate = Random.Range(4, 6);
            timeSinceLastSpawned += Time.deltaTime;

            if (!GameController.instance.gameOver && timeSinceLastSpawned > spawRate)
            {
                timeSinceLastSpawned = 0;
                SpawnColumn();
            }
        }
    }

    void SpawnColumn()
    {
        float spawYPosition = Random.Range(columnMin, columnMax);
        columns[currentColumn].transform.position = new Vector2(spawXPosition, spawYPosition);

        currentColumn++;
        if (currentColumn >= columnPoolSize)
            currentColumn = 0;
    }
}
