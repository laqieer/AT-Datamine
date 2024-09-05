// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCharacterAnimatorMotion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.Action;
using GameCore.Animation;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018B6")]
  public class FreeMapCharacterAnimatorMotion : IFreeMapCharacterActionController
  {
    [Token(Token = "0x4006B2F")]
    [FieldOffset(Offset = "0x10")]
    private readonly FreeMapCharacterActionAnimatorBase[] MainActions;
    [Token(Token = "0x4006B32")]
    [FieldOffset(Offset = "0x28")]
    protected float walkAnimationSpeedBase;
    [Token(Token = "0x4006B33")]
    [FieldOffset(Offset = "0x2C")]
    protected float runAnimationSpeedBase;

    [Token(Token = "0x1700167F")]
    private FreeMapCharacterActionAnimatorBase CurrentInstance
    {
      [Token(Token = "0x6008C46"), Address(RVA = "0x452C404", Offset = "0x452C404", VA = "0x452C404")] get
      {
        return (FreeMapCharacterActionAnimatorBase) null;
      }
    }

    [Token(Token = "0x17001680")]
    public CharacterMainAction Current
    {
      [Token(Token = "0x6008C47"), Address(RVA = "0x452C438", Offset = "0x452C438", VA = "0x452C438")] private set
      {
      }
      [Token(Token = "0x6008C48"), Address(RVA = "0x452C440", Offset = "0x452C440", VA = "0x452C440")] get
      {
        return new CharacterMainAction();
      }
    }

    [Token(Token = "0x17001681")]
    public FreeMapSideRuntimeAnimatorControl Controller
    {
      [Token(Token = "0x6008C49"), Address(RVA = "0x452C448", Offset = "0x452C448", VA = "0x452C448")] private set
      {
      }
      [Token(Token = "0x6008C4A"), Address(RVA = "0x452C450", Offset = "0x452C450", VA = "0x452C450")] get
      {
        return (FreeMapSideRuntimeAnimatorControl) null;
      }
    }

    [Token(Token = "0x17001682")]
    public float WalkAnimationSpeed
    {
      [Token(Token = "0x6008C4B"), Address(RVA = "0x452C458", Offset = "0x452C458", VA = "0x452C458")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001683")]
    public float RunAnimationSpeed
    {
      [Token(Token = "0x6008C4C"), Address(RVA = "0x452C468", Offset = "0x452C468", VA = "0x452C468")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001684")]
    public float AnimationWalkSpeedRate
    {
      [Token(Token = "0x6008C4D"), Address(RVA = "0x452C478", Offset = "0x452C478", VA = "0x452C478")] set
      {
      }
      [Token(Token = "0x6008C4E"), Address(RVA = "0x452C480", Offset = "0x452C480", VA = "0x452C480")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001685")]
    public float AnimationRunSpeedRate
    {
      [Token(Token = "0x6008C4F"), Address(RVA = "0x452C488", Offset = "0x452C488", VA = "0x452C488")] set
      {
      }
      [Token(Token = "0x6008C50"), Address(RVA = "0x452C490", Offset = "0x452C490", VA = "0x452C490")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001686")]
    public bool IsOneceEnded
    {
      [Token(Token = "0x6008C51"), Address(RVA = "0x452C498", Offset = "0x452C498", VA = "0x452C498")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008C52"), Address(RVA = "0x452C4A0", Offset = "0x452C4A0", VA = "0x452C4A0")] private set
      {
      }
    }

    [Token(Token = "0x6008C53")]
    [Address(RVA = "0x452B96C", Offset = "0x452B96C", VA = "0x452B96C")]
    public FreeMapCharacterAnimatorMotion()
    {
    }

    [Token(Token = "0x6008C54")]
    [Address(RVA = "0x452BEE4", Offset = "0x452BEE4", VA = "0x452BEE4")]
    public void Initialize(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008C55")]
    [Address(RVA = "0x452C4AC", Offset = "0x452C4AC", VA = "0x452C4AC", Slot = "4")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6008C56")]
    [Address(RVA = "0x452BC68", Offset = "0x452BC68", VA = "0x452BC68")]
    public void Play(CharacterMainAction next, bool oneceEndedDetection = false)
    {
    }

    [Token(Token = "0x6008C57")]
    [Address(RVA = "0x452C50C", Offset = "0x452C50C", VA = "0x452C50C")]
    private void OnOneceEnded()
    {
    }

    [Token(Token = "0x6008C58")]
    [Address(RVA = "0x452C518", Offset = "0x452C518", VA = "0x452C518")]
    public void SetAnimationSpeed(float walkSpeed, float runSpeed)
    {
    }

    [Token(Token = "0x6008C59")]
    [Address(RVA = "0x452C520", Offset = "0x452C520", VA = "0x452C520")]
    public void SetAnimationRate(float walkRate, float runRate)
    {
    }

    [Token(Token = "0x6008C5A")]
    [Address(RVA = "0x452C304", Offset = "0x452C304", VA = "0x452C304", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x6008C5B")]
    [Address(RVA = "0x452C528", Offset = "0x452C528", VA = "0x452C528")]
    public FreeMapCharacterActionAnimatorBase GetActionAnimation(CharacterMainAction action)
    {
      return (FreeMapCharacterActionAnimatorBase) null;
    }
  }
}
