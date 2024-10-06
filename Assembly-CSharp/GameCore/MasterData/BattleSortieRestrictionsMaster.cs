// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSortieRestrictionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E64")]
  [Serializable]
  public sealed class BattleSortieRestrictionsMaster : BaseMaster<BattleSortieRestrictionsData>
  {
    [Token(Token = "0x40045A2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleSortieRestrictionsData>> descriptionTable;

    [Token(Token = "0x60057B9")]
    [Address(RVA = "0x3E43014", Offset = "0x3E43014", VA = "0x3E43014")]
    public IReadOnlyDictionary<int, BattleSortieRestrictionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleSortieRestrictionsData>) null;
    }

    [Token(Token = "0x60057BA")]
    [Address(RVA = "0x3E4301C", Offset = "0x3E4301C", VA = "0x3E4301C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057BB")]
    [Address(RVA = "0x3E432E0", Offset = "0x3E432E0", VA = "0x3E432E0", Slot = "5")]
    protected override BattleSortieRestrictionsData LoadEntity(IMasterDataReader reader)
    {
      return (BattleSortieRestrictionsData) null;
    }

    [Token(Token = "0x60057BC")]
    [Address(RVA = "0x3E43350", Offset = "0x3E43350", VA = "0x3E43350")]
    private void OnLoadEntity(BattleSortieRestrictionsData entity)
    {
    }

    [Token(Token = "0x60057BD")]
    [Address(RVA = "0x3E43084", Offset = "0x3E43084", VA = "0x3E43084")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x60057BE")]
    [Address(RVA = "0x3E43354", Offset = "0x3E43354", VA = "0x3E43354")]
    private void GroupingByStyleExpId(BattleSortieRestrictionsData entity)
    {
    }

    [Token(Token = "0x60057BF")]
    [Address(RVA = "0x3E43510", Offset = "0x3E43510", VA = "0x3E43510")]
    public IReadOnlyList<BattleSortieRestrictionsData> GetListByGroupId(int groupId)
    {
      return (IReadOnlyList<BattleSortieRestrictionsData>) null;
    }

    [Token(Token = "0x60057C0")]
    [Address(RVA = "0x3E435CC", Offset = "0x3E435CC", VA = "0x3E435CC")]
    public BattleSortieRestrictionsMaster()
    {
    }
  }
}
