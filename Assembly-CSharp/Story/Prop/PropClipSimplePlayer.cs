// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropClipSimplePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000665")]
  [AddComponentMenu("Staq/Story/Prop ClipSimplePlayer")]
  [ExecuteAlways]
  public class PropClipSimplePlayer : PropContents<PropElementContainer<PropClipElement>>
  {
    [Token(Token = "0x4001F02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Animator targetAnimator;
    [Token(Token = "0x4001F03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool useIK;
    [Token(Token = "0x4001F04")]
    [FieldOffset(Offset = "0x30")]
    private PropClipElement current;
    [Token(Token = "0x4001F05")]
    [FieldOffset(Offset = "0x38")]
    private PlayableGraph graph;
    [Token(Token = "0x4001F06")]
    [FieldOffset(Offset = "0x48")]
    private AnimationLayerMixerPlayable rootMixer;
    [Token(Token = "0x4001F07")]
    [FieldOffset(Offset = "0x58")]
    private AnimationClipPlayable currentPlayable;

    [Token(Token = "0x17000551")]
    public Animator TargetAnimator
    {
      [Token(Token = "0x60024B7"), Address(RVA = "0x2F33AD8", Offset = "0x2F33AD8", VA = "0x2F33AD8")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x17000552")]
    public bool UseIK
    {
      [Token(Token = "0x60024B8"), Address(RVA = "0x2F33B6C", Offset = "0x2F33B6C", VA = "0x2F33B6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60024B9")]
    [Address(RVA = "0x2F33B74", Offset = "0x2F33B74", VA = "0x2F33B74")]
    public void Awake()
    {
    }

    [Token(Token = "0x60024BA")]
    [Address(RVA = "0x2F33B78", Offset = "0x2F33B78", VA = "0x2F33B78")]
    public void InitializeSystem()
    {
    }

    [Token(Token = "0x60024BB")]
    [Address(RVA = "0x2F33D20", Offset = "0x2F33D20", VA = "0x2F33D20", Slot = "5")]
    public override void Play(params string[] commands)
    {
    }

    [Token(Token = "0x60024BC")]
    [Address(RVA = "0x2F33E5C", Offset = "0x2F33E5C", VA = "0x2F33E5C")]
    private void Play(PropClipElement old, PropClipElement now)
    {
    }

    [Token(Token = "0x60024BD")]
    [Address(RVA = "0x2F33FB8", Offset = "0x2F33FB8", VA = "0x2F33FB8")]
    private void Update()
    {
    }

    [Token(Token = "0x60024BE")]
    [Address(RVA = "0x2F340D8", Offset = "0x2F340D8", VA = "0x2F340D8")]
    public PropClipSimplePlayer()
    {
    }
  }
}
