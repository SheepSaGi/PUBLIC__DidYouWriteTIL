using UnityEngine;

public class SpawnEnemyController : MonoBehaviour
{
    private TILController controller;
    public GameObject Monster;
    private float currTime = 0;
    private void Awake()
    {
        controller = GetComponent<TILController>();
    }

    private void Start()
    {
        
    }
    private void Update()
    {
        currTime += Time.deltaTime;
        if(currTime > 20)
        {
            SpawnMonster();
            currTime = 0;
        }
        
    }

    private void SpawnMonster() 
    {
        GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool("HyukM");
        obj.transform.position = new Vector3(Random.Range(-1.5f,1.5f),3.7f,0f);
    }
}