// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleForcedSortieMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E4A")]
  [Serializable]
  public sealed class BattleForcedSortieMaster : BaseMaster<BattleForcedSortieData>
  {
    [Token(Token = "0x40044E9")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleForcedSortieData>> descriptionTable;

    [Token(Token = "0x60056EB")]
    [Address(RVA = "0x3E3A7D0", Offset = "0x3E3A7D0", VA = "0x3E3A7D0")]
    public IReadOnlyDictionary<int, BattleForcedSortieData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleForcedSortieData>) null;
    }

    [Token(Token = "0x60056EC")]
    [Address(RVA = "0x3E3A7D8", Offset = "0x3E3A7D8", VA = "0x3E3A7D8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056ED")]
    [Address(RVA = "0x3E3AA9C", Offset = "0x3E3AA9C", VA = "0x3E3AA9C", Slot = "5")]
    protected override BattleForcedSortieData LoadEntity(IMasterDataReader reader)
    {
      return (BattleForcedSortieData) null;
    }

    [Token(Token = "0x60056EE")]
    [Address(RVA = "0x3E3AB0C", Offset = "0x3E3AB0C", VA = "0x3E3AB0C")]
    private void OnLoadEntity(BattleForcedSortieData entity)
    {
    }

    [Token(Token = "0x60056EF")]
    [Address(RVA = "0x3E3A840", Offset = "0x3E3A840", VA = "0x3E3A840")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x60056F0")]
    [Address(RVA = "0x3E3AB10", Offset = "0x3E3AB10", VA = "0x3E3AB10")]
    private void GroupingByStyleExpId(BattleForcedSortieData entity)
    {
    }

    [Token(Token = "0x60056F1")]
    [Address(RVA = "0x3E3ACCC", Offset = "0x3E3ACCC", VA = "0x3E3ACCC")]
    public IReadOnlyList<BattleForcedSortieData> GetListByGroupId(int groupId)
    {
      return (IReadOnlyList<BattleForcedSortieData>) null;
    }

    [Token(Token = "0x60056F2")]
    [Address(RVA = "0x3E3AD88", Offset = "0x3E3AD88", VA = "0x3E3AD88")]
    public BattleForcedSortieMaster()
    {
    }
  }
}
