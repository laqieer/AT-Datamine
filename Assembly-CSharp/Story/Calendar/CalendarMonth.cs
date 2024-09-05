// Decompiled with JetBrains decompiler
// Type: Story.Calendar.CalendarMonth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x2000727")]
  public class CalendarMonth : MonoBehaviour
  {
    [Token(Token = "0x400213E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI txtMonth;
    [Token(Token = "0x400213F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI txtNum;
    [Token(Token = "0x4002140")]
    [FieldOffset(Offset = "0x28")]
    private readonly (int START, int END) MONTH_DISPLAY_LENGTH;

    [Token(Token = "0x600284E")]
    [Address(RVA = "0x367526C", Offset = "0x367526C", VA = "0x367526C")]
    public void SetMonth(int month)
    {
    }

    [Token(Token = "0x600284F")]
    [Address(RVA = "0x3675348", Offset = "0x3675348", VA = "0x3675348")]
    public void Off()
    {
    }

    [Token(Token = "0x6002850")]
    [Address(RVA = "0x367536C", Offset = "0x367536C", VA = "0x367536C")]
    public CalendarMonth()
    {
    }
  }
}
