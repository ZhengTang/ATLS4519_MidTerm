using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandom : MonoBehaviour
{
    public float timer;
    NavMeshAgent NavMeshAgent;
    NavMeshPath path;
    Vector3 target;
    bool inCoRoutine;
    bool validPath;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-40, 40);
        float y = Random.Range(0, 20);
        float z = Random.Range(-40, 40);

        Vector3 pos = new Vector3(x*10, y, z*10);
        return pos;
    }

    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timer);
        getNewPath();
        validPath = NavMeshAgent.CalculatePath(target, path);
        //if (!NavMeshAgent.CalculatePath(target, path)) Debug.Log("Found an invalid path");

        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f);
            getNewPath();
            validPath = NavMeshAgent.CalculatePath(target, path);
        }
        inCoRoutine = false;
    }

    void getNewPath()
    {
        target = getNewRandomPosition();
        NavMeshAgent.SetDestination(target);
    }
    // Update is called once per frame
    void Update()
    {
        if (!inCoRoutine)
        {
            StartCoroutine(DoSomething());
        }
    }

}
