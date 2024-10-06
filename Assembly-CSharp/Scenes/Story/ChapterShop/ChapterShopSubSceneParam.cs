// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopSubSceneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002F00")]
  public class ChapterShopSubSceneParam : ChangeSceneParameter
  {
    [Token(Token = "0x17003E4C")]
    public ShopTypeEnum ShopTypeEnum
    {
      [Token(Token = "0x60125CC"), Address(RVA = "0x22FE460", Offset = "0x22FE460", VA = "0x22FE460")] get
      {
        return new ShopTypeEnum();
      }
      [Token(Token = "0x60125CD"), Address(RVA = "0x22FE468", Offset = "0x22FE468", VA = "0x22FE468")] private set
      {
      }
    }

    [Token(Token = "0x17003E4D")]
    public int ObjectID
    {
      [Token(Token = "0x60125CE"), Address(RVA = "0x22FE470", Offset = "0x22FE470", VA = "0x22FE470")] get
      {
        return new int();
      }
      [Token(Token = "0x60125CF"), Address(RVA = "0x22FE478", Offset = "0x22FE478", VA = "0x22FE478")] private set
      {
      }
    }

    [Token(Token = "0x17003E4E")]
    public string CharacterName
    {
      [Token(Token = "0x60125D0"), Address(RVA = "0x22FE480", Offset = "0x22FE480", VA = "0x22FE480")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60125D1"), Address(RVA = "0x22FE488", Offset = "0x22FE488", VA = "0x22FE488")] set
      {
      }
    }

    [Token(Token = "0x17003E4F")]
    public ChapterShopType ChapterShopType
    {
      [Token(Token = "0x60125D2"), Address(RVA = "0x22FE490", Offset = "0x22FE490", VA = "0x22FE490")] get
      {
        return new ChapterShopType();
      }
      [Token(Token = "0x60125D3"), Address(RVA = "0x22FE498", Offset = "0x22FE498", VA = "0x22FE498")] set
      {
      }
    }

    [Token(Token = "0x60125D4")]
    [Address(RVA = "0x22FE4A0", Offset = "0x22FE4A0", VA = "0x22FE4A0")]
    public ChapterShopSubSceneParam(
      ShopTypeEnum shopTypeEnum,
      int objectId,
      string characterName,
      ChapterShopType chapterShopType = ChapterShopType.StorySceneChange)
    {
    }
  }
}
