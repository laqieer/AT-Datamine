// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.InOutFaderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C4")]
  public abstract class InOutFaderBase : MonoBehaviour, IInOutFader
  {
    [Token(Token = "0x6013DEB")]
    public abstract void Initialize(Action onFinish = null);

    [Token(Token = "0x6013DEC")]
    public abstract void Open(Action onFinish = null);

    [Token(Token = "0x6013DED")]
    public abstract void Close(Action onFinish = null);

    [Token(Token = "0x6013DEE")]
    [Address(RVA = "0x1AE9800", Offset = "0x1AE9800", VA = "0x1AE9800")]
    protected InOutFaderBase()
    {
    }
  }
}
