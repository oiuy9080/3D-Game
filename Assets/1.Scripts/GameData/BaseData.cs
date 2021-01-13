using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// data의 기본 클래스.
/// 공통적인 데이터를 가지고 있게 되는데, 이름만 현재 가지고 있다.
/// 데이터의 갯수와 이름의 목록 리스트를 얻을수 있다.
/// 
/// </summary>


public class BaseData : ScriptableObject
{
    public const string dataDirectory = "/9.ResourcesData/Resources/Data/";
    public string[] names = null;

    public BaseData()    {    }

    public int GetDataCount()
    {
        int retValue = 0;

        if(this.names != null ) // 데이터를 읽어왔냐 안읽어왔냐의 차이. 0이던 뭐던 null이면 데이터 자체를 못읽어왔다는 소리.
        {
            retValue = this.name.Length;
        }
        return 0;
    }
    
    /// <summary>
    /// 툴에 출력하기 위한 이름목록을 만들어주는 함수.
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    public string[] GetNameList(bool showID, string fillerWord = "")
    {
        string[] retList = new string[0];
        if(this.names == null)
        {
            return retList;
        }

        retList = new string[this.names.Length];

        for(int i=0; i < this.names.Length; i++)
        {
            if(fillerWord != "")
            {
                if(names[i].ToLower().Contains(fillerWord.ToLower()) == false)
                {
                    continue;
                }
            }
            if(showID)
            {
                retList[i] = i.ToString() + " : " + this.names[i];
            }
            else
            {
                retList[i] = this.names[i];
            }
        }

        return retList;
    }

    public virtual int AddData(string newName)
    {


        return GetDataCount();
    }

    public virtual void RemoveData(int index)
    {

    }

    public virtual void Copy(int index)
    {

    }


}
