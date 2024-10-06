// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapTransformHolderList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F6")]
  public class FreeMapTransformHolderList
  {
    [Token(Token = "0x4006427")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<FreeMapUIParamBase, FreeMapUITransformHolder> list;

    [Token(Token = "0x6007C45")]
    [Address(RVA = "0x21A0210", Offset = "0x21A0210", VA = "0x21A0210")]
    public void Add(FreeMapUIParamBase param, FreeMapUITransformHolder holder)
    {
    }

    [Token(Token = "0x6007C46")]
    [Address(RVA = "0x21A02B4", Offset = "0x21A02B4", VA = "0x21A02B4")]
    public void Remove(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007C47")]
    [Address(RVA = "0x21A030C", Offset = "0x21A030C", VA = "0x21A030C")]
    public bool Contains(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6007C48")]
    [Address(RVA = "0x21A0324", Offset = "0x21A0324", VA = "0x21A0324")]
    public FreeMapUITransformHolder TryGet(FreeMapUIParamBase param)
    {
      return (FreeMapUITransformHolder) null;
    }

    [Token(Token = "0x6007C49")]
    [Address(RVA = "0x21A04C4", Offset = "0x21A04C4", VA = "0x21A04C4")]
    public void ReleaseAll()
    {
    }

    [Token(Token = "0x6007C4A")]
    [Address(RVA = "0x21A0514", Offset = "0x21A0514", VA = "0x21A0514")]
    public FreeMapTransformHolderList()
    {
    }
  }
}
