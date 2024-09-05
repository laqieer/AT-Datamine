// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionPickUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001916")]
  public class FreeMapCharacterActionPickUp : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C4F")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C50")]
    private const string StateFlag = "bPickUp";

    [Token(Token = "0x6008EA6")]
    [Address(RVA = "0x4B0328C", Offset = "0x4B0328C", VA = "0x4B0328C", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EA7")]
    [Address(RVA = "0x4B032EC", Offset = "0x4B032EC", VA = "0x4B032EC", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008EA8")]
    [Address(RVA = "0x4B0336C", Offset = "0x4B0336C", VA = "0x4B0336C", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EA9")]
    [Address(RVA = "0x4B033E8", Offset = "0x4B033E8", VA = "0x4B033E8", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008EAA")]
    [Address(RVA = "0x4B0346C", Offset = "0x4B0346C", VA = "0x4B0346C")]
    public FreeMapCharacterActionPickUp()
    {
    }
  }
}
