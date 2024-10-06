// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127B")]
  [Serializable]
  public sealed class StoryFreeActionSettingMaster : BaseMaster<StoryFreeActionSettingData>
  {
    [Token(Token = "0x6006911")]
    [Address(RVA = "0x48CC154", Offset = "0x48CC154", VA = "0x48CC154")]
    public IReadOnlyDictionary<int, StoryFreeActionSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionSettingData>) null;
    }

    [Token(Token = "0x6006912")]
    [Address(RVA = "0x48CC15C", Offset = "0x48CC15C", VA = "0x48CC15C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006913")]
    [Address(RVA = "0x48CC1BC", Offset = "0x48CC1BC", VA = "0x48CC1BC", Slot = "5")]
    protected override StoryFreeActionSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionSettingData) null;
    }

    [Token(Token = "0x6006914")]
    [Address(RVA = "0x48CC214", Offset = "0x48CC214", VA = "0x48CC214")]
    public IReadOnlyCollection<StoryFreeActionSettingData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionSettingData>) null;
    }

    [Token(Token = "0x6006915")]
    [Address(RVA = "0x48CC264", Offset = "0x48CC264", VA = "0x48CC264")]
    public StoryFreeActionSettingMaster()
    {
    }
  }
}
