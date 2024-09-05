// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapConnectLoader`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x200188A")]
  public class FreeMapConnectLoader<T> where T : ScriptableObject
  {
    [Token(Token = "0x4006ABC")]
    [FieldOffset(Offset = "0x0")]
    private string assetBundleName;
    [Token(Token = "0x4006ABD")]
    [FieldOffset(Offset = "0x0")]
    private string nowAssetBundleName;
    [Token(Token = "0x4006ABE")]
    [FieldOffset(Offset = "0x0")]
    private bool isLoaded;
    [Token(Token = "0x4006ABF")]
    private const string AssetBundleLabelSplite = "_";

    [Token(Token = "0x6008B60")]
    public FreeMapConnectLoader(string assetBundleName)
    {
    }

    [Token(Token = "0x6008B61")]
    public IEnumerator TryGetConnectAsset(int connectId, string assetName, Action<T> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008B62")]
    public void ReleaseConnectBundle()
    {
    }
  }
}
