using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private ItemBase[] items;
    [SerializeField] private float spawnInterval = 1.5f;
    [SerializeField] private PlayerController player;

    private float minDistanceToPlayer;
    private float nextSpawnTime;

    private void Start()
    {
        minDistanceToPlayer = Camera.main.orthographicSize * Screen.width / Screen.height * 2f;
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnInterval;
            SpawnRandomItems();
        }
    }


    public void SpawnRandomItems(float howMany = 1)
    {
        for (int i = 0; i < howMany; i++)
        {
            int index = Random.Range(0, items.Length);
            float x = player.transform.position.x + minDistanceToPlayer + Random.Range(0f, 00f);
            float y = Random.Range(transform.position.x, transform.position.y + 0f);

            ItemBase spawnedItem = Instantiate(items[index]);
            spawnedItem.transform.position = new Vector3(x, y, 0f);
            Destroy(spawnedItem.gameObject, 7f);
        }
    }
}
