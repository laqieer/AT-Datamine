// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultPlayer.PlayerRankUpFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Battle.ResultPlayer
{
  [Token(Token = "0x20037CB")]
  public class PlayerRankUpFlow : IBattleResultFlow
  {
    [Token(Token = "0x400F3D7")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400F3D8")]
    [FieldOffset(Offset = "0x18")]
    private int _beforeExp;
    [Token(Token = "0x400F3D9")]
    [FieldOffset(Offset = "0x1C")]
    private int _afterExp;

    [Token(Token = "0x6015F5A")]
    [Address(RVA = "0x232C098", Offset = "0x232C098", VA = "0x232C098")]
    public PlayerRankUpFlow(AssetCachedSpawner assetCachedSpawner, int beforeExp, int afterExp)
    {
    }

    [Token(Token = "0x6015F5B")]
    [Address(RVA = "0x232C0D4", Offset = "0x232C0D4", VA = "0x232C0D4", Slot = "4")]
    public IEnumerator PlayAndWait() => (IEnumerator) null;
  }
}
