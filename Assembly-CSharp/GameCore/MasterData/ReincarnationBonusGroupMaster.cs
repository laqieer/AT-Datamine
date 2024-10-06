// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationBonusGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013A8")]
  [Serializable]
  public sealed class ReincarnationBonusGroupMaster : BaseMaster<ReincarnationBonusGroupData>
  {
    [Token(Token = "0x4005B9E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ReincarnationBonusGroupData>> groupTable;

    [Token(Token = "0x6006E63")]
    [Address(RVA = "0x4704EB8", Offset = "0x4704EB8", VA = "0x4704EB8")]
    public IReadOnlyDictionary<int, ReincarnationBonusGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ReincarnationBonusGroupData>) null;
    }

    [Token(Token = "0x6006E64")]
    [Address(RVA = "0x4704EC0", Offset = "0x4704EC0", VA = "0x4704EC0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E65")]
    [Address(RVA = "0x4704F20", Offset = "0x4704F20", VA = "0x4704F20", Slot = "5")]
    protected override ReincarnationBonusGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ReincarnationBonusGroupData) null;
    }

    [Token(Token = "0x6006E66")]
    [Address(RVA = "0x4704F90", Offset = "0x4704F90", VA = "0x4704F90")]
    private void OnLoadEntity(ReincarnationBonusGroupData entity)
    {
    }

    [Token(Token = "0x6006E67")]
    [Address(RVA = "0x4704F94", Offset = "0x4704F94", VA = "0x4704F94")]
    private void GroupingByReincarnationBonusGroup(ReincarnationBonusGroupData entity)
    {
    }

    [Token(Token = "0x6006E68")]
    [Address(RVA = "0x4705150", Offset = "0x4705150", VA = "0x4705150")]
    public List<ReincarnationBonusGroupData> GetListByGroupId(int id)
    {
      return (List<ReincarnationBonusGroupData>) null;
    }

    [Token(Token = "0x6006E69")]
    [Address(RVA = "0x470520C", Offset = "0x470520C", VA = "0x470520C")]
    public ReincarnationBonusGroupData GetUniqueData(int id, int count)
    {
      return (ReincarnationBonusGroupData) null;
    }

    [Token(Token = "0x6006E6A")]
    [Address(RVA = "0x470537C", Offset = "0x470537C", VA = "0x470537C")]
    public int GetSlotUnlock(int id) => new int();

    [Token(Token = "0x6006E6B")]
    [Address(RVA = "0x47054F8", Offset = "0x47054F8", VA = "0x47054F8")]
    public bool IsSlotUnlock(int id, int reincarnationCount) => new bool();

    [Token(Token = "0x6006E6C")]
    [Address(RVA = "0x4705514", Offset = "0x4705514", VA = "0x4705514")]
    public int GetTrustUnlock(int id) => new int();

    [Token(Token = "0x6006E6D")]
    [Address(RVA = "0x4705690", Offset = "0x4705690", VA = "0x4705690")]
    public ReincarnationBonusGroupMaster()
    {
    }
  }
}
