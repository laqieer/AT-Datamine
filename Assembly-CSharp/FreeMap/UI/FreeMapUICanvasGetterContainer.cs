// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUICanvasGetterContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F9")]
  public class FreeMapUICanvasGetterContainer : MonoBehaviour
  {
    [Token(Token = "0x400642F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FreeMapUICanvasGetter icon;
    [Token(Token = "0x4006430")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FreeMapUICanvasGetter transition;
    [Token(Token = "0x4006431")]
    private const int COUNT = 2;

    [Token(Token = "0x17001328")]
    public FreeMapUICanvasGetter IconCanvas
    {
      [Token(Token = "0x6007C57"), Address(RVA = "0x21A0954", Offset = "0x21A0954", VA = "0x21A0954")] get
      {
        return (FreeMapUICanvasGetter) null;
      }
    }

    [Token(Token = "0x17001329")]
    public FreeMapUICanvasGetter TransitionCanvas
    {
      [Token(Token = "0x6007C58"), Address(RVA = "0x21A095C", Offset = "0x21A095C", VA = "0x21A095C")] get
      {
        return (FreeMapUICanvasGetter) null;
      }
    }

    [Token(Token = "0x6007C59")]
    [Address(RVA = "0x21A0964", Offset = "0x21A0964", VA = "0x21A0964")]
    public IEnumerable<FreeMapUICanvasGetter> Elements()
    {
      return (IEnumerable<FreeMapUICanvasGetter>) null;
    }

    [Token(Token = "0x6007C5A")]
    [Address(RVA = "0x21A0A9C", Offset = "0x21A0A9C", VA = "0x21A0A9C")]
    public FreeMapUICanvasGetterContainer()
    {
    }
  }
}
