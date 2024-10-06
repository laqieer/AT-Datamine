// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.Check.CheckPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.Check
{
  [Token(Token = "0x2003977")]
  public class CheckPresenter : MonoBehaviour
  {
    [Token(Token = "0x400FB12")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CheckView _view;
    [Token(Token = "0x400FB1A")]
    [FieldOffset(Offset = "0x58")]
    private CheckModel _model;

    [Token(Token = "0x17004A63")]
    public Action OnRecoverySuccess
    {
      [Token(Token = "0x601695A"), Address(RVA = "0x42F2298", Offset = "0x42F2298", VA = "0x42F2298")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601695B"), Address(RVA = "0x42F22A0", Offset = "0x42F22A0", VA = "0x42F22A0")] set
      {
      }
    }

    [Token(Token = "0x17004A64")]
    public Action OnRecoveryError
    {
      [Token(Token = "0x601695C"), Address(RVA = "0x42F22A8", Offset = "0x42F22A8", VA = "0x42F22A8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601695D"), Address(RVA = "0x42F22B0", Offset = "0x42F22B0", VA = "0x42F22B0")] set
      {
      }
    }

    [Token(Token = "0x17004A65")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x601695E"), Address(RVA = "0x42F22B8", Offset = "0x42F22B8", VA = "0x42F22B8")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x601695F"), Address(RVA = "0x42F22C0", Offset = "0x42F22C0", VA = "0x42F22C0")] set
      {
      }
    }

    [Token(Token = "0x17004A66")]
    public Action Closure
    {
      [Token(Token = "0x6016960"), Address(RVA = "0x42F22C8", Offset = "0x42F22C8", VA = "0x42F22C8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6016961"), Address(RVA = "0x42F22D0", Offset = "0x42F22D0", VA = "0x42F22D0")] set
      {
      }
    }

    [Token(Token = "0x17004A67")]
    public Action ClosureChain
    {
      [Token(Token = "0x6016962"), Address(RVA = "0x42F22D8", Offset = "0x42F22D8", VA = "0x42F22D8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6016963"), Address(RVA = "0x42F22E0", Offset = "0x42F22E0", VA = "0x42F22E0")] set
      {
      }
    }

    [Token(Token = "0x17004A68")]
    public Action OnClose
    {
      [Token(Token = "0x6016964"), Address(RVA = "0x42F22E8", Offset = "0x42F22E8", VA = "0x42F22E8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6016965"), Address(RVA = "0x42F22F0", Offset = "0x42F22F0", VA = "0x42F22F0")] set
      {
      }
    }

    [Token(Token = "0x17004A69")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x6016966"), Address(RVA = "0x42F22F8", Offset = "0x42F22F8", VA = "0x42F22F8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6016967"), Address(RVA = "0x42F2300", Offset = "0x42F2300", VA = "0x42F2300")] set
      {
      }
    }

    [Token(Token = "0x6016968")]
    [Address(RVA = "0x42F1B68", Offset = "0x42F1B68", VA = "0x42F1B68")]
    public void Initialize(ApRecoveryModel apRecoveryModel)
    {
    }

    [Token(Token = "0x6016969")]
    [Address(RVA = "0x42F2650", Offset = "0x42F2650", VA = "0x42F2650")]
    private void Close(bool useChain = false)
    {
    }

    [Token(Token = "0x601696A")]
    [Address(RVA = "0x42F26A0", Offset = "0x42F26A0", VA = "0x42F26A0")]
    private void OnClickButtonClose()
    {
    }

    [Token(Token = "0x601696B")]
    [Address(RVA = "0x42F26E4", Offset = "0x42F26E4", VA = "0x42F26E4")]
    private void OnClickButtonRecovery()
    {
    }

    [Token(Token = "0x601696C")]
    [Address(RVA = "0x42F27F4", Offset = "0x42F27F4", VA = "0x42F27F4")]
    private void OnClickButtonLaw()
    {
    }

    [Token(Token = "0x601696D")]
    [Address(RVA = "0x42F27FC", Offset = "0x42F27FC", VA = "0x42F27FC")]
    public CheckPresenter()
    {
    }
  }
}
