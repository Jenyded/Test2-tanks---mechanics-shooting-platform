using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuncsPlatform : MonoBehaviour
{
    public Transform Player;
    public Chunk[] PlatformPrefabs;
    public Chunk FirstPlatform;

    private List<Chunk> spawnedPlatforms = new List<Chunk>();

    private void Start()
    {
        spawnedPlatforms.Add(FirstPlatform);
    }
    private void Update()
    {
        if(Player.position.x > spawnedPlatforms[spawnedPlatforms.Count - 1].End.position.x - 20)
        {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform()
    {
        Chunk newChuck = Instantiate(PlatformPrefabs[Random.Range(0, PlatformPrefabs.Length)]);
        newChuck.transform.position = spawnedPlatforms[spawnedPlatforms.Count - 1].End.position - newChuck.Begin.localPosition;
        spawnedPlatforms.Add(newChuck);

        if(spawnedPlatforms.Count >= 4)
        {
            Destroy(spawnedPlatforms[1].gameObject);
            spawnedPlatforms.RemoveAt(0);
        }
    }
}
