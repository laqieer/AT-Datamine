// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarHoridayData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001299")]
  [Serializable]
  public sealed class StoryMainQuestCalendarHoridayData : IMasterDataEntity
  {
    [Token(Token = "0x40058BA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058BB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40058BC")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17000FF6")]
    public int Key
    {
      [Token(Token = "0x60069A2"), Address(RVA = "0x48D1D28", Offset = "0x48D1D28", VA = "0x48D1D28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069A3")]
    [Address(RVA = "0x48D1D30", Offset = "0x48D1D30", VA = "0x48D1D30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069A4")]
    [Address(RVA = "0x48D1E3C", Offset = "0x48D1E3C", VA = "0x48D1E3C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FF7")]
    public string HolidayName
    {
      [Token(Token = "0x60069A5"), Address(RVA = "0x48D1EC4", Offset = "0x48D1EC4", VA = "0x48D1EC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60069A6")]
    [Address(RVA = "0x48D1FA0", Offset = "0x48D1FA0", VA = "0x48D1FA0")]
    public StoryMainQuestCalendarHoridayData()
    {
    }
  }
}
