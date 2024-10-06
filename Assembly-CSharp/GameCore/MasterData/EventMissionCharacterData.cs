// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventMissionCharacterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001115")]
  [Serializable]
  public sealed class EventMissionCharacterData : IMasterDataEntity
  {
    [Token(Token = "0x4005338")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005339")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int eventId;
    [Token(Token = "0x400533A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string style1;
    [Token(Token = "0x400533B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string style2;
    [Token(Token = "0x400533C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string style3;
    [Token(Token = "0x400533D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x400533E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000EAB")]
    public int Key
    {
      [Token(Token = "0x600625B"), Address(RVA = "0x4ADE7C0", Offset = "0x4ADE7C0", VA = "0x4ADE7C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600625C")]
    [Address(RVA = "0x4ADE7C8", Offset = "0x4ADE7C8", VA = "0x4ADE7C8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600625D")]
    [Address(RVA = "0x4ADEAB4", Offset = "0x4ADEAB4", VA = "0x4ADEAB4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600625E")]
    [Address(RVA = "0x4ADEBEC", Offset = "0x4ADEBEC", VA = "0x4ADEBEC")]
    public EventMissionCharacterData()
    {
    }
  }
}
