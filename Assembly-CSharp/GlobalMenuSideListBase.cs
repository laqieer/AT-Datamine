// Decompiled with JetBrains decompiler
// Type: GlobalMenuSideListBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002AD")]
public class GlobalMenuSideListBase : MonoBehaviour
{
  [Token(Token = "0x4000FD1")]
  [FieldOffset(Offset = "0x18")]
  public Button[] menuButton;
  [Token(Token = "0x4000FD2")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private UITweenGroup menuButtonTween;
  [Token(Token = "0x4000FD3")]
  [FieldOffset(Offset = "0x28")]
  protected string[][] buttonTweenName;

  [Token(Token = "0x60010C5")]
  [Address(RVA = "0x1BEA49C", Offset = "0x1BEA49C", VA = "0x1BEA49C", Slot = "4")]
  protected virtual void Awake()
  {
  }

  [Token(Token = "0x60010C6")]
  [Address(RVA = "0x1BEA6DC", Offset = "0x1BEA6DC", VA = "0x1BEA6DC")]
  public IEnumerator PlayTween(int currIdx, int nextIdx) => (IEnumerator) null;

  [Token(Token = "0x60010C7")]
  [Address(RVA = "0x1BEA780", Offset = "0x1BEA780", VA = "0x1BEA780")]
  public IEnumerator PlayTween(int currIdx, int nextIdx, Action onStartPlayback)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60010C8")]
  [Address(RVA = "0x1BEA838", Offset = "0x1BEA838", VA = "0x1BEA838")]
  public bool isPlaying() => new bool();

  [Token(Token = "0x60010C9")]
  [Address(RVA = "0x1BE4148", Offset = "0x1BE4148", VA = "0x1BE4148")]
  public GlobalMenuSideListBase()
  {
  }
}
