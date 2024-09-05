// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.TransitionViewStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x200160F")]
  public class TransitionViewStateHandler
  {
    [Token(Token = "0x400646F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<TransitionViewStateHandler.Type, TransitionViewState> states;

    [Token(Token = "0x17001348")]
    public TransitionViewState CurrentState
    {
      [Token(Token = "0x6007CE6"), Address(RVA = "0x21A4F70", Offset = "0x21A4F70", VA = "0x21A4F70")] get
      {
        return (TransitionViewState) null;
      }
      [Token(Token = "0x6007CE7"), Address(RVA = "0x21A4F78", Offset = "0x21A4F78", VA = "0x21A4F78")] private set
      {
      }
    }

    [Token(Token = "0x6007CE8")]
    [Address(RVA = "0x21A47C4", Offset = "0x21A47C4", VA = "0x21A47C4")]
    public TransitionViewStateHandler()
    {
    }

    [Token(Token = "0x6007CE9")]
    [Address(RVA = "0x21A43E4", Offset = "0x21A43E4", VA = "0x21A43E4")]
    public void Setup(FreeMapResourceLoader loader, Transform parent)
    {
    }

    [Token(Token = "0x6007CEA")]
    [Address(RVA = "0x21A474C", Offset = "0x21A474C", VA = "0x21A474C")]
    public void ChangeState(TransitionViewStateHandler.Type type)
    {
    }

    [Token(Token = "0x2001610")]
    public enum Type
    {
      [Token(Token = "0x4006472")] Normal,
      [Token(Token = "0x4006473")] FastTravel,
    }
  }
}
