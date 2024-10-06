// Decompiled with JetBrains decompiler
// Type: GameCore.AssetSpawnOperation`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BCC")]
  public class AssetSpawnOperation<T> : AssetSpawnOperationBase where T : UnityEngine.Object
  {
    [Token(Token = "0x40035C1")]
    [FieldOffset(Offset = "0x0")]
    private Action<T> OnSpawnFinish;

    [Token(Token = "0x170009C4")]
    public T Asset
    {
      [Token(Token = "0x6004364")] get => (T) null;
      [Token(Token = "0x6004365")] private set
      {
      }
    }

    [Token(Token = "0x6004366")]
    public AssetSpawnOperation(Action<T> onSpawnFinish)
    {
    }

    [Token(Token = "0x6004367")]
    protected override UnityEngine.Object GetAsset() => (UnityEngine.Object) null;

    [Token(Token = "0x6004368")]
    protected override void OnFinish(UnityEngine.Object asset)
    {
    }
  }
}
