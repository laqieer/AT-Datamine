// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventPosterTouchController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B6E")]
  public class HomeEventPosterTouchController : MonoBehaviour
  {
    [Token(Token = "0x4003419")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject colliderObj;
    [Token(Token = "0x400341A")]
    [FieldOffset(Offset = "0x20")]
    private Action touchAction;

    [Token(Token = "0x6004115")]
    [Address(RVA = "0x2A2D4B0", Offset = "0x2A2D4B0", VA = "0x2A2D4B0")]
    public void SetTouchAction(Action touchAction)
    {
    }

    [Token(Token = "0x6004116")]
    [Address(RVA = "0x2A2D4B8", Offset = "0x2A2D4B8", VA = "0x2A2D4B8")]
    private void Update()
    {
    }

    [Token(Token = "0x6004117")]
    [Address(RVA = "0x2A2D798", Offset = "0x2A2D798", VA = "0x2A2D798")]
    public HomeEventPosterTouchController()
    {
    }
  }
}
