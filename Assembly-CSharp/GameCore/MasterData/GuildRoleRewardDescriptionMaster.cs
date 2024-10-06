// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRoleRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001019")]
  [Serializable]
  public sealed class GuildRoleRewardDescriptionMaster : BaseMaster<GuildRoleRewardDescriptionData>
  {
    [Token(Token = "0x6005DC1")]
    [Address(RVA = "0x2796A80", Offset = "0x2796A80", VA = "0x2796A80")]
    public IReadOnlyDictionary<int, GuildRoleRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildRoleRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005DC2")]
    [Address(RVA = "0x2796A88", Offset = "0x2796A88", VA = "0x2796A88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DC3")]
    [Address(RVA = "0x2796AE8", Offset = "0x2796AE8", VA = "0x2796AE8", Slot = "5")]
    protected override GuildRoleRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildRoleRewardDescriptionData) null;
    }

    [Token(Token = "0x6005DC4")]
    [Address(RVA = "0x2796B40", Offset = "0x2796B40", VA = "0x2796B40")]
    public List<GuildRoleRewardDescriptionData> GetRoleRewardsWithRoleType(
      int groupId,
      GuildRoleTypeEnum roleType)
    {
      return (List<GuildRoleRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005DC5")]
    [Address(RVA = "0x2796C68", Offset = "0x2796C68", VA = "0x2796C68")]
    public GuildRoleRewardDescriptionMaster()
    {
    }
  }
}
