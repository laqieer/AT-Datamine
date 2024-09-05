// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleLoadOperation`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A5")]
  public class AssetBundleLoadOperation<T> : IAssetLoadOperation<T>, IAssetLoadOperation, IEnumerator
    where T : UnityEngine.Object
  {
    [Token(Token = "0x4005ECA")]
    [FieldOffset(Offset = "0x0")]
    private AssetBundleRequest request;

    [Token(Token = "0x170011D2")]
    public object Current
    {
      [Token(Token = "0x600744D")] get => (object) null;
    }

    [Token(Token = "0x600744E")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x600744F")]
    public void Reset()
    {
    }

    [Token(Token = "0x170011D3")]
    public UnityEngine.Object asset
    {
      [Token(Token = "0x6007450")] get => (UnityEngine.Object) null;
    }

    [Token(Token = "0x170011D4")]
    public bool IsDone
    {
      [Token(Token = "0x6007451")] get => new bool();
    }

    [Token(Token = "0x140000FB")]
    public event Action<T> onComplete
    {
      [Token(Token = "0x6007452")] add
      {
      }
      [Token(Token = "0x6007453")] remove
      {
      }
    }

    [Token(Token = "0x140000FC")]
    private event Action<T> onCompleteEvent
    {
      [Token(Token = "0x6007454")] add
      {
      }
      [Token(Token = "0x6007455")] remove
      {
      }
    }

    [Token(Token = "0x6007456")]
    public AssetBundleLoadOperation(AssetBundleRequest request, Action<T> resultCallback)
    {
    }

    [Token(Token = "0x6007457")]
    private void OnRequestComplete(AsyncOperation asyncOperation)
    {
    }
  }
}
