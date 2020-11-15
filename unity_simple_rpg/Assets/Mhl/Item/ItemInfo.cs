using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アイテム情報クラス
/// </summary>
public class ItemInfo
{
    private long id;            // アイテムのID
    private string name;        // アイテムの名前
    private string description; // アイテムの説明

    public long Id
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id">アイテムID</param>
    /// <param name="name">アイテムの名前</param>
    /// <param name="description">アイテムの説明</param>
    public ItemInfo(long id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
    }
}
