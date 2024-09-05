// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaArenaQuestPrepareSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200313A")]
  internal class ArenaArenaQuestPrepareSubScene : ChangeSceneParameter
  {
    [Token(Token = "0x400D18E")]
    [FieldOffset(Offset = "0x18")]
    public ArenaTopSceneBase arenaSceneBase;
    [Token(Token = "0x400D18F")]
    [FieldOffset(Offset = "0x20")]
    public DeckTypeEnum deckType;

    [Token(Token = "0x601334C")]
    [Address(RVA = "0x45DE074", Offset = "0x45DE074", VA = "0x45DE074")]
    public ArenaArenaQuestPrepareSubScene()
    {
    }
  }
}
