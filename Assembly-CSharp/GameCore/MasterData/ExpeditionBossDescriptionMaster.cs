// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F8E")]
  [Serializable]
  public sealed class ExpeditionBossDescriptionMaster : BaseMaster<ExpeditionBossDescriptionData>
  {
    [Token(Token = "0x4004E8E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionBossDescriptionData>> bossDescriptionTable;

    [Token(Token = "0x6005B69")]
    [Address(RVA = "0x2781F4C", Offset = "0x2781F4C", VA = "0x2781F4C")]
    public IReadOnlyDictionary<int, ExpeditionBossDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6005B6A")]
    [Address(RVA = "0x2781F54", Offset = "0x2781F54", VA = "0x2781F54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B6B")]
    [Address(RVA = "0x2781FB4", Offset = "0x2781FB4", VA = "0x2781FB4", Slot = "5")]
    protected override ExpeditionBossDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossDescriptionData) null;
    }

    [Token(Token = "0x6005B6C")]
    [Address(RVA = "0x2782024", Offset = "0x2782024", VA = "0x2782024")]
    private void OnLoadEntity(ExpeditionBossDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B6D")]
    [Address(RVA = "0x2782028", Offset = "0x2782028", VA = "0x2782028")]
    private void GroupingByBoss(ExpeditionBossDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B6E")]
    [Address(RVA = "0x2782180", Offset = "0x2782180", VA = "0x2782180")]
    public IReadOnlyCollection<ExpeditionBossDescriptionData> GetList(int boss)
    {
      return (IReadOnlyCollection<ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6005B6F")]
    [Address(RVA = "0x27821F8", Offset = "0x27821F8", VA = "0x27821F8")]
    public ExpeditionBossDescriptionData GetBossDescriptionData(int boss, int level)
    {
      return (ExpeditionBossDescriptionData) null;
    }

    [Token(Token = "0x6005B70")]
    [Address(RVA = "0x27822FC", Offset = "0x27822FC", VA = "0x27822FC")]
    public ExpeditionBossDescriptionMaster()
    {
    }
  }
}
