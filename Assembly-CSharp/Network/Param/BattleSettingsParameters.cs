// Decompiled with JetBrains decompiler
// Type: Network.Param.BattleSettingsParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A45")]
  [Serializable]
  public class BattleSettingsParameters : IBattleSettingsParameters
  {
    [Token(Token = "0x4007055")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool is_auto_setting;
    [Token(Token = "0x4007056")]
    [FieldOffset(Offset = "0x11")]
    [SerializeField]
    private bool is_skip_arrange;
    [Token(Token = "0x4007057")]
    [FieldOffset(Offset = "0x12")]
    [SerializeField]
    private bool speed;
    [Token(Token = "0x4007058")]
    [FieldOffset(Offset = "0x13")]
    [SerializeField]
    private bool duel;
    [Token(Token = "0x4007059")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool grid;

    [Token(Token = "0x1700188B")]
    public bool IsAutoSetting
    {
      [Token(Token = "0x60095F1"), Address(RVA = "0x48EEDB0", Offset = "0x48EEDB0", VA = "0x48EEDB0", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095F2"), Address(RVA = "0x48EEDB8", Offset = "0x48EEDB8", VA = "0x48EEDB8", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x1700188C")]
    public bool IsSkipArrange
    {
      [Token(Token = "0x60095F3"), Address(RVA = "0x48EEDC4", Offset = "0x48EEDC4", VA = "0x48EEDC4", Slot = "6")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095F4"), Address(RVA = "0x48EEDCC", Offset = "0x48EEDCC", VA = "0x48EEDCC", Slot = "7")] set
      {
      }
    }

    [Token(Token = "0x1700188D")]
    public bool Speed
    {
      [Token(Token = "0x60095F5"), Address(RVA = "0x48EEDD8", Offset = "0x48EEDD8", VA = "0x48EEDD8", Slot = "8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095F6"), Address(RVA = "0x48EEDE0", Offset = "0x48EEDE0", VA = "0x48EEDE0", Slot = "9")] set
      {
      }
    }

    [Token(Token = "0x1700188E")]
    public bool Duel
    {
      [Token(Token = "0x60095F7"), Address(RVA = "0x48EEDEC", Offset = "0x48EEDEC", VA = "0x48EEDEC", Slot = "10")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095F8"), Address(RVA = "0x48EEDF4", Offset = "0x48EEDF4", VA = "0x48EEDF4", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x1700188F")]
    public bool Grid
    {
      [Token(Token = "0x60095F9"), Address(RVA = "0x48EEE00", Offset = "0x48EEE00", VA = "0x48EEE00", Slot = "12")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095FA"), Address(RVA = "0x48EEE08", Offset = "0x48EEE08", VA = "0x48EEE08", Slot = "13")] set
      {
      }
    }

    [Token(Token = "0x60095FB")]
    [Address(RVA = "0x48EEE14", Offset = "0x48EEE14", VA = "0x48EEE14")]
    public BattleSettingsParameters()
    {
    }
  }
}
