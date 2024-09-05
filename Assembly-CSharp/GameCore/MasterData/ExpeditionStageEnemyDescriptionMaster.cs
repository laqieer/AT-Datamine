// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageEnemyDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAF")]
  [Serializable]
  public sealed class ExpeditionStageEnemyDescriptionMaster : 
    BaseMaster<ExpeditionStageEnemyDescriptionData>
  {
    [Token(Token = "0x4004EFB")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionStageEnemyDescriptionData>> enemyPlacementTable;

    [Token(Token = "0x6005C08")]
    [Address(RVA = "0x2788998", Offset = "0x2788998", VA = "0x2788998")]
    public IReadOnlyDictionary<int, ExpeditionStageEnemyDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionStageEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005C09")]
    [Address(RVA = "0x27889A0", Offset = "0x27889A0", VA = "0x27889A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C0A")]
    [Address(RVA = "0x2788A00", Offset = "0x2788A00", VA = "0x2788A00", Slot = "5")]
    protected override ExpeditionStageEnemyDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionStageEnemyDescriptionData) null;
    }

    [Token(Token = "0x6005C0B")]
    [Address(RVA = "0x2788A70", Offset = "0x2788A70", VA = "0x2788A70")]
    private void OnLoadEntity(ExpeditionStageEnemyDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C0C")]
    [Address(RVA = "0x2788A74", Offset = "0x2788A74", VA = "0x2788A74")]
    private void GroupingByEnemyID(ExpeditionStageEnemyDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C0D")]
    [Address(RVA = "0x2788918", Offset = "0x2788918", VA = "0x2788918")]
    public IReadOnlyCollection<ExpeditionStageEnemyDescriptionData> GetList(int placement)
    {
      return (IReadOnlyCollection<ExpeditionStageEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005C0E")]
    [Address(RVA = "0x2788BCC", Offset = "0x2788BCC", VA = "0x2788BCC")]
    public ExpeditionStageEnemyDescriptionMaster()
    {
    }
  }
}
