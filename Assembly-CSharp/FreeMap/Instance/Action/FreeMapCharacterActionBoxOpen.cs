// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionBoxOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001911")]
  public class FreeMapCharacterActionBoxOpen : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C47")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C48")]
    private const string StateFlag = "bBoxOpen";

    [Token(Token = "0x6008E8C")]
    [Address(RVA = "0x4B027B0", Offset = "0x4B027B0", VA = "0x4B027B0", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008E8D")]
    [Address(RVA = "0x4B02810", Offset = "0x4B02810", VA = "0x4B02810", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008E8E")]
    [Address(RVA = "0x4B02890", Offset = "0x4B02890", VA = "0x4B02890", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008E8F")]
    [Address(RVA = "0x4B0290C", Offset = "0x4B0290C", VA = "0x4B0290C", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008E90")]
    [Address(RVA = "0x4B02990", Offset = "0x4B02990", VA = "0x4B02990")]
    public FreeMapCharacterActionBoxOpen()
    {
    }
  }
}
