using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    private int fireCount;
    public UnityAction<int> OnFireCountChanged;

    public int FireCount { set { fireCount = value; OnFireCountChanged?.Invoke(value); } get { return fireCount; } }
}
