// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.TapsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003F3")]
  public class TapsData : IEnumerable<InputEventDataEditable>, IEnumerable
  {
    [Token(Token = "0x40016B6")]
    [FieldOffset(Offset = "0x20")]
    private List<InputEventDataEditable> tapList;

    [Token(Token = "0x1700027F")]
    public InputEventDataEditable First
    {
      [Token(Token = "0x60016B4"), Address(RVA = "0x2488D08", Offset = "0x2488D08", VA = "0x2488D08")] get
      {
        return (InputEventDataEditable) null;
      }
    }

    [Token(Token = "0x17000280")]
    public InputEventDataEditable Second
    {
      [Token(Token = "0x60016B5"), Address(RVA = "0x2488D10", Offset = "0x2488D10", VA = "0x2488D10")] get
      {
        return (InputEventDataEditable) null;
      }
    }

    [Token(Token = "0x60016B6")]
    [Address(RVA = "0x2486D88", Offset = "0x2486D88", VA = "0x2486D88")]
    public TapsData()
    {
    }

    [Token(Token = "0x60016B7")]
    [Address(RVA = "0x2488CBC", Offset = "0x2488CBC", VA = "0x2488CBC")]
    public bool IsDouble() => new bool();

    [Token(Token = "0x60016B8")]
    [Address(RVA = "0x2487234", Offset = "0x2487234", VA = "0x2487234")]
    public void Select(Action<int, InputEventDataEditable> action)
    {
    }

    [Token(Token = "0x60016B9")]
    [Address(RVA = "0x2486C0C", Offset = "0x2486C0C", VA = "0x2486C0C", Slot = "4")]
    public IEnumerator<InputEventDataEditable> GetEnumerator()
    {
      return (IEnumerator<InputEventDataEditable>) null;
    }

    [Token(Token = "0x60016BA")]
    [Address(RVA = "0x2488D18", Offset = "0x2488D18", VA = "0x2488D18", Slot = "5")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }
  }
}
