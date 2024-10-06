// Decompiled with JetBrains decompiler
// Type: GameCore.AssetSpawnOperationBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BCB")]
  public class AssetSpawnOperationBase
  {
    [Token(Token = "0x170009C2")]
    public bool IsDone
    {
      [Token(Token = "0x600435C"), Address(RVA = "0x36403E8", Offset = "0x36403E8", VA = "0x36403E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600435D"), Address(RVA = "0x36403F0", Offset = "0x36403F0", VA = "0x36403F0")] private set
      {
      }
    }

    [Token(Token = "0x170009C3")]
    public Object AssetObject
    {
      [Token(Token = "0x600435E"), Address(RVA = "0x36403FC", Offset = "0x36403FC", VA = "0x36403FC")] get
      {
        return (Object) null;
      }
    }

    [Token(Token = "0x600435F")]
    [Address(RVA = "0x363ECAC", Offset = "0x363ECAC", VA = "0x363ECAC")]
    public void Cancel()
    {
    }

    [Token(Token = "0x6004360")]
    [Address(RVA = "0x3640408", Offset = "0x3640408", VA = "0x3640408")]
    public void Finish(Object asset)
    {
    }

    [Token(Token = "0x6004361")]
    [Address(RVA = "0x364042C", Offset = "0x364042C", VA = "0x364042C", Slot = "4")]
    protected virtual Object GetAsset() => (Object) null;

    [Token(Token = "0x6004362")]
    [Address(RVA = "0x3640434", Offset = "0x3640434", VA = "0x3640434", Slot = "5")]
    protected virtual void OnFinish(Object asset)
    {
    }

    [Token(Token = "0x6004363")]
    [Address(RVA = "0x3640438", Offset = "0x3640438", VA = "0x3640438")]
    public AssetSpawnOperationBase()
    {
    }
  }
}
