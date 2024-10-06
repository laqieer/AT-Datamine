// Decompiled with JetBrains decompiler
// Type: Story.Element.ReferenceAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story.Element
{
  [Token(Token = "0x20006AF")]
  public class ReferenceAnimator : MonoBehaviour
  {
    [Token(Token = "0x4001FFF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator myAnimator;

    [Token(Token = "0x17000592")]
    public Animator MyAnimator
    {
      [Token(Token = "0x60025EA"), Address(RVA = "0x2F3F54C", Offset = "0x2F3F54C", VA = "0x2F3F54C")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x60025EB")]
    [Address(RVA = "0x2F3F554", Offset = "0x2F3F554", VA = "0x2F3F554")]
    public ReferenceAnimator()
    {
    }
  }
}
