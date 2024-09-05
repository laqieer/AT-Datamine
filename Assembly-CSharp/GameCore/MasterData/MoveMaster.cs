// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200137C")]
  [Serializable]
  public sealed class MoveMaster : BaseMaster<MoveData>
  {
    [Token(Token = "0x6006DA2")]
    [Address(RVA = "0x46FE934", Offset = "0x46FE934", VA = "0x46FE934")]
    public IReadOnlyDictionary<int, MoveData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MoveData>) null;
    }

    [Token(Token = "0x6006DA3")]
    [Address(RVA = "0x46FE93C", Offset = "0x46FE93C", VA = "0x46FE93C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DA4")]
    [Address(RVA = "0x46FE99C", Offset = "0x46FE99C", VA = "0x46FE99C", Slot = "5")]
    protected override MoveData LoadEntity(IMasterDataReader reader) => (MoveData) null;

    [Token(Token = "0x6006DA5")]
    [Address(RVA = "0x46FE9F4", Offset = "0x46FE9F4", VA = "0x46FE9F4")]
    public MoveMaster()
    {
    }
  }
}
