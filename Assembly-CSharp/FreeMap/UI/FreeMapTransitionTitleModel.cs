// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapTransitionTitleModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001608")]
  public class FreeMapTransitionTitleModel
  {
    [Token(Token = "0x14000108")]
    public event Action<string> OnPlayShow
    {
      [Token(Token = "0x6007CC7"), Address(RVA = "0x21A4000", Offset = "0x21A4000", VA = "0x21A4000")] add
      {
      }
      [Token(Token = "0x6007CC8"), Address(RVA = "0x21A40B0", Offset = "0x21A40B0", VA = "0x21A40B0")] remove
      {
      }
    }

    [Token(Token = "0x14000109")]
    public event Action<Action> OnPlayHide
    {
      [Token(Token = "0x6007CC9"), Address(RVA = "0x21A4160", Offset = "0x21A4160", VA = "0x21A4160")] add
      {
      }
      [Token(Token = "0x6007CCA"), Address(RVA = "0x21A4210", Offset = "0x21A4210", VA = "0x21A4210")] remove
      {
      }
    }

    [Token(Token = "0x6007CCB")]
    [Address(RVA = "0x21A28F4", Offset = "0x21A28F4", VA = "0x21A28F4")]
    public void Release()
    {
    }

    [Token(Token = "0x6007CCC")]
    [Address(RVA = "0x21A42C0", Offset = "0x21A42C0", VA = "0x21A42C0")]
    public void PlayShow(int areaID)
    {
    }

    [Token(Token = "0x6007CCD")]
    [Address(RVA = "0x21A43A0", Offset = "0x21A43A0", VA = "0x21A43A0")]
    public void PlayHide(Action callback = null)
    {
    }

    [Token(Token = "0x6007CCE")]
    [Address(RVA = "0x21A1CCC", Offset = "0x21A1CCC", VA = "0x21A1CCC")]
    public FreeMapTransitionTitleModel()
    {
    }
  }
}
