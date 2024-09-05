// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.HighScoreRankingItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200083A")]
  public class HighScoreRankingItem : MonoBehaviour
  {
    [Token(Token = "0x4002731")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ownerArrow;
    [Token(Token = "0x4002732")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI rankValue;
    [Token(Token = "0x4002733")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GameObject> rankValueBackground;
    [Token(Token = "0x4002734")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x4002735")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI guildName;
    [Token(Token = "0x4002736")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI playerName;
    [Token(Token = "0x4002737")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI highScoreValue;
    [Token(Token = "0x4002738")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x4002739")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner spawner;

    [Token(Token = "0x6002F51")]
    [Address(RVA = "0x3E6DC3C", Offset = "0x3E6DC3C", VA = "0x3E6DC3C")]
    public void Initialize(
      AssetCachedSpawner spawner,
      PlayerScoreAttackRankingDetailType playerRankingInfo)
    {
    }

    [Token(Token = "0x6002F52")]
    [Address(RVA = "0x3E6DA30", Offset = "0x3E6DA30", VA = "0x3E6DA30")]
    public void InitializeNoPlayer()
    {
    }

    [Token(Token = "0x6002F53")]
    [Address(RVA = "0x3E6EC2C", Offset = "0x3E6EC2C", VA = "0x3E6EC2C")]
    private void SetThumb(int styleId)
    {
    }

    [Token(Token = "0x6002F54")]
    [Address(RVA = "0x3E6ED04", Offset = "0x3E6ED04", VA = "0x3E6ED04")]
    private void OpenHighScoreResultPopup(PlayerScoreAttackRankingDetailType data)
    {
    }

    [Token(Token = "0x6002F55")]
    [Address(RVA = "0x3E6ED84", Offset = "0x3E6ED84", VA = "0x3E6ED84")]
    public HighScoreRankingItem()
    {
    }
  }
}
