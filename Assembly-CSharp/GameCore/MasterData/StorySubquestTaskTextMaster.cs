// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskTextMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200131B")]
  [Serializable]
  public sealed class StorySubquestTaskTextMaster : BaseMaster<StorySubquestTaskTextData>
  {
    [Token(Token = "0x4005A5F")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006BEC")]
    [Address(RVA = "0x48E711C", Offset = "0x48E711C", VA = "0x48E711C")]
    public IReadOnlyDictionary<int, StorySubquestTaskTextData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestTaskTextData>) null;
    }

    [Token(Token = "0x6006BED")]
    [Address(RVA = "0x48E7124", Offset = "0x48E7124", VA = "0x48E7124", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BEE")]
    [Address(RVA = "0x48E7184", Offset = "0x48E7184", VA = "0x48E7184", Slot = "5")]
    protected override StorySubquestTaskTextData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestTaskTextData) null;
    }

    [Token(Token = "0x6006BEF")]
    [Address(RVA = "0x48E71DC", Offset = "0x48E71DC", VA = "0x48E71DC")]
    public StorySubquestTaskTextMaster()
    {
    }
  }
}
