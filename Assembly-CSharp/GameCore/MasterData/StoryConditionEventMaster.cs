// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryConditionEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120E")]
  [Serializable]
  public sealed class StoryConditionEventMaster : BaseMaster<StoryConditionEventData>
  {
    [Token(Token = "0x60066FB")]
    [Address(RVA = "0x4D2A808", Offset = "0x4D2A808", VA = "0x4D2A808")]
    public IReadOnlyDictionary<int, StoryConditionEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryConditionEventData>) null;
    }

    [Token(Token = "0x60066FC")]
    [Address(RVA = "0x4D2A810", Offset = "0x4D2A810", VA = "0x4D2A810", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066FD")]
    [Address(RVA = "0x4D2A870", Offset = "0x4D2A870", VA = "0x4D2A870", Slot = "5")]
    protected override StoryConditionEventData LoadEntity(IMasterDataReader reader)
    {
      return (StoryConditionEventData) null;
    }

    [Token(Token = "0x60066FE")]
    [Address(RVA = "0x4D2A8C8", Offset = "0x4D2A8C8", VA = "0x4D2A8C8")]
    public StoryConditionEventMaster()
    {
    }
  }
}
