// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapClipActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x200190C")]
  public abstract class FreeMapClipActionBase : 
    IFreeMapCharacterAction<FreeMapCharacterClipMotion>,
    IFreeMapClipActionHandler
  {
    [Token(Token = "0x170016D3")]
    protected abstract List<AnimationClipParam> ClipFiles { [Token(Token = "0x6008E6E")] get; }

    [Token(Token = "0x170016D4")]
    public bool IsFinish
    {
      [Token(Token = "0x6008E6F"), Address(RVA = "0x4B01C40", Offset = "0x4B01C40", VA = "0x4B01C40")] private set
      {
      }
      [Token(Token = "0x6008E70"), Address(RVA = "0x4B01C4C", Offset = "0x4B01C4C", VA = "0x4B01C4C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008E71")]
    [Address(RVA = "0x4B01C54", Offset = "0x4B01C54", VA = "0x4B01C54", Slot = "10")]
    public virtual void Enter(FreeMapCharacterClipMotion motion)
    {
    }

    [Token(Token = "0x6008E72")]
    [Address(RVA = "0x4B01D24", Offset = "0x4B01D24", VA = "0x4B01D24", Slot = "11")]
    public virtual bool Execute(FreeMapCharacterClipMotion motion, float deltaTime) => new bool();

    [Token(Token = "0x6008E73")]
    [Address(RVA = "0x4B01F48", Offset = "0x4B01F48", VA = "0x4B01F48", Slot = "12")]
    public virtual void Exit(FreeMapCharacterClipMotion motion)
    {
    }

    [Token(Token = "0x6008E74")]
    [Address(RVA = "0x4B02104", Offset = "0x4B02104", VA = "0x4B02104", Slot = "7")]
    public IEnumerator WaitCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6008E75")]
    [Address(RVA = "0x4B02194", Offset = "0x4B02194", VA = "0x4B02194")]
    protected static AnimationClipParam CreateParam(
      string name,
      ClipPlayMode playMode,
      float transitionDuration = 0.0f,
      float playTime = 0.0f,
      float playSpeed = 1f)
    {
      return (AnimationClipParam) null;
    }

    [Token(Token = "0x6008E76")]
    [Address(RVA = "0x4B02240", Offset = "0x4B02240", VA = "0x4B02240")]
    protected FreeMapClipActionBase()
    {
    }
  }
}
