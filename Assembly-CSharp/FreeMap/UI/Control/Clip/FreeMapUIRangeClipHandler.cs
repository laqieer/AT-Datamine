// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapUIRangeClipHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016BF")]
  public class FreeMapUIRangeClipHandler
  {
    [Token(Token = "0x40065CF")]
    [FieldOffset(Offset = "0x10")]
    private BoxCollider[] rangeClipBoxColliderArray;
    [Token(Token = "0x40065D0")]
    [FieldOffset(Offset = "0x18")]
    private List<int> currentRangeIndexList;

    [Token(Token = "0x600809F")]
    [Address(RVA = "0x41F5AFC", Offset = "0x41F5AFC", VA = "0x41F5AFC")]
    public FreeMapUIRangeClipHandler(RangeClipScriptableData[] dataArray, Transform parent)
    {
    }

    [Token(Token = "0x60080A0")]
    [Address(RVA = "0x41F5C4C", Offset = "0x41F5C4C", VA = "0x41F5C4C")]
    public void UpdateCurrentCollider(Vector3 playerPosition)
    {
    }

    [Token(Token = "0x60080A1")]
    [Address(RVA = "0x41F5DB8", Offset = "0x41F5DB8", VA = "0x41F5DB8")]
    public void Release()
    {
    }

    [Token(Token = "0x60080A2")]
    [Address(RVA = "0x41F5980", Offset = "0x41F5980", VA = "0x41F5980")]
    public bool IsContainIndex(int rangeIndex) => new bool();
  }
}
