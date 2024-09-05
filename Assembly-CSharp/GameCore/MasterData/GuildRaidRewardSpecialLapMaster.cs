// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSpecialLapMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001000")]
  [Serializable]
  public sealed class GuildRaidRewardSpecialLapMaster : BaseMaster<GuildRaidRewardSpecialLapData>
  {
    [Token(Token = "0x6005D4C")]
    [Address(RVA = "0x279288C", Offset = "0x279288C", VA = "0x279288C")]
    public IReadOnlyDictionary<int, GuildRaidRewardSpecialLapData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardSpecialLapData>) null;
    }

    [Token(Token = "0x6005D4D")]
    [Address(RVA = "0x2792894", Offset = "0x2792894", VA = "0x2792894", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D4E")]
    [Address(RVA = "0x27928F4", Offset = "0x27928F4", VA = "0x27928F4", Slot = "5")]
    protected override GuildRaidRewardSpecialLapData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardSpecialLapData) null;
    }

    [Token(Token = "0x6005D4F")]
    [Address(RVA = "0x279294C", Offset = "0x279294C", VA = "0x279294C")]
    public GuildRaidRewardSpecialLapMaster()
    {
    }
  }
}
