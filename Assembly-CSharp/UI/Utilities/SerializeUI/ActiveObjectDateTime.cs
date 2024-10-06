// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectDateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A2")]
  [Serializable]
  public class ActiveObjectDateTime
  {
    [Token(Token = "0x4002890")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4002891")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int argumentIndex;
    [Token(Token = "0x4002892")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ActiveObjectDateTime.JudgeType judge;
    [Token(Token = "0x4002893")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string value;
    [Token(Token = "0x4002894")]
    [FieldOffset(Offset = "0x28")]
    private DateTime? serializeDateTime;

    [Token(Token = "0x1700071E")]
    public int ArgumentIndex
    {
      [Token(Token = "0x6003138"), Address(RVA = "0x3C15FFC", Offset = "0x3C15FFC", VA = "0x3C15FFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003139")]
    [Address(RVA = "0x3C16004", Offset = "0x3C16004", VA = "0x3C16004")]
    private DateTime? ConvertStringToDateTime(string dateTimeString) => new DateTime?();

    [Token(Token = "0x600313A")]
    [Address(RVA = "0x3C15B98", Offset = "0x3C15B98", VA = "0x3C15B98")]
    public bool Judge(int index, DateTime? comparisonValue) => new bool();

    [Token(Token = "0x600313B")]
    [Address(RVA = "0x3C1623C", Offset = "0x3C1623C", VA = "0x3C1623C")]
    public ActiveObjectDateTime()
    {
    }

    [Token(Token = "0x20008A3")]
    public enum JudgeType
    {
      [Token(Token = "0x4002896")] Equal,
      [Token(Token = "0x4002897")] NotEqual,
      [Token(Token = "0x4002898")] GreaterThan,
      [Token(Token = "0x4002899")] GreaterThanEqual,
      [Token(Token = "0x400289A")] LessThan,
      [Token(Token = "0x400289B")] LessThanEqual,
    }
  }
}
