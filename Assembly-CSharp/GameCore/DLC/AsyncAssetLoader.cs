// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AsyncAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Threading;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A6")]
  public class AsyncAssetLoader : IDisposable
  {
    [Token(Token = "0x4005ECC")]
    [FieldOffset(Offset = "0x10")]
    private ICollection<string> loadedAssetBundleNames;

    [Token(Token = "0x6007458")]
    public UniTask<T> LoadAssetAsync<T>(
      string assetBundleName,
      string assetName,
      CancellationToken cancellationToken)
      where T : UnityEngine.Object
    {
      return new UniTask<T>();
    }

    [Token(Token = "0x6007459")]
    [Address(RVA = "0x43EC6F4", Offset = "0x43EC6F4", VA = "0x43EC6F4")]
    private UniTask LoadAsync(CancellationToken cancellationToken) => new UniTask();

    [Token(Token = "0x600745A")]
    [Address(RVA = "0x43EC83C", Offset = "0x43EC83C", VA = "0x43EC83C")]
    public UniTask LoadAssetBundleAsync(string assetBundleName, CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x600745B")]
    [Address(RVA = "0x43EC990", Offset = "0x43EC990", VA = "0x43EC990")]
    public UniTask LoadAssetBundlesAsync(
      ICollection<string> assetBundleNames,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x600745C")]
    [Address(RVA = "0x43ECAE4", Offset = "0x43ECAE4", VA = "0x43ECAE4")]
    private void UnloadAssetBundles()
    {
    }

    [Token(Token = "0x600745D")]
    [Address(RVA = "0x43ECE18", Offset = "0x43ECE18", VA = "0x43ECE18", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600745E")]
    [Address(RVA = "0x43ECE1C", Offset = "0x43ECE1C", VA = "0x43ECE1C")]
    public AsyncAssetLoader()
    {
    }
  }
}
