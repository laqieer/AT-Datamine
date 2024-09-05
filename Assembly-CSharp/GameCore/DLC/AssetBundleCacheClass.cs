// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleCacheClass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001475")]
  public class AssetBundleCacheClass
  {
    [Token(Token = "0x4005E16")]
    [FieldOffset(Offset = "0x10")]
    public AssetBundle assetBundle;
    [Token(Token = "0x4005E17")]
    [FieldOffset(Offset = "0x18")]
    public List<string> tag;
    [Token(Token = "0x4005E18")]
    [FieldOffset(Offset = "0x20")]
    public DateTime lastUpdate;

    [Token(Token = "0x6007339")]
    [Address(RVA = "0x4055DEC", Offset = "0x4055DEC", VA = "0x4055DEC")]
    public AssetBundleCacheClass(AssetBundle ab, string t)
    {
    }
  }
}
