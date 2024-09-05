// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopGrowthTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001199")]
  [Serializable]
  public sealed class StoryShopGrowthTypeMaster : BaseMaster<StoryShopGrowthTypeData>
  {
    [Token(Token = "0x60064F9")]
    [Address(RVA = "0x4AF49BC", Offset = "0x4AF49BC", VA = "0x4AF49BC")]
    public IReadOnlyDictionary<int, StoryShopGrowthTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryShopGrowthTypeData>) null;
    }

    [Token(Token = "0x60064FA")]
    [Address(RVA = "0x4AF49C4", Offset = "0x4AF49C4", VA = "0x4AF49C4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064FB")]
    [Address(RVA = "0x4AF4A24", Offset = "0x4AF4A24", VA = "0x4AF4A24", Slot = "5")]
    protected override StoryShopGrowthTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryShopGrowthTypeData) null;
    }

    [Token(Token = "0x60064FC")]
    [Address(RVA = "0x4AF4A7C", Offset = "0x4AF4A7C", VA = "0x4AF4A7C")]
    public StoryShopGrowthTypeMaster()
    {
    }
  }
}
