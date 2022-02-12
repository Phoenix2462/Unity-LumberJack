using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumberJackAI : MonoBehaviour
{
    [HideInInspector]public List<Transform> objects = new List<Transform>();
    private Vector2 _closestTree;
    private IEnumerator _coroutine;
    private IEnumerator _farm;
    private bool _isFarming = false;
    private float _speed = 10f;// Set the speed here
    private GameObject farmingGameObject;
    public static LumberJackAI Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private IEnumerator GetClosestObjectEnum()
    {
        while (true)
        {
            _closestTree = GetClosestObject().position;
            yield return new WaitForSeconds(0.2f);
        }
    }
    private IEnumerator FarmEnum()
    {
        //Insert animation system here
        print("Animation1");
        yield return new WaitForSeconds(1f);
        //Insert animation system here
        print("Animation2");
        _isFarming = false;
        Destroy(farmingGameObject);
        StopCoroutine(nameof(FarmEnum));
    }
    private void Start()
    {
        _coroutine = GetClosestObjectEnum();
        StartCoroutine(_coroutine);
    }

    private void Update()
    {
        if (!_isFarming)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, _closestTree, _speed * Time.deltaTime);
        }
    }

    private Transform GetClosestObject()
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform t in objects)
        {
            float dist = Vector3.Distance(t.position, currentPos);
            if (dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }
        }

        return tMin;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "SpawnedObject")
        {
            _isFarming = true;
            StartCoroutine(nameof(FarmEnum));
            objects.Remove(other.transform);
            farmingGameObject = other.gameObject;
        }
    }
}
