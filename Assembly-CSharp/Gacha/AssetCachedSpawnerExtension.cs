// Decompiled with JetBrains decompiler
// Type: Gacha.AssetCachedSpawnerExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014EB")]
  internal static class AssetCachedSpawnerExtension
  {
    [Token(Token = "0x6007646")]
    public static IEnumerator SpawnAndInstantiate<T>(
      this AssetCachedSpawner spawner,
      string assetBundleName,
      string assetName,
      Transform parent,
      Action<T> onCreate)
      where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007647")]
    public static void Preload<T>(
      this AssetCachedSpawner spawner,
      GachaAssetBundleInfo.AssetBundleInfo assetBundleInfo)
      where T : UnityEngine.Object
    {
    }
  }
}
