// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.EditorAssetLoadOperation`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A4")]
  public class EditorAssetLoadOperation<T> : IAssetLoadOperation<T>, IAssetLoadOperation, IEnumerator
    where T : UnityEngine.Object
  {
    [Token(Token = "0x170011CF")]
    public object Current
    {
      [Token(Token = "0x6007442")] get => (object) null;
    }

    [Token(Token = "0x6007443")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x6007444")]
    public void Reset()
    {
    }

    [Token(Token = "0x170011D0")]
    public UnityEngine.Object asset
    {
      [Token(Token = "0x6007445")] get => (UnityEngine.Object) null;
      [Token(Token = "0x6007446")] private set
      {
      }
    }

    [Token(Token = "0x170011D1")]
    public bool IsDone
    {
      [Token(Token = "0x6007447")] get => new bool();
    }

    [Token(Token = "0x140000F9")]
    public event Action<T> onComplete
    {
      [Token(Token = "0x6007448")] add
      {
      }
      [Token(Token = "0x6007449")] remove
      {
      }
    }

    [Token(Token = "0x140000FA")]
    private event Action<T> onCompleteEvent
    {
      [Token(Token = "0x600744A")] add
      {
      }
      [Token(Token = "0x600744B")] remove
      {
      }
    }

    [Token(Token = "0x600744C")]
    public EditorAssetLoadOperation(UnityEngine.Object asset, Action<T> resultCallback)
    {
    }
  }
}
