// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.TableDataBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F36")]
  internal abstract class TableDataBase<Value> where Value : struct, ITableDataValue
  {
    [Token(Token = "0x400CA74")]
    public const int NotSelected = -1;
    [Token(Token = "0x400CA75")]
    [FieldOffset(Offset = "0x0")]
    private Func<Value, bool> filter;

    [Token(Token = "0x14000195")]
    public event TableDataBase<Value>.ChangeFilter OnChangeFilter
    {
      [Token(Token = "0x6012728")] add
      {
      }
      [Token(Token = "0x6012729")] remove
      {
      }
    }

    [Token(Token = "0x17003E8B")]
    public BindingParam<int> SelectIndex
    {
      [Token(Token = "0x601272A")] private set
      {
      }
      [Token(Token = "0x601272B")] get => (BindingParam<int>) null;
    }

    [Token(Token = "0x17003E8C")]
    public List<Value> AllValues
    {
      [Token(Token = "0x601272C")] get => (List<Value>) null;
    }

    [Token(Token = "0x17003E8D")]
    public IEnumerable<Value> Values
    {
      [Token(Token = "0x601272D")] get => (IEnumerable<Value>) null;
    }

    [Token(Token = "0x17003E8E")]
    public bool IsSelect
    {
      [Token(Token = "0x601272E")] get => new bool();
    }

    [Token(Token = "0x601272F")]
    public TableDataBase(List<Value> values)
    {
    }

    [Token(Token = "0x6012730")]
    public void Reset()
    {
    }

    [Token(Token = "0x6012731")]
    public void Subscribe(TableDataBase<Value>.ChangeFilter eventHandler)
    {
    }

    [Token(Token = "0x17003E8F")]
    public Value Current
    {
      [Token(Token = "0x6012732")] get => (Value) null;
    }

    [Token(Token = "0x6012733")]
    public Value GetValue(int index) => (Value) null;

    [Token(Token = "0x6012734")]
    public void SetDefaultIndex()
    {
    }

    [Token(Token = "0x6012735")]
    public void SetFilter(Func<Value, bool> filter)
    {
    }

    [Token(Token = "0x2002F37")]
    public delegate void ChangeFilter(IEnumerable<Value> values, int index) where Value : struct, ITableDataValue;
  }
}
