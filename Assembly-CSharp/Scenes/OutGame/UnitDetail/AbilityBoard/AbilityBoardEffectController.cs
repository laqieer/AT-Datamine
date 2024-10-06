// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardEffectController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003321")]
  public class AbilityBoardEffectController : MonoBehaviour
  {
    [Token(Token = "0x400DD2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;

    [Token(Token = "0x6014197")]
    [Address(RVA = "0x20C47AC", Offset = "0x20C47AC", VA = "0x20C47AC")]
    public IEnumerator InitializeTimelineAsync() => (IEnumerator) null;

    [Token(Token = "0x6014198")]
    [Address(RVA = "0x20C3F98", Offset = "0x20C3F98", VA = "0x20C3F98")]
    public void PlayInAnim(Action finishAction = null)
    {
    }

    [Token(Token = "0x6014199")]
    [Address(RVA = "0x20C71F8", Offset = "0x20C71F8", VA = "0x20C71F8")]
    public AbilityBoardEffectController()
    {
    }
  }
}
