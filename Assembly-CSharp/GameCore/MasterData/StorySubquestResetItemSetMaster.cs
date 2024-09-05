// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestResetItemSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001309")]
  [Serializable]
  public sealed class StorySubquestResetItemSetMaster : BaseMaster<StorySubquestResetItemSetData>
  {
    [Token(Token = "0x6006B7B")]
    [Address(RVA = "0x48E2C00", Offset = "0x48E2C00", VA = "0x48E2C00")]
    public IReadOnlyDictionary<int, StorySubquestResetItemSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestResetItemSetData>) null;
    }

    [Token(Token = "0x6006B7C")]
    [Address(RVA = "0x48E2C08", Offset = "0x48E2C08", VA = "0x48E2C08", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B7D")]
    [Address(RVA = "0x48E2C68", Offset = "0x48E2C68", VA = "0x48E2C68", Slot = "5")]
    protected override StorySubquestResetItemSetData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestResetItemSetData) null;
    }

    [Token(Token = "0x6006B7E")]
    [Address(RVA = "0x48E2CC0", Offset = "0x48E2CC0", VA = "0x48E2CC0")]
    public StorySubquestResetItemSetMaster()
    {
    }
  }
}
