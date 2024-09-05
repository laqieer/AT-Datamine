// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2BookListWithTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Scenes.Story.Facility.Book;
using System.Collections;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003E9F")]
  [MoonSharpUserData]
  public class Adv2BookListWithTab : LuaSignal
  {
    [Token(Token = "0x40112D4")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40112D5")]
    [FieldOffset(Offset = "0x20")]
    private BookListWithTab bookListWithTab;
    [Token(Token = "0x40112D6")]
    [FieldOffset(Offset = "0x28")]
    private Story.Adv.LuaObjects.Book selected;
    [Token(Token = "0x40112D7")]
    [FieldOffset(Offset = "0x30")]
    private bool cancel;

    [Token(Token = "0x6019344")]
    [Address(RVA = "0x2D05D90", Offset = "0x2D05D90", VA = "0x2D05D90")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6019345")]
    [Address(RVA = "0x2D05FC8", Offset = "0x2D05FC8", VA = "0x2D05FC8")]
    public void Load()
    {
    }

    [Token(Token = "0x6019346")]
    [Address(RVA = "0x2D06060", Offset = "0x2D06060", VA = "0x2D06060")]
    private IEnumerator LoadInternal(
      AssetCachedSpawner spawner,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019347")]
    [Address(RVA = "0x2D06104", Offset = "0x2D06104", VA = "0x2D06104")]
    public void Open(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6019348")]
    [Address(RVA = "0x2D06220", Offset = "0x2D06220", VA = "0x2D06220")]
    public void Close()
    {
    }

    [Token(Token = "0x6019349")]
    [Address(RVA = "0x2D0623C", Offset = "0x2D0623C", VA = "0x2D0623C")]
    private void Cancel()
    {
    }

    [Token(Token = "0x601934A")]
    [Address(RVA = "0x2D06264", Offset = "0x2D06264", VA = "0x2D06264")]
    private void OnSelect(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x601934B")]
    [Address(RVA = "0x2D06324", Offset = "0x2D06324", VA = "0x2D06324")]
    public void Decide(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x601934C")]
    [Address(RVA = "0x2D063B0", Offset = "0x2D063B0", VA = "0x2D063B0")]
    public Story.Adv.LuaObjects.Book Selected() => (Story.Adv.LuaObjects.Book) null;

    [Token(Token = "0x601934D")]
    [Address(RVA = "0x2D063B8", Offset = "0x2D063B8", VA = "0x2D063B8")]
    public void Reset()
    {
    }

    [Token(Token = "0x601934E")]
    [Address(RVA = "0x2D063C0", Offset = "0x2D063C0", VA = "0x2D063C0")]
    public bool Canceled() => new bool();

    [Token(Token = "0x601934F")]
    [Address(RVA = "0x2D05F3C", Offset = "0x2D05F3C", VA = "0x2D05F3C")]
    public static Adv2ProjectFilePlayer AdvPlayer() => (Adv2ProjectFilePlayer) null;

    [Token(Token = "0x6019350")]
    [Address(RVA = "0x2D063C8", Offset = "0x2D063C8", VA = "0x2D063C8")]
    public Adv2BookListWithTab()
    {
    }
  }
}
