using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int ColumnPoolSize = 5;
    public GameObject ColumnPrefab;
    public float SpawnRate = 4f;
    public float ColumnMin = -1f;
    public float ColumnMax = 3.5f;

    private GameObject[] columns;
    private Vector2 ObjectPoolPosition = new Vector2(-15f,-25f);
    private float TimeSinceLastSpawn;
    private float SpawnXPosition = 10f;
    private int CurrentColumn = 0;

	// Use this for initialization
	void Start () {

        columns = new GameObject[ColumnPoolSize];
        for (int i = 0; i < ColumnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(ColumnPrefab, ObjectPoolPosition, Quaternion.identity);

        }
		
	}
	
	// Update is called once per frame
	void Update () {

        TimeSinceLastSpawn += Time.deltaTime;
		if(GameControl.instance.GameOver == false && TimeSinceLastSpawn >= SpawnRate)
        {
            TimeSinceLastSpawn = 0;
            float SpawnYPosition = Random.Range(ColumnMin,ColumnMax);
            columns[CurrentColumn].transform.position = new Vector2(SpawnXPosition,SpawnYPosition);
            CurrentColumn ++;
            if(CurrentColumn >= ColumnPoolSize)
            {
                CurrentColumn = 0;
            }
        }
	}
}
