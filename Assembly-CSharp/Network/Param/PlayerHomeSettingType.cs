// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerHomeSettingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC4")]
  [Serializable]
  public class PlayerHomeSettingType
  {
    [Token(Token = "0x40072B5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int slot_1_style_id;
    [Token(Token = "0x40072B6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int slot_2_style_id;
    [Token(Token = "0x40072B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int slot_3_style_id;
    [Token(Token = "0x40072B8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int slot_4_style_id;

    [Token(Token = "0x17001B0B")]
    public int Slot1StyleId
    {
      [Token(Token = "0x6009B51"), Address(RVA = "0x48F1A9C", Offset = "0x48F1A9C", VA = "0x48F1A9C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B52"), Address(RVA = "0x48F1AA4", Offset = "0x48F1AA4", VA = "0x48F1AA4")] set
      {
      }
    }

    [Token(Token = "0x17001B0C")]
    public int Slot2StyleId
    {
      [Token(Token = "0x6009B53"), Address(RVA = "0x48F1AAC", Offset = "0x48F1AAC", VA = "0x48F1AAC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B54"), Address(RVA = "0x48F1AB4", Offset = "0x48F1AB4", VA = "0x48F1AB4")] set
      {
      }
    }

    [Token(Token = "0x17001B0D")]
    public int Slot3StyleId
    {
      [Token(Token = "0x6009B55"), Address(RVA = "0x48F1ABC", Offset = "0x48F1ABC", VA = "0x48F1ABC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B56"), Address(RVA = "0x48F1AC4", Offset = "0x48F1AC4", VA = "0x48F1AC4")] set
      {
      }
    }

    [Token(Token = "0x17001B0E")]
    public int Slot4StyleId
    {
      [Token(Token = "0x6009B57"), Address(RVA = "0x48F1ACC", Offset = "0x48F1ACC", VA = "0x48F1ACC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B58"), Address(RVA = "0x48F1AD4", Offset = "0x48F1AD4", VA = "0x48F1AD4")] set
      {
      }
    }

    [Token(Token = "0x6009B59")]
    [Address(RVA = "0x48F1ADC", Offset = "0x48F1ADC", VA = "0x48F1ADC")]
    public PlayerHomeSettingType()
    {
    }
  }
}
