// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.BindingParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F1C")]
  public class BindingParam<T>
  {
    [Token(Token = "0x400CA1E")]
    [FieldOffset(Offset = "0x0")]
    private T value;

    [Token(Token = "0x1400018F")]
    public event EventHandler<T> ChangeValue
    {
      [Token(Token = "0x601267F")] add
      {
      }
      [Token(Token = "0x6012680")] remove
      {
      }
    }

    [Token(Token = "0x17003E67")]
    public T Value
    {
      [Token(Token = "0x6012681")] set
      {
      }
      [Token(Token = "0x6012682")] get => (T) null;
    }

    [Token(Token = "0x6012683")]
    public BindingParam(T initial = null)
    {
    }

    [Token(Token = "0x6012684")]
    public void Subscribe(EventHandler<T> eventHandler)
    {
    }
  }
}
