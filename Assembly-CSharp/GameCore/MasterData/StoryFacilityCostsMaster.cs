// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityCostsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200121B")]
  [Serializable]
  public sealed class StoryFacilityCostsMaster : BaseMaster<StoryFacilityCostsData>
  {
    [Token(Token = "0x40056AD")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryFacilityCostsData> groupTable;

    [Token(Token = "0x6006731")]
    [Address(RVA = "0x4D2D3C4", Offset = "0x4D2D3C4", VA = "0x4D2D3C4")]
    public IReadOnlyDictionary<int, StoryFacilityCostsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityCostsData>) null;
    }

    [Token(Token = "0x6006732")]
    [Address(RVA = "0x4D2D3CC", Offset = "0x4D2D3CC", VA = "0x4D2D3CC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006733")]
    [Address(RVA = "0x4D2D538", Offset = "0x4D2D538", VA = "0x4D2D538", Slot = "5")]
    protected override StoryFacilityCostsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityCostsData) null;
    }

    [Token(Token = "0x6006734")]
    [Address(RVA = "0x4D2D434", Offset = "0x4D2D434", VA = "0x4D2D434")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006735")]
    [Address(RVA = "0x4D2D5A8", Offset = "0x4D2D5A8", VA = "0x4D2D5A8")]
    private void OnLoadEntity(StoryFacilityCostsData entity)
    {
    }

    [Token(Token = "0x6006736")]
    [Address(RVA = "0x4D2D600", Offset = "0x4D2D600", VA = "0x4D2D600")]
    public List<StoryFacilityCostsData> GetList(int label) => (List<StoryFacilityCostsData>) null;

    [Token(Token = "0x6006737")]
    [Address(RVA = "0x4D2D658", Offset = "0x4D2D658", VA = "0x4D2D658")]
    public StoryFacilityCostsMaster()
    {
    }
  }
}
