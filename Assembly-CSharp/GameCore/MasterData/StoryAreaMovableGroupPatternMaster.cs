// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableGroupPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011CB")]
  [Serializable]
  public sealed class StoryAreaMovableGroupPatternMaster : 
    BaseMaster<StoryAreaMovableGroupPatternData>
  {
    [Token(Token = "0x60065D3")]
    [Address(RVA = "0x4D1F5B0", Offset = "0x4D1F5B0", VA = "0x4D1F5B0")]
    public IReadOnlyDictionary<int, StoryAreaMovableGroupPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableGroupPatternData>) null;
    }

    [Token(Token = "0x60065D4")]
    [Address(RVA = "0x4D1F5B8", Offset = "0x4D1F5B8", VA = "0x4D1F5B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065D5")]
    [Address(RVA = "0x4D1F618", Offset = "0x4D1F618", VA = "0x4D1F618", Slot = "5")]
    protected override StoryAreaMovableGroupPatternData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableGroupPatternData) null;
    }

    [Token(Token = "0x60065D6")]
    [Address(RVA = "0x4D1F670", Offset = "0x4D1F670", VA = "0x4D1F670")]
    public StoryAreaMovableGroupPatternMaster()
    {
    }
  }
}
