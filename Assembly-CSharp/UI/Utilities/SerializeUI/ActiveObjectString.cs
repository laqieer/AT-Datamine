// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A4")]
  [Serializable]
  public class ActiveObjectString
  {
    [Token(Token = "0x400289C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x400289D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int argumentIndex;
    [Token(Token = "0x400289E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ActiveObjectString.JudgeType judge;
    [Token(Token = "0x400289F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string value;

    [Token(Token = "0x1700071F")]
    public int ArgumentIndex
    {
      [Token(Token = "0x600313C"), Address(RVA = "0x3C16244", Offset = "0x3C16244", VA = "0x3C16244")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600313D")]
    [Address(RVA = "0x3C15DBC", Offset = "0x3C15DBC", VA = "0x3C15DBC")]
    public bool Judge(int index, string comparisonValue) => new bool();

    [Token(Token = "0x600313E")]
    [Address(RVA = "0x3C1624C", Offset = "0x3C1624C", VA = "0x3C1624C")]
    public ActiveObjectString()
    {
    }

    [Token(Token = "0x20008A5")]
    public enum JudgeType
    {
      [Token(Token = "0x40028A1")] CompareTo,
      [Token(Token = "0x40028A2")] Any,
      [Token(Token = "0x40028A3")] NotAny,
      [Token(Token = "0x40028A4")] Contain,
      [Token(Token = "0x40028A5")] NotContain,
    }
  }
}
