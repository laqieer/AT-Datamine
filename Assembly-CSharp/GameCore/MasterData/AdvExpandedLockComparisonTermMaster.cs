// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvExpandedLockComparisonTermMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAC")]
  [Serializable]
  public sealed class AdvExpandedLockComparisonTermMaster : 
    BaseMaster<AdvExpandedLockComparisonTermData>
  {
    [Token(Token = "0x400418B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AdvExpandedLockComparisonTermData>> lockTable;

    [Token(Token = "0x60053B2")]
    [Address(RVA = "0x3A9CA4C", Offset = "0x3A9CA4C", VA = "0x3A9CA4C")]
    public IReadOnlyDictionary<int, AdvExpandedLockComparisonTermData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvExpandedLockComparisonTermData>) null;
    }

    [Token(Token = "0x60053B3")]
    [Address(RVA = "0x3A9CA54", Offset = "0x3A9CA54", VA = "0x3A9CA54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053B4")]
    [Address(RVA = "0x3A9CB0C", Offset = "0x3A9CB0C", VA = "0x3A9CB0C", Slot = "5")]
    protected override AdvExpandedLockComparisonTermData LoadEntity(IMasterDataReader reader)
    {
      return (AdvExpandedLockComparisonTermData) null;
    }

    [Token(Token = "0x60053B5")]
    [Address(RVA = "0x3A9CABC", Offset = "0x3A9CABC", VA = "0x3A9CABC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60053B6")]
    [Address(RVA = "0x3A9CB7C", Offset = "0x3A9CB7C", VA = "0x3A9CB7C")]
    private void OnLoadEntity(AdvExpandedLockComparisonTermData entity)
    {
    }

    [Token(Token = "0x60053B7")]
    [Address(RVA = "0x3A9CCF8", Offset = "0x3A9CCF8", VA = "0x3A9CCF8")]
    public IReadOnlyList<AdvExpandedLockComparisonTermData> GetList(int ExpandedlockGroupId)
    {
      return (IReadOnlyList<AdvExpandedLockComparisonTermData>) null;
    }

    [Token(Token = "0x60053B8")]
    [Address(RVA = "0x3A9CDB4", Offset = "0x3A9CDB4", VA = "0x3A9CDB4")]
    public AdvExpandedLockComparisonTermMaster()
    {
    }
  }
}
