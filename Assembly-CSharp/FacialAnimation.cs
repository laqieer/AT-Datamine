// Decompiled with JetBrains decompiler
// Type: FacialAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Home.LipSync;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000221")]
public class FacialAnimation : MonoBehaviour
{
  [Token(Token = "0x4000CAC")]
  [FieldOffset(Offset = "0x18")]
  private FacialAnimationSet set;
  [Token(Token = "0x4000CAD")]
  [FieldOffset(Offset = "0x20")]
  private PlayableGraph graph;
  [Token(Token = "0x4000CAE")]
  [FieldOffset(Offset = "0x30")]
  private AnimationLayerMixerPlayable layer;
  [Token(Token = "0x4000CAF")]
  [FieldOffset(Offset = "0x40")]
  private AnimationMixerPlayable faceMixer;
  [Token(Token = "0x4000CB0")]
  [FieldOffset(Offset = "0x50")]
  private AnimationMixerPlayable blinkMixer;
  [Token(Token = "0x4000CB1")]
  [FieldOffset(Offset = "0x60")]
  private AnimationMixerPlayable lipMixer;
  [Token(Token = "0x4000CB8")]
  [FieldOffset(Offset = "0x88")]
  private float BaseTransitionTime;
  [Token(Token = "0x4000CB9")]
  [FieldOffset(Offset = "0x8C")]
  private float BaseLipTransitionTime;
  [Token(Token = "0x4000CBA")]
  [FieldOffset(Offset = "0x90")]
  private float BaseLipClipDuration;
  [Token(Token = "0x4000CBB")]
  [FieldOffset(Offset = "0x94")]
  private float LipPlaySpeed;
  [Token(Token = "0x4000CBC")]
  [FieldOffset(Offset = "0x98")]
  private float BaseBlinkClipDuration;
  [Token(Token = "0x4000CBD")]
  [FieldOffset(Offset = "0x9C")]
  private float BlinkPlaySpeed;

