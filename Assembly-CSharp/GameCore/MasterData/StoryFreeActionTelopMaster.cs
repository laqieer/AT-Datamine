// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTelopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128A")]
  [Serializable]
  public sealed class StoryFreeActionTelopMaster : BaseMaster<StoryFreeActionTelopData>
  {
    [Token(Token = "0x6006960")]
    [Address(RVA = "0x48CFC08", Offset = "0x48CFC08", VA = "0x48CFC08")]
    public IReadOnlyDictionary<int, StoryFreeActionTelopData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionTelopData>) null;
    }

    [Token(Token = "0x6006961")]
    [Address(RVA = "0x48CFC10", Offset = "0x48CFC10", VA = "0x48CFC10", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006962")]
    [Address(RVA = "0x48CFC70", Offset = "0x48CFC70", VA = "0x48CFC70", Slot = "5")]
    protected override StoryFreeActionTelopData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionTelopData) null;
    }

    [Token(Token = "0x6006963")]
    [Address(RVA = "0x48CFCC8", Offset = "0x48CFCC8", VA = "0x48CFCC8")]
    public IEnumerable<StoryFreeActionTelopData> GetList()
    {
      return (IEnumerable<StoryFreeActionTelopData>) null;
    }

    [Token(Token = "0x6006964")]
    [Address(RVA = "0x48CFD18", Offset = "0x48CFD18", VA = "0x48CFD18")]
    public StoryFreeActionTelopMaster()
    {
    }
  }
}
