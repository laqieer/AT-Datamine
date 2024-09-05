// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionIdle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001915")]
  public class FreeMapCharacterActionIdle : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C4E")]
    public const string StateName = "Idl";

    [Token(Token = "0x6008EA1")]
    [Address(RVA = "0x4B03158", Offset = "0x4B03158", VA = "0x4B03158", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EA2")]
    [Address(RVA = "0x4B03174", Offset = "0x4B03174", VA = "0x4B03174", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008EA3")]
    [Address(RVA = "0x4B0320C", Offset = "0x4B0320C", VA = "0x4B0320C", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EA4")]
    [Address(RVA = "0x4B03238", Offset = "0x4B03238", VA = "0x4B03238", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008EA5")]
    [Address(RVA = "0x4B03284", Offset = "0x4B03284", VA = "0x4B03284")]
    public FreeMapCharacterActionIdle()
    {
    }
  }
}
