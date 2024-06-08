using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class GameController : MonoBehaviour
{
    public GameObject CoinPrefab;
    private void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Initialize();
        Debug.Log("Start");
    }
    private void Update()
    {
        Debug.Log("Update");

    }
    private void OnEnable()
    {
        Debug.Log("onEnable");
    }

    private void OnDisable()
    {
        Debug.Log("onDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy");
    }
    public void Initialize()
    {
        Instantiate(CoinPrefab);

    }
}
