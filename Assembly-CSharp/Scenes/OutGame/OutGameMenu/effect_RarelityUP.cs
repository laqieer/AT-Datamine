// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.effect_RarelityUP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A5B")]
  public class effect_RarelityUP : MonoBehaviour
  {
    [Token(Token = "0x400FFD1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FFD2")]
    [FieldOffset(Offset = "0x20")]
    private bool isInDirection;
    [Token(Token = "0x400FFD3")]
    [FieldOffset(Offset = "0x28")]
    private Action directFinish;

    [Token(Token = "0x6016F02")]
    [Address(RVA = "0x29C0D7C", Offset = "0x29C0D7C", VA = "0x29C0D7C")]
    public void StartEffect(Action finish)
    {
    }

    [Token(Token = "0x6016F03")]
    [Address(RVA = "0x29C0E6C", Offset = "0x29C0E6C", VA = "0x29C0E6C")]
    private IEnumerator WaitOutDirection() => (IEnumerator) null;

    [Token(Token = "0x6016F04")]
    [Address(RVA = "0x29C0EFC", Offset = "0x29C0EFC", VA = "0x29C0EFC")]
    private IEnumerator playend() => (IEnumerator) null;

    [Token(Token = "0x6016F05")]
    [Address(RVA = "0x29C0F8C", Offset = "0x29C0F8C", VA = "0x29C0F8C")]
    public effect_RarelityUP()
    {
    }
  }
}
