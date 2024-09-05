// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearOptionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABD")]
  [Serializable]
  public class PlayerGearOptionType
  {
    [Token(Token = "0x4007298")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float option_value;
    [Token(Token = "0x4007299")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int option_id;
    [Token(Token = "0x400729A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int slot;

    [Token(Token = "0x17001AEE")]
    public float OptionValue
    {
      [Token(Token = "0x6009B10"), Address(RVA = "0x48F188C", Offset = "0x48F188C", VA = "0x48F188C")] get
      {
        return new float();
      }
      [Token(Token = "0x6009B11"), Address(RVA = "0x48F1894", Offset = "0x48F1894", VA = "0x48F1894")] set
      {
      }
    }

    [Token(Token = "0x17001AEF")]
    public int OptionId
    {
      [Token(Token = "0x6009B12"), Address(RVA = "0x48F189C", Offset = "0x48F189C", VA = "0x48F189C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B13"), Address(RVA = "0x48F18A4", Offset = "0x48F18A4", VA = "0x48F18A4")] set
      {
      }
    }

    [Token(Token = "0x17001AF0")]
    public int Slot
    {
      [Token(Token = "0x6009B14"), Address(RVA = "0x48F18AC", Offset = "0x48F18AC", VA = "0x48F18AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B15"), Address(RVA = "0x48F18B4", Offset = "0x48F18B4", VA = "0x48F18B4")] set
      {
      }
    }

    [Token(Token = "0x6009B16")]
    [Address(RVA = "0x48F18BC", Offset = "0x48F18BC", VA = "0x48F18BC")]
    public PlayerGearOptionType()
    {
    }
  }
}
