// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionRun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001917")]
  public class FreeMapCharacterActionRun : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C51")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C52")]
    private const string StateFlag = "bRun";

    [Token(Token = "0x6008EAB")]
    [Address(RVA = "0x4B034BC", Offset = "0x4B034BC", VA = "0x4B034BC", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EAC")]
    [Address(RVA = "0x4B0351C", Offset = "0x4B0351C", VA = "0x4B0351C", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008EAD")]
    [Address(RVA = "0x4B035AC", Offset = "0x4B035AC", VA = "0x4B035AC", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EAE")]
    [Address(RVA = "0x4B03628", Offset = "0x4B03628", VA = "0x4B03628", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008EAF")]
    [Address(RVA = "0x4B036AC", Offset = "0x4B036AC", VA = "0x4B036AC")]
    public FreeMapCharacterActionRun()
    {
    }
  }
}
