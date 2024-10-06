// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionItemTimeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A8C")]
  public class MissionItemTimeView : MonoBehaviour
  {
    [Token(Token = "0x400B515")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MissionItemTimeView.Time _time;
    [Token(Token = "0x400B516")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MissionItemTimeView.Date _date;

    [Token(Token = "0x6010A79")]
    [Address(RVA = "0x4BCD414", Offset = "0x4BCD414", VA = "0x4BCD414")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6010A7A")]
    [Address(RVA = "0x4BCD43C", Offset = "0x4BCD43C", VA = "0x4BCD43C")]
    public void SetTime(in TimeSpan time)
    {
    }

    [Token(Token = "0x6010A7B")]
    [Address(RVA = "0x4BCD83C", Offset = "0x4BCD83C", VA = "0x4BCD83C")]
    public void SetTime(in TimeSpan? time)
    {
    }

    [Token(Token = "0x6010A7C")]
    [Address(RVA = "0x4BCD8C8", Offset = "0x4BCD8C8", VA = "0x4BCD8C8")]
    public void SetTimeIfLessThanDay100(in TimeSpan? time)
    {
    }

    [Token(Token = "0x6010A7D")]
    [Address(RVA = "0x4BCD98C", Offset = "0x4BCD98C", VA = "0x4BCD98C")]
    public MissionItemTimeView()
    {
    }

    [Token(Token = "0x2002A8D")]
    [Serializable]
    public class Time
    {
      [Token(Token = "0x400B517")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject _timeObj;
      [Token(Token = "0x400B518")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextMeshProUGUI _timeHour;
      [Token(Token = "0x400B519")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private TextMeshProUGUI _timeMinute;

      [Token(Token = "0x6010A7E")]
      [Address(RVA = "0x4BCD51C", Offset = "0x4BCD51C", VA = "0x4BCD51C")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x6010A7F")]
      [Address(RVA = "0x4BCD55C", Offset = "0x4BCD55C", VA = "0x4BCD55C")]
      public void SetTime(in TimeSpan time)
      {
      }

      [Token(Token = "0x6010A80")]
      [Address(RVA = "0x4BCD994", Offset = "0x4BCD994", VA = "0x4BCD994")]
      public Time()
      {
      }
    }

    [Token(Token = "0x2002A8E")]
    [Serializable]
    public class Date
    {
      [Token(Token = "0x400B51A")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject _dateObj;
      [Token(Token = "0x400B51B")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextMeshProUGUI _day;

      [Token(Token = "0x6010A81")]
      [Address(RVA = "0x4BCD53C", Offset = "0x4BCD53C", VA = "0x4BCD53C")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x6010A82")]
      [Address(RVA = "0x4BCD6A4", Offset = "0x4BCD6A4", VA = "0x4BCD6A4")]
      public void SetTime(in TimeSpan time)
      {
      }

      [Token(Token = "0x6010A83")]
      [Address(RVA = "0x4BCD99C", Offset = "0x4BCD99C", VA = "0x4BCD99C")]
      public Date()
      {
      }
    }
  }
}
