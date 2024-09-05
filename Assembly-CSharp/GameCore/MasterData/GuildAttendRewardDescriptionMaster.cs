// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildAttendRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001013")]
  [Serializable]
  public sealed class GuildAttendRewardDescriptionMaster : 
    BaseMaster<GuildAttendRewardDescriptionData>
  {
    [Token(Token = "0x6005DA5")]
    [Address(RVA = "0x2795728", Offset = "0x2795728", VA = "0x2795728")]
    public IReadOnlyDictionary<int, GuildAttendRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildAttendRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005DA6")]
    [Address(RVA = "0x2795730", Offset = "0x2795730", VA = "0x2795730", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DA7")]
    [Address(RVA = "0x2795790", Offset = "0x2795790", VA = "0x2795790", Slot = "5")]
    protected override GuildAttendRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildAttendRewardDescriptionData) null;
    }

    [Token(Token = "0x6005DA8")]
    [Address(RVA = "0x27957E8", Offset = "0x27957E8", VA = "0x27957E8")]
    public List<GuildAttendRewardDescriptionData> GetDescriptionDataListWithGroupId(int groupId)
    {
      return (List<GuildAttendRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005DA9")]
    [Address(RVA = "0x2795A20", Offset = "0x2795A20", VA = "0x2795A20")]
    public List<GuildAttendRewardDescriptionData> GetAttendRewardsWithAttendCount(
      int groupId,
      int attendCount)
    {
      return (List<GuildAttendRewardDescriptionData>) null;
    }

    [Token(Token = "0x6005DAA")]
    [Address(RVA = "0x2795B9C", Offset = "0x2795B9C", VA = "0x2795B9C")]
    public int[] GetAttendCountArrayWithGroupId(int groupId) => (int[]) null;

    [Token(Token = "0x6005DAB")]
    [Address(RVA = "0x2795D88", Offset = "0x2795D88", VA = "0x2795D88")]
    public GuildAttendRewardDescriptionMaster()
    {
    }
  }
}
