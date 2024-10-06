// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryDayOfWeekMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012DC")]
  [Serializable]
  public sealed class StoryDayOfWeekMaster : BaseMaster<StoryDayOfWeekData>
  {
    [Token(Token = "0x6006ACE")]
    [Address(RVA = "0x48DCAA0", Offset = "0x48DCAA0", VA = "0x48DCAA0")]
    public IReadOnlyDictionary<int, StoryDayOfWeekData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryDayOfWeekData>) null;
    }

    [Token(Token = "0x6006ACF")]
    [Address(RVA = "0x48DCAA8", Offset = "0x48DCAA8", VA = "0x48DCAA8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AD0")]
    [Address(RVA = "0x48DCB08", Offset = "0x48DCB08", VA = "0x48DCB08", Slot = "5")]
    protected override StoryDayOfWeekData LoadEntity(IMasterDataReader reader)
    {
      return (StoryDayOfWeekData) null;
    }

    [Token(Token = "0x6006AD1")]
    [Address(RVA = "0x48DCB60", Offset = "0x48DCB60", VA = "0x48DCB60")]
    public StoryDayOfWeekMaster()
    {
    }
  }
}
