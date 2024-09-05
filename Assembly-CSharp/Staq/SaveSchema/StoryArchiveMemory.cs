// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.StoryArchiveMemory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE1")]
  public struct StoryArchiveMemory : IFlatbufferObject
  {
    [Token(Token = "0x4010C42")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FE0")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601870A"), Address(RVA = "0x26E31C0", Offset = "0x26E31C0", VA = "0x26E31C0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601870B")]
    [Address(RVA = "0x26E31C8", Offset = "0x26E31C8", VA = "0x26E31C8")]
    public static StoryArchiveMemory GetRootAsStoryArchiveMemory(ByteBuffer _bb)
    {
      return new StoryArchiveMemory();
    }

    [Token(Token = "0x601870C")]
    [Address(RVA = "0x26E31D4", Offset = "0x26E31D4", VA = "0x26E31D4")]
    public static StoryArchiveMemory GetRootAsStoryArchiveMemory(
      ByteBuffer _bb,
      StoryArchiveMemory obj)
    {
      return new StoryArchiveMemory();
    }

    [Token(Token = "0x601870D")]
    [Address(RVA = "0x26E3230", Offset = "0x26E3230", VA = "0x26E3230")]
    public static bool StoryArchiveMemoryBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601870E")]
    [Address(RVA = "0x26E327C", Offset = "0x26E327C", VA = "0x26E327C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601870F")]
    [Address(RVA = "0x26E3218", Offset = "0x26E3218", VA = "0x26E3218")]
    public StoryArchiveMemory __assign(int _i, ByteBuffer _bb) => new StoryArchiveMemory();

    [Token(Token = "0x6018710")]
    [Address(RVA = "0x26E3288", Offset = "0x26E3288", VA = "0x26E3288")]
    public int PlayedArchiveIds(int j) => new int();

    [Token(Token = "0x17004FE1")]
    public int PlayedArchiveIdsLength
    {
      [Token(Token = "0x6018711"), Address(RVA = "0x26E32E8", Offset = "0x26E32E8", VA = "0x26E32E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018712")]
    [Address(RVA = "0x26E331C", Offset = "0x26E331C", VA = "0x26E331C")]
    public ArraySegment<byte>? GetPlayedArchiveIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018713")]
    [Address(RVA = "0x26E3354", Offset = "0x26E3354", VA = "0x26E3354")]
    public int[] GetPlayedArchiveIdsArray() => (int[]) null;

    [Token(Token = "0x17004FE2")]
    public bool IsIntroUnlocked
    {
      [Token(Token = "0x6018714"), Address(RVA = "0x26E33A0", Offset = "0x26E33A0", VA = "0x26E33A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FE3")]
    public bool IsCommonUnlocked
    {
      [Token(Token = "0x6018715"), Address(RVA = "0x26E33E8", Offset = "0x26E33E8", VA = "0x26E33E8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FE4")]
    public bool IsDinatanUnlocked
    {
      [Token(Token = "0x6018716"), Address(RVA = "0x26E3430", Offset = "0x26E3430", VA = "0x26E3430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FE5")]
    public bool IsLanslotUnlocked
    {
      [Token(Token = "0x6018717"), Address(RVA = "0x26E3478", Offset = "0x26E3478", VA = "0x26E3478")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FE6")]
    public bool IsGuinevereUnlocked
    {
      [Token(Token = "0x6018718"), Address(RVA = "0x26E34C0", Offset = "0x26E34C0", VA = "0x26E34C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018719")]
    [Address(RVA = "0x26E3508", Offset = "0x26E3508", VA = "0x26E3508")]
    public static Offset<StoryArchiveMemory> CreateStoryArchiveMemory(
      FlatBufferBuilder builder,
      VectorOffset playedArchiveIdsOffset = default (VectorOffset),
      bool isIntroUnlocked = false,
      bool isCommonUnlocked = false,
      bool isDinatanUnlocked = false,
      bool isLanslotUnlocked = false,
      bool isGuinevereUnlocked = false)
    {
      return new Offset<StoryArchiveMemory>();
    }

    [Token(Token = "0x601871A")]
    [Address(RVA = "0x26E36C0", Offset = "0x26E36C0", VA = "0x26E36C0")]
    public static void StartStoryArchiveMemory(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601871B")]
    [Address(RVA = "0x26E35B0", Offset = "0x26E35B0", VA = "0x26E35B0")]
    public static void AddPlayedArchiveIds(
      FlatBufferBuilder builder,
      VectorOffset playedArchiveIdsOffset)
    {
    }

    [Token(Token = "0x601871C")]
    [Address(RVA = "0x26E36D8", Offset = "0x26E36D8", VA = "0x26E36D8")]
    public static VectorOffset CreatePlayedArchiveIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601871D")]
    [Address(RVA = "0x26E3780", Offset = "0x26E3780", VA = "0x26E3780")]
    public static VectorOffset CreatePlayedArchiveIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601871E")]
    [Address(RVA = "0x26E3808", Offset = "0x26E3808", VA = "0x26E3808")]
    public static void StartPlayedArchiveIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601871F")]
    [Address(RVA = "0x26E3650", Offset = "0x26E3650", VA = "0x26E3650")]
    public static void AddIsIntroUnlocked(FlatBufferBuilder builder, bool isIntroUnlocked)
    {
    }

    [Token(Token = "0x6018720")]
    [Address(RVA = "0x26E3630", Offset = "0x26E3630", VA = "0x26E3630")]
    public static void AddIsCommonUnlocked(FlatBufferBuilder builder, bool isCommonUnlocked)
    {
    }

    [Token(Token = "0x6018721")]
    [Address(RVA = "0x26E3610", Offset = "0x26E3610", VA = "0x26E3610")]
    public static void AddIsDinatanUnlocked(FlatBufferBuilder builder, bool isDinatanUnlocked)
    {
    }

    [Token(Token = "0x6018722")]
    [Address(RVA = "0x26E35F0", Offset = "0x26E35F0", VA = "0x26E35F0")]
    public static void AddIsLanslotUnlocked(FlatBufferBuilder builder, bool isLanslotUnlocked)
    {
    }

    [Token(Token = "0x6018723")]
    [Address(RVA = "0x26E35D0", Offset = "0x26E35D0", VA = "0x26E35D0")]
    public static void AddIsGuinevereUnlocked(FlatBufferBuilder builder, bool isGuinevereUnlocked)
    {
    }

    [Token(Token = "0x6018724")]
    [Address(RVA = "0x26E3670", Offset = "0x26E3670", VA = "0x26E3670")]
    public static Offset<StoryArchiveMemory> EndStoryArchiveMemory(FlatBufferBuilder builder)
    {
      return new Offset<StoryArchiveMemory>();
    }

    [Token(Token = "0x6018725")]
    [Address(RVA = "0x26E3828", Offset = "0x26E3828", VA = "0x26E3828")]
    public static void FinishStoryArchiveMemoryBuffer(
      FlatBufferBuilder builder,
      Offset<StoryArchiveMemory> offset)
    {
    }

    [Token(Token = "0x6018726")]
    [Address(RVA = "0x26E3884", Offset = "0x26E3884", VA = "0x26E3884")]
    public static void FinishSizePrefixedStoryArchiveMemoryBuffer(
      FlatBufferBuilder builder,
      Offset<StoryArchiveMemory> offset)
    {
    }
  }
}
