// Decompiled with JetBrains decompiler
// Type: UnitView.UI.FooterFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnitView.UI.FooterFunctions;
using UnityEngine;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000400")]
  [Serializable]
  public class FooterFunction
  {
    [Token(Token = "0x40016C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ChangeUnit changeUnit;
    [Token(Token = "0x40016C9")]
    [FieldOffset(Offset = "0x18")]
    private IFunction current;

    [Token(Token = "0x17000289")]
    public ChangeUnit ChangeUnit
    {
      [Token(Token = "0x60016E6"), Address(RVA = "0x248977C", Offset = "0x248977C", VA = "0x248977C")] get
      {
        return (ChangeUnit) null;
      }
    }

    [Token(Token = "0x60016E7")]
    [Address(RVA = "0x2489784", Offset = "0x2489784", VA = "0x2489784")]
    public void Disable()
    {
    }

    [Token(Token = "0x60016E8")]
    [Address(RVA = "0x248982C", Offset = "0x248982C", VA = "0x248982C")]
    public void UnitChange()
    {
    }

    [Token(Token = "0x60016E9")]
    [Address(RVA = "0x2489834", Offset = "0x2489834", VA = "0x2489834")]
    private void Modify(IFunction modified)
    {
    }

    [Token(Token = "0x60016EA")]
    [Address(RVA = "0x2489944", Offset = "0x2489944", VA = "0x2489944")]
    public FooterFunction()
    {
    }
  }
}
