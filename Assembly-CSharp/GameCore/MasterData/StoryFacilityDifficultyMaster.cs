// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityDifficultyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200121E")]
  [Serializable]
  public sealed class StoryFacilityDifficultyMaster : BaseMaster<StoryFacilityDifficultyData>
  {
    [Token(Token = "0x40056B5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(int, int), StoryFacilityDifficultyData> groupTable;

    [Token(Token = "0x600673F")]
    [Address(RVA = "0x4D2DA5C", Offset = "0x4D2DA5C", VA = "0x4D2DA5C")]
    public IReadOnlyDictionary<int, StoryFacilityDifficultyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityDifficultyData>) null;
    }

    [Token(Token = "0x6006740")]
    [Address(RVA = "0x4D2DA64", Offset = "0x4D2DA64", VA = "0x4D2DA64", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006741")]
    [Address(RVA = "0x4D2DB1C", Offset = "0x4D2DB1C", VA = "0x4D2DB1C", Slot = "5")]
    protected override StoryFacilityDifficultyData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityDifficultyData) null;
    }

    [Token(Token = "0x6006742")]
    [Address(RVA = "0x4D2DACC", Offset = "0x4D2DACC", VA = "0x4D2DACC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006743")]
    [Address(RVA = "0x4D2DB8C", Offset = "0x4D2DB8C", VA = "0x4D2DB8C")]
    private void OnLoadEntity(StoryFacilityDifficultyData entity)
    {
    }

    [Token(Token = "0x6006744")]
    [Address(RVA = "0x4D2DC24", Offset = "0x4D2DC24", VA = "0x4D2DC24")]
    public StoryFacilityDifficultyData Get(int attachID, int level)
    {
      return (StoryFacilityDifficultyData) null;
    }

    [Token(Token = "0x6006745")]
    [Address(RVA = "0x4D2DCF4", Offset = "0x4D2DCF4", VA = "0x4D2DCF4")]
    public StoryFacilityDifficultyMaster()
    {
    }
  }
}
