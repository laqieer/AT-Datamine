// Decompiled with JetBrains decompiler
// Type: Battle.UI.RewardItemPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002338")]
  public sealed class RewardItemPanel : MonoBehaviour
  {
    [Token(Token = "0x400956E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400956F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x4009570")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject oneTimeLabel;
    [Token(Token = "0x4009571")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI itemNum;

    [Token(Token = "0x600D757")]
    [Address(RVA = "0x1D27418", Offset = "0x1D27418", VA = "0x1D27418")]
    public void Set(
      ItemTypeEnum itemType,
      int id,
      int amount,
      bool isFirstTime,
      bool isOneTimeReward)
    {
    }

    [Token(Token = "0x600D758")]
    [Address(RVA = "0x1D1BF4C", Offset = "0x1D1BF4C", VA = "0x1D1BF4C")]
    public void Set(
      RewardTypeEnum rewardType,
      int id,
      int amount,
      bool isFirstTime,
      bool isOneTimeReward)
    {
    }

    [Token(Token = "0x600D759")]
    [Address(RVA = "0x1D275B4", Offset = "0x1D275B4", VA = "0x1D275B4")]
    public RewardItemPanel()
    {
    }
  }
}
