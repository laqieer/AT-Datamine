// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E62")]
  [Serializable]
  public sealed class BattleRewardDescriptionMaster : BaseMaster<BattleRewardDescriptionData>
  {
    [Token(Token = "0x400459C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleRewardDescriptionData>> rewardGroupTable;

    [Token(Token = "0x60057AE")]
    [Address(RVA = "0x3E429A8", Offset = "0x3E429A8", VA = "0x3E429A8")]
    public IReadOnlyDictionary<int, BattleRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleRewardDescriptionData>) null;
    }

    [Token(Token = "0x60057AF")]
    [Address(RVA = "0x3E429B0", Offset = "0x3E429B0", VA = "0x3E429B0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057B0")]
    [Address(RVA = "0x3E42A10", Offset = "0x3E42A10", VA = "0x3E42A10", Slot = "5")]
    protected override BattleRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleRewardDescriptionData) null;
    }

    [Token(Token = "0x60057B1")]
    [Address(RVA = "0x3E42A80", Offset = "0x3E42A80", VA = "0x3E42A80")]
    private void OnLoadEntity(BattleRewardDescriptionData entity)
    {
    }

    [Token(Token = "0x60057B2")]
    [Address(RVA = "0x3E42A84", Offset = "0x3E42A84", VA = "0x3E42A84")]
    private void GroupingByRewardId(BattleRewardDescriptionData entity)
    {
    }

    [Token(Token = "0x60057B3")]
    [Address(RVA = "0x3E42BD8", Offset = "0x3E42BD8", VA = "0x3E42BD8")]
    public IReadOnlyList<BattleRewardDescriptionData> GetListByRewardGroupId(int rewardGroupId)
    {
      return (IReadOnlyList<BattleRewardDescriptionData>) null;
    }

    [Token(Token = "0x60057B4")]
    [Address(RVA = "0x3E42C94", Offset = "0x3E42C94", VA = "0x3E42C94")]
    public BattleRewardDescriptionMaster()
    {
    }
  }
}
