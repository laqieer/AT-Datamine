// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTimeSlotGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F9")]
  [Serializable]
  public sealed class StoryTimeSlotGroupData : IMasterDataEntity
  {
    [Token(Token = "0x40059D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059D5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x40059D6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public StoryTimeSlotTypeEnum timeslotID;

    [Token(Token = "0x17001036")]
    public int Key
    {
      [Token(Token = "0x6006B4B"), Address(RVA = "0x48E1258", Offset = "0x48E1258", VA = "0x48E1258", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B4C")]
    [Address(RVA = "0x48E1260", Offset = "0x48E1260", VA = "0x48E1260", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B4D")]
    [Address(RVA = "0x48E13CC", Offset = "0x48E13CC", VA = "0x48E13CC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B4E")]
    [Address(RVA = "0x48E1460", Offset = "0x48E1460", VA = "0x48E1460")]
    public StoryTimeSlotGroupData()
    {
    }
  }
}
