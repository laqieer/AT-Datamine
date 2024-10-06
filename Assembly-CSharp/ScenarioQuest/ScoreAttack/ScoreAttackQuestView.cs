// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackQuestView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Home.Bannner;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000840")]
  public class ScoreAttackQuestView : MonoBehaviour
  {
    [Token(Token = "0x400274D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("難易度選択")]
    private ScrollRect scrollRect;
    [Token(Token = "0x400274E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestContent questContent;
    [Token(Token = "0x400274F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI basicScore;
    [Token(Token = "0x4002750")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("ドット用オブジェクト")]
    private HomeBannerDotView dotObject;
    [Token(Token = "0x4002751")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject dotObjectRoot;
    [Token(Token = "0x4002752")]
    [FieldOffset(Offset = "0x40")]
    [Header("推奨属性")]
    [SerializeField]
    private TypeIcon typeIcon;
    [Token(Token = "0x4002753")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("TotalHP")]
    private TextMeshProUGUI textTotalHp;
    [Token(Token = "0x4002754")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton buttonRight;
    [Token(Token = "0x4002755")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton buttonLeft;
    [Token(Token = "0x4002756")]
    [FieldOffset(Offset = "0x60")]
    private List<QuestInfo> questList;
    [Token(Token = "0x4002757")]
    [FieldOffset(Offset = "0x68")]
    private List<HomeBannerDotView> _dotList;
    [Token(Token = "0x4002758")]
    [FieldOffset(Offset = "0x70")]
    private int selectedQuestId;
    [Token(Token = "0x4002759")]
    [FieldOffset(Offset = "0x78")]
    private Action<int> onChangeStartButtonQuest;
    [Token(Token = "0x400275A")]
    [FieldOffset(Offset = "0x80")]
    private int _scoreAttackId;

    [Token(Token = "0x170006FA")]
    private int SelectedQuestId
    {
      [Token(Token = "0x6002F7A"), Address(RVA = "0x3E6F970", Offset = "0x3E6F970", VA = "0x3E6F970")] get
      {
        return new int();
      }
      [Token(Token = "0x6002F7B"), Address(RVA = "0x3E6F978", Offset = "0x3E6F978", VA = "0x3E6F978")] set
      {
      }
    }

    [Token(Token = "0x6002F7C")]
    [Address(RVA = "0x3E6F9A4", Offset = "0x3E6F9A4", VA = "0x3E6F9A4")]
    public int ChangeQuestId() => new int();

    [Token(Token = "0x6002F7D")]
    [Address(RVA = "0x3E6F9D4", Offset = "0x3E6F9D4", VA = "0x3E6F9D4")]
    public void Initialize(
      AssetCachedSpawner spawner,
      int scoreAttackId,
      int questId,
      Action<int> onChangeQuestIdAction = null)
    {
    }

    [Token(Token = "0x6002F7E")]
    [Address(RVA = "0x3E7028C", Offset = "0x3E7028C", VA = "0x3E7028C")]
    public void SetQuestInfo()
    {
    }

    [Token(Token = "0x6002F7F")]
    [Address(RVA = "0x3E70850", Offset = "0x3E70850", VA = "0x3E70850")]
    private void OnClickRight()
    {
    }

    [Token(Token = "0x6002F80")]
    [Address(RVA = "0x3E70A84", Offset = "0x3E70A84", VA = "0x3E70A84")]
    private void OnClickLeft()
    {
    }

    [Token(Token = "0x6002F81")]
    [Address(RVA = "0x3E6FDAC", Offset = "0x3E6FDAC", VA = "0x3E6FDAC")]
    private void Create(int scoreAttackId, int questId)
    {
    }

    [Token(Token = "0x6002F82")]
    [Address(RVA = "0x3E70E50", Offset = "0x3E70E50", VA = "0x3E70E50")]
    private void CreateQuest(ScoreAttackQuestData quest)
    {
    }

    [Token(Token = "0x6002F83")]
    [Address(RVA = "0x3E70F34", Offset = "0x3E70F34", VA = "0x3E70F34")]
    private void CreateDot()
    {
    }

    [Token(Token = "0x6002F84")]
    [Address(RVA = "0x3E70FE8", Offset = "0x3E70FE8", VA = "0x3E70FE8")]
    private HomeBannerDotView CreateBannerDotView(bool isSelected) => (HomeBannerDotView) null;

    [Token(Token = "0x6002F85")]
    [Address(RVA = "0x3E703C8", Offset = "0x3E703C8", VA = "0x3E703C8")]
    private void SetDotHighlight(int index)
    {
    }

    [Token(Token = "0x6002F86")]
    [Address(RVA = "0x3E70C98", Offset = "0x3E70C98", VA = "0x3E70C98")]
    private void ClearDot()
    {
    }

    [Token(Token = "0x6002F87")]
    [Address(RVA = "0x3E702B4", Offset = "0x3E702B4", VA = "0x3E702B4")]
    private void SetButtonInteractable()
    {
    }

    [Token(Token = "0x6002F88")]
    [Address(RVA = "0x3E7049C", Offset = "0x3E7049C", VA = "0x3E7049C")]
    private void SetRecommendElementIcon()
    {
    }

    [Token(Token = "0x6002F89")]
    [Address(RVA = "0x3E70650", Offset = "0x3E70650", VA = "0x3E70650")]
    private void SetTotalHp()
    {
    }

    [Token(Token = "0x6002F8A")]
    [Address(RVA = "0x3E710C0", Offset = "0x3E710C0", VA = "0x3E710C0")]
    private int GetTotalHp(BattleData battleData) => new int();

    [Token(Token = "0x6002F8B")]
    [Address(RVA = "0x3E706F4", Offset = "0x3E706F4", VA = "0x3E706F4")]
    private void SetDiffName()
    {
    }

    [Token(Token = "0x6002F8C")]
    [Address(RVA = "0x3E70730", Offset = "0x3E70730", VA = "0x3E70730")]
    private void SetBasicScore()
    {
    }

    [Token(Token = "0x6002F8D")]
    [Address(RVA = "0x3E714BC", Offset = "0x3E714BC", VA = "0x3E714BC")]
    private (int, int) CreateParam(NpcUnitDataData npc) => ();

    [Token(Token = "0x6002F8E")]
    [Address(RVA = "0x3E71E44", Offset = "0x3E71E44", VA = "0x3E71E44")]
    public ScoreAttackQuestView()
    {
    }
  }
}
