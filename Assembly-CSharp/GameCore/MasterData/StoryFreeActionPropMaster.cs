// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPropMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001271")]
  [Serializable]
  public sealed class StoryFreeActionPropMaster : BaseMaster<StoryFreeActionPropData>
  {
    [Token(Token = "0x60068DB")]
    [Address(RVA = "0x48CA2BC", Offset = "0x48CA2BC", VA = "0x48CA2BC")]
    public IReadOnlyDictionary<int, StoryFreeActionPropData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionPropData>) null;
    }

    [Token(Token = "0x60068DC")]
    [Address(RVA = "0x48CA2C4", Offset = "0x48CA2C4", VA = "0x48CA2C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068DD")]
    [Address(RVA = "0x48CA324", Offset = "0x48CA324", VA = "0x48CA324", Slot = "5")]
    protected override StoryFreeActionPropData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionPropData) null;
    }

    [Token(Token = "0x60068DE")]
    [Address(RVA = "0x48CA37C", Offset = "0x48CA37C", VA = "0x48CA37C")]
    public IEnumerable<StoryFreeActionPropData> GetList()
    {
      return (IEnumerable<StoryFreeActionPropData>) null;
    }

    [Token(Token = "0x60068DF")]
    [Address(RVA = "0x48CA3CC", Offset = "0x48CA3CC", VA = "0x48CA3CC")]
    public StoryFreeActionPropMaster()
    {
    }
  }
}
