// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectInteger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A0")]
  [Serializable]
  public class ActiveObjectInteger
  {
    [Token(Token = "0x4002885")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4002886")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int argumentIndex;
    [Token(Token = "0x4002887")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ActiveObjectInteger.JudgeType judge;
    [Token(Token = "0x4002888")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int value;

    [Token(Token = "0x1700071D")]
    public int ArgumentIndex
    {
      [Token(Token = "0x6003135"), Address(RVA = "0x3C15FEC", Offset = "0x3C15FEC", VA = "0x3C15FEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003136")]
    [Address(RVA = "0x3C15A8C", Offset = "0x3C15A8C", VA = "0x3C15A8C")]
    public bool Judge(int index, int? comparisonValue) => new bool();

    [Token(Token = "0x6003137")]
    [Address(RVA = "0x3C15FF4", Offset = "0x3C15FF4", VA = "0x3C15FF4")]
    public ActiveObjectInteger()
    {
    }

    [Token(Token = "0x20008A1")]
    public enum JudgeType
    {
      [Token(Token = "0x400288A")] Equal,
      [Token(Token = "0x400288B")] NotEqual,
      [Token(Token = "0x400288C")] GreaterThan,
      [Token(Token = "0x400288D")] GreaterThanEqual,
      [Token(Token = "0x400288E")] LessThan,
      [Token(Token = "0x400288F")] LessThanEqual,
    }
  }
}
