// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaVersus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200316B")]
  public class ArenaVersus : MonoBehaviour
  {
    [Token(Token = "0x400D288")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArenaTopSceneBase sceneBase;
    [Token(Token = "0x400D289")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ArenaTeam teamEnemy;
    [Token(Token = "0x400D28A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArenaTeam teamPlayer;
    [Token(Token = "0x400D28B")]
    [FieldOffset(Offset = "0x30")]
    private bool isEnemyInitialize;
    [Token(Token = "0x400D28C")]
    [FieldOffset(Offset = "0x31")]
    private bool isPlayerInitialize;
    [Token(Token = "0x400D28D")]
    [FieldOffset(Offset = "0x34")]
    private int ranking;

    [Token(Token = "0x601349A")]
    [Address(RVA = "0x4A2544C", Offset = "0x4A2544C", VA = "0x4A2544C")]
    public void Initialize(
      int ranking,
      TeamParameter playerTeam,
      TeamParameter enemyTeam,
      bool ishideUnitRank)
    {
    }

    [Token(Token = "0x601349B")]
    [Address(RVA = "0x4A2BAC4", Offset = "0x4A2BAC4", VA = "0x4A2BAC4")]
    public void ButtonVersus()
    {
    }

    [Token(Token = "0x601349C")]
    [Address(RVA = "0x4A2BAF8", Offset = "0x4A2BAF8", VA = "0x4A2BAF8")]
    public void ButtonVersusSkip()
    {
    }

    [Token(Token = "0x601349D")]
    [Address(RVA = "0x4A25554", Offset = "0x4A25554", VA = "0x4A25554")]
    public IEnumerator IsInitialize(Action onFinish) => (IEnumerator) null;

    [Token(Token = "0x601349E")]
    [Address(RVA = "0x4A2BB54", Offset = "0x4A2BB54", VA = "0x4A2BB54")]
    public ArenaVersus()
    {
    }
  }
}
