// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.QuestStartButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200083E")]
  public class QuestStartButton : MonoBehaviour
  {
    [Token(Token = "0x4002741")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton questStartButton;
    [Token(Token = "0x4002742")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private APIconView apIcon;
    [Token(Token = "0x4002743")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject lockObject;
    [Token(Token = "0x4002744")]
    [FieldOffset(Offset = "0x30")]
    [Header("AP消費無しオブジェクト")]
    [SerializeField]
    private GameObject ApNoConsumeObject;
    [Token(Token = "0x4002745")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI freeApText;
    [Token(Token = "0x4002747")]
    [FieldOffset(Offset = "0x48")]
    private int _selectedQuestId;
    [Token(Token = "0x4002748")]
    [FieldOffset(Offset = "0x4C")]
    private bool _isLock;

    [Token(Token = "0x170006F5")]
    private bool IsFreeAp
    {
      [Token(Token = "0x6002F61"), Address(RVA = "0x3E6EF60", Offset = "0x3E6EF60", VA = "0x3E6EF60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x140000E4")]
    public event Func<int> GetFreeNum
    {
      [Token(Token = "0x6002F62"), Address(RVA = "0x3E6F040", Offset = "0x3E6F040", VA = "0x3E6F040")] add
      {
      }
      [Token(Token = "0x6002F63"), Address(RVA = "0x3E6F0F0", Offset = "0x3E6F0F0", VA = "0x3E6F0F0")] remove
      {
      }
    }

    [Token(Token = "0x6002F64")]
    [Address(RVA = "0x3E6EFC4", Offset = "0x3E6EFC4", VA = "0x3E6EFC4")]
    public int? FreeApNum() => new int?();

    [Token(Token = "0x170006F6")]
    public int SelectedQuestId
    {
      [Token(Token = "0x6002F65"), Address(RVA = "0x3E6F1A0", Offset = "0x3E6F1A0", VA = "0x3E6F1A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6002F66"), Address(RVA = "0x3E6F1A8", Offset = "0x3E6F1A8", VA = "0x3E6F1A8")] set
      {
      }
    }

    [Token(Token = "0x170006F7")]
    public bool IsLock
    {
      [Token(Token = "0x6002F67"), Address(RVA = "0x3E6F204", Offset = "0x3E6F204", VA = "0x3E6F204")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002F68"), Address(RVA = "0x3E6F20C", Offset = "0x3E6F20C", VA = "0x3E6F20C")] set
      {
      }
    }

    [Token(Token = "0x6002F69")]
    [Address(RVA = "0x3E6F218", Offset = "0x3E6F218", VA = "0x3E6F218")]
    public void Initialize(int scoreAttackId)
    {
    }

    [Token(Token = "0x6002F6A")]
    [Address(RVA = "0x3E6F2D0", Offset = "0x3E6F2D0", VA = "0x3E6F2D0")]
    public void SetPlayButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x6002F6B")]
    [Address(RVA = "0x3E6F320", Offset = "0x3E6F320", VA = "0x3E6F320")]
    public void ApSet(int cost)
    {
    }

    [Token(Token = "0x6002F6C")]
    [Address(RVA = "0x3E6F21C", Offset = "0x3E6F21C", VA = "0x3E6F21C")]
    public void SetApConsume(int scoreAttackId)
    {
    }

    [Token(Token = "0x6002F6D")]
    [Address(RVA = "0x3E6F340", Offset = "0x3E6F340", VA = "0x3E6F340")]
    private void SetFreeApText(int scoreAttackId)
    {
    }

    [Token(Token = "0x6002F6E")]
    [Address(RVA = "0x3E6F1B0", Offset = "0x3E6F1B0", VA = "0x3E6F1B0")]
    private void OnQuestChanged()
    {
    }

    [Token(Token = "0x6002F6F")]
    [Address(RVA = "0x3E6F6A4", Offset = "0x3E6F6A4", VA = "0x3E6F6A4")]
    public QuestStartButton()
    {
    }
  }
}
