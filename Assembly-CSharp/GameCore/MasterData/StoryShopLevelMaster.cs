// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopLevelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200119B")]
  [Serializable]
  public sealed class StoryShopLevelMaster : BaseMaster<StoryShopLevelData>
  {
    [Token(Token = "0x6006501")]
    [Address(RVA = "0x4AF4C68", Offset = "0x4AF4C68", VA = "0x4AF4C68")]
    public IReadOnlyDictionary<int, StoryShopLevelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryShopLevelData>) null;
    }

    [Token(Token = "0x6006502")]
    [Address(RVA = "0x4AF4C70", Offset = "0x4AF4C70", VA = "0x4AF4C70", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006503")]
    [Address(RVA = "0x4AF4CD0", Offset = "0x4AF4CD0", VA = "0x4AF4CD0", Slot = "5")]
    protected override StoryShopLevelData LoadEntity(IMasterDataReader reader)
    {
      return (StoryShopLevelData) null;
    }

    [Token(Token = "0x6006504")]
    [Address(RVA = "0x4AF34D0", Offset = "0x4AF34D0", VA = "0x4AF34D0")]
    public bool UnlockShopLevel(int shopLevelId) => new bool();

    [Token(Token = "0x6006505")]
    [Address(RVA = "0x4AF4D30", Offset = "0x4AF4D30", VA = "0x4AF4D30")]
    public StoryShopLevelMaster()
    {
    }
  }
}
