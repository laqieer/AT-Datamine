// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventMissionCharacterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001114")]
  [Serializable]
  public sealed class EventMissionCharacterMaster : BaseMaster<EventMissionCharacterData>
  {
    [Token(Token = "0x6006257")]
    [Address(RVA = "0x4ADE6B8", Offset = "0x4ADE6B8", VA = "0x4ADE6B8")]
    public IReadOnlyDictionary<int, EventMissionCharacterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EventMissionCharacterData>) null;
    }

    [Token(Token = "0x6006258")]
    [Address(RVA = "0x4ADE6C0", Offset = "0x4ADE6C0", VA = "0x4ADE6C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006259")]
    [Address(RVA = "0x4ADE720", Offset = "0x4ADE720", VA = "0x4ADE720", Slot = "5")]
    protected override EventMissionCharacterData LoadEntity(IMasterDataReader reader)
    {
      return (EventMissionCharacterData) null;
    }

    [Token(Token = "0x600625A")]
    [Address(RVA = "0x4ADE778", Offset = "0x4ADE778", VA = "0x4ADE778")]
    public EventMissionCharacterMaster()
    {
    }
  }
}
