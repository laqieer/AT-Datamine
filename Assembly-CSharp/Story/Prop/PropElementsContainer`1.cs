// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropElementsContainer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000672")]
  [Serializable]
  public class PropElementsContainer<T> : IPropElementContainer
  {
    [Token(Token = "0x4001F15")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private string groupID;
    [Token(Token = "0x4001F16")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private List<T> elements;

    [Token(Token = "0x1700055B")]
    public string GroupID
    {
      [Token(Token = "0x60024E8")] get => (string) null;
      [Token(Token = "0x60024E9")] set
      {
      }
    }

    [Token(Token = "0x1700055C")]
    public List<T> Elements
    {
      [Token(Token = "0x60024EA")] get => (List<T>) null;
      [Token(Token = "0x60024EB")] set
      {
      }
    }

    [Token(Token = "0x60024EC")]
    public PropElementsContainer()
    {
    }
  }
}
