// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldAutoTurretSimpleStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022F2")]
  public class FieldAutoTurretSimpleStatus : MonoBehaviour
  {
    [Token(Token = "0x40093C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40093C9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI autoTurretName;
    [Token(Token = "0x40093CA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button statusButton;
    [Token(Token = "0x40093CB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject statusButtonOff;
    [Token(Token = "0x40093CC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject statusButtonOn;
    [Token(Token = "0x40093CD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button detailButton;
    [Token(Token = "0x40093CE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject detailButtonOff;
    [Token(Token = "0x40093CF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject detailButtonOn;
    [Token(Token = "0x40093D0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject statusView;
    [Token(Token = "0x40093D1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject detailView;
    [Token(Token = "0x40093D2")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SkillRangeView skillRangeView;
    [Token(Token = "0x40093D3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private IconUI[] rangeTypeIcons;
    [Token(Token = "0x40093D4")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI rangeMin;
    [Token(Token = "0x40093D5")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI rangeMax;
    [Token(Token = "0x40093D6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CustomSkillIcon mainSkillIcon;
    [Token(Token = "0x40093D7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private SkillIconSub[] subSkillIcons;
    [Token(Token = "0x40093D8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI coolTime;
    [Token(Token = "0x40093D9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI skillDetail;
    [Token(Token = "0x40093DA")]
    [FieldOffset(Offset = "0xA8")]
    private bool visible;

    [Token(Token = "0x600D5AF")]
    [Address(RVA = "0x1D16C24", Offset = "0x1D16C24", VA = "0x1D16C24")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D5B0")]
    [Address(RVA = "0x1D16D24", Offset = "0x1D16D24", VA = "0x1D16D24")]
    public void UpdateStatus(FacilityData facilityData)
    {
    }

    [Token(Token = "0x600D5B1")]
    [Address(RVA = "0x1D17104", Offset = "0x1D17104", VA = "0x1D17104")]
    private void SetMainSkillIcon(FacilityData facilityData)
    {
    }

    [Token(Token = "0x600D5B2")]
    [Address(RVA = "0x1D1733C", Offset = "0x1D1733C", VA = "0x1D1733C")]
    private void SetSubSkillIcon(FacilityData facilityData)
    {
    }

    [Token(Token = "0x600D5B3")]
    [Address(RVA = "0x1D176EC", Offset = "0x1D176EC", VA = "0x1D176EC")]
    public void Show()
    {
    }

    [Token(Token = "0x600D5B4")]
    [Address(RVA = "0x1D17760", Offset = "0x1D17760", VA = "0x1D17760")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D5B5")]
    [Address(RVA = "0x1D177D0", Offset = "0x1D177D0", VA = "0x1D177D0")]
    private void OnStatusButton()
    {
    }

    [Token(Token = "0x600D5B6")]
    [Address(RVA = "0x1D17858", Offset = "0x1D17858", VA = "0x1D17858")]
    private void OnDetailButton()
    {
    }

    [Token(Token = "0x600D5B7")]
    [Address(RVA = "0x1D178E0", Offset = "0x1D178E0", VA = "0x1D178E0")]
    public FieldAutoTurretSimpleStatus()
    {
    }
  }
}
