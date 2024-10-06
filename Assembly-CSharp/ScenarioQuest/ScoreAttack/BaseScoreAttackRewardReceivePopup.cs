// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.BaseScoreAttackRewardReceivePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000834")]
  public class BaseScoreAttackRewardReceivePopup : PopupBase
  {
    [Token(Token = "0x4002718")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Header("共通部分")]
    protected ItemIcon icon;
    [Token(Token = "0x4002719")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    protected Transform iconRoot;
    [Token(Token = "0x400271A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    protected Text textTitle;
    [Token(Token = "0x400271B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    protected CommonButton closeButton;
    [Token(Token = "0x400271C")]
    [FieldOffset(Offset = "0xA8")]
    protected BaseScoreAttackRewardReceivePopup.RewardType _type;
    [Token(Token = "0x400271D")]
    [FieldOffset(Offset = "0xB0")]
    private Action _closeAction;

    [Token(Token = "0x6002F39")]
    [Address(RVA = "0x3E6D050", Offset = "0x3E6D050", VA = "0x3E6D050")]
    public static (string, string) GetAssetName(BaseScoreAttackRewardReceivePopup.RewardType type)
    {
      return ();
    }

    [Token(Token = "0x6002F3A")]
    [Address(RVA = "0x3E6D124", Offset = "0x3E6D124", VA = "0x3E6D124")]
    protected void Initialize(List<Network.Param.Reward> rewards, AssetCachedSpawner spawner, Action closeAction = null)
    {
    }

    [Token(Token = "0x6002F3B")]
    [Address(RVA = "0x3E6D388", Offset = "0x3E6D388", VA = "0x3E6D388", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6002F3C")]
    [Address(RVA = "0x3E6D3B8", Offset = "0x3E6D3B8", VA = "0x3E6D3B8")]
    public BaseScoreAttackRewardReceivePopup()
    {
    }

    [Token(Token = "0x2000835")]
    public enum RewardType
    {
      [Token(Token = "0x400271F")] Ranking,
      [Token(Token = "0x4002720")] HighScore,
      [Token(Token = "0x4002721")] TotalScore,
    }
  }
}
