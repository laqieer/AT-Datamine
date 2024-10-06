// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionAnimatorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001910")]
  public abstract class FreeMapCharacterActionAnimatorBase : 
    IFreeMapCharacterAction<FreeMapCharacterAnimatorMotion>
  {
    [Token(Token = "0x4006C46")]
    [FieldOffset(Offset = "0x10")]
    private System.Action onOneceEnded;

    [Token(Token = "0x6008E82")]
    [Address(RVA = "0x4B026E0", Offset = "0x4B026E0", VA = "0x4B026E0", Slot = "7")]
    public virtual void Enter(FreeMapCharacterAnimatorMotion motion)
    {
    }

    [Token(Token = "0x6008E83")]
    protected abstract void Enter(FreeMapSideRuntimeAnimatorControl controller);

    [Token(Token = "0x6008E84")]
    public abstract bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime);

    [Token(Token = "0x6008E85")]
    [Address(RVA = "0x4B02700", Offset = "0x4B02700", VA = "0x4B02700", Slot = "10")]
    public virtual void Exit(FreeMapCharacterAnimatorMotion motion)
    {
    }

    [Token(Token = "0x6008E86")]
    protected abstract void Exit(FreeMapSideRuntimeAnimatorControl controller);

    [Token(Token = "0x6008E87")]
    [Address(RVA = "0x4B02720", Offset = "0x4B02720", VA = "0x4B02720")]
    protected void BaseChange(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008E88")]
    public abstract bool IsMatchAnimationName(string boolName, string stateName);

    [Token(Token = "0x6008E89")]
    [Address(RVA = "0x4B02774", Offset = "0x4B02774", VA = "0x4B02774")]
    protected void OnOneceEndedTiming()
    {
    }

    [Token(Token = "0x6008E8A")]
    [Address(RVA = "0x4B027A0", Offset = "0x4B027A0", VA = "0x4B027A0")]
    public void SetOneceEndedCallback(System.Action callback)
    {
    }

    [Token(Token = "0x6008E8B")]
    [Address(RVA = "0x4B027A8", Offset = "0x4B027A8", VA = "0x4B027A8")]
    protected FreeMapCharacterActionAnimatorBase()
    {
    }
  }
}
