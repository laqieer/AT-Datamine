// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityEncountBonusDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001220")]
  [Serializable]
  public sealed class StoryFacilityEncountBonusDetailMaster : 
    BaseMaster<StoryFacilityEncountBonusDetailData>
  {
    [Token(Token = "0x600674A")]
    [Address(RVA = "0x4D2E0E4", Offset = "0x4D2E0E4", VA = "0x4D2E0E4")]
    public IReadOnlyDictionary<int, StoryFacilityEncountBonusDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityEncountBonusDetailData>) null;
    }

    [Token(Token = "0x600674B")]
    [Address(RVA = "0x4D2E0EC", Offset = "0x4D2E0EC", VA = "0x4D2E0EC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600674C")]
    [Address(RVA = "0x4D2E14C", Offset = "0x4D2E14C", VA = "0x4D2E14C", Slot = "5")]
    protected override StoryFacilityEncountBonusDetailData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityEncountBonusDetailData) null;
    }

    [Token(Token = "0x600674D")]
    [Address(RVA = "0x4D2E1A4", Offset = "0x4D2E1A4", VA = "0x4D2E1A4")]
    public StoryFacilityEncountBonusDetailMaster()
    {
    }
  }
}
