// Decompiled with JetBrains decompiler
// Type: Routine.Variables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x200225D")]
  public class Variables
  {
    [Token(Token = "0x400909F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, int> dic;

    [Token(Token = "0x17002D5C")]
    [MoonSharpHidden]
    public IReadOnlyDictionary<string, int> Dic
    {
      [Token(Token = "0x600D0BC"), Address(RVA = "0x4CDC658", Offset = "0x4CDC658", VA = "0x4CDC658")] get
      {
        return (IReadOnlyDictionary<string, int>) null;
      }
    }

    [Token(Token = "0x17002D5D")]
    public int this[string key]
    {
      [Token(Token = "0x600D0BD"), Address(RVA = "0x4CDC660", Offset = "0x4CDC660", VA = "0x4CDC660")] get
      {
        return new int();
      }
      [Token(Token = "0x600D0BE"), Address(RVA = "0x4CDC708", Offset = "0x4CDC708", VA = "0x4CDC708")] set
      {
      }
    }

    [Token(Token = "0x600D0BF")]
    [Address(RVA = "0x4CDC7C0", Offset = "0x4CDC7C0", VA = "0x4CDC7C0")]
    public Variables()
    {
    }

    [Token(Token = "0x600D0C0")]
    [Address(RVA = "0x4CDC83C", Offset = "0x4CDC83C", VA = "0x4CDC83C")]
    public Variables(IReadOnlyDictionary<string, int> src)
    {
    }

    [Token(Token = "0x600D0C1")]
    [Address(RVA = "0x4CDC664", Offset = "0x4CDC664", VA = "0x4CDC664")]
    public int GetValue(string key) => new int();

    [Token(Token = "0x600D0C2")]
    [Address(RVA = "0x4CDC70C", Offset = "0x4CDC70C", VA = "0x4CDC70C")]
    public void SetValue(string key, int value)
    {
    }

    [Token(Token = "0x600D0C3")]
    [Address(RVA = "0x4CDC8D0", Offset = "0x4CDC8D0", VA = "0x4CDC8D0")]
    public void SetValues(IReadOnlyDictionary<string, int> dic)
    {
    }

    [Token(Token = "0x600D0C4")]
    [Address(RVA = "0x4CDCBCC", Offset = "0x4CDCBCC", VA = "0x4CDCBCC")]
    private void AddValue(string key, int value)
    {
    }

    [Token(Token = "0x600D0C5")]
    [Address(RVA = "0x4CDCC34", Offset = "0x4CDCC34", VA = "0x4CDCC34")]
    public void Clear()
    {
    }
  }
}
