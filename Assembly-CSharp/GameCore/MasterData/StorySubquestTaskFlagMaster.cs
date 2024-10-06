// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestTaskFlagMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001316")]
  [Serializable]
  public sealed class StorySubquestTaskFlagMaster : BaseMaster<StorySubquestTaskFlagData>
  {
    [Token(Token = "0x6006BCF")]
    [Address(RVA = "0x48E5D58", Offset = "0x48E5D58", VA = "0x48E5D58")]
    public IReadOnlyDictionary<int, StorySubquestTaskFlagData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestTaskFlagData>) null;
    }

    [Token(Token = "0x6006BD0")]
    [Address(RVA = "0x48E5D60", Offset = "0x48E5D60", VA = "0x48E5D60", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006BD1")]
    [Address(RVA = "0x48E5DC0", Offset = "0x48E5DC0", VA = "0x48E5DC0", Slot = "5")]
    protected override StorySubquestTaskFlagData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestTaskFlagData) null;
    }

    [Token(Token = "0x6006BD2")]
    [Address(RVA = "0x48E5E18", Offset = "0x48E5E18", VA = "0x48E5E18")]
    public StorySubquestTaskFlagMaster()
    {
    }
  }
}
