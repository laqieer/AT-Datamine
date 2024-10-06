// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestPrepareSubSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003259")]
  public class QuestPrepareSubSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x1700414F")]
    public QuestInfo Quest
    {
      [Token(Token = "0x6013A38"), Address(RVA = "0x461A0A0", Offset = "0x461A0A0", VA = "0x461A0A0")] get
      {
        return (QuestInfo) null;
      }
      [Token(Token = "0x6013A39"), Address(RVA = "0x461A0A8", Offset = "0x461A0A8", VA = "0x461A0A8")] private set
      {
      }
    }

    [Token(Token = "0x17004150")]
    public DeckTypeEnum DeckType
    {
      [Token(Token = "0x6013A3A"), Address(RVA = "0x461A0B0", Offset = "0x461A0B0", VA = "0x461A0B0")] get
      {
        return new DeckTypeEnum();
      }
      [Token(Token = "0x6013A3B"), Address(RVA = "0x461A0B8", Offset = "0x461A0B8", VA = "0x461A0B8")] private set
      {
      }
    }

    [Token(Token = "0x17004151")]
    public bool NeedFadeOnInitialize
    {
      [Token(Token = "0x6013A3C"), Address(RVA = "0x461A0C0", Offset = "0x461A0C0", VA = "0x461A0C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013A3D"), Address(RVA = "0x461A0C8", Offset = "0x461A0C8", VA = "0x461A0C8")] set
      {
      }
    }

    [Token(Token = "0x17004152")]
    public bool IsGuildRaid
    {
      [Token(Token = "0x6013A3E"), Address(RVA = "0x461A0D4", Offset = "0x461A0D4", VA = "0x461A0D4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013A3F"), Address(RVA = "0x461A0DC", Offset = "0x461A0DC", VA = "0x461A0DC")] set
      {
      }
    }

    [Token(Token = "0x17004153")]
    public List<string> UsedStyleIds
    {
      [Token(Token = "0x6013A40"), Address(RVA = "0x461A0E8", Offset = "0x461A0E8", VA = "0x461A0E8")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6013A41"), Address(RVA = "0x461A0F0", Offset = "0x461A0F0", VA = "0x461A0F0")] set
      {
      }
    }

    [Token(Token = "0x17004154")]
    public bool IsMock
    {
      [Token(Token = "0x6013A42"), Address(RVA = "0x461A0F8", Offset = "0x461A0F8", VA = "0x461A0F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013A43"), Address(RVA = "0x461A100", Offset = "0x461A100", VA = "0x461A100")] set
      {
      }
    }

    [Token(Token = "0x6013A44")]
    [Address(RVA = "0x461252C", Offset = "0x461252C", VA = "0x461252C")]
    public QuestPrepareSubSceneParameter(QuestInfo quest, DeckTypeEnum deckType = DeckTypeEnum.BATTLE5)
    {
    }
  }
}
