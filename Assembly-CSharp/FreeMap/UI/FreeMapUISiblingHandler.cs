// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUISiblingHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Entity;
using FreeMap.UI.Manager;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001600")]
  public class FreeMapUISiblingHandler
  {
    [Token(Token = "0x400644C")]
    [FieldOffset(Offset = "0x10")]
    private List<FreeMapUIBase> siblingUIList;

    [Token(Token = "0x6007C8F")]
    [Address(RVA = "0x21A2CB8", Offset = "0x21A2CB8", VA = "0x21A2CB8")]
    public void RegisterUI(FreeMapUIBase target)
    {
    }

    [Token(Token = "0x6007C90")]
    [Address(RVA = "0x21A2D60", Offset = "0x21A2D60", VA = "0x21A2D60")]
    public void ErasureUI(FreeMapUIBase target)
    {
    }

    [Token(Token = "0x6007C91")]
    public void RegisterUIFromManager<T>(FreeMapUIManager<T> manager) where T : FreeMapUIBase
    {
    }

    [Token(Token = "0x6007C92")]
    [Address(RVA = "0x21A24C8", Offset = "0x21A24C8", VA = "0x21A24C8")]
    public void Update()
    {
    }

    [Token(Token = "0x6007C93")]
    [Address(RVA = "0x21A1E3C", Offset = "0x21A1E3C", VA = "0x21A1E3C")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007C94")]
    [Address(RVA = "0x21A2DB8", Offset = "0x21A2DB8", VA = "0x21A2DB8")]
    private void SortSibiling()
    {
    }

    [Token(Token = "0x6007C95")]
    [Address(RVA = "0x21A1D38", Offset = "0x21A1D38", VA = "0x21A1D38")]
    public FreeMapUISiblingHandler()
    {
    }
  }
}
