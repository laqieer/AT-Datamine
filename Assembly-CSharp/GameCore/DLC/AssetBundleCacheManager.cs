// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleCacheManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001476")]
  public class AssetBundleCacheManager : SingletonMonoBehaviour<AssetBundleCacheManager>
  {
    [Token(Token = "0x4005E19")]
    [FieldOffset(Offset = "0x1C")]
    private readonly int CacheMax;
    [Token(Token = "0x4005E1A")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, AssetBundleCacheClass> cacheDic;

    [Token(Token = "0x600733A")]
    [Address(RVA = "0x4055F20", Offset = "0x4055F20", VA = "0x4055F20", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600733B")]
    [Address(RVA = "0x4055F70", Offset = "0x4055F70", VA = "0x4055F70")]
    public void Clear()
    {
    }

    [Token(Token = "0x600733C")]
    [Address(RVA = "0x4056144", Offset = "0x4056144", VA = "0x4056144")]
    public IEnumerator Load(
      List<string> assetBundleNames,
      Action<Dictionary<string, AssetBundle>> callback,
      string tag)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600733D")]
    [Address(RVA = "0x40561F8", Offset = "0x40561F8", VA = "0x40561F8")]
    public void Free(string tag)
    {
    }

    [Token(Token = "0x600733E")]
    [Address(RVA = "0x4056414", Offset = "0x4056414", VA = "0x4056414")]
    public void Unload()
    {
    }

    [Token(Token = "0x600733F")]
    [Address(RVA = "0x4056858", Offset = "0x4056858", VA = "0x4056858")]
    public AssetBundleCacheManager()
    {
    }
  }
}
