// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123C")]
  [Serializable]
  public sealed class StoryFreeActionAreaGroupMaster : BaseMaster<StoryFreeActionAreaGroupData>
  {
    [Token(Token = "0x400574A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionAreaGroupData>> groupingTable;

    [Token(Token = "0x60067AC")]
    [Address(RVA = "0x4D317BC", Offset = "0x4D317BC", VA = "0x4D317BC")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaGroupData>) null;
    }

    [Token(Token = "0x60067AD")]
    [Address(RVA = "0x4D317C4", Offset = "0x4D317C4", VA = "0x4D317C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067AE")]
    [Address(RVA = "0x4D31888", Offset = "0x4D31888", VA = "0x4D31888", Slot = "5")]
    protected override StoryFreeActionAreaGroupData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaGroupData) null;
    }

    [Token(Token = "0x60067AF")]
    [Address(RVA = "0x4D3182C", Offset = "0x4D3182C", VA = "0x4D3182C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60067B0")]
    [Address(RVA = "0x4D318F8", Offset = "0x4D318F8", VA = "0x4D318F8")]
    private void OnLoadEntity(StoryFreeActionAreaGroupData entity)
    {
    }

    [Token(Token = "0x60067B1")]
    [Address(RVA = "0x4D31A74", Offset = "0x4D31A74", VA = "0x4D31A74")]
    public IReadOnlyList<StoryFreeActionAreaGroupData> GetAreaGroupDataListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionAreaGroupData>) null;
    }

    [Token(Token = "0x60067B2")]
    [Address(RVA = "0x4D31B30", Offset = "0x4D31B30", VA = "0x4D31B30")]
    public StoryFreeActionAreaGroupMaster()
    {
    }
  }
}
