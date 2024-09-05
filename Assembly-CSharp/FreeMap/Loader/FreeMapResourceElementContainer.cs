// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapResourceElementContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x200188E")]
  public class FreeMapResourceElementContainer : IFreeMapResourceLoader
  {
    [Token(Token = "0x1700164C")]
    private FreeMapResourceLoader RefLoader
    {
      [Token(Token = "0x6008B72"), Address(RVA = "0x452767C", Offset = "0x452767C", VA = "0x452767C")] get
      {
        return (FreeMapResourceLoader) null;
      }
    }

    [Token(Token = "0x1700164D")]
    private FreeMapResourceCacheManager RefCacheManager
    {
      [Token(Token = "0x6008B73"), Address(RVA = "0x4527684", Offset = "0x4527684", VA = "0x4527684")] get
      {
        return (FreeMapResourceCacheManager) null;
      }
    }

    [Token(Token = "0x1700164E")]
    public bool IsUsing
    {
      [Token(Token = "0x6008B74"), Address(RVA = "0x452768C", Offset = "0x452768C", VA = "0x452768C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700164F")]
    public List<IFreeMapResourceElement> Elements
    {
      [Token(Token = "0x6008B75"), Address(RVA = "0x45276DC", Offset = "0x45276DC", VA = "0x45276DC")] get
      {
        return (List<IFreeMapResourceElement>) null;
      }
    }

    [Token(Token = "0x17001650")]
    public Dictionary<string, List<Func<IEnumerator>>> RequestDic
    {
      [Token(Token = "0x6008B76"), Address(RVA = "0x45276E4", Offset = "0x45276E4", VA = "0x45276E4")] get
      {
        return (Dictionary<string, List<Func<IEnumerator>>>) null;
      }
    }

    [Token(Token = "0x6008B77")]
    [Address(RVA = "0x45276EC", Offset = "0x45276EC", VA = "0x45276EC")]
    public FreeMapResourceElementContainer(
      FreeMapResourceLoader loader,
      FreeMapResourceCacheManager cacheManager)
    {
    }

    [Token(Token = "0x6008B78")]
    [Address(RVA = "0x45277C4", Offset = "0x45277C4", VA = "0x45277C4")]
    public void Release()
    {
    }

    [Token(Token = "0x6008B79")]
    public void LoadRequest<T>(
      string assetBundleName,
      string assetName,
      LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x6008B7A")]
    [Address(RVA = "0x452784C", Offset = "0x452784C", VA = "0x452784C", Slot = "5")]
    public void LoadRequest(string assetBundleName, string assetName, CoLoadCallback callback)
    {
    }

    [Token(Token = "0x6008B7B")]
    public void LoadAndCacheRequest<T>(
      string assetBundleName,
      string assetName,
      LoadCachedAssetCallback callback)
      where T : UnityEngine.Object
    {
    }
  }
}
