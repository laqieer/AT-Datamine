// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropContents`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000671")]
  public abstract class PropContents<TContainer> : PropContents where TContainer : IPropElementContainer
  {
    [Token(Token = "0x4001F14")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private List<TContainer> elementContainers;

    [Token(Token = "0x1700055A")]
    public List<TContainer> ElementContainers
    {
      [Token(Token = "0x60024E5")] get => (List<TContainer>) null;
    }

    [Token(Token = "0x60024E6")]
    public override sealed IEnumerable<IPropElementContainer> GetPropContainers()
    {
      return (IEnumerable<IPropElementContainer>) null;
    }

    [Token(Token = "0x60024E7")]
    protected PropContents()
    {
    }
  }
}
