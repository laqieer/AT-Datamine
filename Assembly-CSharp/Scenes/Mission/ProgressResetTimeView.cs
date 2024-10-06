// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.ProgressResetTimeView
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
  [Token(Token = "0x2002AAE")]
  [Serializable]
  public class ProgressResetTimeView
  {
    [Token(Token = "0x400B59B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TextMeshProUGUI _dailyResetTimeHour;
    [Token(Token = "0x400B59C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _remainingTimeHour;
    [Token(Token = "0x400B59D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI _remainingTimeMin;

    [Token(Token = "0x6010B1B")]
    [Address(RVA = "0x4BD2EF8", Offset = "0x4BD2EF8", VA = "0x4BD2EF8")]
    public void SetResetTime(in TimeSpan time)
    {
    }

    [Token(Token = "0x6010B1C")]
    [Address(RVA = "0x4BD2D30", Offset = "0x4BD2D30", VA = "0x4BD2D30")]
    public void SetResetTime(int hour)
    {
    }

    [Token(Token = "0x6010B1D")]
    [Address(RVA = "0x4BD2D90", Offset = "0x4BD2D90", VA = "0x4BD2D90")]
    public void SetRemainingTime(in TimeSpan time)
    {
    }

    [Token(Token = "0x6010B1E")]
    [Address(RVA = "0x4BD2F74", Offset = "0x4BD2F74", VA = "0x4BD2F74")]
    public ProgressResetTimeView()
    {
    }
  }
}
