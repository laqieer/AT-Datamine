// Decompiled with JetBrains decompiler
// Type: UI.Direction.AssetBundleLoadData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Direction
{
  [Token(Token = "0x20008F1")]
  [Serializable]
  public class AssetBundleLoadData
  {
    [Token(Token = "0x40029D3")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("AssetBundleラベル名")]
    public string labelName;
    [Token(Token = "0x40029D4")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("アセット名")]
    public string assetName;

    [Token(Token = "0x600327D")]
    [Address(RVA = "0x3C22FE8", Offset = "0x3C22FE8", VA = "0x3C22FE8")]
    public AssetBundleLoadData(string label, string asset)
    {
    }
  }
}
