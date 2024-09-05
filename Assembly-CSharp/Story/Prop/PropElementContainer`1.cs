// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropElementContainer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000673")]
  [Serializable]
  public class PropElementContainer<T> : IPropElementContainer
  {
    [Token(Token = "0x4001F17")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private string groupID;
    [Token(Token = "0x4001F18")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T element;

    [Token(Token = "0x1700055D")]
    public string GroupID
    {
      [Token(Token = "0x60024ED")] get => (string) null;
      [Token(Token = "0x60024EE")] set
      {
      }
    }

    [Token(Token = "0x1700055E")]
    public T Element
    {
      [Token(Token = "0x60024EF")] get => (T) null;
      [Token(Token = "0x60024F0")] set
      {
      }
    }

    [Token(Token = "0x60024F1")]
    public PropElementContainer()
    {
    }
  }
}
