// Decompiled with JetBrains decompiler
// Type: StaqData.Story.StoryShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData.Story
{
  [Token(Token = "0x2002160")]
  public class StoryShop
  {
    [Token(Token = "0x17002CD9")]
    public ShopLayoutData Layout
    {
      [Token(Token = "0x600CC96"), Address(RVA = "0x1BB06A4", Offset = "0x1BB06A4", VA = "0x1BB06A4")] get
      {
        return (ShopLayoutData) null;
      }
      [Token(Token = "0x600CC97"), Address(RVA = "0x1BB06AC", Offset = "0x1BB06AC", VA = "0x1BB06AC")] private set
      {
      }
    }

    [Token(Token = "0x600CC98")]
    [Address(RVA = "0x1BB06B4", Offset = "0x1BB06B4", VA = "0x1BB06B4")]
    public StoryShop(ShopLayoutData layout)
    {
    }
  }
}
