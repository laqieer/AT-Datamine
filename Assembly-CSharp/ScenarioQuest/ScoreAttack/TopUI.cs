// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.TopUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200087B")]
  public class TopUI : MonoBehaviour
  {
    [Token(Token = "0x400280D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textDate;
    [Token(Token = "0x400280E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400280F")]
    [FieldOffset(Offset = "0x28")]
    [Header("Button")]
    [SerializeField]
    private CommonButton buttonRule;
    [Token(Token = "0x4002810")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton buttonHowTo;
    [Token(Token = "0x4002811")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton buttonPlay;
    [Token(Token = "0x4002812")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton buttonBack;

    [Token(Token = "0x6003097")]
    [Address(RVA = "0x3E76964", Offset = "0x3E76964", VA = "0x3E76964")]
    public void Initialize(AssetCachedSpawner spawner, int scoreAttackId)
    {
    }

    [Token(Token = "0x6003098")]
    [Address(RVA = "0x3E76D68", Offset = "0x3E76D68", VA = "0x3E76D68")]
    public void SetRuleButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x6003099")]
    [Address(RVA = "0x3E76DD0", Offset = "0x3E76DD0", VA = "0x3E76DD0")]
    public void SetHowToButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x600309A")]
    [Address(RVA = "0x3E7A3F8", Offset = "0x3E7A3F8", VA = "0x3E7A3F8")]
    public void SetPlayButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x600309B")]
    [Address(RVA = "0x3E76E84", Offset = "0x3E76E84", VA = "0x3E76E84")]
    public void SetBackButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x600309C")]
    [Address(RVA = "0x3E7A448", Offset = "0x3E7A448", VA = "0x3E7A448")]
    private ScoreAttackEventData GetMasterData(int scoreAttackId) => (ScoreAttackEventData) null;

    [Token(Token = "0x600309D")]
    [Address(RVA = "0x3E7A2F4", Offset = "0x3E7A2F4", VA = "0x3E7A2F4")]
    private void SetOpenText(int id)
    {
    }

    [Token(Token = "0x600309E")]
    [Address(RVA = "0x3E7A340", Offset = "0x3E7A340", VA = "0x3E7A340")]
    private void CreateAPHeader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600309F")]
    [Address(RVA = "0x3E7A450", Offset = "0x3E7A450", VA = "0x3E7A450")]
    public TopUI()
    {
    }
  }
}
