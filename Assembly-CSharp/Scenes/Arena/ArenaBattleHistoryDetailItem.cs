// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaBattleHistoryDetailItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003119")]
  public class ArenaBattleHistoryDetailItem : MonoBehaviour
  {
    [Token(Token = "0x400D101")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI txtName;
    [Token(Token = "0x400D102")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI txtLevel;
    [Token(Token = "0x400D103")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI txtTotalPower;
    [Token(Token = "0x400D104")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject winObj;
    [Token(Token = "0x400D105")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject loseObj;
    [Token(Token = "0x400D106")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StyleThumb thumbPrefab;
    [Token(Token = "0x400D107")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<Transform> positions;
    [Token(Token = "0x400D108")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject offence;
    [Token(Token = "0x400D109")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject defense;

    [Token(Token = "0x60132BC")]
    [Address(RVA = "0x45E29A8", Offset = "0x45E29A8", VA = "0x45E29A8")]
    public void Initialize(
      bool isWin,
      bool isAttack,
      List<PlayerUnitArenaHistoryType> units,
      string playerName,
      int exp,
      int totalPower)
    {
    }

    [Token(Token = "0x60132BD")]
    [Address(RVA = "0x45E2D98", Offset = "0x45E2D98", VA = "0x45E2D98")]
    public ArenaBattleHistoryDetailItem()
    {
    }
  }
}
