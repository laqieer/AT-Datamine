// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionBackgroundMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001246")]
  [Serializable]
  public sealed class StoryFreeActionBackgroundMaster : BaseMaster<StoryFreeActionBackgroundData>
  {
    [Token(Token = "0x60067F3")]
    [Address(RVA = "0x4D342A0", Offset = "0x4D342A0", VA = "0x4D342A0")]
    public IReadOnlyDictionary<int, StoryFreeActionBackgroundData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionBackgroundData>) null;
    }

    [Token(Token = "0x60067F4")]
    [Address(RVA = "0x4D342A8", Offset = "0x4D342A8", VA = "0x4D342A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60067F5")]
    [Address(RVA = "0x4D34308", Offset = "0x4D34308", VA = "0x4D34308", Slot = "5")]
    protected override StoryFreeActionBackgroundData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionBackgroundData) null;
    }

    [Token(Token = "0x60067F6")]
    [Address(RVA = "0x4D34360", Offset = "0x4D34360", VA = "0x4D34360")]
    public IReadOnlyCollection<StoryFreeActionBackgroundData> GetList()
    {
      return (IReadOnlyCollection<StoryFreeActionBackgroundData>) null;
    }

    [Token(Token = "0x60067F7")]
    [Address(RVA = "0x4D343B0", Offset = "0x4D343B0", VA = "0x4D343B0")]
    public StoryFreeActionBackgroundMaster()
    {
    }
  }
}
