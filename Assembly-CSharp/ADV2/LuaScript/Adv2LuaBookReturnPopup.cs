// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaBookReturnPopup
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
  [Token(Token = "0x2003EAA")]
  [MoonSharpUserData]
  public class Adv2LuaBookReturnPopup : LuaSignal
  {
    [Token(Token = "0x40112FF")]
    [FieldOffset(Offset = "0x18")]
    private Adv2ProjectFilePlayer advPlayer;
    [Token(Token = "0x4011300")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4011301")]
    [FieldOffset(Offset = "0x28")]
    private Transform parent;
    [Token(Token = "0x4011302")]
    [FieldOffset(Offset = "0x30")]
    private BookReturnPopup returnPopup;
    [Token(Token = "0x4011303")]
    [FieldOffset(Offset = "0x38")]
    private Adv2LuaBookReturnPopup.ResultValue result;

    [Token(Token = "0x170051C7")]
    public int Result
    {
      [Token(Token = "0x60193BB"), Address(RVA = "0x2FEDDD4", Offset = "0x2FEDDD4", VA = "0x2FEDDD4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60193BC")]
    [Address(RVA = "0x2FEDDDC", Offset = "0x2FEDDDC", VA = "0x2FEDDDC")]
    public Adv2LuaBookReturnPopup(Adv2ProjectFilePlayer advPlayer, Transform parent)
    {
    }

    [Token(Token = "0x60193BD")]
    [Address(RVA = "0x2FEDF90", Offset = "0x2FEDF90", VA = "0x2FEDF90")]
    public void PreLoad()
    {
    }

    [Token(Token = "0x60193BE")]
    [Address(RVA = "0x2FEDFBC", Offset = "0x2FEDFBC", VA = "0x2FEDFBC")]
    public void Load()
    {
    }

    [Token(Token = "0x60193BF")]
    [Address(RVA = "0x2FEE0D8", Offset = "0x2FEE0D8", VA = "0x2FEE0D8")]
    private void OnInstantiated(BookReturnPopup popup, Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x60193C0")]
    [Address(RVA = "0x2FEE2BC", Offset = "0x2FEE2BC", VA = "0x2FEE2BC")]
    public void Set(Story.Adv.LuaObjects.Book book)
    {
    }

    [Token(Token = "0x60193C1")]
    [Address(RVA = "0x2FEE30C", Offset = "0x2FEE30C", VA = "0x2FEE30C")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60193C2")]
    [Address(RVA = "0x2FEE328", Offset = "0x2FEE328", VA = "0x2FEE328")]
    public void SetCount(int num, int max)
    {
    }

    [Token(Token = "0x60193C3")]
    [Address(RVA = "0x2FEE344", Offset = "0x2FEE344", VA = "0x2FEE344")]
    public void Open()
    {
    }

    [Token(Token = "0x60193C4")]
    [Address(RVA = "0x2FEE368", Offset = "0x2FEE368", VA = "0x2FEE368")]
    public void Close()
    {
    }

    [Token(Token = "0x2003EAB")]
    private enum ResultValue
    {
      [Token(Token = "0x4011307")] Negative = -1, // 0xFFFFFFFF
      [Token(Token = "0x4011305")] None = 0,
      [Token(Token = "0x4011306")] Positive = 1,
    }
  }
}
