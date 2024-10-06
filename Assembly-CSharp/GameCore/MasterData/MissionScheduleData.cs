// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A4")]
  [Serializable]
  public sealed class MissionScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x4005201")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005202")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005203")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime start;
    [Token(Token = "0x4005204")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime end;

    [Token(Token = "0x17000E5A")]
    public int Key
    {
      [Token(Token = "0x6006053"), Address(RVA = "0x28D6440", Offset = "0x28D6440", VA = "0x28D6440", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006054")]
    [Address(RVA = "0x28D6448", Offset = "0x28D6448", VA = "0x28D6448", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006055")]
    [Address(RVA = "0x28D6614", Offset = "0x28D6614", VA = "0x28D6614", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006056")]
    [Address(RVA = "0x28D6714", Offset = "0x28D6714", VA = "0x28D6714")]
    public bool IsInSchedule(in DateTime time) => new bool();

    [Token(Token = "0x6006057")]
    [Address(RVA = "0x28D67C4", Offset = "0x28D67C4", VA = "0x28D67C4")]
    public MissionScheduleData()
    {
    }
  }
}
