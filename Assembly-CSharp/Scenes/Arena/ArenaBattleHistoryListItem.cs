// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaBattleHistoryListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003122")]
  public class ArenaBattleHistoryListItem : MonoBehaviour
  {
    [Token(Token = "0x400D139")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject winObj;
    [Token(Token = "0x400D13A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject loseObj;
    [Token(Token = "0x400D13B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI level;
    [Token(Token = "0x400D13C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI totalPower;
    [Token(Token = "0x400D13D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI playerName;
    [Token(Token = "0x400D13E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text endAt;
    [Token(Token = "0x400D13F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private StyleThumb thumbnail;
    [Token(Token = "0x400D140")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400D141")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject offence;
    [Token(Token = "0x400D142")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject defense;
    [Token(Token = "0x400D143")]
    [FieldOffset(Offset = "0x68")]
    private Action<int> onClickDetail;

    [Token(Token = "0x60132E1")]
    [Address(RVA = "0x45E4618", Offset = "0x45E4618", VA = "0x45E4618")]
    public void Setup(
      ArenaBattleHistoryType historyData,
      Sprite thumbnailSprite,
      Action<long> onClickDetail)
    {
    }

    [Token(Token = "0x60132E2")]
    [Address(RVA = "0x45E48BC", Offset = "0x45E48BC", VA = "0x45E48BC")]
    private string GetTimeText(string endAt) => (string) null;

    [Token(Token = "0x60132E3")]
    [Address(RVA = "0x45E4960", Offset = "0x45E4960", VA = "0x45E4960")]
    public ArenaBattleHistoryListItem()
    {
    }
  }
}
