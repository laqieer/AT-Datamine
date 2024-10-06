// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionWalk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001919")]
  public class FreeMapCharacterActionWalk : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C55")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C56")]
    private const string StateFlag = "bWalk";

    [Token(Token = "0x6008EB5")]
    [Address(RVA = "0x4B0392C", Offset = "0x4B0392C", VA = "0x4B0392C", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EB6")]
    [Address(RVA = "0x4B0398C", Offset = "0x4B0398C", VA = "0x4B0398C", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008EB7")]
    [Address(RVA = "0x4B03A1C", Offset = "0x4B03A1C", VA = "0x4B03A1C", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EB8")]
    [Address(RVA = "0x4B03A98", Offset = "0x4B03A98", VA = "0x4B03A98", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008EB9")]
    [Address(RVA = "0x4B03B1C", Offset = "0x4B03B1C", VA = "0x4B03B1C")]
    public FreeMapCharacterActionWalk()
    {
    }
  }
}
