// Decompiled with JetBrains decompiler
// Type: LoginBonus.IAnimationStateHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AED")]
  public interface IAnimationStateHandle
  {
    [Token(Token = "0x6003E48")]
    void Skip();

    [Token(Token = "0x6003E49")]
    bool IsSkipped();

    [Token(Token = "0x6003E4A")]
    bool IsFinished();

    [Token(Token = "0x6003E4B")]
    IEnumerator WaitForFinished(Action onUpdate = null);
  }
}
