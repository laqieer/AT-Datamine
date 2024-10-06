// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaRegionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001240")]
  [Serializable]
  public sealed class StoryFreeActionAreaRegionMaster : BaseMaster<StoryFreeActionAreaRegionData>
  {
    [Token(Token = "0x400575E")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x60067C2")]
    [Address(RVA = "0x4D3272C", Offset = "0x4D3272C", VA = "0x4D3272C")]
    public IReadOnlyDictionary<int, StoryFreeActionAreaRegionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionAreaRegionData>) null;
    }

    [Token(Token = "0x60067C3")]
    [Address(RVA = "0x4D32734", Offset = "0x4D32734", VA = "0x4D32734", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067C4")]
    [Address(RVA = "0x4D32794", Offset = "0x4D32794", VA = "0x4D32794", Slot = "5")]
    protected override StoryFreeActionAreaRegionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionAreaRegionData) null;
    }

    [Token(Token = "0x60067C5")]
    [Address(RVA = "0x4D327EC", Offset = "0x4D327EC", VA = "0x4D327EC")]
    public StoryFreeActionAreaRegionMaster()
    {
    }
  }
}
