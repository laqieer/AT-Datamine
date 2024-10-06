// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.BaseSimpleDuelAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002551")]
  public abstract class BaseSimpleDuelAction : IDuelAction
  {
    [Token(Token = "0x400A079")]
    [FieldOffset(Offset = "0x18")]
    protected DuelData duelData;
    [Token(Token = "0x400A07A")]
    [FieldOffset(Offset = "0x20")]
    protected ActionData actionData;
    [Token(Token = "0x400A07B")]
    [FieldOffset(Offset = "0x28")]
    protected IDirector mainDirector;

    [Token(Token = "0x17003179")]
    public virtual float TimeScale
    {
      [Token(Token = "0x600E64E"), Address(RVA = "0x486ED54", Offset = "0x486ED54", VA = "0x486ED54", Slot = "10")] get
      {
        return new float();
      }
      [Token(Token = "0x600E64F"), Address(RVA = "0x486ED5C", Offset = "0x486ED5C", VA = "0x486ED5C", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x1400013A")]
    public event OnCompletedAction OnComplete
    {
      [Token(Token = "0x600E650"), Address(RVA = "0x486ED64", Offset = "0x486ED64", VA = "0x486ED64", Slot = "4")] add
      {
      }
      [Token(Token = "0x600E651"), Address(RVA = "0x486EE00", Offset = "0x486EE00", VA = "0x486EE00", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x600E652")]
    [Address(RVA = "0x486EE9C", Offset = "0x486EE9C", VA = "0x486EE9C", Slot = "12")]
    public virtual void Initialize(
      DuelData data,
      ActionData targetActionData,
      IDirector mainDirector)
    {
    }

    [Token(Token = "0x600E653")]
    public abstract void RequestStaging();

    [Token(Token = "0x600E654")]
    [Address(RVA = "0x486EEA8", Offset = "0x486EEA8", VA = "0x486EEA8")]
    protected void DispatchComplete()
    {
    }

    [Token(Token = "0x600E655")]
    [Address(RVA = "0x486EEE4", Offset = "0x486EEE4", VA = "0x486EEE4", Slot = "14")]
    protected virtual void CompleteInternal()
    {
    }

    [Token(Token = "0x600E656")]
    [Address(RVA = "0x486EEE8", Offset = "0x486EEE8", VA = "0x486EEE8")]
    protected bool ShowStatusEffect(ActionTargetResultData result, bool moveCameraToTarget)
    {
      return new bool();
    }

    [Token(Token = "0x600E657")]
    [Address(RVA = "0x486F6F4", Offset = "0x486F6F4", VA = "0x486F6F4")]
    protected void ShowDamageToTarget()
    {
    }

    [Token(Token = "0x600E658")]
    [Address(RVA = "0x4870104", Offset = "0x4870104", VA = "0x4870104")]
    protected BaseSimpleDuelAction()
    {
    }
  }
}
