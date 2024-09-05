// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System.Collections;
using UI;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001641")]
  public class QuestUI : MonoBehaviour
  {
    [Token(Token = "0x4006506")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x4006507")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor description;
    [Token(Token = "0x4006508")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private QuestPeriodUI period;
    [Token(Token = "0x4006509")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image repeat;
    [Token(Token = "0x400650A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private QuestProgressUI progressUI;
    [Token(Token = "0x400650B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private QuestRewardUI rewardUI;
    [Token(Token = "0x400650C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private QuestRewardCustomSkillUI rewardSkillUI;
    [Token(Token = "0x400650D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private QuestButtonLayoutControUI questButtonLayoutControl;
    [Token(Token = "0x400650E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private QuestStatePlateUI questStatePlate;
    [Token(Token = "0x400650F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextAccessor questConditionsText;
    [Token(Token = "0x4006510")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TriangleUI triangleUI;
    [Token(Token = "0x4006511")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject repeatObj;
    [Token(Token = "0x4006514")]
    [FieldOffset(Offset = "0x88")]
    private PopupBase openedPopup;
    [Token(Token = "0x4006515")]
    [FieldOffset(Offset = "0x90")]
    private ItemDetailPopupGenerator itemDetailPopupGenerator;

    [Token(Token = "0x1700138D")]
    public QuestButtonLayoutControUI QuestButtonLayoutControUI
    {
      [Token(Token = "0x6007E34"), Address(RVA = "0x21AD648", Offset = "0x21AD648", VA = "0x21AD648")] get
      {
        return (QuestButtonLayoutControUI) null;
      }
    }

    [Token(Token = "0x1700138E")]
    public QuestStatePlateUI QuestStatePlateUI
    {
      [Token(Token = "0x6007E35"), Address(RVA = "0x21AD650", Offset = "0x21AD650", VA = "0x21AD650")] get
      {
        return (QuestStatePlateUI) null;
      }
    }

    [Token(Token = "0x1700138F")]
    public TriangleUI TriangleUI
    {
      [Token(Token = "0x6007E36"), Address(RVA = "0x21AD658", Offset = "0x21AD658", VA = "0x21AD658")] get
      {
        return (TriangleUI) null;
      }
    }

    [Token(Token = "0x17001390")]
    public IQuestUIEvent QuestUIEvent
    {
      [Token(Token = "0x6007E37"), Address(RVA = "0x21AD660", Offset = "0x21AD660", VA = "0x21AD660")] get
      {
        return (IQuestUIEvent) null;
      }
      [Token(Token = "0x6007E38"), Address(RVA = "0x21AD668", Offset = "0x21AD668", VA = "0x21AD668")] set
      {
      }
    }

    [Token(Token = "0x17001391")]
    public bool IsResourceLoading
    {
      [Token(Token = "0x6007E39"), Address(RVA = "0x21AD670", Offset = "0x21AD670", VA = "0x21AD670")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007E3A"), Address(RVA = "0x21AD678", Offset = "0x21AD678", VA = "0x21AD678")] private set
      {
      }
    }

    [Token(Token = "0x6007E3B")]
    [Address(RVA = "0x21AC464", Offset = "0x21AC464", VA = "0x21AC464")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6007E3C")]
    [Address(RVA = "0x21AC6FC", Offset = "0x21AC6FC", VA = "0x21AC6FC")]
    public void Set(IQuestDataSetter questDataSetter)
    {
    }

    [Token(Token = "0x6007E3D")]
    [Address(RVA = "0x21AC854", Offset = "0x21AC854", VA = "0x21AC854")]
    public void Set(QuestUIStateHandler questUIHandler)
    {
    }

    [Token(Token = "0x6007E3E")]
    [Address(RVA = "0x21AD6F8", Offset = "0x21AD6F8", VA = "0x21AD6F8")]
    public void OnClose()
    {
    }

    [Token(Token = "0x6007E3F")]
    [Address(RVA = "0x21AD7B4", Offset = "0x21AD7B4", VA = "0x21AD7B4")]
    public void OnPositive()
    {
    }

    [Token(Token = "0x6007E40")]
    [Address(RVA = "0x21AD85C", Offset = "0x21AD85C", VA = "0x21AD85C")]
    public void OnNegative()
    {
    }

    [Token(Token = "0x6007E41")]
    [Address(RVA = "0x21AD908", Offset = "0x21AD908", VA = "0x21AD908")]
    public void OnNeutral()
    {
    }

    [Token(Token = "0x6007E42")]
    [Address(RVA = "0x21AD9B4", Offset = "0x21AD9B4", VA = "0x21AD9B4")]
    public void OnMap()
    {
    }

    [Token(Token = "0x6007E43")]
    [Address(RVA = "0x21ADA60", Offset = "0x21ADA60", VA = "0x21ADA60")]
    private void OnActionRewardInfo(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6007E44")]
    [Address(RVA = "0x21ADA80", Offset = "0x21ADA80", VA = "0x21ADA80")]
    private IEnumerator StartRewardInfo(RewardTypeEnum rewardType, int rewardId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007E45")]
    [Address(RVA = "0x21ADB24", Offset = "0x21ADB24", VA = "0x21ADB24")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x6007E46")]
    [Address(RVA = "0x21ADBA8", Offset = "0x21ADBA8", VA = "0x21ADBA8")]
    public QuestUI()
    {
    }
  }
}
