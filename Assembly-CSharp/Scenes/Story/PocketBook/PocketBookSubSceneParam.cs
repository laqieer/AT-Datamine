// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookSubSceneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.State;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DBB")]
  public class PocketBookSubSceneParam : ChangeSceneParameter
  {
    [Token(Token = "0x17003D19")]
    public CurrentFreeActionParam CurrentFreeActionParam
    {
      [Token(Token = "0x6011E21"), Address(RVA = "0x3FA8F5C", Offset = "0x3FA8F5C", VA = "0x3FA8F5C")] get
      {
        return (CurrentFreeActionParam) null;
      }
      [Token(Token = "0x6011E22"), Address(RVA = "0x3FA8F64", Offset = "0x3FA8F64", VA = "0x3FA8F64")] set
      {
      }
    }

    [Token(Token = "0x17003D1A")]
    public IPocketBookEventHandler PocketBookEventHandler
    {
      [Token(Token = "0x6011E23"), Address(RVA = "0x3FA8F6C", Offset = "0x3FA8F6C", VA = "0x3FA8F6C")] get
      {
        return (IPocketBookEventHandler) null;
      }
      [Token(Token = "0x6011E24"), Address(RVA = "0x3FA8F74", Offset = "0x3FA8F74", VA = "0x3FA8F74")] set
      {
      }
    }

    [Token(Token = "0x17003D1B")]
    public PocketBookStoryIndex.Tab.Type TabType
    {
      [Token(Token = "0x6011E25"), Address(RVA = "0x3FA8F7C", Offset = "0x3FA8F7C", VA = "0x3FA8F7C")] get
      {
        return new PocketBookStoryIndex.Tab.Type();
      }
      [Token(Token = "0x6011E26"), Address(RVA = "0x3FA8F84", Offset = "0x3FA8F84", VA = "0x3FA8F84")] set
      {
      }
    }

    [Token(Token = "0x17003D1C")]
    public FreeMapStateManager Entity
    {
      [Token(Token = "0x6011E27"), Address(RVA = "0x3FA8F8C", Offset = "0x3FA8F8C", VA = "0x3FA8F8C")] get
      {
        return (FreeMapStateManager) null;
      }
      [Token(Token = "0x6011E28"), Address(RVA = "0x3FA8F94", Offset = "0x3FA8F94", VA = "0x3FA8F94")] set
      {
      }
    }

    [Token(Token = "0x6011E29")]
    [Address(RVA = "0x3FA8F9C", Offset = "0x3FA8F9C", VA = "0x3FA8F9C")]
    public PocketBookSubSceneParam(
      CurrentFreeActionParam freeActionParam,
      FreeMapStateManager entity)
    {
    }
  }
}
