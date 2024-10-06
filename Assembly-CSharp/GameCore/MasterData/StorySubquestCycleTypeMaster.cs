// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestCycleTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001303")]
  [Serializable]
  public sealed class StorySubquestCycleTypeMaster : BaseMaster<StorySubquestCycleTypeData>
  {
    [Token(Token = "0x6006B68")]
    [Address(RVA = "0x48E23BC", Offset = "0x48E23BC", VA = "0x48E23BC")]
    public IReadOnlyDictionary<int, StorySubquestCycleTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestCycleTypeData>) null;
    }

    [Token(Token = "0x6006B69")]
    [Address(RVA = "0x48E23C4", Offset = "0x48E23C4", VA = "0x48E23C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B6A")]
    [Address(RVA = "0x48E2424", Offset = "0x48E2424", VA = "0x48E2424", Slot = "5")]
    protected override StorySubquestCycleTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestCycleTypeData) null;
    }

    [Token(Token = "0x6006B6B")]
    [Address(RVA = "0x48E247C", Offset = "0x48E247C", VA = "0x48E247C")]
    public StorySubquestCycleTypeMaster()
    {
    }
  }
}
