// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTimeSlotGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F8")]
  [Serializable]
  public sealed class StoryTimeSlotGroupMaster : BaseMaster<StoryTimeSlotGroupData>
  {
    [Token(Token = "0x40059D3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryTimeSlotGroupData>> groupingTable;

    [Token(Token = "0x6006B43")]
    [Address(RVA = "0x48E0E50", Offset = "0x48E0E50", VA = "0x48E0E50")]
    public IReadOnlyDictionary<int, StoryTimeSlotGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryTimeSlotGroupData>) null;
    }

    [Token(Token = "0x6006B44")]
    [Address(RVA = "0x48E0E58", Offset = "0x48E0E58", VA = "0x48E0E58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B45")]
    [Address(RVA = "0x48E0F1C", Offset = "0x48E0F1C", VA = "0x48E0F1C", Slot = "5")]
    protected override StoryTimeSlotGroupData LoadEntity(IMasterDataReader reader)
    {
      return (StoryTimeSlotGroupData) null;
    }

    [Token(Token = "0x6006B46")]
    [Address(RVA = "0x48E0EC0", Offset = "0x48E0EC0", VA = "0x48E0EC0")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006B47")]
    [Address(RVA = "0x48E0F8C", Offset = "0x48E0F8C", VA = "0x48E0F8C")]
    private void OnLoadEntity(StoryTimeSlotGroupData entity)
    {
    }

    [Token(Token = "0x6006B48")]
    [Address(RVA = "0x48E0F90", Offset = "0x48E0F90", VA = "0x48E0F90")]
    private void Grouping(StoryTimeSlotGroupData entity)
    {
    }

    [Token(Token = "0x6006B49")]
    [Address(RVA = "0x48E110C", Offset = "0x48E110C", VA = "0x48E110C")]
    public IReadOnlyCollection<StoryTimeSlotGroupData> GetListByGroupLabel(int groupLabel)
    {
      return (IReadOnlyCollection<StoryTimeSlotGroupData>) null;
    }

    [Token(Token = "0x6006B4A")]
    [Address(RVA = "0x48E11C8", Offset = "0x48E11C8", VA = "0x48E11C8")]
    public StoryTimeSlotGroupMaster()
    {
    }
  }
}
