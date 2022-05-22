using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonBehaviour을 지웠기 때문에 이 class는 컴포넌트로 사용할 수 없음
public class Animal
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}
