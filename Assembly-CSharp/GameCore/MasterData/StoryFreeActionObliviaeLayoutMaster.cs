// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionObliviaeLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001266")]
  [Serializable]
  public sealed class StoryFreeActionObliviaeLayoutMaster : 
    BaseMaster<StoryFreeActionObliviaeLayoutData>
  {
    [Token(Token = "0x60068A0")]
    [Address(RVA = "0x48C871C", Offset = "0x48C871C", VA = "0x48C871C")]
    public IReadOnlyDictionary<int, StoryFreeActionObliviaeLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionObliviaeLayoutData>) null;
    }

    [Token(Token = "0x60068A1")]
    [Address(RVA = "0x48C8724", Offset = "0x48C8724", VA = "0x48C8724", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068A2")]
    [Address(RVA = "0x48C8784", Offset = "0x48C8784", VA = "0x48C8784", Slot = "5")]
    protected override StoryFreeActionObliviaeLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionObliviaeLayoutData) null;
    }

    [Token(Token = "0x60068A3")]
    [Address(RVA = "0x48C87DC", Offset = "0x48C87DC", VA = "0x48C87DC")]
    public IEnumerable<StoryFreeActionObliviaeLayoutData> GetList(int layoutLabel)
    {
      return (IEnumerable<StoryFreeActionObliviaeLayoutData>) null;
    }

    [Token(Token = "0x60068A4")]
    [Address(RVA = "0x48C88E4", Offset = "0x48C88E4", VA = "0x48C88E4")]
    public StoryFreeActionObliviaeLayoutMaster()
    {
    }
  }
}
