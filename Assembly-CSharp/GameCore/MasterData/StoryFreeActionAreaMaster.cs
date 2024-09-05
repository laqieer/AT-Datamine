// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001244")]
  [Serializable]
  public sealed class StoryFreeActionAreaMaster : BaseMaster<StoryFreeActionAreaData>
  {
    [Token(Token = "0x400576E")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x400576F")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionAreaData>> regions;

    [Token(Token = "0x60067E7")]
    [Address(RVA = "0x4D33A58", Offset = "0x4D33A58", VA = "0x4D33A58")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaData>) null;
    }

    [Token(Token = "0x60067E8")]
    [Address(RVA = "0x4D33A60", Offset = "0x4D33A60", VA = "0x4D33A60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067E9")]
    [Address(RVA = "0x4D33AC0", Offset = "0x4D33AC0", VA = "0x4D33AC0", Slot = "5")]
    protected override StoryFreeActionAreaData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaData) null;
    }

    [Token(Token = "0x60067EA")]
    [Address(RVA = "0x4D33B30", Offset = "0x4D33B30", VA = "0x4D33B30")]
    private void OnLoadEntity(StoryFreeActionAreaData entity)
    {
    }

    [Token(Token = "0x60067EB")]
    [Address(RVA = "0x4D33CAC", Offset = "0x4D33CAC", VA = "0x4D33CAC")]
    public IReadOnlyCollection<StoryFreeActionAreaData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionAreaData>) null;
    }

    [Token(Token = "0x60067EC")]
    [Address(RVA = "0x4D33CFC", Offset = "0x4D33CFC", VA = "0x4D33CFC")]
    public IEnumerable<StoryFreeActionAreaData> GetAreasInRegion(int region)
    {
      return (IEnumerable<StoryFreeActionAreaData>) null;
    }

    [Token(Token = "0x60067ED")]
    [Address(RVA = "0x4D33DD0", Offset = "0x4D33DD0", VA = "0x4D33DD0")]
    public StoryFreeActionAreaMaster()
    {
    }
  }
}
