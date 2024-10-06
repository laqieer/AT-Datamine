// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaBookPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Scenes.Story.Facility.Book;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EA7")]
  [MoonSharpUserData]
  public class Adv2LuaBookPopup : LuaSignal
  {
    [Token(Token = "0x40112F4")]
    [FieldOffset(Offset = "0x18")]
    private Adv2ProjectFilePlayer advPlayer;
    [Token(Token = "0x40112F5")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40112F6")]
    [FieldOffset(Offset = "0x28")]
    private Transform parent;
    [Token(Token = "0x40112F7")]
    [FieldOffset(Offset = "0x30")]
    private BookRentalPopup rentalPopup;
    [Token(Token = "0x40112F8")]
    [FieldOffset(Offset = "0x38")]
    private Adv2LuaBookPopup.ResultValue result;

    [Token(Token = "0x170051C6")]
    public int Result
    {
      [Token(Token = "0x60193AB"), Address(RVA = "0x2FED728", Offset = "0x2FED728", VA = "0x2FED728")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60193AC")]
    [Address(RVA = "0x2FED730", Offset = "0x2FED730", VA = "0x2FED730")]
    public Adv2LuaBookPopup(Adv2ProjectFilePlayer advPlayer, Transform parent)
    {
    }

    [Token(Token = "0x60193AD")]
    [Address(RVA = "0x2FED8E4", Offset = "0x2FED8E4", VA = "0x2FED8E4")]
    public void PreLoad()
    {
    }

    [Token(Token = "0x60193AE")]
    [Address(RVA = "0x2FED910", Offset = "0x2FED910", VA = "0x2FED910")]
    public void Load()
    {
    }

    [Token(Token = "0x60193AF")]
    [Address(RVA = "0x2FEDA2C", Offset = "0x2FEDA2C", VA = "0x2FEDA2C")]
    private void OnInstantiated(BookRentalPopup popup, Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x60193B0")]
    [Address(RVA = "0x2FEDC10", Offset = "0x2FEDC10", VA = "0x2FEDC10")]
    public void Set(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x60193B1")]
    [Address(RVA = "0x2FEDC74", Offset = "0x2FEDC74", VA = "0x2FEDC74")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60193B2")]
    [Address(RVA = "0x2FEDC90", Offset = "0x2FEDC90", VA = "0x2FEDC90")]
    public void SetFlavour(string flavour)
    {
    }

    [Token(Token = "0x60193B3")]
    [Address(RVA = "0x2FEDCC8", Offset = "0x2FEDCC8", VA = "0x2FEDCC8")]
    public void SetPositiveButton(string text)
    {
    }

    [Token(Token = "0x60193B4")]
    [Address(RVA = "0x2FEDCAC", Offset = "0x2FEDCAC", VA = "0x2FEDCAC")]
    public void SetCount(int num, int max)
    {
    }

    [Token(Token = "0x60193B5")]
    [Address(RVA = "0x2FEDD5C", Offset = "0x2FEDD5C", VA = "0x2FEDD5C")]
    public void Open()
    {
    }

    [Token(Token = "0x60193B6")]
    [Address(RVA = "0x2FEDD80", Offset = "0x2FEDD80", VA = "0x2FEDD80")]
    public void Close()
    {
    }

    [Token(Token = "0x2003EA8")]
    private enum ResultValue
    {
      [Token(Token = "0x40112FC")] Negative = -1, // 0xFFFFFFFF
      [Token(Token = "0x40112FA")] None = 0,
      [Token(Token = "0x40112FB")] Positive = 1,
    }
  }
}
