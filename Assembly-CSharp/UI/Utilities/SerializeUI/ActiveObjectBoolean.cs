// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ActiveObjectBoolean
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A6")]
  [Serializable]
  public class ActiveObjectBoolean
  {
    [Token(Token = "0x40028A6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string description;
    [Token(Token = "0x40028A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int argumentIndex;
    [Token(Token = "0x40028A8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool value;

    [Token(Token = "0x17000720")]
    public int ArgumentIndex
    {
      [Token(Token = "0x600313F"), Address(RVA = "0x3C16254", Offset = "0x3C16254", VA = "0x3C16254")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003140")]
    [Address(RVA = "0x3C15E74", Offset = "0x3C15E74", VA = "0x3C15E74")]
    public bool Judge(int index, bool? comparisonValue) => new bool();

    [Token(Token = "0x6003141")]
    [Address(RVA = "0x3C1625C", Offset = "0x3C1625C", VA = "0x3C1625C")]
    public ActiveObjectBoolean()
    {
    }
  }
}
