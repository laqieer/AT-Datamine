// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindAffectedBoneAnimationStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F0D")]
  public class WindAffectedBoneAnimationStack : IDisposable
  {
    [Token(Token = "0x17005210")]
    public Stack<WindCommonParameter> AnimationStack
    {
      [Token(Token = "0x6019797"), Address(RVA = "0x3741E54", Offset = "0x3741E54", VA = "0x3741E54")] get
      {
        return (Stack<WindCommonParameter>) null;
      }
      [Token(Token = "0x6019798"), Address(RVA = "0x3741E5C", Offset = "0x3741E5C", VA = "0x3741E5C")] set
      {
      }
    }

    [Token(Token = "0x17005211")]
    public WindAffectedBone WindAffectedBone
    {
      [Token(Token = "0x6019799"), Address(RVA = "0x3741E64", Offset = "0x3741E64", VA = "0x3741E64")] get
      {
        return (WindAffectedBone) null;
      }
      [Token(Token = "0x601979A"), Address(RVA = "0x3741E6C", Offset = "0x3741E6C", VA = "0x3741E6C")] set
      {
      }
    }

    [Token(Token = "0x601979B")]
    [Address(RVA = "0x3741E74", Offset = "0x3741E74", VA = "0x3741E74", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x601979C")]
    [Address(RVA = "0x3741EDC", Offset = "0x3741EDC", VA = "0x3741EDC")]
    public WindAffectedBoneAnimationStack()
    {
    }
  }
}
