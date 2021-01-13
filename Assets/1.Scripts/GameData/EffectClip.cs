﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 이펙트 프리팹과 경로와 타입등의 속성 테이터를 가지고 있게 되며
/// 프리팹 사전로딩 기능을 갖고있고 - 풀링을 위한기능.
/// 이펙트 인스턴스 기능도 갖고 있다 - 풀링과 연계해서 사용하기도 한다.
/// </summary>
public class EffectClip
{
    public int realId = 0;

    public EffectType effectTyep = EffectType.NORMAL;
    public GameObject effectPrf = null;
    public string effectName = string.Empty;
    public string effectPath = string.Empty;
    public string effectFullPath = string.Empty;

    public EffectClip() { }

    public void PreLoad()
    {
        effectFullPath = effectPath + effectName;
        if(this.effectFullPath != string.Empty && this.effectPrf == null) //이미 사전에 로딩이 되어있다면 또 해줄 필요 없기때문.
        {
            this.effectPrf = ResourceManager.Load(effectFullPath) as GameObject;
        }
    }

    public void ReleaseEffect()
    {
        if(this.effectPrf != null)
        {
            this.effectPrf = null;
        }
    }


    /// <summary>
    /// 원하는 위치에 내가 원하는 이펙트를 인스턴스한다.
    /// </summary>
    /// <param name="Pos"></param>
    /// <returns></returns>
    public GameObject Instantiate( Vector3 Pos)
    {
        if(this.effectPrf == null)
        {
            this.PreLoad();
        }    
        if(this.effectPrf != null)
        {
            GameObject effect = GameObject.Instantiate(this.effectPrf, Pos, Quaternion.identity);
            return effect;
        }
        return null;
    }


}
