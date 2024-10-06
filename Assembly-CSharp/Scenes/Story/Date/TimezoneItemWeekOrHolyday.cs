// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimezoneItemWeekOrHolyday
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB5")]
  public class TimezoneItemWeekOrHolyday : MonoBehaviour
  {
    [Token(Token = "0x400C83C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("休日：表記1")]
    private TimezoneItemLocalizeText holyday;
    [Token(Token = "0x400C83D")]
    [FieldOffset(Offset = "0x20")]
    [Header("休日：表記2")]
    [SerializeField]
    private TimezoneItemLocalizeText holydayUnder;
    [Token(Token = "0x400C83E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("平日：表記1")]
    private TimezoneItemLocalizeText weekday;
    [Token(Token = "0x400C83F")]
    [FieldOffset(Offset = "0x30")]
    [Header("平日：表記2")]
    [SerializeField]
    private TimezoneItemLocalizeText weekdayUnder;

    [Token(Token = "0x17003DE3")]
    public TimezoneItemLocalizeText Holyday
    {
      [Token(Token = "0x60123AB"), Address(RVA = "0x4598678", Offset = "0x4598678", VA = "0x4598678")] get
      {
        return (TimezoneItemLocalizeText) null;
      }
    }

    [Token(Token = "0x17003DE4")]
    public TimezoneItemLocalizeText HolydayUnder
    {
      [Token(Token = "0x60123AC"), Address(RVA = "0x4598680", Offset = "0x4598680", VA = "0x4598680")] get
      {
        return (TimezoneItemLocalizeText) null;
      }
    }

    [Token(Token = "0x17003DE5")]
    public TimezoneItemLocalizeText Weekday
    {
      [Token(Token = "0x60123AD"), Address(RVA = "0x4598688", Offset = "0x4598688", VA = "0x4598688")] get
      {
        return (TimezoneItemLocalizeText) null;
      }
    }

    [Token(Token = "0x17003DE6")]
    public TimezoneItemLocalizeText WeekdayUnder
    {
      [Token(Token = "0x60123AE"), Address(RVA = "0x4598690", Offset = "0x4598690", VA = "0x4598690")] get
      {
        return (TimezoneItemLocalizeText) null;
      }
    }

    [Token(Token = "0x60123AF")]
    [Address(RVA = "0x4598698", Offset = "0x4598698", VA = "0x4598698")]
    public TimezoneItemWeekOrHolyday()
    {
    }
  }
}
