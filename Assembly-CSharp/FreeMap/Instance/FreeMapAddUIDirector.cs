// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapAddUIDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.UI;
using FreeMap.UI.Builder;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x2001902")]
  public class FreeMapAddUIDirector : IFreeMapResourceElement
  {
    [Token(Token = "0x14000125")]
    public event Action<FreeMapUIBase> OnBuild
    {
      [Token(Token = "0x6008E09"), Address(RVA = "0x4AFD068", Offset = "0x4AFD068", VA = "0x4AFD068")] add
      {
      }
      [Token(Token = "0x6008E0A"), Address(RVA = "0x4AFD118", Offset = "0x4AFD118", VA = "0x4AFD118")] remove
      {
      }
    }

    [Token(Token = "0x170016BF")]
    private IFreeMapInstanceUIBuilder UIBuilder
    {
      [Token(Token = "0x6008E0B"), Address(RVA = "0x4AFD1C8", Offset = "0x4AFD1C8", VA = "0x4AFD1C8")] get
      {
        return (IFreeMapInstanceUIBuilder) null;
      }
    }

    [Token(Token = "0x170016C0")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008E0C"), Address(RVA = "0x4AFD1D0", Offset = "0x4AFD1D0", VA = "0x4AFD1D0", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x170016C1")]
    private FreeMapCommonElement Element
    {
      [Token(Token = "0x6008E0D"), Address(RVA = "0x4AFD1D8", Offset = "0x4AFD1D8", VA = "0x4AFD1D8")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x170016C2")]
    private FreeMapUITransformHolder TransformHolder
    {
      [Token(Token = "0x6008E0E"), Address(RVA = "0x4AFD1E0", Offset = "0x4AFD1E0", VA = "0x4AFD1E0")] get
      {
        return (FreeMapUITransformHolder) null;
      }
    }

    [Token(Token = "0x170016C3")]
    private FreeMapIconEventControlElement IconEventElement
    {
      [Token(Token = "0x6008E0F"), Address(RVA = "0x4AFD1E8", Offset = "0x4AFD1E8", VA = "0x4AFD1E8")] get
      {
        return (FreeMapIconEventControlElement) null;
      }
    }

    [Token(Token = "0x170016C4")]
    private FreeMapInstance Target
    {
      [Token(Token = "0x6008E10"), Address(RVA = "0x4AFD1F0", Offset = "0x4AFD1F0", VA = "0x4AFD1F0")] get
      {
        return (FreeMapInstance) null;
      }
    }

    [Token(Token = "0x6008E11")]
    [Address(RVA = "0x4AFD1F8", Offset = "0x4AFD1F8", VA = "0x4AFD1F8")]
    public FreeMapAddUIDirector(
      FreeMapCommonElement element,
      FreeMapInstance target,
      IFreeMapInstanceUIBuilder uiBuilder,
      FreeMapUITransformHolder transformHolder,
      FreeMapIconEventControlElement iconEventElement)
    {
    }

    [Token(Token = "0x6008E12")]
    [Address(RVA = "0x4AFD248", Offset = "0x4AFD248", VA = "0x4AFD248", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008E13")]
    [Address(RVA = "0x4AFD2F0", Offset = "0x4AFD2F0", VA = "0x4AFD2F0", Slot = "6")]
    public void Build()
    {
    }
  }
}
