// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSuppressMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001008")]
  [Serializable]
  public sealed class GuildRaidRewardSuppressMaster : BaseMaster<GuildRaidRewardSuppressData>
  {
    [Token(Token = "0x6005D6E")]
    [Address(RVA = "0x2793924", Offset = "0x2793924", VA = "0x2793924")]
    public IReadOnlyDictionary<int, GuildRaidRewardSuppressData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRaidRewardSuppressData>) null;
    }

    [Token(Token = "0x6005D6F")]
    [Address(RVA = "0x279392C", Offset = "0x279392C", VA = "0x279392C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D70")]
    [Address(RVA = "0x279398C", Offset = "0x279398C", VA = "0x279398C", Slot = "5")]
    protected override GuildRaidRewardSuppressData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRaidRewardSuppressData) null;
    }

    [Token(Token = "0x6005D71")]
    [Address(RVA = "0x27939E4", Offset = "0x27939E4", VA = "0x27939E4")]
    public GuildRaidRewardSuppressMaster()
    {
    }
  }
}