  [Token(Token = "0x17000122")]
  private int FacialIndex
  {
    [Token(Token = "0x6000D72"), Address(RVA = "0x1C86418", Offset = "0x1C86418", VA = "0x1C86418")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D73"), Address(RVA = "0x1C86420", Offset = "0x1C86420", VA = "0x1C86420")] set
    {
    }
  }

  [Token(Token = "0x17000123")]
  private int PlayingFacialIndex
  {
    [Token(Token = "0x6000D74"), Address(RVA = "0x1C86428", Offset = "0x1C86428", VA = "0x1C86428")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D75"), Address(RVA = "0x1C86430", Offset = "0x1C86430", VA = "0x1C86430")] set
    {
    }
  }

  [Token(Token = "0x17000124")]
  private int BlinkIndex
  {
    [Token(Token = "0x6000D76"), Address(RVA = "0x1C86438", Offset = "0x1C86438", VA = "0x1C86438")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D77"), Address(RVA = "0x1C86440", Offset = "0x1C86440", VA = "0x1C86440")] set
    {
    }
  }

  [Token(Token = "0x17000125")]
  private int PlayingBlinkIndex
  {
    [Token(Token = "0x6000D78"), Address(RVA = "0x1C86448", Offset = "0x1C86448", VA = "0x1C86448")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D79"), Address(RVA = "0x1C86450", Offset = "0x1C86450", VA = "0x1C86450")] set
    {
    }
  }

  [Token(Token = "0x17000126")]
  private int LipIndex
  {
    [Token(Token = "0x6000D7A"), Address(RVA = "0x1C86458", Offset = "0x1C86458", VA = "0x1C86458")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D7B"), Address(RVA = "0x1C86460", Offset = "0x1C86460", VA = "0x1C86460")] set
    {
    }
  }

  [Token(Token = "0x17000127")]
  private int PlayingLipIndex
  {
    [Token(Token = "0x6000D7C"), Address(RVA = "0x1C86468", Offset = "0x1C86468", VA = "0x1C86468")] get
    {
      return new int();
    }
    [Token(Token = "0x6000D7D"), Address(RVA = "0x1C86470", Offset = "0x1C86470", VA = "0x1C86470")] set
    {
    }
  }

  [Token(Token = "0x17000128")]
  private bool IsInFacialTransition
  {
    [Token(Token = "0x6000D7E"), Address(RVA = "0x1C86478", Offset = "0x1C86478", VA = "0x1C86478")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D7F"), Address(RVA = "0x1C86480", Offset = "0x1C86480", VA = "0x1C86480")] set
    {
    }
  }

  [Token(Token = "0x17000129")]
  private bool IsInBlinkTransition
  {
    [Token(Token = "0x6000D80"), Address(RVA = "0x1C8648C", Offset = "0x1C8648C", VA = "0x1C8648C")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D81"), Address(RVA = "0x1C86494", Offset = "0x1C86494", VA = "0x1C86494")] set
    {
    }
  }

  [Token(Token = "0x1700012A")]
  private bool IsInLipTransition
  {
    [Token(Token = "0x6000D82"), Address(RVA = "0x1C864A0", Offset = "0x1C864A0", VA = "0x1C864A0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D83"), Address(RVA = "0x1C864A8", Offset = "0x1C864A8", VA = "0x1C864A8")] set
    {
    }
  }

  [Token(Token = "0x1700012B")]
  public bool IsPlayingLipAnimation
  {
    [Token(Token = "0x6000D84"), Address(RVA = "0x1C864B4", Offset = "0x1C864B4", VA = "0x1C864B4")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D85"), Address(RVA = "0x1C864BC", Offset = "0x1C864BC", VA = "0x1C864BC")] set
    {
    }
  }

  [Token(Token = "0x1700012C")]
  public bool IsPlayingBlinkAnimation
  {
    [Token(Token = "0x6000D86"), Address(RVA = "0x1C864C8", Offset = "0x1C864C8", VA = "0x1C864C8")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000D87"), Address(RVA = "0x1C864D0", Offset = "0x1C864D0", VA = "0x1C864D0")] set
    {
    }
  }

  [Token(Token = "0x6000D88")]
  [Address(RVA = "0x1C864DC", Offset = "0x1C864DC", VA = "0x1C864DC")]
  public void OnEnable()
  {
  }

  [Token(Token = "0x6000D89")]
  [Address(RVA = "0x1C864E8", Offset = "0x1C864E8", VA = "0x1C864E8")]
  public void Initialize(FacialAnimationSet set, Animator targetAnimator)
  {
  }

  [Token(Token = "0x6000D8A")]
  [Address(RVA = "0x1C86710", Offset = "0x1C86710", VA = "0x1C86710")]
  private void InitializeFaceMixer(FacialAnimationSet set)
  {
  }

  [Token(Token = "0x6000D8B")]
  [Address(RVA = "0x1C8687C", Offset = "0x1C8687C", VA = "0x1C8687C")]
  private void InitializeBlinkMixer(FacialAnimationSet set)
  {
  }

  [Token(Token = "0x6000D8C")]
  [Address(RVA = "0x1C86B24", Offset = "0x1C86B24", VA = "0x1C86B24")]
  private void InitializeLipMixer(FacialAnimationSet set)
  {
  }

  [Token(Token = "0x6000D8D")]
  [Address(RVA = "0x1C86F7C", Offset = "0x1C86F7C", VA = "0x1C86F7C")]
  public void SetFacialMotion(string tag)
  {
  }

  [Token(Token = "0x6000D8E")]
  [Address(RVA = "0x1C85D64", Offset = "0x1C85D64", VA = "0x1C85D64")]
  public void SetBlinkType(BlinkType blinkType)
  {
  }

  [Token(Token = "0x6000D8F")]
  [Address(RVA = "0x1C87078", Offset = "0x1C87078", VA = "0x1C87078")]
  public void SetLipType(LipType lipType)
  {
  }

  [Token(Token = "0x6000D90")]
  [Address(RVA = "0x1C87080", Offset = "0x1C87080", VA = "0x1C87080")]
  public LipType GetLipType() => new LipType();

  [Token(Token = "0x6000D91")]
  [Address(RVA = "0x1C87088", Offset = "0x1C87088", VA = "0x1C87088")]
  public void SetBaseTransitionTime(float time)
  {
  }

  [Token(Token = "0x6000D92")]
  [Address(RVA = "0x1C87090", Offset = "0x1C87090", VA = "0x1C87090")]
  public void SetBaseLipTransitionTime(float time)
  {
  }

  [Token(Token = "0x6000D93")]
  [Address(RVA = "0x1C87098", Offset = "0x1C87098", VA = "0x1C87098")]
  public void SetLipPlaySpeed(float speed)
  {
  }

  [Token(Token = "0x6000D94")]
  [Address(RVA = "0x1C870A0", Offset = "0x1C870A0", VA = "0x1C870A0")]
  public void SetBlinkPlaySpeed(float speed)
  {
  }

  [Token(Token = "0x6000D95")]
  [Address(RVA = "0x1C86DCC", Offset = "0x1C86DCC", VA = "0x1C86DCC")]
  private void InitializeFace()
  {
  }

  [Token(Token = "0x6000D96")]
  [Address(RVA = "0x1C86EF4", Offset = "0x1C86EF4", VA = "0x1C86EF4")]
  private void InitializeLip()
  {
  }

  [Token(Token = "0x6000D97")]
  [Address(RVA = "0x1C86E6C", Offset = "0x1C86E6C", VA = "0x1C86E6C")]
  private void InitializeBlink()
  {
  }

  [Token(Token = "0x6000D98")]
  [Address(RVA = "0x1C87158", Offset = "0x1C87158", VA = "0x1C87158")]
  private IEnumerator TransitionFace() => (IEnumerator) null;

  [Token(Token = "0x6000D99")]
  [Address(RVA = "0x1C871E8", Offset = "0x1C871E8", VA = "0x1C871E8")]
  private IEnumerator TransitionBlink() => (IEnumerator) null;

  [Token(Token = "0x6000D9A")]
  [Address(RVA = "0x1C87278", Offset = "0x1C87278", VA = "0x1C87278")]
  private IEnumerator TransitionLip() => (IEnumerator) null;

  [Token(Token = "0x6000D9B")]
  [Address(RVA = "0x1C85D6C", Offset = "0x1C85D6C", VA = "0x1C85D6C")]
  public void Transition()
  {
  }

  [Token(Token = "0x6000D9C")]
  [Address(RVA = "0x1C870A8", Offset = "0x1C870A8", VA = "0x1C870A8")]
  private void ResetMixer(AnimationMixerPlayable mixerPlayable)
  {
  }

  [Token(Token = "0x6000D9D")]
  [Address(RVA = "0x1C86F94", Offset = "0x1C86F94", VA = "0x1C86F94")]
  private int TagToIndex(string tag) => new int();

  [Token(Token = "0x6000D9E")]
  [Address(RVA = "0x1C87310", Offset = "0x1C87310", VA = "0x1C87310")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000D9F")]
  [Address(RVA = "0x1C8731C", Offset = "0x1C8731C", VA = "0x1C8731C")]
  public FacialAnimation()
  {
  }
}
