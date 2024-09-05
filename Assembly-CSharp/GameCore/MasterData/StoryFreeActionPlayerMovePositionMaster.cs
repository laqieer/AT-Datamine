// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPlayerMovePositionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126D")]
  [Serializable]
  public sealed class StoryFreeActionPlayerMovePositionMaster : 
    BaseMaster<StoryFreeActionPlayerMovePositionData>
  {
    [Token(Token = "0x60068C5")]
    [Address(RVA = "0x48C9834", Offset = "0x48C9834", VA = "0x48C9834")]
    public IReadOnlyDictionary<int, StoryFreeActionPlayerMovePositionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionPlayerMovePositionData>) null;
    }

    [Token(Token = "0x60068C6")]
    [Address(RVA = "0x48C983C", Offset = "0x48C983C", VA = "0x48C983C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60068C7")]
    [Address(RVA = "0x48C989C", Offset = "0x48C989C", VA = "0x48C989C", Slot = "5")]
    protected override StoryFreeActionPlayerMovePositionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionPlayerMovePositionData) null;
    }

    [Token(Token = "0x60068C8")]
    [Address(RVA = "0x48C98F4", Offset = "0x48C98F4", VA = "0x48C98F4")]
    public IReadOnlyCollection<StoryFreeActionPlayerMovePositionData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionPlayerMovePositionData>) null;
    }

    [Token(Token = "0x60068C9")]
    [Address(RVA = "0x48C9944", Offset = "0x48C9944", VA = "0x48C9944")]
    public StoryFreeActionPlayerMovePositionMaster()
    {
    }
  }
}
