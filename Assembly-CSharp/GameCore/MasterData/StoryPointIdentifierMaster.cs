// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryPointIdentifierMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012ED")]
  [Serializable]
  public sealed class StoryPointIdentifierMaster : BaseMaster<StoryPointIdentifierData>
  {
    [Token(Token = "0x6006B14")]
    [Address(RVA = "0x48DEE3C", Offset = "0x48DEE3C", VA = "0x48DEE3C")]
    public IReadOnlyDictionary<int, StoryPointIdentifierData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryPointIdentifierData>) null;
    }

    [Token(Token = "0x6006B15")]
    [Address(RVA = "0x48DEE44", Offset = "0x48DEE44", VA = "0x48DEE44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B16")]
    [Address(RVA = "0x48DEEA4", Offset = "0x48DEEA4", VA = "0x48DEEA4", Slot = "5")]
    protected override StoryPointIdentifierData LoadEntity(IMasterDataReader reader)
    {
      return (StoryPointIdentifierData) null;
    }

    [Token(Token = "0x6006B17")]
    [Address(RVA = "0x48DEEFC", Offset = "0x48DEEFC", VA = "0x48DEEFC")]
    public StoryPointIdentifierMaster()
    {
    }
  }
}
