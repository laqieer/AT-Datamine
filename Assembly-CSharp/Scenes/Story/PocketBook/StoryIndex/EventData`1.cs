// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.EventData`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex
{
  [Token(Token = "0x2002DCD")]
  public class EventData<T>
  {
    [Token(Token = "0x400C4EE")]
    [FieldOffset(Offset = "0x0")]
    private T value;

    [Token(Token = "0x17003D2C")]
    public T Value
    {
      [Token(Token = "0x6011E92")] get => (T) null;
      [Token(Token = "0x6011E93")] set
      {
      }
    }

    [Token(Token = "0x14000159")]
    public event Action<T> OnValueChanged
    {
      [Token(Token = "0x6011E94")] add
      {
      }
      [Token(Token = "0x6011E95")] remove
      {
      }
    }

    [Token(Token = "0x1400015A")]
    public event Action<T, T> OnValueChangedFromTo
    {
      [Token(Token = "0x6011E96")] add
      {
      }
      [Token(Token = "0x6011E97")] remove
      {
      }
    }

    [Token(Token = "0x6011E98")]
    public EventData()
    {
    }

    [Token(Token = "0x6011E99")]
    public EventData(T init)
    {
    }
  }
}
