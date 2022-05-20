using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2, 2)에서 (5, 6)까지의 거리 : " + distance);
    }

    float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}

//이후의 for문, if문, while문, 배열 등 알고있는 내용은 스킵