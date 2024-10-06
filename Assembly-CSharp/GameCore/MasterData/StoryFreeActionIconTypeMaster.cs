// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionIconTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200125B")]
  [Serializable]
  public sealed class StoryFreeActionIconTypeMaster : BaseMaster<StoryFreeActionIconTypeData>
  {
    [Token(Token = "0x6006861")]
    [Address(RVA = "0x4D38628", Offset = "0x4D38628", VA = "0x4D38628")]
    public IReadOnlyDictionary<int, StoryFreeActionIconTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionIconTypeData>) null;
    }

    [Token(Token = "0x6006862")]
    [Address(RVA = "0x4D38630", Offset = "0x4D38630", VA = "0x4D38630", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006863")]
    [Address(RVA = "0x4D38690", Offset = "0x4D38690", VA = "0x4D38690", Slot = "5")]
    protected override StoryFreeActionIconTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionIconTypeData) null;
    }

    [Token(Token = "0x6006864")]
    [Address(RVA = "0x4D386E8", Offset = "0x4D386E8", VA = "0x4D386E8")]
    public StoryFreeActionIconTypeMaster()
    {
    }
  }
}
