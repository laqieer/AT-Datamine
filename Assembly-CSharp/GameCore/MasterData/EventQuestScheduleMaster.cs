// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventQuestScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001116")]
  [Serializable]
  public sealed class EventQuestScheduleMaster : BaseMaster<EventQuestScheduleData>
  {
    [Token(Token = "0x600625F")]
    [Address(RVA = "0x4ADEBF4", Offset = "0x4ADEBF4", VA = "0x4ADEBF4")]
    public IReadOnlyDictionary<int, EventQuestScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EventQuestScheduleData>) null;
    }

    [Token(Token = "0x6006260")]
    [Address(RVA = "0x4ADEBFC", Offset = "0x4ADEBFC", VA = "0x4ADEBFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006261")]
    [Address(RVA = "0x4ADEC5C", Offset = "0x4ADEC5C", VA = "0x4ADEC5C", Slot = "5")]
    protected override EventQuestScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (EventQuestScheduleData) null;
    }

    [Token(Token = "0x6006262")]
    [Address(RVA = "0x4ADECB4", Offset = "0x4ADECB4", VA = "0x4ADECB4")]
    public EventQuestScheduleMaster()
    {
    }
  }
}
