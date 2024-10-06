// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x200147C")]
  [Serializable]
  public class AssetBundleInfo
  {
    [Token(Token = "0x4005E33")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int fileSize;
    [Token(Token = "0x4005E34")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string checkSum;
    [Token(Token = "0x4005E35")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string[] dependencies;

    [Token(Token = "0x600735D")]
    [Address(RVA = "0x4058228", Offset = "0x4058228", VA = "0x4058228")]
    public AssetBundleInfo()
    {
    }
  }
}
