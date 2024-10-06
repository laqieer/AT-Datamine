// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaBookListNoTab
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
  [Token(Token = "0x2003EA5")]
  [MoonSharpUserData]
  public class Adv2LuaBookListNoTab : LuaSignal
  {
    [Token(Token = "0x40112EB")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40112EC")]
    [FieldOffset(Offset = "0x20")]
    private BookListNoTab bookList;
    [Token(Token = "0x40112ED")]
    [FieldOffset(Offset = "0x28")]
    private Story.Adv.LuaObjects.Book selected;
    [Token(Token = "0x40112EE")]
    [FieldOffset(Offset = "0x30")]
    private bool cancel;

    [Token(Token = "0x6019396")]
    [Address(RVA = "0x2FECE58", Offset = "0x2FECE58", VA = "0x2FECE58")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6019397")]
    [Address(RVA = "0x2FED090", Offset = "0x2FED090", VA = "0x2FED090")]
    public void Load()
    {
    }

    [Token(Token = "0x6019398")]
    [Address(RVA = "0x2FED128", Offset = "0x2FED128", VA = "0x2FED128")]
    private IEnumerator LoadInternal(
      AssetCachedSpawner spawner,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019399")]
    [Address(RVA = "0x2FED1CC", Offset = "0x2FED1CC", VA = "0x2FED1CC")]
    public void Open(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x601939A")]
    [Address(RVA = "0x2FED2E8", Offset = "0x2FED2E8", VA = "0x2FED2E8")]
    public void Close()
    {
    }

    [Token(Token = "0x601939B")]
    [Address(RVA = "0x2FED304", Offset = "0x2FED304", VA = "0x2FED304")]
    private void Cancel()
    {
    }

    [Token(Token = "0x601939C")]
    [Address(RVA = "0x2FED32C", Offset = "0x2FED32C", VA = "0x2FED32C")]
    private void OnSelect(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x601939D")]
    [Address(RVA = "0x2FED004", Offset = "0x2FED004", VA = "0x2FED004")]
    public static Adv2ProjectFilePlayer AdvPlayer() => (Adv2ProjectFilePlayer) null;

    [Token(Token = "0x601939E")]
    [Address(RVA = "0x2FED370", Offset = "0x2FED370", VA = "0x2FED370")]
    public void Decide(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x601939F")]
    [Address(RVA = "0x2FED3FC", Offset = "0x2FED3FC", VA = "0x2FED3FC")]
    public Story.Adv.LuaObjects.Book Selected() => (Story.Adv.LuaObjects.Book) null;

    [Token(Token = "0x60193A0")]
    [Address(RVA = "0x2FED404", Offset = "0x2FED404", VA = "0x2FED404")]
    public void Reset()
    {
    }

    [Token(Token = "0x60193A1")]
    [Address(RVA = "0x2FED40C", Offset = "0x2FED40C", VA = "0x2FED40C")]
    public bool Canceled() => new bool();

    [Token(Token = "0x60193A2")]
    [Address(RVA = "0x2FED414", Offset = "0x2FED414", VA = "0x2FED414")]
    public Adv2LuaBookListNoTab()
    {
    }
  }
}
