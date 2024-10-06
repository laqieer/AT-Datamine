// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A4")]
  public class FgGIDMissionListItemView : MonoBehaviour
  {
    [Token(Token = "0x4006E0D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("報酬アイコン")]
    private RawImage imageRewardIcon;
    [Token(Token = "0x4006E0E")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    [Header("タイトル")]
    [SerializeField]
    private TextMeshProUGUI textTitle;
    [Token(Token = "0x4006E0F")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [Header("詳細")]
    [SerializeField]
    private TextMeshProUGUI textDescription;
    [Token(Token = "0x4006E10")]
    [FieldOffset(Offset = "0x30")]
    [Header("報酬内容")]
    [Space(10f)]
    [SerializeField]
    private TextMeshProUGUI textReward;
    [Token(Token = "0x4006E11")]
    [FieldOffset(Offset = "0x38")]
    [Space(10f)]
    [Header("期間表示")]
    [SerializeField]
    private GameObject endDateRoot;
    [Token(Token = "0x4006E12")]
    [FieldOffset(Offset = "0x40")]
    [Tooltip("チャレンジ期間")]
    [SerializeField]
    private TextMeshProUGUI textChallengeEndDateTime;
    [Token(Token = "0x4006E13")]
    [FieldOffset(Offset = "0x48")]
    [Tooltip("報酬受け取り期間")]
    [SerializeField]
    private TextMeshProUGUI textRewardEndDateTime;
    [Token(Token = "0x4006E14")]
    [FieldOffset(Offset = "0x50")]
    [Space(10f)]
    [Header("受け取りボタン")]
    [SerializeField]
    private Button buttonReceive;
    [Token(Token = "0x4006E15")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("挑戦ボタン")]
    [Space(10f)]
    private Button buttonChallenge;
    [Token(Token = "0x4006E16")]
    [FieldOffset(Offset = "0x60")]
    [Space(10f)]
    [Header("未達成")]
    [SerializeField]
    private GameObject objectNotAchieved;
    [Token(Token = "0x4006E17")]
    [FieldOffset(Offset = "0x68")]
    private bool isOwnApp;
    [Token(Token = "0x4006E18")]
    [FieldOffset(Offset = "0x70")]
    private IFgGIDMissionListItemPresenter presenter;

    [Token(Token = "0x1700178B")]
    public IFgGIDMissionListItemPresenter Presenter
    {
      [Token(Token = "0x6009244"), Address(RVA = "0x4D0EF0C", Offset = "0x4D0EF0C", VA = "0x4D0EF0C")] set
      {
      }
    }

    [Token(Token = "0x6009245")]
    [Address(RVA = "0x4D0FC70", Offset = "0x4D0FC70", VA = "0x4D0FC70")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009246")]
    [Address(RVA = "0x4D0FD80", Offset = "0x4D0FD80", VA = "0x4D0FD80")]
    public void SetRewardIcon(Texture texture)
    {
    }

    [Token(Token = "0x6009247")]
    [Address(RVA = "0x4D0EAF8", Offset = "0x4D0EAF8", VA = "0x4D0EAF8")]
    public void SetTitleText(string value)
    {
    }

    [Token(Token = "0x6009248")]
    [Address(RVA = "0x4D0EB1C", Offset = "0x4D0EB1C", VA = "0x4D0EB1C")]
    public void SetDescriptionText(string value)
    {
    }

    [Token(Token = "0x6009249")]
    [Address(RVA = "0x4D0EB40", Offset = "0x4D0EB40", VA = "0x4D0EB40")]
    public void SetRewardText(string value)
    {
    }

    [Token(Token = "0x600924A")]
    [Address(RVA = "0x4D0EB64", Offset = "0x4D0EB64", VA = "0x4D0EB64")]
    public void SetChallengeEndDateTimeText(string value)
    {
    }

    [Token(Token = "0x600924B")]
    [Address(RVA = "0x4D0EB88", Offset = "0x4D0EB88", VA = "0x4D0EB88")]
    public void SetRewardEndDateTimeText(string value)
    {
    }

    [Token(Token = "0x600924C")]
    [Address(RVA = "0x4D0EBAC", Offset = "0x4D0EBAC", VA = "0x4D0EBAC")]
    public void SetIsReceivable(bool isReceivable)
    {
    }

    [Token(Token = "0x600924D")]
    [Address(RVA = "0x4D0FDD0", Offset = "0x4D0FDD0", VA = "0x4D0FDD0")]
    public void SetIsOwnAppView(bool isOwnApp)
    {
    }

    [Token(Token = "0x600924E")]
    [Address(RVA = "0x4D0FDDC", Offset = "0x4D0FDDC", VA = "0x4D0FDDC")]
    private void OnReceiveButtonClicked()
    {
    }

    [Token(Token = "0x600924F")]
    [Address(RVA = "0x4D0FE80", Offset = "0x4D0FE80", VA = "0x4D0FE80")]
    private void OnChallengeButtonClicked()
    {
    }

    [Token(Token = "0x6009250")]
    [Address(RVA = "0x4D0FF24", Offset = "0x4D0FF24", VA = "0x4D0FF24")]
    public FgGIDMissionListItemView()
    {
    }
  }
}
