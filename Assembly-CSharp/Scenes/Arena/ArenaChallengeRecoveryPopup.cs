// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaChallengeRecoveryPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200312A")]
  public class ArenaChallengeRecoveryPopup : PopupBase
  {
    [Token(Token = "0x400D15D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemConsumeText;
    [Token(Token = "0x400D15E")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text recoveryAtText;
    [Token(Token = "0x400D15F")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject noticeTextObj;
    [Token(Token = "0x400D160")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ArenaChallengeRecoveryItemCost paidCoin;
    [Token(Token = "0x400D161")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ArenaChallengeRecoveryItemCost freeCoin;
    [Token(Token = "0x400D162")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private ArenaChallengeRecoveryItemCost ticket;
    [Token(Token = "0x400D163")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400D164")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton recoveryButton;
    [Token(Token = "0x400D165")]
    [FieldOffset(Offset = "0xC8")]
    private string format;
    [Token(Token = "0x400D166")]
    [FieldOffset(Offset = "0xD0")]
    private long arenaId;
    [Token(Token = "0x400D167")]
    [FieldOffset(Offset = "0xD8")]
    private bool isCoinShortage;
    [Token(Token = "0x400D168")]
    [FieldOffset(Offset = "0xE0")]
    private Action<PlayerArenaType> callback;
    [Token(Token = "0x400D169")]
    [FieldOffset(Offset = "0xE8")]
    private arenaCountResetTypeEnum countType;

    [Token(Token = "0x17004041")]
    private RuntimeDataManager runtimeDataManager
    {
      [Token(Token = "0x6013303"), Address(RVA = "0x45E579C", Offset = "0x45E579C", VA = "0x45E579C")] get
      {
        return (RuntimeDataManager) null;
      }
    }

    [Token(Token = "0x17004042")]
    private PlayerProfile playerProfile
    {
      [Token(Token = "0x6013304"), Address(RVA = "0x45E57DC", Offset = "0x45E57DC", VA = "0x45E57DC")] get
      {
        return (PlayerProfile) null;
      }
    }

    [Token(Token = "0x6013305")]
    [Address(RVA = "0x45E57F8", Offset = "0x45E57F8", VA = "0x45E57F8")]
    public void Initialize(long arenaId, bool isNeedRecovery, Action<PlayerArenaType> callback)
    {
    }

    [Token(Token = "0x6013306")]
    [Address(RVA = "0x45E5D64", Offset = "0x45E5D64", VA = "0x45E5D64", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6013307")]
    [Address(RVA = "0x45E5D6C", Offset = "0x45E5D6C", VA = "0x45E5D6C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6013308")]
    [Address(RVA = "0x45E5D8C", Offset = "0x45E5D8C", VA = "0x45E5D8C")]
    public void OnClickRecovery()
    {
    }

    [Token(Token = "0x6013309")]
    [Address(RVA = "0x45E5CFC", Offset = "0x45E5CFC", VA = "0x45E5CFC")]
    private IEnumerator RecoveryCounter() => (IEnumerator) null;

    [Token(Token = "0x601330A")]
    [Address(RVA = "0x45E5E84", Offset = "0x45E5E84", VA = "0x45E5E84")]
    private IEnumerator APIArenaBattleCount() => (IEnumerator) null;

    [Token(Token = "0x601330B")]
    [Address(RVA = "0x45E5F3C", Offset = "0x45E5F3C", VA = "0x45E5F3C")]
    public void OnClickPublishLawsPopup()
    {
    }

    [Token(Token = "0x601330C")]
    [Address(RVA = "0x45E5F44", Offset = "0x45E5F44", VA = "0x45E5F44")]
    public ArenaChallengeRecoveryPopup()
    {
    }
  }
}
