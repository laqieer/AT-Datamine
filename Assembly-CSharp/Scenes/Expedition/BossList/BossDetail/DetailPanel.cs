// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.DetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D3B")]
  public class DetailPanel : MonoBehaviour
  {
    [Token(Token = "0x400C1EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text stageNameText;
    [Token(Token = "0x400C1EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text fixRewardText;
    [Token(Token = "0x400C1F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text fixRewardNumberText;
    [Token(Token = "0x400C1F1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<ItemIcon> fixRewardIconList;
    [Token(Token = "0x400C1F2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ItemIcon rewardIconBase;
    [Token(Token = "0x400C1F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject fixRewardIconParent;
    [Token(Token = "0x400C1F4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject fixSoulRewardObject;
    [Token(Token = "0x400C1F5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text rareRewardText;
    [Token(Token = "0x400C1F6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text rareRewardNumberText;
    [Token(Token = "0x400C1F7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<ItemIcon> rareRewardIconList;
    [Token(Token = "0x400C1F8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject rareRewardIconParent;
    [Token(Token = "0x400C1F9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject rareSoulRewardObject;
    [Token(Token = "0x400C1FA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject checkObject;
    [Token(Token = "0x400C1FB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private BossDetailCheckText checkText;
    [Token(Token = "0x400C1FC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject focusObject;
    [Token(Token = "0x400C1FD")]
    private const int MaxRewardIconNumber = 7;

    [Token(Token = "0x6011AF2")]
    [Address(RVA = "0x42B05E8", Offset = "0x42B05E8", VA = "0x42B05E8")]
    public void InitBossDetail(
      ExpeditionStageDescriptionData inputStageData,
      bool isBeforeLevelClear,
      bool isFocus)
    {
    }

    [Token(Token = "0x6011AF3")]
    [Address(RVA = "0x42B0660", Offset = "0x42B0660", VA = "0x42B0660")]
    private void SetCheckText(
      ExpeditionStageDescriptionData inputStageData,
      bool isBeforeLevelClear)
    {
    }

    [Token(Token = "0x6011AF4")]
    [Address(RVA = "0x42B0820", Offset = "0x42B0820", VA = "0x42B0820")]
    private void SetDetailPanel(ExpeditionStageDescriptionData inputStageData)
    {
    }

    [Token(Token = "0x6011AF5")]
    [Address(RVA = "0x42B0E00", Offset = "0x42B0E00", VA = "0x42B0E00")]
    private string GetSoulName(int soulId) => (string) null;

    [Token(Token = "0x6011AF6")]
    [Address(RVA = "0x42B0ECC", Offset = "0x42B0ECC", VA = "0x42B0ECC")]
    public DetailPanel()
    {
    }
  }
}
