// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionCharacterPatternAssignDataMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124C")]
  [Serializable]
  public sealed class StoryFreeActionCharacterPatternAssignDataMaster : 
    BaseMaster<StoryFreeActionCharacterPatternAssignDataData>
  {
    [Token(Token = "0x6006813")]
    [Address(RVA = "0x4D3566C", Offset = "0x4D3566C", VA = "0x4D3566C")]
    public IReadOnlyDictionary<int, StoryFreeActionCharacterPatternAssignDataData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionCharacterPatternAssignDataData>) null;
    }

    [Token(Token = "0x6006814")]
    [Address(RVA = "0x4D35674", Offset = "0x4D35674", VA = "0x4D35674", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006815")]
    [Address(RVA = "0x4D356D4", Offset = "0x4D356D4", VA = "0x4D356D4", Slot = "5")]
    protected override StoryFreeActionCharacterPatternAssignDataData LoadEntity(
      IMasterDataReader reader)
    {
      return (StoryFreeActionCharacterPatternAssignDataData) null;
    }

    [Token(Token = "0x6006816")]
    [Address(RVA = "0x4D3572C", Offset = "0x4D3572C", VA = "0x4D3572C")]
    public StoryFreeActionCharacterPatternAssignDataMaster()
    {
    }
  }
}
