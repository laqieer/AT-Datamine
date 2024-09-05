// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionSit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001918")]
  public class FreeMapCharacterActionSit : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C53")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C54")]
    private const string StateFlag = "bSit";

    [Token(Token = "0x6008EB0")]
    [Address(RVA = "0x4B036FC", Offset = "0x4B036FC", VA = "0x4B036FC", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EB1")]
    [Address(RVA = "0x4B0375C", Offset = "0x4B0375C", VA = "0x4B0375C", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008EB2")]
    [Address(RVA = "0x4B037DC", Offset = "0x4B037DC", VA = "0x4B037DC", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008EB3")]
    [Address(RVA = "0x4B03858", Offset = "0x4B03858", VA = "0x4B03858", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008EB4")]
    [Address(RVA = "0x4B038DC", Offset = "0x4B038DC", VA = "0x4B038DC")]
    public FreeMapCharacterActionSit()
    {
    }
  }
}
