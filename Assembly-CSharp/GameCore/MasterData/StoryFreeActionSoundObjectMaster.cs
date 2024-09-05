// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionSoundObjectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200127F")]
  [Serializable]
  public sealed class StoryFreeActionSoundObjectMaster : BaseMaster<StoryFreeActionSoundObjectData>
  {
    [Token(Token = "0x6006925")]
    [Address(RVA = "0x48CD38C", Offset = "0x48CD38C", VA = "0x48CD38C")]
    public IReadOnlyDictionary<int, StoryFreeActionSoundObjectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionSoundObjectData>) null;
    }

    [Token(Token = "0x6006926")]
    [Address(RVA = "0x48CD394", Offset = "0x48CD394", VA = "0x48CD394", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006927")]
    [Address(RVA = "0x48CD3F4", Offset = "0x48CD3F4", VA = "0x48CD3F4", Slot = "5")]
    protected override StoryFreeActionSoundObjectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionSoundObjectData) null;
    }

    [Token(Token = "0x6006928")]
    [Address(RVA = "0x48CD44C", Offset = "0x48CD44C", VA = "0x48CD44C")]
    public StoryFreeActionSoundObjectMaster()
    {
    }
  }
}
