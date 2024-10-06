// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003153")]
  public class ArenaTop : MonoBehaviour
  {
    [Token(Token = "0x400D210")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArenaPlayerList arenaPlayerList;
    [Token(Token = "0x400D211")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image imageUnit;
    [Token(Token = "0x400D212")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider currentRanking;
    [Token(Token = "0x400D213")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Slider bestRanking;
    [Token(Token = "0x400D214")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text currentRankingText;
    [Token(Token = "0x400D215")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text bestRankingText;
    [Token(Token = "0x400D216")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private StyleThumb currentThumb;
    [Token(Token = "0x400D217")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private StyleThumb bestThumb;
    [Token(Token = "0x400D218")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text arenaCoinText;
    [Token(Token = "0x400D219")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text battleCountText;
    [Token(Token = "0x400D21A")]
    private const string BattleCountString = "{0}/{1}";
    [Token(Token = "0x400D21B")]
    private const string BattleCountZeroString = "<color=#f67979>{0}</color>/{1}";
    [Token(Token = "0x400D21C")]
    [FieldOffset(Offset = "0x68")]
    private ArenaTopSceneBase sceneBase;

    [Token(Token = "0x60133E5")]
    [Address(RVA = "0x4A2420C", Offset = "0x4A2420C", VA = "0x4A2420C")]
    public void Initialize(
      APIArenaDetailResponse detail,
      PlayerArenaType arenaType,
      ArenaTopSceneBase sceneBase)
    {
    }

    [Token(Token = "0x60133E6")]
    [Address(RVA = "0x4A24708", Offset = "0x4A24708", VA = "0x4A24708")]
    public void UpdateTimeReward()
    {
    }

    [Token(Token = "0x60133E7")]
    [Address(RVA = "0x4A24720", Offset = "0x4A24720", VA = "0x4A24720")]
    private void SetTimeReward()
    {
    }

    [Token(Token = "0x60133E8")]
    [Address(RVA = "0x4A244B0", Offset = "0x4A244B0", VA = "0x4A244B0")]
    private void SetMedal()
    {
    }

    [Token(Token = "0x60133E9")]
    [Address(RVA = "0x4A24610", Offset = "0x4A24610", VA = "0x4A24610")]
    public void SetBattleCount(PlayerArenaType arenaType)
    {
    }

    [Token(Token = "0x60133EA")]
    [Address(RVA = "0x4A2473C", Offset = "0x4A2473C", VA = "0x4A2473C")]
    public void UpdateRanking(APIArenaDetailResponse detail, PlayerArenaType arenaType)
    {
    }

    [Token(Token = "0x60133EB")]
    [Address(RVA = "0x4A24378", Offset = "0x4A24378", VA = "0x4A24378")]
    public void SetPlayerProfile(APIArenaDetailResponse detail, PlayerArenaType arenaType)
    {
    }

    [Token(Token = "0x60133EC")]
    [Address(RVA = "0x4A2425C", Offset = "0x4A2425C", VA = "0x4A2425C")]
    private void SetUnitImage()
    {
    }

    [Token(Token = "0x60133ED")]
    [Address(RVA = "0x4A248FC", Offset = "0x4A248FC", VA = "0x4A248FC")]
    public ArenaTop()
    {
    }
  }
}
