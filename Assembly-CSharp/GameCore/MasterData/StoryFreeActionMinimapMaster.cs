// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionMinimapMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001261")]
  [Serializable]
  public sealed class StoryFreeActionMinimapMaster : BaseMaster<StoryFreeActionMinimapData>
  {
    [Token(Token = "0x600688A")]
    [Address(RVA = "0x48C7A20", Offset = "0x48C7A20", VA = "0x48C7A20")]
    public IReadOnlyDictionary<int, StoryFreeActionMinimapData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionMinimapData>) null;
    }

    [Token(Token = "0x600688B")]
    [Address(RVA = "0x48C7A28", Offset = "0x48C7A28", VA = "0x48C7A28", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600688C")]
    [Address(RVA = "0x48C7A88", Offset = "0x48C7A88", VA = "0x48C7A88", Slot = "5")]
    protected override StoryFreeActionMinimapData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionMinimapData) null;
    }

    [Token(Token = "0x600688D")]
    [Address(RVA = "0x48C7AE0", Offset = "0x48C7AE0", VA = "0x48C7AE0")]
    public StoryFreeActionMinimapMaster()
    {
    }
  }
}
