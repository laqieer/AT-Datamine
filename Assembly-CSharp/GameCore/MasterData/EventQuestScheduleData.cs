// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventQuestScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001117")]
  [Serializable]
  public sealed class EventQuestScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x400533F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005340")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string text;
    [Token(Token = "0x4005341")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4005342")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000EAC")]
    public int Key
    {
      [Token(Token = "0x6006263"), Address(RVA = "0x4ADECFC", Offset = "0x4ADECFC", VA = "0x4ADECFC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006264")]
    [Address(RVA = "0x4ADED04", Offset = "0x4ADED04", VA = "0x4ADED04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006265")]
    [Address(RVA = "0x4ADEED0", Offset = "0x4ADEED0", VA = "0x4ADEED0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006266")]
    [Address(RVA = "0x4ADEFD0", Offset = "0x4ADEFD0", VA = "0x4ADEFD0")]
    public EventQuestScheduleData()
    {
    }
  }
}
