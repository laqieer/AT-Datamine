// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemDetailPopupGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008CE")]
  [Obsolete("[非推奨]ItemDetailPopupProviderを使ってください。")]
  public class ItemDetailPopupGenerator : IDisposable
  {
    [Token(Token = "0x17000733")]
    public bool IsLoaded
    {
      [Token(Token = "0x60031EB"), Address(RVA = "0x3C1D39C", Offset = "0x3C1D39C", VA = "0x3C1D39C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60031EC"), Address(RVA = "0x3C1D3A4", Offset = "0x3C1D3A4", VA = "0x3C1D3A4")] private set
      {
      }
    }

    [Token(Token = "0x17000734")]
    public ItemDetailPopupResource Resource
    {
      [Token(Token = "0x60031ED"), Address(RVA = "0x3C1D3B0", Offset = "0x3C1D3B0", VA = "0x3C1D3B0")] get
      {
        return (ItemDetailPopupResource) null;
      }
      [Token(Token = "0x60031EE"), Address(RVA = "0x3C1D3B8", Offset = "0x3C1D3B8", VA = "0x3C1D3B8")] private set
      {
      }
    }

    [Token(Token = "0x60031EF")]
    [Address(RVA = "0x3C1D3C0", Offset = "0x3C1D3C0", VA = "0x3C1D3C0")]
    public IEnumerator LoadAssetAsync(Action onFinish = null) => (IEnumerator) null;

    [Token(Token = "0x60031F0")]
    [Address(RVA = "0x3C1D45C", Offset = "0x3C1D45C", VA = "0x3C1D45C")]
    public void AddNeedAssetBundle()
    {
    }

    [Token(Token = "0x60031F1")]
    [Address(RVA = "0x3C1D560", Offset = "0x3C1D560", VA = "0x3C1D560")]
    public void LoadPrefab()
    {
    }

    [Token(Token = "0x60031F2")]
    [Address(RVA = "0x3C1D7A8", Offset = "0x3C1D7A8", VA = "0x3C1D7A8")]
    public ItemDetailPopup Generate(Transform parent) => (ItemDetailPopup) null;

    [Token(Token = "0x60031F3")]
    [Address(RVA = "0x3C1D864", Offset = "0x3C1D864", VA = "0x3C1D864")]
    public ItemDetailPopup GenerateItemBox(Transform parent) => (ItemDetailPopup) null;

    [Token(Token = "0x60031F4")]
    [Address(RVA = "0x3C1D920", Offset = "0x3C1D920", VA = "0x3C1D920", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60031F5")]
    [Address(RVA = "0x3C1DA0C", Offset = "0x3C1DA0C", VA = "0x3C1DA0C")]
    public ItemDetailPopupGenerator()
    {
    }
  }
}
