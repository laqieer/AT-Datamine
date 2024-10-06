// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.Book
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using StaqData;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x2000761")]
  [MoonSharpUserData]
  public class Book
  {
    [Token(Token = "0x40021C6")]
    [FieldOffset(Offset = "0x10")]
    public int ID;
    [Token(Token = "0x40021C7")]
    [FieldOffset(Offset = "0x14")]
    public int Priority;
    [Token(Token = "0x40021C8")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x40021C9")]
    [FieldOffset(Offset = "0x20")]
    public string Flavour;
    [Token(Token = "0x40021CA")]
    [FieldOffset(Offset = "0x28")]
    public string LockedCondition;
    [Token(Token = "0x40021CB")]
    [FieldOffset(Offset = "0x30")]
    public bool IsLocked;
    [Token(Token = "0x40021CC")]
    [FieldOffset(Offset = "0x31")]
    public bool IsAlready;
    [Token(Token = "0x40021CD")]
    [FieldOffset(Offset = "0x38")]
    public BookProgress Progress;
    [Token(Token = "0x40021CE")]
    [FieldOffset(Offset = "0x40")]
    public BookComplete Complete;

    [Token(Token = "0x17000636")]
    public bool IsNew
    {
      [Token(Token = "0x6002960"), Address(RVA = "0x367FCE8", Offset = "0x367FCE8", VA = "0x367FCE8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000637")]
    public bool Read
    {
      [Token(Token = "0x6002961"), Address(RVA = "0x367FD8C", Offset = "0x367FD8C", VA = "0x367FD8C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002962")]
    [Address(RVA = "0x367FD9C", Offset = "0x367FD9C", VA = "0x367FD9C")]
    public LuaSequence.ParamControl.HumanParameter GetHumanParam()
    {
      return (LuaSequence.ParamControl.HumanParameter) null;
    }

    [Token(Token = "0x6002963")]
    [Address(RVA = "0x367FEA8", Offset = "0x367FEA8", VA = "0x367FEA8")]
    public LuaRewardItem[] GetItemRewards() => (LuaRewardItem[]) null;

    [Token(Token = "0x6002964")]
    [Address(RVA = "0x367FF10", Offset = "0x367FF10", VA = "0x367FF10")]
    public Ability[] GetRewardAbilities() => (Ability[]) null;

    [Token(Token = "0x6002965")]
    [Address(RVA = "0x367FE24", Offset = "0x367FE24", VA = "0x367FE24")]
    private ChapterItem GetData() => (ChapterItem) null;

    [Token(Token = "0x6002966")]
    [Address(RVA = "0x367F5BC", Offset = "0x367F5BC", VA = "0x367F5BC")]
    public Book()
    {
    }
  }
}
