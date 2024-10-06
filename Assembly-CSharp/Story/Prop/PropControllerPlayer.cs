// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropControllerPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000668")]
  [AddComponentMenu("Staq/Story/Prop ControllerPlayer")]
  [ExecuteAlways]
  public class PropControllerPlayer : PropContents<PropElementsContainer<PropControllerElement>>
  {
    [Token(Token = "0x4001F0E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Animator targetAnimator;

    [Token(Token = "0x17000558")]
    public Animator TargetAnimator
    {
      [Token(Token = "0x60024CD"), Address(RVA = "0x2F34280", Offset = "0x2F34280", VA = "0x2F34280")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x60024CE")]
    [Address(RVA = "0x2F34314", Offset = "0x2F34314", VA = "0x2F34314", Slot = "5")]
    public override void Play(params string[] commands)
    {
    }

    [Token(Token = "0x60024CF")]
    [Address(RVA = "0x2F34474", Offset = "0x2F34474", VA = "0x2F34474")]
    private void PlayAnimation(IEnumerable<PropControllerElement> elements)
    {
    }

    [Token(Token = "0x60024D0")]
    [Address(RVA = "0x2F34744", Offset = "0x2F34744", VA = "0x2F34744")]
    private void PlayAnimation(PropControllerElement element)
    {
    }

    [Token(Token = "0x60024D1")]
    [Address(RVA = "0x2F347DC", Offset = "0x2F347DC", VA = "0x2F347DC")]
    public PropControllerPlayer()
    {
    }
  }
}
