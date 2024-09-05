// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionConditionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001078")]
  [Serializable]
  public sealed class LobbyFreeActionConditionsData : IMasterDataEntity
  {
    [Token(Token = "0x400516B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400516C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400516D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int chapterID;
    [Token(Token = "0x400516E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int timeslotID;
    [Token(Token = "0x400516F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int seasonID;
    [Token(Token = "0x4005170")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int specialConditionID;
    [Token(Token = "0x4005171")]
    public const int ResidentID = 0;

    [Token(Token = "0x17000E39")]
    public int Key
    {
      [Token(Token = "0x6005F82"), Address(RVA = "0x28CE908", Offset = "0x28CE908", VA = "0x28CE908", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F83")]
    [Address(RVA = "0x28CE910", Offset = "0x28CE910", VA = "0x28CE910", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F84")]
    [Address(RVA = "0x28CEB9C", Offset = "0x28CEB9C", VA = "0x28CEB9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F85")]
    [Address(RVA = "0x28CE06C", Offset = "0x28CE06C", VA = "0x28CE06C")]
    public bool IsMatchCondition(int currentChapter, DateTime time, int styleID = 0) => new bool();

    [Token(Token = "0x6005F86")]
    [Address(RVA = "0x28CEC64", Offset = "0x28CEC64", VA = "0x28CEC64")]
    public bool IsMatchChapter(int currentChapterID) => new bool();

    [Token(Token = "0x6005F87")]
    [Address(RVA = "0x28CEC8C", Offset = "0x28CEC8C", VA = "0x28CEC8C")]
    public bool IsMatchSeason(DateTime time) => new bool();

    [Token(Token = "0x6005F88")]
    [Address(RVA = "0x28CEEF8", Offset = "0x28CEEF8", VA = "0x28CEEF8")]
    public bool IsMatchTimeslot(DateTime time) => new bool();

    [Token(Token = "0x6005F89")]
    [Address(RVA = "0x28CF020", Offset = "0x28CF020", VA = "0x28CF020")]
    public bool IsMatchCharacterBirthday(DateTime time, int styleID) => new bool();

    [Token(Token = "0x6005F8A")]
    [Address(RVA = "0x28CF18C", Offset = "0x28CF18C", VA = "0x28CF18C")]
    public LobbyFreeActionConditionsData()
    {
    }
  }
}
