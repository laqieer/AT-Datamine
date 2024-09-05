// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropEventSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000674")]
  public class PropEventSender : MonoBehaviour, IPropEventSubject
  {
    [Token(Token = "0x140000E3")]
    public event UnityAction<AnimationEvent> OnReceiveEvent
    {
      [Token(Token = "0x60024F2"), Address(RVA = "0x2F35274", Offset = "0x2F35274", VA = "0x2F35274")] add
      {
      }
      [Token(Token = "0x60024F3"), Address(RVA = "0x2F35324", Offset = "0x2F35324", VA = "0x2F35324")] remove
      {
      }
    }

    [Token(Token = "0x60024F4")]
    [Address(RVA = "0x2F353D4", Offset = "0x2F353D4", VA = "0x2F353D4")]
    public void PropEvent(AnimationEvent eventParam)
    {
    }

    [Token(Token = "0x60024F5")]
    [Address(RVA = "0x2F353F0", Offset = "0x2F353F0", VA = "0x2F353F0", Slot = "4")]
    public void Subscribe(IPropEventObserver observer)
    {
    }

    [Token(Token = "0x60024F6")]
    [Address(RVA = "0x2F354D4", Offset = "0x2F354D4", VA = "0x2F354D4")]
    public PropEventSender()
    {
    }
  }
}
