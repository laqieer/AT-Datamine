// Decompiled with JetBrains decompiler
// Type: GameCore.Resource.PlayableAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Resource
{
  [Token(Token = "0x2000CAE")]
  public class PlayableAnimator : MonoBehaviour
  {
    [Token(Token = "0x4003915")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator animator;
    [Token(Token = "0x4003916")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayableAnimationParameter> parameterList;
    [Token(Token = "0x4003917")]
    [FieldOffset(Offset = "0x28")]
    private List<string> playableStateNameList;
    [Token(Token = "0x4003918")]
    [FieldOffset(Offset = "0x30")]
    private PlayableAnimatorController playableAnimatorController;

    [Token(Token = "0x17000AB3")]
    private Animator Animator
    {
      [Token(Token = "0x6004923"), Address(RVA = "0x3135094", Offset = "0x3135094", VA = "0x3135094")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x17000AB4")]
    private List<string> PlayableStateNameList
    {
      [Token(Token = "0x6004924"), Address(RVA = "0x3135128", Offset = "0x3135128", VA = "0x3135128")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6004925")]
    [Address(RVA = "0x3135334", Offset = "0x3135334", VA = "0x3135334")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004926")]
    [Address(RVA = "0x31353D4", Offset = "0x31353D4", VA = "0x31353D4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004927")]
    [Address(RVA = "0x3135458", Offset = "0x3135458", VA = "0x3135458")]
    public void Play(string stateName)
    {
    }

    [Token(Token = "0x6004928")]
    [Address(RVA = "0x3135550", Offset = "0x3135550", VA = "0x3135550")]
    private bool TryGetClipData(string stateName, ref PlayableAnimationParameter data)
    {
      return new bool();
    }

    [Token(Token = "0x6004929")]
    [Address(RVA = "0x3135700", Offset = "0x3135700", VA = "0x3135700")]
    public PlayableAnimator()
    {
    }
  }
}
