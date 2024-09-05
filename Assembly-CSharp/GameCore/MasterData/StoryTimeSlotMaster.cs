// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTimeSlotMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012FA")]
  [Serializable]
  public sealed class StoryTimeSlotMaster : BaseMaster<StoryTimeSlotData>
  {
    [Token(Token = "0x6006B4F")]
    [Address(RVA = "0x48E1468", Offset = "0x48E1468", VA = "0x48E1468")]
    public IReadOnlyDictionary<int, StoryTimeSlotData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryTimeSlotData>) null;
    }

    [Token(Token = "0x6006B50")]
    [Address(RVA = "0x48E1470", Offset = "0x48E1470", VA = "0x48E1470", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B51")]
    [Address(RVA = "0x48E14D0", Offset = "0x48E14D0", VA = "0x48E14D0", Slot = "5")]
    protected override StoryTimeSlotData LoadEntity(IMasterDataReader reader)
    {
      return (StoryTimeSlotData) null;
    }

    [Token(Token = "0x6006B52")]
    [Address(RVA = "0x48E1528", Offset = "0x48E1528", VA = "0x48E1528")]
    public StoryTimeSlotMaster()
    {
    }
  }
}
