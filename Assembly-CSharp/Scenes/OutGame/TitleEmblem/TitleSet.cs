// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.TitleEmblem.TitleSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.TitleEmblem
{
  [Token(Token = "0x200335E")]
  public struct TitleSet
  {
    [Token(Token = "0x17004377")]
    public readonly ITitleMasterData PreTitle
    {
      [Token(Token = "0x60142FB"), Address(RVA = "0x1E15D0C", Offset = "0x1E15D0C", VA = "0x1E15D0C")] get
      {
        return (ITitleMasterData) null;
      }
    }

    [Token(Token = "0x17004378")]
    public readonly ITitleMasterData PostTitle
    {
      [Token(Token = "0x60142FC"), Address(RVA = "0x1E15D14", Offset = "0x1E15D14", VA = "0x1E15D14")] get
      {
        return (ITitleMasterData) null;
      }
    }

    [Token(Token = "0x17004379")]
    public readonly ITitleMasterData Frame
    {
      [Token(Token = "0x60142FD"), Address(RVA = "0x1E15D1C", Offset = "0x1E15D1C", VA = "0x1E15D1C")] get
      {
        return (ITitleMasterData) null;
      }
    }

    [Token(Token = "0x60142FE")]
    [Address(RVA = "0x1E15D24", Offset = "0x1E15D24", VA = "0x1E15D24")]
    public TitleSet(ITitleMasterData pre, ITitleMasterData post, ITitleMasterData frame)
    {
    }

    [Token(Token = "0x60142FF")]
    [Address(RVA = "0x1E1504C", Offset = "0x1E1504C", VA = "0x1E1504C")]
    public void Deconstruct(
      out ITitleMasterData pre,
      out ITitleMasterData post,
      out ITitleMasterData frame)
    {
    }

    [Token(Token = "0x6014300")]
    [Address(RVA = "0x1E15068", Offset = "0x1E15068", VA = "0x1E15068")]
    public bool IsEachPattern() => new bool();

    [Token(Token = "0x6014301")]
    [Address(RVA = "0x1E1511C", Offset = "0x1E1511C", VA = "0x1E1511C")]
    public bool IsCombinationTextPattern() => new bool();

    [Token(Token = "0x6014302")]
    [Address(RVA = "0x1E151CC", Offset = "0x1E151CC", VA = "0x1E151CC")]
    public bool IsTextImagePattern() => new bool();

    [Token(Token = "0x6014303")]
    [Address(RVA = "0x1E1527C", Offset = "0x1E1527C", VA = "0x1E1527C")]
    public bool IsFullSetPattern() => new bool();
  }
}
