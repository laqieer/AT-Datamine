// Decompiled with JetBrains decompiler
// Type: GameCore.Time.GameTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Time
{
  [Token(Token = "0x2000C39")]
  public class GameTime : Singleton<GameTime>
  {
    [Token(Token = "0x17000A27")]
    public DateTime ServerTime
    {
      [Token(Token = "0x6004638"), Address(RVA = "0x3515C4C", Offset = "0x3515C4C", VA = "0x3515C4C")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6004639"), Address(RVA = "0x3515C54", Offset = "0x3515C54", VA = "0x3515C54")] private set
      {
      }
    }

    [Token(Token = "0x17000A28")]
    public float StartTime
    {
      [Token(Token = "0x600463A"), Address(RVA = "0x3515C5C", Offset = "0x3515C5C", VA = "0x3515C5C")] get
      {
        return new float();
      }
      [Token(Token = "0x600463B"), Address(RVA = "0x3515C64", Offset = "0x3515C64", VA = "0x3515C64")] private set
      {
      }
    }

    [Token(Token = "0x17000A29")]
    public DateTime Now
    {
      [Token(Token = "0x600463C"), Address(RVA = "0x3515C6C", Offset = "0x3515C6C", VA = "0x3515C6C")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000A2A")]
    public DateTime DailyUpdateDateTime
    {
      [Token(Token = "0x600463D"), Address(RVA = "0x3515CF8", Offset = "0x3515CF8", VA = "0x3515CF8")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600463E"), Address(RVA = "0x3515D00", Offset = "0x3515D00", VA = "0x3515D00")] private set
      {
      }
    }

    [Token(Token = "0x17000A2B")]
    public TimeSpan DailyUpdateRemainingTimeSpan
    {
      [Token(Token = "0x600463F"), Address(RVA = "0x3515D08", Offset = "0x3515D08", VA = "0x3515D08")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x17000A2C")]
    public DateTime WeeklyUpdateDateTime
    {
      [Token(Token = "0x6004640"), Address(RVA = "0x3515DF8", Offset = "0x3515DF8", VA = "0x3515DF8")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6004641"), Address(RVA = "0x3515E00", Offset = "0x3515E00", VA = "0x3515E00")] private set
      {
      }
    }

    [Token(Token = "0x17000A2D")]
    public TimeSpan WeeklyUpdateRemainingTimeSpan
    {
      [Token(Token = "0x6004642"), Address(RVA = "0x3515E08", Offset = "0x3515E08", VA = "0x3515E08")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x17000A2E")]
    public bool IsDailyUpdateTimeOvered
    {
      [Token(Token = "0x6004643"), Address(RVA = "0x3515EF8", Offset = "0x3515EF8", VA = "0x3515EF8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004644")]
    [Address(RVA = "0x3515F6C", Offset = "0x3515F6C", VA = "0x3515F6C")]
    public void SetServerTime(string serverTime)
    {
    }

    [Token(Token = "0x6004645")]
    [Address(RVA = "0x3515FE4", Offset = "0x3515FE4", VA = "0x3515FE4")]
    public void SetDailyUpdateDateTime(string nextDayStartAt)
    {
    }

    [Token(Token = "0x6004646")]
    [Address(RVA = "0x3516060", Offset = "0x3516060", VA = "0x3516060")]
    public void SetDailyUpdateDateTime(in DateTime dateTime)
    {
    }

    [Token(Token = "0x6004647")]
    [Address(RVA = "0x351606C", Offset = "0x351606C", VA = "0x351606C")]
    public void SetWeeklyUpdateDateTime(string nextWeekStartAt)
    {
    }

    [Token(Token = "0x6004648")]
    [Address(RVA = "0x35160E8", Offset = "0x35160E8", VA = "0x35160E8")]
    public void SetWeeklyUpdateDateTime(in DateTime dateTime)
    {
    }

    [Token(Token = "0x6004649")]
    [Address(RVA = "0x35160F4", Offset = "0x35160F4", VA = "0x35160F4")]
    public GameTime()
    {
    }
  }
}
