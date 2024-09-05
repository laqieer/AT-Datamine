// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.MovableMobAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Animation;
using GameCore.Animation;
using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

#nullable disable
namespace Area.MovableMob
{
  [Token(Token = "0x2002825")]
  public class MovableMobAnimator : IPropEventSubject
  {
    [Token(Token = "0x400AB42")]
    [FieldOffset(Offset = "0x10")]
    protected Animator targetAnimator;
    [Token(Token = "0x400AB43")]
    [FieldOffset(Offset = "0x18")]
    protected PlayableGraph graph;
    [Token(Token = "0x400AB44")]
    [FieldOffset(Offset = "0x28")]
    protected AnimationMixerPlayable rootMixer;

    [Token(Token = "0x1700378A")]
    public PlayableGraph RootGraph
    {
      [Token(Token = "0x600FCAC"), Address(RVA = "0x4425B44", Offset = "0x4425B44", VA = "0x4425B44")] get
      {
        return new PlayableGraph();
      }
    }

    [Token(Token = "0x1700378B")]
    protected AnimationClipControl ClipControl
    {
      [Token(Token = "0x600FCAD"), Address(RVA = "0x4425B50", Offset = "0x4425B50", VA = "0x4425B50")] set
      {
      }
      [Token(Token = "0x600FCAE"), Address(RVA = "0x4425B58", Offset = "0x4425B58", VA = "0x4425B58")] get
      {
        return (AnimationClipControl) null;
      }
    }

    [Token(Token = "0x1700378C")]
    protected AnimationClipParam ClipParam
    {
      [Token(Token = "0x600FCAF"), Address(RVA = "0x4425B60", Offset = "0x4425B60", VA = "0x4425B60")] set
      {
      }
      [Token(Token = "0x600FCB0"), Address(RVA = "0x4425B68", Offset = "0x4425B68", VA = "0x4425B68")] get
      {
        return (AnimationClipParam) null;
      }
    }

    [Token(Token = "0x1700378D")]
    private PropEventSender EventSender
    {
      [Token(Token = "0x600FCB1"), Address(RVA = "0x4425B70", Offset = "0x4425B70", VA = "0x4425B70")] set
      {
      }
      [Token(Token = "0x600FCB2"), Address(RVA = "0x4425B78", Offset = "0x4425B78", VA = "0x4425B78")] get
      {
        return (PropEventSender) null;
      }
    }

    [Token(Token = "0x1700378E")]
    public OverrideIKGoal OverrideIK
    {
      [Token(Token = "0x600FCB3"), Address(RVA = "0x4425B80", Offset = "0x4425B80", VA = "0x4425B80")] private set
      {
      }
      [Token(Token = "0x600FCB4"), Address(RVA = "0x4425B88", Offset = "0x4425B88", VA = "0x4425B88")] get
      {
        return (OverrideIKGoal) null;
      }
    }

    [Token(Token = "0x600FCB5")]
    [Address(RVA = "0x4425B90", Offset = "0x4425B90", VA = "0x4425B90")]
    public void Initialize(Animator target)
    {
    }

    [Token(Token = "0x600FCB6")]
    [Address(RVA = "0x4425DBC", Offset = "0x4425DBC", VA = "0x4425DBC")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x600FCB7")]
    [Address(RVA = "0x4425E20", Offset = "0x4425E20", VA = "0x4425E20")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600FCB8")]
    [Address(RVA = "0x4425E70", Offset = "0x4425E70", VA = "0x4425E70")]
    public void Play(AnimationClip clip, ClipPlayMode clipPlayMode = ClipPlayMode.Loop)
    {
    }

    [Token(Token = "0x600FCB9")]
    [Address(RVA = "0x4425FA8", Offset = "0x4425FA8", VA = "0x4425FA8", Slot = "4")]
    public void Subscribe(IPropEventObserver observer)
    {
    }

    [Token(Token = "0x600FCBA")]
    [Address(RVA = "0x4426040", Offset = "0x4426040", VA = "0x4426040")]
    public MovableMobAnimator()
    {
    }
  }
}
