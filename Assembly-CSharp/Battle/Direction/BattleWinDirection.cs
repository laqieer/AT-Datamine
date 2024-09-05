// Decompiled with JetBrains decompiler
// Type: Battle.Direction.BattleWinDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.Direction
{
  [Token(Token = "0x20025C2")]
  public class BattleWinDirection : MonoBehaviour
  {
    [Token(Token = "0x400A26C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController controller;
    [Token(Token = "0x400A26D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton skipButton;

    [Token(Token = "0x170031C2")]
    public bool IsInitialized
    {
      [Token(Token = "0x600E91C"), Address(RVA = "0x4C46FF4", Offset = "0x4C46FF4", VA = "0x4C46FF4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170031C3")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E91D"), Address(RVA = "0x4C47010", Offset = "0x4C47010", VA = "0x4C47010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E91E")]
    [Address(RVA = "0x4C4702C", Offset = "0x4C4702C", VA = "0x4C4702C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600E91F")]
    [Address(RVA = "0x4C470C0", Offset = "0x4C470C0", VA = "0x4C470C0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E920")]
    [Address(RVA = "0x4C47110", Offset = "0x4C47110", VA = "0x4C47110")]
    public void Play(bool shortMode)
    {
    }

    [Token(Token = "0x600E921")]
    [Address(RVA = "0x4C47190", Offset = "0x4C47190", VA = "0x4C47190")]
    private void SkipLastFrame()
    {
    }

    [Token(Token = "0x600E922")]
    [Address(RVA = "0x4C471E4", Offset = "0x4C471E4", VA = "0x4C471E4")]
    public BattleWinDirection()
    {
    }
  }
}
