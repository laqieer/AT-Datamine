// Decompiled with JetBrains decompiler
// Type: Scenes.Story.DateDisplayMonthDay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D6E")]
  [Serializable]
  public class DateDisplayMonthDay : IDateDisplayElementCommon
  {
    [Token(Token = "0x400C2E1")]
    [FieldOffset(Offset = "0x10")]
    [Header("切り替える親")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400C2E2")]
    [FieldOffset(Offset = "0x18")]
    [Header("月(10の位)")]
    [SerializeField]
    private Image month10DigitImage;
    [Token(Token = "0x400C2E3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("月(1の位)")]
    private Image month1DigitImage;
    [Token(Token = "0x400C2E4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("日(10の位)")]
    private Image day10DigitImage;
    [Token(Token = "0x400C2E5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("日(1の位)")]
    private Image day1DigitImage;
    [Token(Token = "0x400C2E6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("曜日(EN)")]
    private GameObject[] dayOfWeekEnTextImages;
    [Token(Token = "0x400C2E7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("曜日(繫体字用)")]
    private Text dayOfWeekZH;

    [Token(Token = "0x17003CA2")]
    public GameObject Root
    {
      [Token(Token = "0x6011BFF"), Address(RVA = "0x42BCEDC", Offset = "0x42BCEDC", VA = "0x42BCEDC", Slot = "4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17003CA3")]
    public GameObject[] DayOfWeekEnTextImages
    {
      [Token(Token = "0x6011C00"), Address(RVA = "0x42BCEE4", Offset = "0x42BCEE4", VA = "0x42BCEE4", Slot = "5")] get
      {
        return (GameObject[]) null;
      }
    }

    [Token(Token = "0x17003CA4")]
    public Text DayOfWeekZH
    {
      [Token(Token = "0x6011C01"), Address(RVA = "0x42BCEEC", Offset = "0x42BCEEC", VA = "0x42BCEEC", Slot = "6")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x6011C02")]
    [Address(RVA = "0x42BCEF4", Offset = "0x42BCEF4", VA = "0x42BCEF4")]
    public void SetDayData(int day, SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C03")]
    [Address(RVA = "0x42BCF1C", Offset = "0x42BCF1C", VA = "0x42BCF1C")]
    public void SetMonthData(int month, SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C04")]
    [Address(RVA = "0x42BCF44", Offset = "0x42BCF44", VA = "0x42BCF44")]
    public DateDisplayMonthDay()
    {
    }
  }
}
