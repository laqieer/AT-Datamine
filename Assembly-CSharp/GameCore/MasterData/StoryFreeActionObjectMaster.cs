// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionObjectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001263")]
  [Serializable]
  public sealed class StoryFreeActionObjectMaster : BaseMaster<StoryFreeActionObjectData>
  {
    [Token(Token = "0x6006892")]
    [Address(RVA = "0x48C827C", Offset = "0x48C827C", VA = "0x48C827C")]
    public IReadOnlyDictionary<int, StoryFreeActionObjectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionObjectData>) null;
    }

    [Token(Token = "0x6006893")]
    [Address(RVA = "0x48C8284", Offset = "0x48C8284", VA = "0x48C8284", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006894")]
    [Address(RVA = "0x48C82E4", Offset = "0x48C82E4", VA = "0x48C82E4", Slot = "5")]
    protected override StoryFreeActionObjectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionObjectData) null;
    }

    [Token(Token = "0x6006895")]
    [Address(RVA = "0x48C833C", Offset = "0x48C833C", VA = "0x48C833C")]
    public StoryFreeActionObjectMaster()
    {
    }
  }
}
