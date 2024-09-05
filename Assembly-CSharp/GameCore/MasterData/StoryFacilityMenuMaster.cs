// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityMenuMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001224")]
  [Serializable]
  public sealed class StoryFacilityMenuMaster : BaseMaster<StoryFacilityMenuData>
  {
    [Token(Token = "0x40056C5")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x40056C6")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<(int, int), StoryFacilityMenuData> groupTable;
    [Token(Token = "0x40056C7")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<int>> kindNumTable;

    [Token(Token = "0x600675E")]
    [Address(RVA = "0x4D2EAF4", Offset = "0x4D2EAF4", VA = "0x4D2EAF4")]
    public IReadOnlyDictionary<int, StoryFacilityMenuData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityMenuData>) null;
    }

    [Token(Token = "0x600675F")]
    [Address(RVA = "0x4D2EAFC", Offset = "0x4D2EAFC", VA = "0x4D2EAFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006760")]
    [Address(RVA = "0x4D2F074", Offset = "0x4D2F074", VA = "0x4D2F074", Slot = "5")]
    protected override StoryFacilityMenuData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityMenuData) null;
    }

    [Token(Token = "0x6006761")]
    [Address(RVA = "0x4D2EB6C", Offset = "0x4D2EB6C", VA = "0x4D2EB6C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006762")]
    [Address(RVA = "0x4D2F0E4", Offset = "0x4D2F0E4", VA = "0x4D2F0E4")]
    private void OnLoadEntity(StoryFacilityMenuData entity)
    {
    }

    [Token(Token = "0x6006763")]
    [Address(RVA = "0x4D2EC70", Offset = "0x4D2EC70", VA = "0x4D2EC70")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006764")]
    [Address(RVA = "0x4D2F144", Offset = "0x4D2F144", VA = "0x4D2F144")]
    public List<StoryFacilityMenuData> GetList(int attachID, int count)
    {
      return (List<StoryFacilityMenuData>) null;
    }

    [Token(Token = "0x6006765")]
    [Address(RVA = "0x4D2F250", Offset = "0x4D2F250", VA = "0x4D2F250")]
    public StoryFacilityMenuMaster()
    {
    }
  }
}
