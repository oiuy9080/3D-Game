using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityObject = UnityEngine.Object;


/// <summary>
/// Resources.Load를 래핑하는 클래스.
/// 추우에 에셋번들로 변경할거라서 사용함.
/// </summary>
public class ResourceManager
{
    public static UnityObject Load(string path)
    {
        // 지금은 리소스 로드지만 추후엔 경로 변경됨.
        return Resources.Load(path);
    }

    public static GameObject LoadAndInstantiate(string path)
    {
        UnityObject source = Load(path);
        if(source  == null)
        {
            return null;
        }
        else
        {
            return GameObject.Instantiate(source) as GameObject; // as는 GameObject로 변경되면 변경된걸 반환 아니면 Null 반환.
        }
    }


}
