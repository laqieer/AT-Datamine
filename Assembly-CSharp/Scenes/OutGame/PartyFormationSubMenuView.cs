// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartyFormationSubMenuView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032AA")]
  public class PartyFormationSubMenuView : MonoBehaviour
  {
    [Token(Token = "0x400D94B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400D94C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D94D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D94E")]
    [FieldOffset(Offset = "0x30")]
    private Action onSortingAction;
    [Token(Token = "0x400D94F")]
    [FieldOffset(Offset = "0x38")]
    private Action onAutoAction;
    [Token(Token = "0x400D950")]
    [FieldOffset(Offset = "0x40")]
    private Action onRevertAction;
    [Token(Token = "0x400D951")]
    [FieldOffset(Offset = "0x48")]
    private Action onAllClierAction;
    [Token(Token = "0x400D953")]
    [FieldOffset(Offset = "0x51")]
    private bool isPlayAnim;

    [Token(Token = "0x17004190")]
    public bool IsOpen
    {
      [Token(Token = "0x6013C59"), Address(RVA = "0x1ADBD90", Offset = "0x1ADBD90", VA = "0x1ADBD90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013C5A"), Address(RVA = "0x1ADBD98", Offset = "0x1ADBD98", VA = "0x1ADBD98")] private set
      {
      }
    }

    [Token(Token = "0x6013C5B")]
    [Address(RVA = "0x1ADBDA4", Offset = "0x1ADBDA4", VA = "0x1ADBDA4")]
    public void InitSubMenu(Action onSorting, Action onAuto, Action onRevert, Action onAllClier)
    {
    }

    [Token(Token = "0x6013C5C")]
    [Address(RVA = "0x1ADBE78", Offset = "0x1ADBE78", VA = "0x1ADBE78")]
    public void Open()
    {
    }

    [Token(Token = "0x6013C5D")]
    [Address(RVA = "0x1ADBF8C", Offset = "0x1ADBF8C", VA = "0x1ADBF8C")]
    public void Close()
    {
    }

    [Token(Token = "0x6013C5E")]
    [Address(RVA = "0x1ADC088", Offset = "0x1ADC088", VA = "0x1ADC088")]
    public void OnSortingButton()
    {
    }

    [Token(Token = "0x6013C5F")]
    [Address(RVA = "0x1ADC0A4", Offset = "0x1ADC0A4", VA = "0x1ADC0A4")]
    public void OnAutoButton()
    {
    }

    [Token(Token = "0x6013C60")]
    [Address(RVA = "0x1ADC0C0", Offset = "0x1ADC0C0", VA = "0x1ADC0C0")]
    public void OnRevertButton()
    {
    }

    [Token(Token = "0x6013C61")]
    [Address(RVA = "0x1ADC0DC", Offset = "0x1ADC0DC", VA = "0x1ADC0DC")]
    public void OnResetButton()
    {
    }

    [Token(Token = "0x6013C62")]
    [Address(RVA = "0x1ADC0F8", Offset = "0x1ADC0F8", VA = "0x1ADC0F8")]
    public PartyFormationSubMenuView()
    {
    }
  }
}
