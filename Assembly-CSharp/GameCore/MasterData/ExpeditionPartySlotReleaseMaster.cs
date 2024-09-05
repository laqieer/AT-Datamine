// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionPartySlotReleaseMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA3")]
  [Serializable]
  public sealed class ExpeditionPartySlotReleaseMaster : BaseMaster<ExpeditionPartySlotReleaseData>
  {
    [Token(Token = "0x4004ED2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionPartySlotReleaseData>> partySlotReleaseTable;

    [Token(Token = "0x6005BD2")]
    [Address(RVA = "0x2786840", Offset = "0x2786840", VA = "0x2786840")]
    public IReadOnlyDictionary<int, ExpeditionPartySlotReleaseData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionPartySlotReleaseData>) null;
    }

    [Token(Token = "0x6005BD3")]
    [Address(RVA = "0x2786848", Offset = "0x2786848", VA = "0x2786848", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BD4")]
    [Address(RVA = "0x27868A8", Offset = "0x27868A8", VA = "0x27868A8", Slot = "5")]
    protected override ExpeditionPartySlotReleaseData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionPartySlotReleaseData) null;
    }

    [Token(Token = "0x6005BD5")]
    [Address(RVA = "0x2786918", Offset = "0x2786918", VA = "0x2786918")]
    private void OnLoadEntity(ExpeditionPartySlotReleaseData entity)
    {
    }

    [Token(Token = "0x6005BD6")]
    [Address(RVA = "0x278691C", Offset = "0x278691C", VA = "0x278691C")]
    private void GroupingByPartyNo(ExpeditionPartySlotReleaseData entity)
    {
    }

    [Token(Token = "0x6005BD7")]
    [Address(RVA = "0x2786A74", Offset = "0x2786A74", VA = "0x2786A74")]
    public IReadOnlyCollection<ExpeditionPartySlotReleaseData> GetList(int partyNo)
    {
      return (IReadOnlyCollection<ExpeditionPartySlotReleaseData>) null;
    }

    [Token(Token = "0x6005BD8")]
    [Address(RVA = "0x2786AEC", Offset = "0x2786AEC", VA = "0x2786AEC")]
    public ExpeditionPartySlotReleaseMaster()
    {
    }
  }
}
