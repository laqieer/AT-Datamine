// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001242")]
  [Serializable]
  public sealed class StoryFreeActionAreaSettingMaster : BaseMaster<StoryFreeActionAreaSettingData>
  {
    [Token(Token = "0x4005762")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionAreaSettingData>> groupingTable;

    [Token(Token = "0x60067CB")]
    [Address(RVA = "0x4D32B24", Offset = "0x4D32B24", VA = "0x4D32B24")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x60067CC")]
    [Address(RVA = "0x4D32B2C", Offset = "0x4D32B2C", VA = "0x4D32B2C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067CD")]
    [Address(RVA = "0x4D32BF0", Offset = "0x4D32BF0", VA = "0x4D32BF0", Slot = "5")]
    protected override StoryFreeActionAreaSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x60067CE")]
    [Address(RVA = "0x4D32B94", Offset = "0x4D32B94", VA = "0x4D32B94")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60067CF")]
    [Address(RVA = "0x4D32C60", Offset = "0x4D32C60", VA = "0x4D32C60")]
    private void OnLoadEntity(StoryFreeActionAreaSettingData entity)
    {
    }

    [Token(Token = "0x60067D0")]
    [Address(RVA = "0x4D32DDC", Offset = "0x4D32DDC", VA = "0x4D32DDC")]
    public IReadOnlyList<StoryFreeActionAreaSettingData> GetAreaSettingDataListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x60067D1")]
    [Address(RVA = "0x4D32E98", Offset = "0x4D32E98", VA = "0x4D32E98")]
    public StoryFreeActionAreaSettingData GetAreaSettingData(int label, int areaID)
    {
      return (StoryFreeActionAreaSettingData) null;
    }

    [Token(Token = "0x60067D2")]
    [Address(RVA = "0x4D331BC", Offset = "0x4D331BC", VA = "0x4D331BC")]
    public IReadOnlyCollection<StoryFreeActionAreaSettingData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionAreaSettingData>) null;
    }

    [Token(Token = "0x60067D3")]
    [Address(RVA = "0x4D3320C", Offset = "0x4D3320C", VA = "0x4D3320C")]
    public StoryFreeActionAreaSettingMaster()
    {
    }
  }
}
