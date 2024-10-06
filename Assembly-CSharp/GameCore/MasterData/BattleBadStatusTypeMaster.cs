// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EBA")]
  [Serializable]
  public sealed class BattleBadStatusTypeMaster : BaseMaster<BattleBadStatusTypeData>
  {
    [Token(Token = "0x6005929")]
    [Address(RVA = "0x3C30920", Offset = "0x3C30920", VA = "0x3C30920")]
    public IReadOnlyDictionary<int, BattleBadStatusTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleBadStatusTypeData>) null;
    }

    [Token(Token = "0x600592A")]
    [Address(RVA = "0x3C30928", Offset = "0x3C30928", VA = "0x3C30928", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600592B")]
    [Address(RVA = "0x3C30988", Offset = "0x3C30988", VA = "0x3C30988", Slot = "5")]
    protected override BattleBadStatusTypeData LoadEntity(IMasterDataReader reader)
    {
      return (BattleBadStatusTypeData) null;
    }

    [Token(Token = "0x600592C")]
    [Address(RVA = "0x3C309E0", Offset = "0x3C309E0", VA = "0x3C309E0")]
    public BattleBadStatusTypeMaster()
    {
    }
  }
}
