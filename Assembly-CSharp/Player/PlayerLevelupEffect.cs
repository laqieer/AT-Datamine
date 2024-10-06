// Decompiled with JetBrains decompiler
// Type: Player.PlayerLevelupEffect
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
namespace Player
{
  [Token(Token = "0x20009CA")]
  public class PlayerLevelupEffect : MonoBehaviour
  {
    [Token(Token = "0x4002D36")]
    [FieldOffset(Offset = "0x18")]
    private readonly string InAnimeName;
    [Token(Token = "0x4002D37")]
    [FieldOffset(Offset = "0x20")]
    private readonly string OutAnimeName;
    [Token(Token = "0x4002D38")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002D39")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image unitTexture;
    [Token(Token = "0x4002D3A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text playerName;
    [Token(Token = "0x4002D3B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float showWaitTime;
    [Token(Token = "0x4002D3D")]
    [FieldOffset(Offset = "0x48")]
    private Action callback;

    [Token(Token = "0x170007CF")]
    private bool IsPlaying
    {
      [Token(Token = "0x60037AC"), Address(RVA = "0x3104398", Offset = "0x3104398", VA = "0x3104398")] get
      {
        return new bool();
      }
      [Token(Token = "0x60037AD"), Address(RVA = "0x31043A0", Offset = "0x31043A0", VA = "0x31043A0")] set
      {
      }
    }

    [Token(Token = "0x60037AE")]
    [Address(RVA = "0x31043AC", Offset = "0x31043AC", VA = "0x31043AC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60037AF")]
    [Address(RVA = "0x3104480", Offset = "0x3104480", VA = "0x3104480")]
    public void Play(Action action)
    {
    }

    [Token(Token = "0x60037B0")]
    [Address(RVA = "0x3104438", Offset = "0x3104438", VA = "0x3104438")]
    public void Hide(bool immediate = false)
    {
    }

    [Token(Token = "0x60037B1")]
    [Address(RVA = "0x31044C4", Offset = "0x31044C4", VA = "0x31044C4")]
    protected IEnumerator ExecutePlay() => (IEnumerator) null;

    [Token(Token = "0x60037B2")]
    [Address(RVA = "0x3104554", Offset = "0x3104554", VA = "0x3104554")]
    public PlayerLevelupEffect()
    {
    }
  }
}
