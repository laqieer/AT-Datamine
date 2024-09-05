// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.IFreeMapResourceLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018B1")]
  public interface IFreeMapResourceLoader
  {
    [Token(Token = "0x6008C27")]
    void LoadRequest<T>(string assetBundleName, string assetName, LoadAssetCallback<T> callback) where T : Object;

    [Token(Token = "0x6008C28")]
    void LoadRequest(string assetBundleName, string assetName, CoLoadCallback callback);

    [Token(Token = "0x6008C29")]
    void LoadAndCacheRequest<T>(
      string assetBundleName,
      string assetName,
      LoadCachedAssetCallback callback)
      where T : Object;
  }
}
