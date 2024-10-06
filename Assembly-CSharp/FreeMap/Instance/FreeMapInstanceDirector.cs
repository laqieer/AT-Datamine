// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapInstanceDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.UI.Builder;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018DF")]
  public class FreeMapInstanceDirector : IFreeMapResourceElement
  {
    [Token(Token = "0x14000120")]
    public event Action<FreeMapInstance, FreeMapUIBase> OnCreate
    {
      [Token(Token = "0x6008D3E"), Address(RVA = "0x4533114", Offset = "0x4533114", VA = "0x4533114")] add
      {
      }
      [Token(Token = "0x6008D3F"), Address(RVA = "0x45331C4", Offset = "0x45331C4", VA = "0x45331C4")] remove
      {
      }
    }

    [Token(Token = "0x170016A7")]
    private IFreeMapInstanceBuilder Builder
    {
      [Token(Token = "0x6008D40"), Address(RVA = "0x4533274", Offset = "0x4533274", VA = "0x4533274")] get
      {
        return (IFreeMapInstanceBuilder) null;
      }
    }

    [Token(Token = "0x170016A8")]
    private IFreeMapInstanceUIBuilder UIBuilder
    {
      [Token(Token = "0x6008D41"), Address(RVA = "0x453327C", Offset = "0x453327C", VA = "0x453327C")] get
      {
        return (IFreeMapInstanceUIBuilder) null;
      }
    }

    [Token(Token = "0x170016A9")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008D42"), Address(RVA = "0x4533284", Offset = "0x4533284", VA = "0x4533284", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x170016AA")]
    private FreeMapCommonElement Element
    {
      [Token(Token = "0x6008D43"), Address(RVA = "0x4533328", Offset = "0x4533328", VA = "0x4533328")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x170016AB")]
    private FreeMapIconEventControlElement IconEventElement
    {
      [Token(Token = "0x6008D44"), Address(RVA = "0x4533330", Offset = "0x4533330", VA = "0x4533330")] get
      {
        return (FreeMapIconEventControlElement) null;
      }
    }

    [Token(Token = "0x6008D45")]
    [Address(RVA = "0x4533338", Offset = "0x4533338", VA = "0x4533338")]
    public FreeMapInstanceDirector(
      FreeMapCommonElement element,
      IFreeMapInstanceBuilder builder,
      IFreeMapInstanceUIBuilder uiBuilder = null,
      FreeMapIconEventControlElement iconEventElement = null)
    {
    }

    [Token(Token = "0x6008D46")]
    [Address(RVA = "0x4533378", Offset = "0x4533378", VA = "0x4533378", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008D47")]
    [Address(RVA = "0x4533590", Offset = "0x4533590", VA = "0x4533590", Slot = "6")]
    public void Build()
    {
    }
  }
}
