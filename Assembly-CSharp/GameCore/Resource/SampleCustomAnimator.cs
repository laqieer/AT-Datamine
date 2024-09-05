// Decompiled with JetBrains decompiler
// Type: GameCore.Resource.SampleCustomAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Resource
{
  [Token(Token = "0x2000CB1")]
  public class SampleCustomAnimator : MonoBehaviour
  {
    [Token(Token = "0x400391D")]
    [FieldOffset(Offset = "0x18")]
    private Animator animator;
    [Token(Token = "0x400391E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private OverrideAnimationPairAsset asset;

    [Token(Token = "0x6004932")]
    [Address(RVA = "0x313579C", Offset = "0x313579C", VA = "0x313579C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004933")]
    [Address(RVA = "0x31357F0", Offset = "0x31357F0", VA = "0x31357F0")]
    private void ApplyOverrideAsset()
    {
    }

    [Token(Token = "0x6004934")]
    [Address(RVA = "0x31357FC", Offset = "0x31357FC", VA = "0x31357FC")]
    public SampleCustomAnimator()
    {
    }
  }
}
