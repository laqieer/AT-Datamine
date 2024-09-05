// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaPlayerListEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003148")]
  public class ArenaPlayerListEnemy : MonoBehaviour
  {
    [Token(Token = "0x400D1D4")]
    protected const int gold = 1;
    [Token(Token = "0x400D1D5")]
    protected const int silver = 2;
    [Token(Token = "0x400D1D6")]
    protected const int bronze = 3;
    [Token(Token = "0x400D1D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected StyleThumb leaderThumb;
    [Token(Token = "0x400D1D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected List<StyleThumb> thumbs;
    [Token(Token = "0x400D1D9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected List<GameObject> unknownBases;
    [Token(Token = "0x400D1DA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected List<GameObject> unknowns;
    [Token(Token = "0x400D1DB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Text playerName;
    [Token(Token = "0x400D1DC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Text playerRank;
    [Token(Token = "0x400D1DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected Text battlePower;
    [Token(Token = "0x400D1DE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected TextMeshProUGUI arenaRanking;
    [Token(Token = "0x400D1DF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected List<GameObject> rankColor;
    [Token(Token = "0x400D1E0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton challengeButton;
    [Token(Token = "0x400D1E1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject[] challengeButtonEffect;
    [Token(Token = "0x400D1E2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    protected PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400D1E3")]
    [FieldOffset(Offset = "0x78")]
    protected ArenaTopSceneBase sceneBase;
    [Token(Token = "0x400D1E4")]
    [FieldOffset(Offset = "0x80")]
    private ArenaPlayerListEnemy.EnemyParam enemy;
    [Token(Token = "0x400D1E5")]
    [FieldOffset(Offset = "0x88")]
    private List<UnitParameterData> unitList;

    [Token(Token = "0x60133BF")]
    [Address(RVA = "0x4A21E90", Offset = "0x4A21E90", VA = "0x4A21E90")]
    public void Initialize(
      ArenaPlayerListEnemy.EnemyParam enemy,
      ArenaTopSceneBase sceneBase,
      int hideUnitsRank,
      int battleCount)
    {
    }

    [Token(Token = "0x60133C0")]
    [Address(RVA = "0x4A21A5C", Offset = "0x4A21A5C", VA = "0x4A21A5C")]
    public void SetPersonalEmblem(int emblemId)
    {
    }

    [Token(Token = "0x60133C1")]
    [Address(RVA = "0x4A2251C", Offset = "0x4A2251C", VA = "0x4A2251C")]
    public void ButtonChallenge()
    {
    }

    [Token(Token = "0x60133C2")]
    [Address(RVA = "0x4A21B50", Offset = "0x4A21B50", VA = "0x4A21B50")]
    protected void SetLeaderUnit(int styleId)
    {
    }

    [Token(Token = "0x60133C3")]
    [Address(RVA = "0x4A22130", Offset = "0x4A22130", VA = "0x4A22130")]
    private void SetUnitUnk(int count)
    {
    }

    [Token(Token = "0x60133C4")]
    [Address(RVA = "0x4A22224", Offset = "0x4A22224", VA = "0x4A22224")]
    protected void SetUnit(
      List<ArenaPlayerListEnemy.EnemyParam.UnitParam> Units)
    {
    }

    [Token(Token = "0x60133C5")]
    [Address(RVA = "0x4A22C04", Offset = "0x4A22C04", VA = "0x4A22C04")]
    protected void SetUnit(List<UnitParameterData> Units)
    {
    }

    [Token(Token = "0x60133C6")]
    [Address(RVA = "0x4A22A18", Offset = "0x4A22A18", VA = "0x4A22A18")]
    protected void SetUnit(int styleId, int level, int rarityStar, int element, StyleThumb thum)
    {
    }

    [Token(Token = "0x60133C7")]
    [Address(RVA = "0x4A2246C", Offset = "0x4A2246C", VA = "0x4A2246C")]
    protected void SetProfile(string playerName, int level)
    {
    }

    [Token(Token = "0x60133C8")]
    [Address(RVA = "0x4A21750", Offset = "0x4A21750", VA = "0x4A21750")]
    public void SetRanking(int ranking, bool lowest = false)
    {
    }

    [Token(Token = "0x60133C9")]
    [Address(RVA = "0x4A21DCC", Offset = "0x4A21DCC", VA = "0x4A21DCC")]
    public ArenaPlayerListEnemy()
    {
    }

    [Token(Token = "0x2003149")]
    protected enum RankColor
    {
      [Token(Token = "0x400D1E7")] normal,
      [Token(Token = "0x400D1E8")] bronze,
      [Token(Token = "0x400D1E9")] silver,
      [Token(Token = "0x400D1EA")] gold,
    }

    [Token(Token = "0x200314A")]
    public class EnemyParam
    {
      [Token(Token = "0x400D1EB")]
      [FieldOffset(Offset = "0x10")]
      public string name;
      [Token(Token = "0x400D1EC")]
      [FieldOffset(Offset = "0x18")]
      public string power;
      [Token(Token = "0x400D1ED")]
      [FieldOffset(Offset = "0x20")]
      public int level;
      [Token(Token = "0x400D1EE")]
      [FieldOffset(Offset = "0x24")]
      public int ranking;
      [Token(Token = "0x400D1EF")]
      [FieldOffset(Offset = "0x28")]
      public Dictionary<int, ArenaPlayerListEnemy.EnemyParam.UnitParam> unitParamList;
      [Token(Token = "0x400D1F0")]
      [FieldOffset(Offset = "0x30")]
      public int symbolStyleId;
      [Token(Token = "0x400D1F1")]
      [FieldOffset(Offset = "0x34")]
      public int emblemId;

      [Token(Token = "0x60133CA")]
      [Address(RVA = "0x4A22D84", Offset = "0x4A22D84", VA = "0x4A22D84")]
      private int CalcStyleLevel(int styleId, int exp) => new int();

      [Token(Token = "0x60133CB")]
      [Address(RVA = "0x4A22E7C", Offset = "0x4A22E7C", VA = "0x4A22E7C")]
      public EnemyParam(EnemyArenaRankingType enemy)
      {
      }

      [Token(Token = "0x200314B")]
      public class UnitParam
      {
        [Token(Token = "0x400D1F2")]
        [FieldOffset(Offset = "0x10")]
        public int styleId;
        [Token(Token = "0x400D1F3")]
        [FieldOffset(Offset = "0x14")]
        public int level;
        [Token(Token = "0x400D1F4")]
        [FieldOffset(Offset = "0x18")]
        public int rarity;

        [Token(Token = "0x60133CC")]
        [Address(RVA = "0x4A23724", Offset = "0x4A23724", VA = "0x4A23724")]
        public UnitParam()
        {
        }
      }
    }
  }
}
