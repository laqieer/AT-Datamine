// Decompiled with JetBrains decompiler
// Type: Battle.Direction.BattleLoseDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.Direction
{
  [Token(Token = "0x20025BB")]
  public class BattleLoseDirection : MonoBehaviour
  {
    [Token(Token = "0x400A251")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController controller;
    [Token(Token = "0x400A252")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton skipButton;

    [Token(Token = "0x170031B5")]
    public bool IsInitialized
    {
      [Token(Token = "0x600E8F2"), Address(RVA = "0x4C462F8", Offset = "0x4C462F8", VA = "0x4C462F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170031B6")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E8F3"), Address(RVA = "0x4C46314", Offset = "0x4C46314", VA = "0x4C46314")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E8F4")]
    [Address(RVA = "0x4C46330", Offset = "0x4C46330", VA = "0x4C46330")]
    private void Awake()
    {
    }

    [Token(Token = "0x600E8F5")]
    [Address(RVA = "0x4C463C4", Offset = "0x4C463C4", VA = "0x4C463C4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E8F6")]
    [Address(RVA = "0x4C46414", Offset = "0x4C46414", VA = "0x4C46414")]
    public void Play(bool shortMode)
    {
    }

    [Token(Token = "0x600E8F7")]
    [Address(RVA = "0x4C46494", Offset = "0x4C46494", VA = "0x4C46494")]
    private void SkipLastFrame()
    {
    }

    [Token(Token = "0x600E8F8")]
    [Address(RVA = "0x4C464E8", Offset = "0x4C464E8", VA = "0x4C464E8")]
    public BattleLoseDirection()
    {
    }
  }
}
