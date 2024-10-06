// Decompiled with JetBrains decompiler
// Type: GlobalMenu.RealTimeViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B98")]
  public class RealTimeViewer : MonoBehaviour
  {
    [Token(Token = "0x40034C4")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<DayOfWeek, string> dayOfWeekNames;
    [Token(Token = "0x40034C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI yearText;
    [Token(Token = "0x40034C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI dayText;
    [Token(Token = "0x40034C7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI dayOfWeekText;
    [Token(Token = "0x40034C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI realTime;
    [Token(Token = "0x40034C9")]
    [FieldOffset(Offset = "0x40")]
    private int beforeYear;
    [Token(Token = "0x40034CA")]
    [FieldOffset(Offset = "0x44")]
    private int beforeMonth;
    [Token(Token = "0x40034CB")]
    [FieldOffset(Offset = "0x48")]
    private int beforeDay;
    [Token(Token = "0x40034CC")]
    [FieldOffset(Offset = "0x4C")]
    private int beforeHour;
    [Token(Token = "0x40034CD")]
    [FieldOffset(Offset = "0x50")]
    private int beforeMinute;
    [Token(Token = "0x40034CE")]
    [FieldOffset(Offset = "0x54")]
    private DayOfWeek beforeWeek;

    [Token(Token = "0x6004229")]
    [Address(RVA = "0x2A33B7C", Offset = "0x2A33B7C", VA = "0x2A33B7C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600422A")]
    [Address(RVA = "0x2A3402C", Offset = "0x2A3402C", VA = "0x2A3402C")]
    public void Update()
    {
    }

    [Token(Token = "0x600422B")]
    [Address(RVA = "0x2A33B80", Offset = "0x2A33B80", VA = "0x2A33B80")]
    private void UpdateRealTime()
    {
    }

    [Token(Token = "0x600422C")]
    [Address(RVA = "0x2A34030", Offset = "0x2A34030", VA = "0x2A34030")]
    public RealTimeViewer()
    {
    }
  }
}
