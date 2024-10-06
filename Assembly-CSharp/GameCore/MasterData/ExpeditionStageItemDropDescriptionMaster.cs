// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageItemDropDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB1")]
  [Serializable]
  public sealed class ExpeditionStageItemDropDescriptionMaster : 
    BaseMaster<ExpeditionStageItemDropDescriptionData>
  {
    [Token(Token = "0x4004EFF")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionStageItemDropDescriptionData>> dropTable;

    [Token(Token = "0x6005C14")]
    [Address(RVA = "0x2788F08", Offset = "0x2788F08", VA = "0x2788F08")]
    public IReadOnlyDictionary<int, ExpeditionStageItemDropDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionStageItemDropDescriptionData>) null;
    }

    [Token(Token = "0x6005C15")]
    [Address(RVA = "0x2788F10", Offset = "0x2788F10", VA = "0x2788F10", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C16")]
    [Address(RVA = "0x2788F70", Offset = "0x2788F70", VA = "0x2788F70", Slot = "5")]
    protected override ExpeditionStageItemDropDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionStageItemDropDescriptionData) null;
    }

    [Token(Token = "0x6005C17")]
    [Address(RVA = "0x2788FE0", Offset = "0x2788FE0", VA = "0x2788FE0")]
    private void OnLoadEntity(ExpeditionStageItemDropDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C18")]
    [Address(RVA = "0x2788FE4", Offset = "0x2788FE4", VA = "0x2788FE4")]
    private void GroupingByDropID(ExpeditionStageItemDropDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C19")]
    [Address(RVA = "0x2788720", Offset = "0x2788720", VA = "0x2788720")]
    public IReadOnlyCollection<ExpeditionStageItemDropDescriptionData> GetList(int drop)
    {
      return (IReadOnlyCollection<ExpeditionStageItemDropDescriptionData>) null;
    }

    [Token(Token = "0x6005C1A")]
    [Address(RVA = "0x278913C", Offset = "0x278913C", VA = "0x278913C")]
    public ExpeditionStageItemDropDescriptionMaster()
    {
    }
  }
}
