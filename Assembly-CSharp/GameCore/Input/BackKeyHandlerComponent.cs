// Decompiled with JetBrains decompiler
// Type: GameCore.Input.BackKeyHandlerComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x200144B")]
  public class BackKeyHandlerComponent : UIBehaviour
  {
    [Token(Token = "0x4005D68")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BackKeyHandlerType handlerType;
    [Token(Token = "0x4005D69")]
    [FieldOffset(Offset = "0x20")]
    private IBackKeyHandler handler;
    [Token(Token = "0x4005D6A")]
    [FieldOffset(Offset = "0x28")]
    private Action onBackKeyAction;
    [Token(Token = "0x4005D6B")]
    [FieldOffset(Offset = "0x30")]
    private bool groupsAllowInteraction;
    [Token(Token = "0x4005D6C")]
    [FieldOffset(Offset = "0x38")]
    private readonly List<CanvasGroup> canvasGroupCache;

    [Token(Token = "0x1700117C")]
    public Action OnBackKeyAction
    {
      [Token(Token = "0x600723A"), Address(RVA = "0x404DE28", Offset = "0x404DE28", VA = "0x404DE28")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600723B"), Address(RVA = "0x404DE30", Offset = "0x404DE30", VA = "0x404DE30")] set
      {
      }
    }

    [Token(Token = "0x1700117D")]
    private bool isBackKeyActionRegistered
    {
      [Token(Token = "0x600723C"), Address(RVA = "0x404DEEC", Offset = "0x404DEEC", VA = "0x404DEEC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600723D")]
    [Address(RVA = "0x404DEFC", Offset = "0x404DEFC", VA = "0x404DEFC", Slot = "14")]
    protected override void OnCanvasGroupChanged()
    {
    }

    [Token(Token = "0x600723E")]
    [Address(RVA = "0x404E0A0", Offset = "0x404E0A0", VA = "0x404E0A0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600723F")]
    [Address(RVA = "0x404E130", Offset = "0x404E130", VA = "0x404E130", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6007240")]
    [Address(RVA = "0x404E1B0", Offset = "0x404E1B0", VA = "0x404E1B0", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x6007241")]
    [Address(RVA = "0x404E0BC", Offset = "0x404E0BC", VA = "0x404E0BC")]
    private void InitializeBackKeyHandler()
    {
    }

    [Token(Token = "0x6007242")]
    [Address(RVA = "0x404E14C", Offset = "0x404E14C", VA = "0x404E14C")]
    private void ReleaseBackKeyHandler()
    {
    }

    [Token(Token = "0x6007243")]
    [Address(RVA = "0x404E218", Offset = "0x404E218", VA = "0x404E218")]
    private IBackKeyHandler CreateBackKeyHandler(BackKeyHandlerType handlerType)
    {
      return (IBackKeyHandler) null;
    }

    [Token(Token = "0x6007244")]
    [Address(RVA = "0x404E3E8", Offset = "0x404E3E8", VA = "0x404E3E8")]
    private void OnBackKey()
    {
    }

    [Token(Token = "0x6007245")]
    [Address(RVA = "0x404E40C", Offset = "0x404E40C", VA = "0x404E40C")]
    public void SetBackKeyHandlerType(BackKeyHandlerType handlerType)
    {
    }

    [Token(Token = "0x6007246")]
    [Address(RVA = "0x404E458", Offset = "0x404E458", VA = "0x404E458")]
    public BackKeyHandlerComponent()
    {
    }
  }
}
