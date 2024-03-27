using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpaSpawner : MonoBehaviour
{
    public Helpa helpaPrefab;
    public float delayMin = 4;
    public float delayMax = 10;

    private List<Transform> _spawnerPoints;

    private Helpa _helpa;

    private void Start()
    {
        _spawnerPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
    }

    private void Update()
    {
        if (_helpa != null) return;
        if (IsInvoking()) return;
        Invoke("CreateHelpa", Random.Range(delayMin,delayMax));
    }

    private void CreateHelpa()
    {
        _helpa = Instantiate(helpaPrefab);
        _helpa.transform.position = _spawnerPoints[Random.Range(0, _spawnerPoints.Count)].position;
    }
}
