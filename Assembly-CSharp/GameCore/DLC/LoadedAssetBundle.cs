// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.LoadedAssetBundle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using System;
using System.Threading;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014D4")]
  public class LoadedAssetBundle
  {
    [Token(Token = "0x17001219")]
    public AssetBundle AssetBundle
    {
      [Token(Token = "0x600757C"), Address(RVA = "0x43F96F0", Offset = "0x43F96F0", VA = "0x43F96F0")] get
      {
        return (AssetBundle) null;
      }
      [Token(Token = "0x600757D"), Address(RVA = "0x43F96F8", Offset = "0x43F96F8", VA = "0x43F96F8")] set
      {
      }
    }

    [Token(Token = "0x1700121A")]
    public int ReferencedCount
    {
      [Token(Token = "0x600757E"), Address(RVA = "0x43F9700", Offset = "0x43F9700", VA = "0x43F9700")] get
      {
        return new int();
      }
      [Token(Token = "0x600757F"), Address(RVA = "0x43F9708", Offset = "0x43F9708", VA = "0x43F9708")] set
      {
      }
    }

    [Token(Token = "0x6007580")]
    [Address(RVA = "0x43EC4F0", Offset = "0x43EC4F0", VA = "0x43EC4F0")]
    public LoadedAssetBundle(AssetBundle ab)
    {
    }

    [Token(Token = "0x6007581")]
    public T GetAsset<T>(string assetName) where T : UnityEngine.Object => (T) null;

    [Token(Token = "0x6007582")]
    public IAssetLoadOperation<T> LoadAssetAsync<T>(string assetName, Action<T> resultCallback) where T : UnityEngine.Object
    {
      return (IAssetLoadOperation<T>) null;
    }

    [Token(Token = "0x6007583")]
    public UniTask<T> LoadAssetAsync<T>(string assetName, CancellationToken cancellationToken) where T : UnityEngine.Object
    {
      return new UniTask<T>();
    }

    [Token(Token = "0x6007584")]
    [Address(RVA = "0x43F9710", Offset = "0x43F9710", VA = "0x43F9710")]
    public byte[] GetAssetBytes(string assetName) => (byte[]) null;
  }
}
