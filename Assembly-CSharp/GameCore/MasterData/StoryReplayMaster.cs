// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C2")]
  [Serializable]
  public sealed class StoryReplayMaster : BaseMaster<StoryReplayData>
  {
    [Token(Token = "0x6006A65")]
    [Address(RVA = "0x48D8A9C", Offset = "0x48D8A9C", VA = "0x48D8A9C")]
    public IReadOnlyDictionary<int, StoryReplayData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryReplayData>) null;
    }

    [Token(Token = "0x6006A66")]
    [Address(RVA = "0x48D8AA4", Offset = "0x48D8AA4", VA = "0x48D8AA4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A67")]
    [Address(RVA = "0x48D8B04", Offset = "0x48D8B04", VA = "0x48D8B04", Slot = "5")]
    protected override StoryReplayData LoadEntity(IMasterDataReader reader)
    {
      return (StoryReplayData) null;
    }

    [Token(Token = "0x6006A68")]
    [Address(RVA = "0x48D8B5C", Offset = "0x48D8B5C", VA = "0x48D8B5C")]
    public StoryReplayMaster()
    {
    }
  }
}
