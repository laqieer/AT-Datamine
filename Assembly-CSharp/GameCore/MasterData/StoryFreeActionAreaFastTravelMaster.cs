// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaFastTravelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123A")]
  [Serializable]
  public sealed class StoryFreeActionAreaFastTravelMaster : 
    BaseMaster<StoryFreeActionAreaFastTravelData>
  {
    [Token(Token = "0x4005745")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x60067A3")]
    [Address(RVA = "0x4D31354", Offset = "0x4D31354", VA = "0x4D31354")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaFastTravelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaFastTravelData>) null;
    }

    [Token(Token = "0x60067A4")]
    [Address(RVA = "0x4D3135C", Offset = "0x4D3135C", VA = "0x4D3135C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067A5")]
    [Address(RVA = "0x4D313BC", Offset = "0x4D313BC", VA = "0x4D313BC", Slot = "5")]
    protected override StoryFreeActionAreaFastTravelData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaFastTravelData) null;
    }

    [Token(Token = "0x60067A6")]
    [Address(RVA = "0x4D31414", Offset = "0x4D31414", VA = "0x4D31414")]
    public StoryFreeActionAreaFastTravelMaster()
    {
    }
  }
}
