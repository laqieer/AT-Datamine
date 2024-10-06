// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChapterShopReleaseSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CFC")]
  public class ChapterShopReleaseSaveData
  {
    [Token(Token = "0x4010C88")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<ShopTypeEnum, ChapterShopReleaseSaveData.ChapterShopRelease> ReleaseAbilityMap;

    [Token(Token = "0x17005015")]
    public bool loaded
    {
      [Token(Token = "0x601882B"), Address(RVA = "0x293B394", Offset = "0x293B394", VA = "0x293B394")] get
      {
        return new bool();
      }
      [Token(Token = "0x601882C"), Address(RVA = "0x293B39C", Offset = "0x293B39C", VA = "0x293B39C")] private set
      {
      }
    }

    [Token(Token = "0x17005016")]
    public static string Path
    {
      [Token(Token = "0x601882D"), Address(RVA = "0x293B3A8", Offset = "0x293B3A8", VA = "0x293B3A8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601882E")]
    [Address(RVA = "0x293B3F8", Offset = "0x293B3F8", VA = "0x293B3F8")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601882F")]
    [Address(RVA = "0x293B440", Offset = "0x293B440", VA = "0x293B440")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018830")]
    [Address(RVA = "0x293B470", Offset = "0x293B470", VA = "0x293B470")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018831")]
    [Address(RVA = "0x293B48C", Offset = "0x293B48C", VA = "0x293B48C")]
    public void Load()
    {
    }

    [Token(Token = "0x6018832")]
    [Address(RVA = "0x293BBE0", Offset = "0x293BBE0", VA = "0x293BBE0")]
    public void Save()
    {
    }

    [Token(Token = "0x6018833")]
    [Address(RVA = "0x293BF8C", Offset = "0x293BF8C", VA = "0x293BF8C")]
    private Offset<ChapterShopReleaseArray> GetData(
      FlatBufferBuilder fbb,
      Offset<ChapterShopReleaseData>[] offsets)
    {
      return new Offset<ChapterShopReleaseArray>();
    }

    [Token(Token = "0x6018834")]
    [Address(RVA = "0x293BEE4", Offset = "0x293BEE4", VA = "0x293BEE4")]
    private Offset<ChapterShopReleaseData> GetChapterShopReleaseData(
      FlatBufferBuilder fbb,
      ChapterShopReleaseSaveData.ChapterShopRelease chapterShopRelease)
    {
      return new Offset<ChapterShopReleaseData>();
    }

    [Token(Token = "0x6018835")]
    [Address(RVA = "0x293BFFC", Offset = "0x293BFFC", VA = "0x293BFFC")]
    public void Set(
      int chapterShopType,
      int shopLevel,
      List<int> lineupIds,
      List<int> releaseStoryAbilityIDs)
    {
    }

    [Token(Token = "0x6018836")]
    [Address(RVA = "0x293C154", Offset = "0x293C154", VA = "0x293C154")]
    public ChapterShopReleaseSaveData()
    {
    }

    [Token(Token = "0x2003CFD")]
    public class ChapterShopRelease
    {
      [Token(Token = "0x17005017")]
      public int ChapterShopType
      {
        [Token(Token = "0x6018837"), Address(RVA = "0x293C1D0", Offset = "0x293C1D0", VA = "0x293C1D0")] get
        {
          return new int();
        }
        [Token(Token = "0x6018838"), Address(RVA = "0x293C1D8", Offset = "0x293C1D8", VA = "0x293C1D8")] set
        {
        }
      }

      [Token(Token = "0x17005018")]
      public int Level
      {
        [Token(Token = "0x6018839"), Address(RVA = "0x293C1E0", Offset = "0x293C1E0", VA = "0x293C1E0")] get
        {
          return new int();
        }
        [Token(Token = "0x601883A"), Address(RVA = "0x293C1E8", Offset = "0x293C1E8", VA = "0x293C1E8")] set
        {
        }
      }

      [Token(Token = "0x17005019")]
      public IReadOnlyList<int> LineupIDs
      {
        [Token(Token = "0x601883B"), Address(RVA = "0x293C1F0", Offset = "0x293C1F0", VA = "0x293C1F0")] get
        {
          return (IReadOnlyList<int>) null;
        }
        [Token(Token = "0x601883C"), Address(RVA = "0x293C1F8", Offset = "0x293C1F8", VA = "0x293C1F8")] set
        {
        }
      }

      [Token(Token = "0x1700501A")]
      public IReadOnlyList<int> ReleaseStoryAbilityIDs
      {
        [Token(Token = "0x601883D"), Address(RVA = "0x293C200", Offset = "0x293C200", VA = "0x293C200")] get
        {
          return (IReadOnlyList<int>) null;
        }
        [Token(Token = "0x601883E"), Address(RVA = "0x293C208", Offset = "0x293C208", VA = "0x293C208")] set
        {
        }
      }

      [Token(Token = "0x601883F")]
      [Address(RVA = "0x293BB40", Offset = "0x293BB40", VA = "0x293BB40")]
      public ChapterShopRelease()
      {
      }
    }
  }
}
