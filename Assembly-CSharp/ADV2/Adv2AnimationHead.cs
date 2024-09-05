// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2AnimationHead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E06")]
  [ExecuteAlways]
  [RequireComponent(typeof (Adv2LinkageAnimation))]
  public class Adv2AnimationHead : MonoBehaviour
  {
    [Token(Token = "0x4011002")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Adv2LinkageAnimation targetComponent;
    [Token(Token = "0x4011003")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected string linkTag;
    [Token(Token = "0x4011004")]
    [FieldOffset(Offset = "0x28")]
    protected string playingClipTag;
    [Token(Token = "0x4011005")]
    [FieldOffset(Offset = "0x30")]
    protected string playingAnimationTag;
    [Token(Token = "0x4011006")]
    [FieldOffset(Offset = "0x38")]
    protected Adv2Manager.OnProccessSignal signal;

    [Token(Token = "0x6018F53")]
    [Address(RVA = "0x2CB498C", Offset = "0x2CB498C", VA = "0x2CB498C")]
    public static Adv2AnimationHead AddComponent(Adv2LinkageAnimation target, string linkageTag)
    {
      return (Adv2AnimationHead) null;
    }

    [Token(Token = "0x6018F54")]
    [Address(RVA = "0x2CB4A78", Offset = "0x2CB4A78", VA = "0x2CB4A78")]
    public void PlayMotion(
      string animationTag,
      float transitionDuration,
      float playSpeed,
      bool loop)
    {
    }

    [Token(Token = "0x6018F55")]
    [Address(RVA = "0x2CB4B18", Offset = "0x2CB4B18", VA = "0x2CB4B18")]
    public void StopMotion()
    {
    }

    [Token(Token = "0x6018F56")]
    [Address(RVA = "0x2CB53A8", Offset = "0x2CB53A8", VA = "0x2CB53A8")]
    public Adv2AnimationHead()
    {
    }
  }
}
