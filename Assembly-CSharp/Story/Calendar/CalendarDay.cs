// Decompiled with JetBrains decompiler
// Type: Story.Calendar.CalendarDay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x2000726")]
  public class CalendarDay : MonoBehaviour
  {
    [Token(Token = "0x4002136")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI txtDay;
    [Token(Token = "0x4002137")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI txtNum;
    [Token(Token = "0x4002138")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup weatherTweenGroup;
    [Token(Token = "0x4002139")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CanvasGroup weatherGanvasGroup;
    [Token(Token = "0x400213A")]
    [FieldOffset(Offset = "0x38")]
    private string[] WEATHER_TWEEN_NAME;
    [Token(Token = "0x400213B")]
    private const string SATDAY_COLOR_CODE = "#0FE1FF";
    [Token(Token = "0x400213C")]
    private const string SUNDAY_COLOR_CODE = "#FF5048";
    [Token(Token = "0x400213D")]
    [FieldOffset(Offset = "0x40")]
    private readonly (int START, int END) DISPLAY_WEEK_TEXT_LENGTH;

    [Token(Token = "0x6002846")]
    [Address(RVA = "0x3674CBC", Offset = "0x3674CBC", VA = "0x3674CBC")]
    public void ShowDayWeek(DayofweekEnum dayWeek, int num, bool isHoliday = false)
    {
    }

    [Token(Token = "0x6002847")]
    [Address(RVA = "0x3674E84", Offset = "0x3674E84", VA = "0x3674E84")]
    public void ShowDay(int num)
    {
    }

    [Token(Token = "0x6002848")]
    [Address(RVA = "0x3674F64", Offset = "0x3674F64", VA = "0x3674F64")]
    public void Hide()
    {
    }

    [Token(Token = "0x6002849")]
    [Address(RVA = "0x3674F88", Offset = "0x3674F88", VA = "0x3674F88")]
    public void ShowWeather(bool sw)
    {
    }

    [Token(Token = "0x600284A")]
    [Address(RVA = "0x3674FB8", Offset = "0x3674FB8", VA = "0x3674FB8")]
    public void ImmediateWheather()
    {
    }

    [Token(Token = "0x600284B")]
    [Address(RVA = "0x3674FEC", Offset = "0x3674FEC", VA = "0x3674FEC")]
    public void PlayWeather(StoryWeatherTypeEnum weather, bool inAnim = true)
    {
    }

    [Token(Token = "0x600284C")]
    [Address(RVA = "0x3674DEC", Offset = "0x3674DEC", VA = "0x3674DEC")]
    private static Color GetColor(DayofweekEnum dayofweekEnum, bool isHoliday) => new Color();

    [Token(Token = "0x600284D")]
    [Address(RVA = "0x367507C", Offset = "0x367507C", VA = "0x367507C")]
    public CalendarDay()
    {
    }
  }
}
