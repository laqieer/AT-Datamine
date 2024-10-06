// Decompiled with JetBrains decompiler
// Type: Dicing.Loader.DicingLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Dicing.Loader
{
  [Token(Token = "0x2001F47")]
  public class DicingLoader
  {
    [Token(Token = "0x400861A")]
    [FieldOffset(Offset = "0x10")]
    private List<string> loadedAssetBundleNameList;

    [Token(Token = "0x600B9B9")]
    [Address(RVA = "0x213E4E4", Offset = "0x213E4E4", VA = "0x213E4E4")]
    public bool IsLoaded(string assetBundleName) => new bool();

    [Token(Token = "0x600B9BA")]
    [Address(RVA = "0x213E5C4", Offset = "0x213E5C4", VA = "0x213E5C4")]
    public GameObject GetAsset(string assetBundleName, string assetName) => (GameObject) null;

    [Token(Token = "0x600B9BB")]
    [Address(RVA = "0x213E72C", Offset = "0x213E72C", VA = "0x213E72C")]
    public void AddLoadAssetBundle(string assetBundleName)
    {
    }

    [Token(Token = "0x600B9BC")]
    [Address(RVA = "0x213E7D8", Offset = "0x213E7D8", VA = "0x213E7D8")]
    public IEnumerator LoadWait(Action<List<string>> onSuccess = null) => (IEnumerator) null;

    [Token(Token = "0x600B9BD")]
    [Address(RVA = "0x213E874", Offset = "0x213E874", VA = "0x213E874")]
    public void ReleaseAssetBundle(string loadedAssetBundleName)
    {
    }

    [Token(Token = "0x600B9BE")]
    [Address(RVA = "0x213E9AC", Offset = "0x213E9AC", VA = "0x213E9AC")]
    public void ReleaseAllAssetBundle()
    {
    }

    [Token(Token = "0x600B9BF")]
    [Address(RVA = "0x213EB38", Offset = "0x213EB38", VA = "0x213EB38")]
    public DicingLoader()
    {
    }
  }
}
