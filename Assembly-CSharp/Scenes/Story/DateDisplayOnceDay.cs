// Decompiled with JetBrains decompiler
// Type: Scenes.Story.DateDisplayOnceDay
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
  [Token(Token = "0x2002D6F")]
  [Serializable]
  public class DateDisplayOnceDay : IDateDisplayElementCommon
  {
    [Token(Token = "0x400C2E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("切り替える親")]
    private GameObject root;
    [Token(Token = "0x400C2E9")]
    [FieldOffset(Offset = "0x18")]
    [Header("10の位")]
    [SerializeField]
    private Image digit10Image;
    [Token(Token = "0x400C2EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("1の位")]
    private Image digit1Image;
    [Token(Token = "0x400C2EB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("曜日(EN)")]
    private GameObject[] dayOfWeekEnTextImages;
    [Token(Token = "0x400C2EC")]
    [FieldOffset(Offset = "0x30")]
    [Header("曜日(繫体字用)")]
    [SerializeField]
    private Text dayOfWeekZH;

    [Token(Token = "0x17003CA5")]
    public GameObject Root
    {
      [Token(Token = "0x6011C05"), Address(RVA = "0x42BCF4C", Offset = "0x42BCF4C", VA = "0x42BCF4C", Slot = "4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17003CA6")]
    public GameObject[] DayOfWeekEnTextImages
    {
      [Token(Token = "0x6011C06"), Address(RVA = "0x42BCF54", Offset = "0x42BCF54", VA = "0x42BCF54", Slot = "5")] get
      {
        return (GameObject[]) null;
      }
    }

    [Token(Token = "0x17003CA7")]
    public Text DayOfWeekZH
    {
      [Token(Token = "0x6011C07"), Address(RVA = "0x42BCF5C", Offset = "0x42BCF5C", VA = "0x42BCF5C", Slot = "6")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x6011C08")]
    [Address(RVA = "0x42BCF64", Offset = "0x42BCF64", VA = "0x42BCF64")]
    public void SetDay(int day, SpriteAtlas calendarAtlas)
    {
    }

    [Token(Token = "0x6011C09")]
    [Address(RVA = "0x42BCF8C", Offset = "0x42BCF8C", VA = "0x42BCF8C")]
    public DateDisplayOnceDay()
    {
    }
  }
}
