// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionRewardDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B2")]
  [Serializable]
  public sealed class TotalMissionRewardDetailMaster : BaseMaster<TotalMissionRewardDetailData>
  {
    [Token(Token = "0x400522A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<TotalMissionRewardDetailData>> descriptionTable;

    [Token(Token = "0x6006093")]
    [Address(RVA = "0x28D8C6C", Offset = "0x28D8C6C", VA = "0x28D8C6C")]
    public IReadOnlyDictionary<int, TotalMissionRewardDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TotalMissionRewardDetailData>) null;
    }

    [Token(Token = "0x6006094")]
    [Address(RVA = "0x28D8C74", Offset = "0x28D8C74", VA = "0x28D8C74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006095")]
    [Address(RVA = "0x28D8CD4", Offset = "0x28D8CD4", VA = "0x28D8CD4", Slot = "5")]
    protected override TotalMissionRewardDetailData LoadEntity(IMasterDataReader reader)
    {
      return (TotalMissionRewardDetailData) null;
    }

    [Token(Token = "0x6006096")]
    [Address(RVA = "0x28D8D44", Offset = "0x28D8D44", VA = "0x28D8D44")]
    private void OnLoadEntity(TotalMissionRewardDetailData entity)
    {
    }

    [Token(Token = "0x6006097")]
    [Address(RVA = "0x28D8D48", Offset = "0x28D8D48", VA = "0x28D8D48")]
    private void GroupingByMissionRewardID(TotalMissionRewardDetailData entity)
    {
    }

    [Token(Token = "0x6006098")]
    [Address(RVA = "0x28D8F04", Offset = "0x28D8F04", VA = "0x28D8F04")]
    public List<TotalMissionRewardDetailData> GetListByMissionRewardID(int missionRewardID)
    {
      return (List<TotalMissionRewardDetailData>) null;
    }

    [Token(Token = "0x6006099")]
    [Address(RVA = "0x28D8FC0", Offset = "0x28D8FC0", VA = "0x28D8FC0")]
    public TotalMissionRewardDetailMaster()
    {
    }
  }
}
