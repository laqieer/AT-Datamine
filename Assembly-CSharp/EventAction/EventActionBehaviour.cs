// Decompiled with JetBrains decompiler
// Type: EventAction.EventActionBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace EventAction
{
  [Token(Token = "0x2001F10")]
  public abstract class EventActionBehaviour : MonoBehaviour
  {
    [Token(Token = "0x1700265F")]
    public bool IsPlaying
    {
      [Token(Token = "0x600B886"), Address(RVA = "0x2134BFC", Offset = "0x2134BFC", VA = "0x2134BFC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B887"), Address(RVA = "0x2134C04", Offset = "0x2134C04", VA = "0x2134C04")] private set
      {
      }
    }

    [Token(Token = "0x600B888")]
    [Address(RVA = "0x2134C10", Offset = "0x2134C10", VA = "0x2134C10")]
    public void Play()
    {
    }

    [Token(Token = "0x600B889")]
    [Address(RVA = "0x2134C48", Offset = "0x2134C48", VA = "0x2134C48", Slot = "4")]
    protected virtual void OnPlay()
    {
    }

    [Token(Token = "0x600B88A")]
    [Address(RVA = "0x2134C4C", Offset = "0x2134C4C", VA = "0x2134C4C", Slot = "5")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x600B88B")]
    [Address(RVA = "0x2134C74", Offset = "0x2134C74", VA = "0x2134C74", Slot = "6")]
    protected virtual IEnumerator Playing() => (IEnumerator) null;

    [Token(Token = "0x600B88C")]
    [Address(RVA = "0x2134D04", Offset = "0x2134D04", VA = "0x2134D04")]
    protected void Finish()
    {
    }

    [Token(Token = "0x600B88D")]
    [Address(RVA = "0x2134D14", Offset = "0x2134D14", VA = "0x2134D14", Slot = "7")]
    protected virtual void OnFinish()
    {
    }

    [Token(Token = "0x600B88E")]
    [Address(RVA = "0x2134D18", Offset = "0x2134D18", VA = "0x2134D18")]
    protected EventActionBehaviour()
    {
    }
  }
}
