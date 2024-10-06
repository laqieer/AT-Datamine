// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookTimeSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Story.Common;
using System;
using UI;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DC8")]
  public class PocketBookTimeSkip : MonoBehaviour
  {
    [Token(Token = "0x400C4C4")]
    private const string IMAGE_NUMBER_TEXT = "Img_Date_Num{0}{1}";
    [Token(Token = "0x400C4C5")]
    private const string WEEKLY_IMAGE_NAME = "Img_Date_{0}{1}";
    [Token(Token = "0x400C4C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C4C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WeatherIcon weatherIcon;
    [Token(Token = "0x400C4C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image dayTenDigitImage;
    [Token(Token = "0x400C4C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image dayOneDigitImage;
    [Token(Token = "0x400C4CA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image monthTenDigitImage;
    [Token(Token = "0x400C4CB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image monthOneDigitImage;
    [Token(Token = "0x400C4CC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image slashImage;
    [Token(Token = "0x400C4CD")]
    [FieldOffset(Offset = "0x50")]
    [Header("0:月曜日 ~ 6:日曜日")]
    [SerializeField]
    private Image[] weeklyImages;
    [Token(Token = "0x400C4CE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextAccessor timeZone;
    [Token(Token = "0x400C4CF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PocketBookTimeSkip.NextDateGroup nextTimeZone;

    [Token(Token = "0x17003D27")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011E66"), Address(RVA = "0x3FAB094", Offset = "0x3FAB094", VA = "0x3FAB094")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003D28")]
    public Action OnClickSkipAction
    {
      [Token(Token = "0x6011E67"), Address(RVA = "0x3FAB09C", Offset = "0x3FAB09C", VA = "0x3FAB09C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011E68"), Address(RVA = "0x3FAB0A4", Offset = "0x3FAB0A4", VA = "0x3FAB0A4")] set
      {
      }
    }

    [Token(Token = "0x6011E69")]
    [Address(RVA = "0x3FAB0AC", Offset = "0x3FAB0AC", VA = "0x3FAB0AC")]
    public StoryMainQuestSequenceData GetNextSequenceData(int sequenceId)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x6011E6A")]
    [Address(RVA = "0x3FA2EF4", Offset = "0x3FA2EF4", VA = "0x3FA2EF4")]
    public void SetData(SpriteAtlas spriteAtlas)
    {
    }

    [Token(Token = "0x6011E6B")]
    [Address(RVA = "0x3FAB4E0", Offset = "0x3FAB4E0", VA = "0x3FAB4E0")]
    private void SetDate(SpriteAtlas spriteAtlas, StoryMainQuestCalendarData calendarData)
    {
    }

    [Token(Token = "0x6011E6C")]
    [Address(RVA = "0x3FAB998", Offset = "0x3FAB998", VA = "0x3FAB998")]
    public void OpenSkipPopup()
    {
    }

    [Token(Token = "0x6011E6D")]
    [Address(RVA = "0x3FAB9B4", Offset = "0x3FAB9B4", VA = "0x3FAB9B4")]
    public PocketBookTimeSkip()
    {
    }

    [Token(Token = "0x2002DC9")]
    [Serializable]
    public class NextDateGroup
    {
      [Token(Token = "0x400C4D1")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject group;
      [Token(Token = "0x400C4D2")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextAccessor date;
      [Token(Token = "0x400C4D3")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private TextAccessor timezone;

      [Token(Token = "0x17003D29")]
      public bool IsNull
      {
        [Token(Token = "0x6011E6E"), Address(RVA = "0x3FAB9BC", Offset = "0x3FAB9BC", VA = "0x3FAB9BC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6011E6F")]
      [Address(RVA = "0x3FABA1C", Offset = "0x3FABA1C", VA = "0x3FABA1C")]
      public void SetActive(bool active)
      {
      }

      [Token(Token = "0x6011E70")]
      [Address(RVA = "0x3FAB960", Offset = "0x3FAB960", VA = "0x3FAB960")]
      public void SetDateText(string date)
      {
      }

      [Token(Token = "0x6011E71")]
      [Address(RVA = "0x3FAB97C", Offset = "0x3FAB97C", VA = "0x3FAB97C")]
      public void SetTimezone(string text)
      {
      }

      [Token(Token = "0x6011E72")]
      [Address(RVA = "0x3FABA3C", Offset = "0x3FABA3C", VA = "0x3FABA3C")]
      public NextDateGroup()
      {
      }
    }
  }
}
