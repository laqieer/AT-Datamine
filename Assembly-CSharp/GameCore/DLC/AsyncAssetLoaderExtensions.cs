// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AsyncAssetLoaderExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using System.Threading;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014AD")]
  public static class AsyncAssetLoaderExtensions
  {
    [Token(Token = "0x600746C")]
    public static UniTask<T> LoadPrefabAsync<T>(
      this AsyncAssetLoader loader,
      string assetBundleName,
      string assetName,
      CancellationToken cancellationToken)
      where T : Component
    {
      return new UniTask<T>();
    }
  }
}
