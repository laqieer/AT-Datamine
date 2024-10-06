// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.AnimationClipParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014E7")]
  [Serializable]
  public class AnimationClipParam
  {
    [Token(Token = "0x400601B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x400601C")]
    [FieldOffset(Offset = "0x18")]
    [NonSerialized]
    public float TransitionTime;
    [Token(Token = "0x400601D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float TransitionDuration;
    [Token(Token = "0x400601E")]
    [FieldOffset(Offset = "0x20")]
    [NonSerialized]
    public float PlayTime;
    [Token(Token = "0x400601F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float PlayDuration;
    [Token(Token = "0x4006020")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float PlaySpeed;
    [Token(Token = "0x4006021")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public ClipPlayMode PlayMode;

    [Token(Token = "0x17001235")]
    public bool IsEnd
    {
      [Token(Token = "0x6007618"), Address(RVA = "0x43FD784", Offset = "0x43FD784", VA = "0x43FD784")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001236")]
    public bool IsFinish
    {
      [Token(Token = "0x6007619"), Address(RVA = "0x43FD794", Offset = "0x43FD794", VA = "0x43FD794")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x140000FD")]
    public event AnimationClipParam.FinishPlay OnFinishPlay
    {
      [Token(Token = "0x600761A"), Address(RVA = "0x43FD7B4", Offset = "0x43FD7B4", VA = "0x43FD7B4")] add
      {
      }
      [Token(Token = "0x600761B"), Address(RVA = "0x43FD850", Offset = "0x43FD850", VA = "0x43FD850")] remove
      {
      }
    }

    [Token(Token = "0x600761C")]
    [Address(RVA = "0x43FD8EC", Offset = "0x43FD8EC", VA = "0x43FD8EC")]
    public void Reset()
    {
    }

    [Token(Token = "0x600761D")]
    [Address(RVA = "0x43FD8F8", Offset = "0x43FD8F8", VA = "0x43FD8F8")]
    public float UpdatePlay(float deltaTime) => new float();

    [Token(Token = "0x600761E")]
    [Address(RVA = "0x43FD998", Offset = "0x43FD998", VA = "0x43FD998")]
    public float UpdateTransition(float deltaTime) => new float();

    [Token(Token = "0x600761F")]
    [Address(RVA = "0x43FD9D0", Offset = "0x43FD9D0", VA = "0x43FD9D0")]
    public AnimationClipParam()
    {
    }

    [Token(Token = "0x20014E8")]
    public delegate void FinishPlay(AnimationClipParam self);
  }
}
