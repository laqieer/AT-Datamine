// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PlayerCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CCB")]
  public struct PlayerCharacter : IFlatbufferObject
  {
    [Token(Token = "0x4010C29")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F95")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601858B"), Address(RVA = "0x26DD6D0", Offset = "0x26DD6D0", VA = "0x26DD6D0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601858C")]
    [Address(RVA = "0x26DD6D8", Offset = "0x26DD6D8", VA = "0x26DD6D8")]
    public static PlayerCharacter GetRootAsPlayerCharacter(ByteBuffer _bb) => new PlayerCharacter();

    [Token(Token = "0x601858D")]
    [Address(RVA = "0x26DD6E4", Offset = "0x26DD6E4", VA = "0x26DD6E4")]
    public static PlayerCharacter GetRootAsPlayerCharacter(ByteBuffer _bb, PlayerCharacter obj)
    {
      return new PlayerCharacter();
    }

    [Token(Token = "0x601858E")]
    [Address(RVA = "0x26DD740", Offset = "0x26DD740", VA = "0x26DD740")]
    public static bool PlayerCharacterBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601858F")]
    [Address(RVA = "0x26DD78C", Offset = "0x26DD78C", VA = "0x26DD78C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018590")]
    [Address(RVA = "0x26DD728", Offset = "0x26DD728", VA = "0x26DD728")]
    public PlayerCharacter __assign(int _i, ByteBuffer _bb) => new PlayerCharacter();

    [Token(Token = "0x17004F96")]
    public string PlayerName
    {
      [Token(Token = "0x6018591"), Address(RVA = "0x26DD798", Offset = "0x26DD798", VA = "0x26DD798")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018592")]
    [Address(RVA = "0x26DD7D4", Offset = "0x26DD7D4", VA = "0x26DD7D4")]
    public ArraySegment<byte>? GetPlayerNameBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018593")]
    [Address(RVA = "0x26DD80C", Offset = "0x26DD80C", VA = "0x26DD80C")]
    public byte[] GetPlayerNameArray() => (byte[]) null;

    [Token(Token = "0x17004F97")]
    public int AvatarId
    {
      [Token(Token = "0x6018594"), Address(RVA = "0x26DD858", Offset = "0x26DD858", VA = "0x26DD858")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F98")]
    public bool IsAccountRecreate
    {
      [Token(Token = "0x6018595"), Address(RVA = "0x26DD89C", Offset = "0x26DD89C", VA = "0x26DD89C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F99")]
    public bool IsEnteredHomeTutorial
    {
      [Token(Token = "0x6018596"), Address(RVA = "0x26DD8E4", Offset = "0x26DD8E4", VA = "0x26DD8E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F9A")]
    public bool IsIntroChapterFinished
    {
      [Token(Token = "0x6018597"), Address(RVA = "0x26DD92C", Offset = "0x26DD92C", VA = "0x26DD92C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018598")]
    [Address(RVA = "0x26DD974", Offset = "0x26DD974", VA = "0x26DD974")]
    public static Offset<PlayerCharacter> CreatePlayerCharacter(
      FlatBufferBuilder builder,
      StringOffset player_nameOffset = default (StringOffset),
      int avatar_id = 0,
      bool is_account_recreate = false,
      bool is_entered_home_tutorial = false,
      bool is_intro_chapter_finished = false)
    {
      return new Offset<PlayerCharacter>();
    }

    [Token(Token = "0x6018599")]
    [Address(RVA = "0x26DDAFC", Offset = "0x26DDAFC", VA = "0x26DDAFC")]
    public static void StartPlayerCharacter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601859A")]
    [Address(RVA = "0x26DDA2C", Offset = "0x26DDA2C", VA = "0x26DDA2C")]
    public static void AddPlayerName(FlatBufferBuilder builder, StringOffset playerNameOffset)
    {
    }

    [Token(Token = "0x601859B")]
    [Address(RVA = "0x26DDA0C", Offset = "0x26DDA0C", VA = "0x26DDA0C")]
    public static void AddAvatarId(FlatBufferBuilder builder, int avatarId)
    {
    }

    [Token(Token = "0x601859C")]
    [Address(RVA = "0x26DDA8C", Offset = "0x26DDA8C", VA = "0x26DDA8C")]
    public static void AddIsAccountRecreate(FlatBufferBuilder builder, bool isAccountRecreate)
    {
    }

    [Token(Token = "0x601859D")]
    [Address(RVA = "0x26DDA6C", Offset = "0x26DDA6C", VA = "0x26DDA6C")]
    public static void AddIsEnteredHomeTutorial(
      FlatBufferBuilder builder,
      bool isEnteredHomeTutorial)
    {
    }

    [Token(Token = "0x601859E")]
    [Address(RVA = "0x26DDA4C", Offset = "0x26DDA4C", VA = "0x26DDA4C")]
    public static void AddIsIntroChapterFinished(
      FlatBufferBuilder builder,
      bool isIntroChapterFinished)
    {
    }

    [Token(Token = "0x601859F")]
    [Address(RVA = "0x26DDAAC", Offset = "0x26DDAAC", VA = "0x26DDAAC")]
    public static Offset<PlayerCharacter> EndPlayerCharacter(FlatBufferBuilder builder)
    {
      return new Offset<PlayerCharacter>();
    }

    [Token(Token = "0x60185A0")]
    [Address(RVA = "0x26DDB14", Offset = "0x26DDB14", VA = "0x26DDB14")]
    public static void FinishPlayerCharacterBuffer(
      FlatBufferBuilder builder,
      Offset<PlayerCharacter> offset)
    {
    }

    [Token(Token = "0x60185A1")]
    [Address(RVA = "0x26DDB70", Offset = "0x26DDB70", VA = "0x26DDB70")]
    public static void FinishSizePrefixedPlayerCharacterBuffer(
      FlatBufferBuilder builder,
      Offset<PlayerCharacter> offset)
    {
    }
  }
}
