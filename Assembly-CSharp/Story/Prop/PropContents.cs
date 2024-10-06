// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropContents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000670")]
  [DisallowMultipleComponent]
  public abstract class PropContents : MonoBehaviour, IPropEventObserver
  {
    [Token(Token = "0x60024E1")]
    [Address(RVA = "0x2F3513C", Offset = "0x2F3513C", VA = "0x2F3513C", Slot = "4")]
    public void ReceiveEvent(AnimationEvent eventParam)
    {
    }

    [Token(Token = "0x60024E2")]
    public abstract void Play(params string[] commands);

    [Token(Token = "0x60024E3")]
    [Address(RVA = "0x2F35264", Offset = "0x2F35264", VA = "0x2F35264", Slot = "6")]
    public virtual IEnumerable<IPropElementContainer> GetPropContainers()
    {
      return (IEnumerable<IPropElementContainer>) null;
    }

    [Token(Token = "0x60024E4")]
    [Address(RVA = "0x2F3526C", Offset = "0x2F3526C", VA = "0x2F3526C")]
    protected PropContents()
    {
    }
  }
}
