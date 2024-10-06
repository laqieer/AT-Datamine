// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E67")]
  [Serializable]
  public sealed class StoryBattleMissionRewardDescriptionMaster : 
    BaseMaster<StoryBattleMissionRewardDescriptionData>
  {
    [Token(Token = "0x40045AC")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryBattleMissionRewardDescriptionData> groupTable;

    [Token(Token = "0x60057C8")]
    [Address(RVA = "0x3E43AC0", Offset = "0x3E43AC0", VA = "0x3E43AC0")]
    public IReadOnlyDictionary<int, StoryBattleMissionRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBattleMissionRewardDescriptionData>) null;
    }

    [Token(Token = "0x60057C9")]
    [Address(RVA = "0x3E43AC8", Offset = "0x3E43AC8", VA = "0x3E43AC8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057CA")]
    [Address(RVA = "0x3E43C34", Offset = "0x3E43C34", VA = "0x3E43C34", Slot = "5")]
    protected override StoryBattleMissionRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBattleMissionRewardDescriptionData) null;
    }

    [Token(Token = "0x60057CB")]
    [Address(RVA = "0x3E43B30", Offset = "0x3E43B30", VA = "0x3E43B30")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60057CC")]
    [Address(RVA = "0x3E43CA4", Offset = "0x3E43CA4", VA = "0x3E43CA4")]
    private void OnLoadEntity(StoryBattleMissionRewardDescriptionData entity)
    {
    }

    [Token(Token = "0x60057CD")]
    [Address(RVA = "0x3E43CFC", Offset = "0x3E43CFC", VA = "0x3E43CFC")]
    public List<StoryBattleMissionRewardDescriptionData> GetList(int label)
    {
      return (List<StoryBattleMissionRewardDescriptionData>) null;
    }

    [Token(Token = "0x60057CE")]
    [Address(RVA = "0x3E43D54", Offset = "0x3E43D54", VA = "0x3E43D54")]
    public StoryBattleMissionRewardDescriptionMaster()
    {
    }
  }
}
