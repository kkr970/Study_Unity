using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        string characterName = "유니티";
        char bloodType = 'A';
        int age = 100;
        //float는 소수점 7자리까지만 정확하게 표현, 8자리부터는 근삿값으로 처리되어짐
        float height = 123.456f;
        bool isAI = true;

        Debug.Log("캐릭터 이름 : " + characterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
        Debug.Log("인공지능인가? : " + isAI);
    }
}
