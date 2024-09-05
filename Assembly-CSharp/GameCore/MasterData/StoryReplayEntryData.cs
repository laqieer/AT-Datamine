// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BF")]
  [Serializable]
  public sealed class StoryReplayEntryData : IMasterDataEntity
  {
    [Token(Token = "0x4005921")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005922")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005923")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyReplay;
    [Token(Token = "0x4005924")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int storyReplayMonthType;
    [Token(Token = "0x4005925")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int dayNumber;
    [Token(Token = "0x4005926")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public DayofweekEnum dayOfWeek;

    [Token(Token = "0x17001011")]
    public int Key
    {
      [Token(Token = "0x6006A59"), Address(RVA = "0x48D8420", Offset = "0x48D8420", VA = "0x48D8420", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A5A")]
    [Address(RVA = "0x48D8428", Offset = "0x48D8428", VA = "0x48D8428", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A5B")]
    [Address(RVA = "0x48D86B4", Offset = "0x48D86B4", VA = "0x48D86B4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A5C")]
    [Address(RVA = "0x48D877C", Offset = "0x48D877C", VA = "0x48D877C")]
    public StoryReplayEntryData()
    {
    }
  }
}
