// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001333")]
  [Serializable]
  public sealed class AbilityBoardConsumeGroupMaster : BaseMaster<AbilityBoardConsumeGroupData>
  {
    [Token(Token = "0x4005A93")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardConsumeGroupData>> descriptionTable;

    [Token(Token = "0x6006C54")]
    [Address(RVA = "0x46F2898", Offset = "0x46F2898", VA = "0x46F2898")]
    public IReadOnlyDictionary<int, AbilityBoardConsumeGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardConsumeGroupData>) null;
    }

    [Token(Token = "0x6006C55")]
    [Address(RVA = "0x46F28A0", Offset = "0x46F28A0", VA = "0x46F28A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C56")]
    [Address(RVA = "0x46F2B64", Offset = "0x46F2B64", VA = "0x46F2B64", Slot = "5")]
    protected override AbilityBoardConsumeGroupData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardConsumeGroupData) null;
    }

    [Token(Token = "0x6006C57")]
    [Address(RVA = "0x46F2BD4", Offset = "0x46F2BD4", VA = "0x46F2BD4")]
    private void OnLoadEntity(AbilityBoardConsumeGroupData entity)
    {
    }

    [Token(Token = "0x6006C58")]
    [Address(RVA = "0x46F2908", Offset = "0x46F2908", VA = "0x46F2908")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C59")]
    [Address(RVA = "0x46F2BD8", Offset = "0x46F2BD8", VA = "0x46F2BD8")]
    private void GroupingByStyleExpId(AbilityBoardConsumeGroupData entity)
    {
    }

    [Token(Token = "0x6006C5A")]
    [Address(RVA = "0x46F2D94", Offset = "0x46F2D94", VA = "0x46F2D94")]
    public IReadOnlyList<AbilityBoardConsumeGroupData> GetListByConsumeGroupId(int consumeGroupId)
    {
      return (IReadOnlyList<AbilityBoardConsumeGroupData>) null;
    }

    [Token(Token = "0x6006C5B")]
    [Address(RVA = "0x46F2E50", Offset = "0x46F2E50", VA = "0x46F2E50")]
    public AbilityBoardConsumeGroupMaster()
    {
    }
  }
}
