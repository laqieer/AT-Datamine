// Decompiled with JetBrains decompiler
// Type: PlayerMake.PlayerMakeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using PlayerMake.StateMachine;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace PlayerMake
{
  [Token(Token = "0x200099F")]
  public class PlayerMakeManager : MonoBehaviour
  {
    [Token(Token = "0x4002CCB")]
    [FieldOffset(Offset = "0x18")]
    public PlayerMakeView PlayerMakeView;
    [Token(Token = "0x4002CCC")]
    [FieldOffset(Offset = "0x20")]
    public PlayerMakeValidation PlayerMakeValidation;
    [Token(Token = "0x4002CCE")]
    [FieldOffset(Offset = "0x30")]
    private bool initialized;
    [Token(Token = "0x4002CCF")]
    [FieldOffset(Offset = "0x31")]
    private bool isBusy;
    [Token(Token = "0x4002CD0")]
    [FieldOffset(Offset = "0x38")]
    private PlayerMakeStateMachine stateMachine;
    [Token(Token = "0x4002CD1")]
    [FieldOffset(Offset = "0x40")]
    private string playerName;
    [Token(Token = "0x4002CD2")]
    [FieldOffset(Offset = "0x48")]
    private IPlayerMakeState nextState;

    [Token(Token = "0x140000E8")]
    public event Action OnConfirmPlayerMake
    {
      [Token(Token = "0x60036D2"), Address(RVA = "0x3538ED0", Offset = "0x3538ED0", VA = "0x3538ED0")] add
      {
      }
      [Token(Token = "0x60036D3"), Address(RVA = "0x3538F6C", Offset = "0x3538F6C", VA = "0x3538F6C")] remove
      {
      }
    }

    [Token(Token = "0x60036D4")]
    [Address(RVA = "0x3539008", Offset = "0x3539008", VA = "0x3539008")]
    public void Start()
    {
    }

    [Token(Token = "0x60036D5")]
    [Address(RVA = "0x3539028", Offset = "0x3539028", VA = "0x3539028")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x60036D6")]
    [Address(RVA = "0x35390B8", Offset = "0x35390B8", VA = "0x35390B8")]
    public void ChangeState(IPlayerMakeState nextState)
    {
    }

    [Token(Token = "0x60036D7")]
    [Address(RVA = "0x35390C0", Offset = "0x35390C0", VA = "0x35390C0")]
    private void Update()
    {
    }

    [Token(Token = "0x60036D8")]
    [Address(RVA = "0x3539170", Offset = "0x3539170", VA = "0x3539170")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60036D9")]
    [Address(RVA = "0x3539178", Offset = "0x3539178", VA = "0x3539178")]
    public void End()
    {
    }

    [Token(Token = "0x60036DA")]
    [Address(RVA = "0x3539180", Offset = "0x3539180", VA = "0x3539180")]
    public void SetPlayerName(string playerName)
    {
    }

    [Token(Token = "0x60036DB")]
    [Address(RVA = "0x3539188", Offset = "0x3539188", VA = "0x3539188")]
    public void ChangeStateToNameInput()
    {
    }

    [Token(Token = "0x60036DC")]
    [Address(RVA = "0x35391F4", Offset = "0x35391F4", VA = "0x35391F4")]
    public void ChangeStateToConfirm()
    {
    }

    [Token(Token = "0x60036DD")]
    [Address(RVA = "0x3539258", Offset = "0x3539258", VA = "0x3539258")]
    public void ChangeStateToEnd()
    {
    }

    [Token(Token = "0x60036DE")]
    [Address(RVA = "0x35392BC", Offset = "0x35392BC", VA = "0x35392BC")]
    public void ConfirmPlayerMake()
    {
    }

    [Token(Token = "0x60036DF")]
    [Address(RVA = "0x35392D8", Offset = "0x35392D8", VA = "0x35392D8")]
    public void PlayerValidation(Action accept, Action<PlayerMakeValidation.InvalidType> deny)
    {
    }

    [Token(Token = "0x60036E0")]
    [Address(RVA = "0x35393E8", Offset = "0x35393E8", VA = "0x35393E8")]
    public PlayerMakeManager()
    {
    }
  }
}
