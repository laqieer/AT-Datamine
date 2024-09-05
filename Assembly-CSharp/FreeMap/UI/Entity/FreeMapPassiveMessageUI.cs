// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapPassiveMessageUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Element;
using FreeMap.UI.Entity.State;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x2001699")]
  public class FreeMapPassiveMessageUI : FreeMapUIBase
  {
    [Token(Token = "0x4006571")]
    [FieldOffset(Offset = "0x48")]
    private readonly float ShowMessageDistance;
    [Token(Token = "0x4006572")]
    [FieldOffset(Offset = "0x4C")]
    private readonly float HideMessageDistance;
    [Token(Token = "0x4006573")]
    [FieldOffset(Offset = "0x50")]
    private readonly StateMachine<FreeMapPassiveMessageUI> machine;
    [Token(Token = "0x4006574")]
    [FieldOffset(Offset = "0x58")]
    private readonly Dictionary<int, PassiveMessageStateBase> stateTable;

    [Token(Token = "0x170013AF")]
    public PassiveMessageState CurrentPassiveMessageState
    {
      [Token(Token = "0x6007F7A"), Address(RVA = "0x21B4788", Offset = "0x21B4788", VA = "0x21B4788")] get
      {
        return new PassiveMessageState();
      }
    }

    [Token(Token = "0x14000111")]
    public event Action<PassiveMessageState> OnChangeState
    {
      [Token(Token = "0x6007F7B"), Address(RVA = "0x21B6D64", Offset = "0x21B6D64", VA = "0x21B6D64")] add
      {
      }
      [Token(Token = "0x6007F7C"), Address(RVA = "0x21B6E14", Offset = "0x21B6E14", VA = "0x21B6E14")] remove
      {
      }
    }

    [Token(Token = "0x170013B0")]
    public FreeMapUIControllElement IconElement
    {
      [Token(Token = "0x6007F7D"), Address(RVA = "0x21B6EC4", Offset = "0x21B6EC4", VA = "0x21B6EC4")] get
      {
        return (FreeMapUIControllElement) null;
      }
      [Token(Token = "0x6007F7E"), Address(RVA = "0x21B6ECC", Offset = "0x21B6ECC", VA = "0x21B6ECC")] private set
      {
      }
    }

    [Token(Token = "0x170013B1")]
    public FreeMapPassiveMessageUIElement MessageElement
    {
      [Token(Token = "0x6007F7F"), Address(RVA = "0x21B6ED4", Offset = "0x21B6ED4", VA = "0x21B6ED4")] get
      {
        return (FreeMapPassiveMessageUIElement) null;
      }
      [Token(Token = "0x6007F80"), Address(RVA = "0x21B6EDC", Offset = "0x21B6EDC", VA = "0x21B6EDC")] private set
      {
      }
    }

    [Token(Token = "0x170013B2")]
    public UITransformAvoidHandler TransformAvoidHandler
    {
      [Token(Token = "0x6007F81"), Address(RVA = "0x21B6EE4", Offset = "0x21B6EE4", VA = "0x21B6EE4")] get
      {
        return (UITransformAvoidHandler) null;
      }
    }

    [Token(Token = "0x170013B3")]
    public override FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x6007F82"), Address(RVA = "0x21B6EEC", Offset = "0x21B6EEC", VA = "0x21B6EEC", Slot = "6")] get
      {
        return new FreeMapUIDirection();
      }
    }

    [Token(Token = "0x170013B4")]
    public override bool IsValid
    {
      [Token(Token = "0x6007F83"), Address(RVA = "0x21B6EF4", Offset = "0x21B6EF4", VA = "0x21B6EF4", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170013B5")]
    public Camera CurrentCamera
    {
      [Token(Token = "0x6007F84"), Address(RVA = "0x21B6F60", Offset = "0x21B6F60", VA = "0x21B6F60")] get
      {
        return (Camera) null;
      }
      [Token(Token = "0x6007F85"), Address(RVA = "0x21B6F68", Offset = "0x21B6F68", VA = "0x21B6F68")] private set
      {
      }
    }

    [Token(Token = "0x170013B6")]
    public FreeMapUICanvas CurrentCanvas
    {
      [Token(Token = "0x6007F86"), Address(RVA = "0x21B6F70", Offset = "0x21B6F70", VA = "0x21B6F70")] get
      {
        return (FreeMapUICanvas) null;
      }
      [Token(Token = "0x6007F87"), Address(RVA = "0x21B6F78", Offset = "0x21B6F78", VA = "0x21B6F78")] private set
      {
      }
    }

    [Token(Token = "0x170013B7")]
    public FreeMapPlayerInstance CurrentPlayer
    {
      [Token(Token = "0x6007F88"), Address(RVA = "0x21B6F80", Offset = "0x21B6F80", VA = "0x21B6F80")] get
      {
        return (FreeMapPlayerInstance) null;
      }
      [Token(Token = "0x6007F89"), Address(RVA = "0x21B6F88", Offset = "0x21B6F88", VA = "0x21B6F88")] private set
      {
      }
    }

    [Token(Token = "0x170013B8")]
    public float CurrentIconDistance
    {
      [Token(Token = "0x6007F8A"), Address(RVA = "0x21B6F90", Offset = "0x21B6F90", VA = "0x21B6F90")] get
      {
        return new float();
      }
      [Token(Token = "0x6007F8B"), Address(RVA = "0x21B6F98", Offset = "0x21B6F98", VA = "0x21B6F98")] private set
      {
      }
    }

    [Token(Token = "0x6007F8C")]
    [Address(RVA = "0x21B6FA0", Offset = "0x21B6FA0", VA = "0x21B6FA0")]
    public FreeMapPassiveMessageUI()
    {
    }

    [Token(Token = "0x6007F8D")]
    [Address(RVA = "0x21B72AC", Offset = "0x21B72AC", VA = "0x21B72AC")]
    public void PassiveMessageInitilaize(FreeMapUIControllElement controlElement)
    {
    }

    [Token(Token = "0x6007F8E")]
    [Address(RVA = "0x21B45E4", Offset = "0x21B45E4", VA = "0x21B45E4")]
    public bool ShowableMessage(FreeMapPlayerInstance player, out float distance) => new bool();

    [Token(Token = "0x6007F8F")]
    [Address(RVA = "0x21B7364", Offset = "0x21B7364", VA = "0x21B7364", Slot = "9")]
    protected override void OnUpdate(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      FreeMapPlayerInstance player,
      bool isUpdateClip)
    {
    }

    [Token(Token = "0x6007F90")]
    [Address(RVA = "0x21B72D4", Offset = "0x21B72D4", VA = "0x21B72D4")]
    public void ChangeState(PassiveMessageState state)
    {
    }

    [Token(Token = "0x6007F91")]
    [Address(RVA = "0x21B7470", Offset = "0x21B7470", VA = "0x21B7470")]
    public void ChangeBackState()
    {
    }

    [Token(Token = "0x6007F92")]
    [Address(RVA = "0x21B473C", Offset = "0x21B473C", VA = "0x21B473C")]
    public void RequestShowMessage()
    {
    }

    [Token(Token = "0x6007F93")]
    [Address(RVA = "0x21B4710", Offset = "0x21B4710", VA = "0x21B4710")]
    public void RequestHideMessage()
    {
    }

    [Token(Token = "0x6007F94")]
    [Address(RVA = "0x21B73F8", Offset = "0x21B73F8", VA = "0x21B73F8")]
    private PassiveMessageStateBase GetState(PassiveMessageState state)
    {
      return (PassiveMessageStateBase) null;
    }

    [Token(Token = "0x6007F95")]
    [Address(RVA = "0x21B74D0", Offset = "0x21B74D0", VA = "0x21B74D0", Slot = "13")]
    protected override void OnDestroyUI()
    {
    }

    [Token(Token = "0x6007F96")]
    [Address(RVA = "0x21B7500", Offset = "0x21B7500", VA = "0x21B7500", Slot = "10")]
    public override void ShowUI()
    {
    }

    [Token(Token = "0x6007F97")]
    [Address(RVA = "0x21B7504", Offset = "0x21B7504", VA = "0x21B7504", Slot = "11")]
    public override void HideUI()
    {
    }

    [Token(Token = "0x6007F98")]
    [Address(RVA = "0x21B750C", Offset = "0x21B750C", VA = "0x21B750C", Slot = "14")]
    public override void ChangeSprite(
      FreeMapUIParamBase targetParam,
      string targetObjectName,
      Sprite sprite)
    {
    }

    [Token(Token = "0x6007F99")]
    [Address(RVA = "0x21B7530", Offset = "0x21B7530", VA = "0x21B7530", Slot = "12")]
    public override void ChangeUI(
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam,
      Sprite sprite,
      UnityAction buttonAction,
      string buttonObjectName)
    {
    }

    [Token(Token = "0x6007F9A")]
    [Address(RVA = "0x21B7534", Offset = "0x21B7534", VA = "0x21B7534", Slot = "8")]
    public override void SetAsLastSibling()
    {
    }
  }
}
