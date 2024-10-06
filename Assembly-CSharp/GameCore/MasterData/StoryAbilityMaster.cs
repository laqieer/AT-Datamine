// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAbilityMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C6")]
  [Serializable]
  public sealed class StoryAbilityMaster : BaseMaster<StoryAbilityData>
  {
    [Token(Token = "0x60065BA")]
    [Address(RVA = "0x4D1E6AC", Offset = "0x4D1E6AC", VA = "0x4D1E6AC")]
    public IReadOnlyDictionary<int, StoryAbilityData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAbilityData>) null;
    }

    [Token(Token = "0x60065BB")]
    [Address(RVA = "0x4D1E6B4", Offset = "0x4D1E6B4", VA = "0x4D1E6B4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065BC")]
    [Address(RVA = "0x4D1E714", Offset = "0x4D1E714", VA = "0x4D1E714", Slot = "5")]
    protected override StoryAbilityData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAbilityData) null;
    }

    [Token(Token = "0x60065BD")]
    [Address(RVA = "0x4D1E76C", Offset = "0x4D1E76C", VA = "0x4D1E76C")]
    public IEnumerable<StoryAbilityData> GetList() => (IEnumerable<StoryAbilityData>) null;

    [Token(Token = "0x60065BE")]
    [Address(RVA = "0x4D1E7BC", Offset = "0x4D1E7BC", VA = "0x4D1E7BC")]
    public StoryAbilityMaster()
    {
    }
  }
}
