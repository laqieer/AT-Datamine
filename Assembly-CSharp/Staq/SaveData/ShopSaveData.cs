// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ShopSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using Network.Param;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D3F")]
  public class ShopSaveData
  {
    [Token(Token = "0x4010D55")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, ShopSaveData.ShopData> ShopDataMap;

    [Token(Token = "0x17005070")]
    public bool loaded
    {
      [Token(Token = "0x6018A4A"), Address(RVA = "0x263B5A4", Offset = "0x263B5A4", VA = "0x263B5A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018A4B"), Address(RVA = "0x263B5AC", Offset = "0x263B5AC", VA = "0x263B5AC")] private set
      {
      }
    }

    [Token(Token = "0x17005071")]
    public static string Path
    {
      [Token(Token = "0x6018A4C"), Address(RVA = "0x263B5B8", Offset = "0x263B5B8", VA = "0x263B5B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A4D")]
    [Address(RVA = "0x263B608", Offset = "0x263B608", VA = "0x263B608")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A4E")]
    [Address(RVA = "0x263B650", Offset = "0x263B650", VA = "0x263B650")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A4F")]
    [Address(RVA = "0x263B680", Offset = "0x263B680", VA = "0x263B680")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A50")]
    [Address(RVA = "0x263B69C", Offset = "0x263B69C", VA = "0x263B69C")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A51")]
    [Address(RVA = "0x263BD30", Offset = "0x263BD30", VA = "0x263BD30")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A52")]
    [Address(RVA = "0x263C3BC", Offset = "0x263C3BC", VA = "0x263C3BC")]
    private Offset<BannerData> GetShopDataOffset(
      FlatBufferBuilder fbb,
      ShopSaveData.ShopData shopData,
      Offset<ArticleData>[] offsets)
    {
      return new Offset<BannerData>();
    }

    [Token(Token = "0x6018A53")]
    [Address(RVA = "0x263C33C", Offset = "0x263C33C", VA = "0x263C33C")]
    private Offset<ArticleData> GetArticleOffset(
      FlatBufferBuilder fbb,
      ShopSaveData.ShopArticleData articleData,
      Offset<ContentData>[] offsets)
    {
      return new Offset<ArticleData>();
    }

    [Token(Token = "0x6018A54")]
    [Address(RVA = "0x263C314", Offset = "0x263C314", VA = "0x263C314")]
    private Offset<ContentData> GetContentOffset(
      FlatBufferBuilder fbb,
      ShopSaveData.ShopContentData contentData)
    {
      return new Offset<ContentData>();
    }

    [Token(Token = "0x6018A55")]
    [Address(RVA = "0x263B980", Offset = "0x263B980", VA = "0x263B980")]
    private ShopSaveData.ShopData ConvShopData(BannerData? data) => new ShopSaveData.ShopData();

    [Token(Token = "0x6018A56")]
    [Address(RVA = "0x263C440", Offset = "0x263C440", VA = "0x263C440")]
    public void SetShopData(PlayerShopType playerShopType, PlayerShopArticleType[] shopArticleTypes)
    {
    }

    [Token(Token = "0x6018A57")]
    [Address(RVA = "0x263C844", Offset = "0x263C844", VA = "0x263C844")]
    public ShopSaveData()
    {
    }

    [Token(Token = "0x2003D40")]
    public struct ShopData
    {
      [Token(Token = "0x17005072")]
      public int ID
      {
        [Token(Token = "0x6018A58"), Address(RVA = "0x263C84C", Offset = "0x263C84C", VA = "0x263C84C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6018A59"), Address(RVA = "0x263C854", Offset = "0x263C854", VA = "0x263C854")] set
        {
        }
      }

      [Token(Token = "0x17005073")]
      public long EndAtTick
      {
        [Token(Token = "0x6018A5A"), Address(RVA = "0x263C85C", Offset = "0x263C85C", VA = "0x263C85C")] readonly get
        {
          return new long();
        }
        [Token(Token = "0x6018A5B"), Address(RVA = "0x263C864", Offset = "0x263C864", VA = "0x263C864")] set
        {
        }
      }

      [Token(Token = "0x17005074")]
      public ShopSaveData.ShopArticleData[] ArticleDatas
      {
        [Token(Token = "0x6018A5C"), Address(RVA = "0x263C86C", Offset = "0x263C86C", VA = "0x263C86C")] readonly get
        {
          return (ShopSaveData.ShopArticleData[]) null;
        }
        [Token(Token = "0x6018A5D"), Address(RVA = "0x263C874", Offset = "0x263C874", VA = "0x263C874")] set
        {
        }
      }
    }

    [Token(Token = "0x2003D41")]
    public struct ShopArticleData
    {
      [Token(Token = "0x17005075")]
      public int ID
      {
        [Token(Token = "0x6018A5E"), Address(RVA = "0x263C87C", Offset = "0x263C87C", VA = "0x263C87C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6018A5F"), Address(RVA = "0x263C884", Offset = "0x263C884", VA = "0x263C884")] set
        {
        }
      }

      [Token(Token = "0x17005076")]
      public ShopSaveData.ShopContentData[] ContentDatas
      {
        [Token(Token = "0x6018A60"), Address(RVA = "0x263C88C", Offset = "0x263C88C", VA = "0x263C88C")] readonly get
        {
          return (ShopSaveData.ShopContentData[]) null;
        }
        [Token(Token = "0x6018A61"), Address(RVA = "0x263C894", Offset = "0x263C894", VA = "0x263C894")] set
        {
        }
      }
    }

    [Token(Token = "0x2003D42")]
    public struct ShopContentData
    {
      [Token(Token = "0x17005077")]
      public int ID
      {
        [Token(Token = "0x6018A62"), Address(RVA = "0x263C89C", Offset = "0x263C89C", VA = "0x263C89C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6018A63"), Address(RVA = "0x263C8A4", Offset = "0x263C8A4", VA = "0x263C8A4")] set
        {
        }
      }

      [Token(Token = "0x17005078")]
      public int Amount
      {
        [Token(Token = "0x6018A64"), Address(RVA = "0x263C8AC", Offset = "0x263C8AC", VA = "0x263C8AC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6018A65"), Address(RVA = "0x263C8B4", Offset = "0x263C8B4", VA = "0x263C8B4")] set
        {
        }
      }
    }
  }
}
