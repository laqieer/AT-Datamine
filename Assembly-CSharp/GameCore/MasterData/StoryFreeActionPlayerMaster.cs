// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPlayerMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126F")]
  [Serializable]
  public sealed class StoryFreeActionPlayerMaster : BaseMaster<StoryFreeActionPlayerData>
  {
    [Token(Token = "0x60068D2")]
    [Address(RVA = "0x48C9F50", Offset = "0x48C9F50", VA = "0x48C9F50")]
    public IReadOnlyDictionary<int, StoryFreeActionPlayerData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionPlayerData>) null;
    }

    [Token(Token = "0x60068D3")]
    [Address(RVA = "0x48C9F58", Offset = "0x48C9F58", VA = "0x48C9F58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068D4")]
    [Address(RVA = "0x48C9FB8", Offset = "0x48C9FB8", VA = "0x48C9FB8", Slot = "5")]
    protected override StoryFreeActionPlayerData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionPlayerData) null;
    }

    [Token(Token = "0x60068D5")]
    [Address(RVA = "0x48CA010", Offset = "0x48CA010", VA = "0x48CA010")]
    public IReadOnlyCollection<StoryFreeActionPlayerData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionPlayerData>) null;
    }

    [Token(Token = "0x60068D6")]
    [Address(RVA = "0x48CA060", Offset = "0x48CA060", VA = "0x48CA060")]
    public StoryFreeActionPlayerMaster()
    {
    }
  }
}
