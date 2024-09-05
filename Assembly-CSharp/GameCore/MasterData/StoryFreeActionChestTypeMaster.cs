// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionChestTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001250")]
  [Serializable]
  public sealed class StoryFreeActionChestTypeMaster : BaseMaster<StoryFreeActionChestTypeData>
  {
    [Token(Token = "0x6006827")]
    [Address(RVA = "0x4D36104", Offset = "0x4D36104", VA = "0x4D36104")]
    public IReadOnlyDictionary<int, StoryFreeActionChestTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionChestTypeData>) null;
    }

    [Token(Token = "0x6006828")]
    [Address(RVA = "0x4D3610C", Offset = "0x4D3610C", VA = "0x4D3610C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006829")]
    [Address(RVA = "0x4D3616C", Offset = "0x4D3616C", VA = "0x4D3616C", Slot = "5")]
    protected override StoryFreeActionChestTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionChestTypeData) null;
    }

    [Token(Token = "0x600682A")]
    [Address(RVA = "0x4D361C4", Offset = "0x4D361C4", VA = "0x4D361C4")]
    public StoryFreeActionChestTypeMaster()
    {
    }
  }
}
