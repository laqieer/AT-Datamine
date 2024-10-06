// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.SubQuestDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.ProceedCondition;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D88")]
  public class SubQuestDetailPopup : PopupBase
  {
    [Token(Token = "0x400C384")]
    private const string JINGLE_PACK_FILE_NAME = "JINGLE_ALL";
    [Token(Token = "0x400C385")]
    private const string RECEIPT_JINGLE_NAME = "JINGLE_QuestReceived";
    [Token(Token = "0x400C386")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI buttonText;
    [Token(Token = "0x400C387")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text limitText;
    [Token(Token = "0x400C388")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text progressDescriptionText;
    [Token(Token = "0x400C389")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text progressText;
    [Token(Token = "0x400C38A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject positiveButtonObj;
    [Token(Token = "0x400C38B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject negativeButtonObj;
    [Token(Token = "0x400C38C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject removeButtonObj;
    [Token(Token = "0x400C38D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public List<RewardItem> rewardList;
    [Token(Token = "0x400C391")]
    [FieldOffset(Offset = "0xE0")]
    private Func<string> NonLimitText;
    [Token(Token = "0x400C392")]
    [FieldOffset(Offset = "0xE8")]
    private TweenAlpha closeTweenAlpha;
    [Token(Token = "0x400C393")]
    [FieldOffset(Offset = "0xF0")]
    private SubQuestDetailPopupToaster cannotProceedNotifyToaster;
    [Token(Token = "0x400C394")]
    [FieldOffset(Offset = "0xF8")]
    private DialogStatus dialogStatus;

    [Token(Token = "0x17003CC7")]
    public string Title
    {
      [Token(Token = "0x6011CC0"), Address(RVA = "0x3F9DA3C", Offset = "0x3F9DA3C", VA = "0x3F9DA3C")] set
      {
      }
    }

    [Token(Token = "0x17003CC8")]
    public string Description
    {
      [Token(Token = "0x6011CC1"), Address(RVA = "0x3F9DA60", Offset = "0x3F9DA60", VA = "0x3F9DA60")] set
      {
      }
    }

    [Token(Token = "0x17003CC9")]
    public string ButtonText
    {
      [Token(Token = "0x6011CC2"), Address(RVA = "0x3F9DA84", Offset = "0x3F9DA84", VA = "0x3F9DA84")] set
      {
      }
    }

    [Token(Token = "0x17003CCA")]
    public string LimitText
    {
      [Token(Token = "0x6011CC3"), Address(RVA = "0x3F9DAA8", Offset = "0x3F9DAA8", VA = "0x3F9DAA8")] set
      {
      }
    }

    [Token(Token = "0x17003CCB")]
    public bool LimitTextEnable
    {
      [Token(Token = "0x6011CC4"), Address(RVA = "0x3F9DACC", Offset = "0x3F9DACC", VA = "0x3F9DACC")] set
      {
      }
    }

    [Token(Token = "0x17003CCC")]
    public string ProgressDescriptionText
    {
      [Token(Token = "0x6011CC5"), Address(RVA = "0x3F9DAEC", Offset = "0x3F9DAEC", VA = "0x3F9DAEC")] set
      {
      }
    }

    [Token(Token = "0x17003CCD")]
    public string ProgressText
    {
      [Token(Token = "0x6011CC6"), Address(RVA = "0x3F9DB10", Offset = "0x3F9DB10", VA = "0x3F9DB10")] set
      {
      }
    }

    [Token(Token = "0x17003CCE")]
    public bool PositiveButtonObj
    {
      [Token(Token = "0x6011CC7"), Address(RVA = "0x3F9DB34", Offset = "0x3F9DB34", VA = "0x3F9DB34")] set
      {
      }
    }

    [Token(Token = "0x17003CCF")]
    public bool NegativeButtonObj
    {
      [Token(Token = "0x6011CC8"), Address(RVA = "0x3F9DB54", Offset = "0x3F9DB54", VA = "0x3F9DB54")] set
      {
      }
    }

    [Token(Token = "0x17003CD0")]
    public bool RemoveButtonObj
    {
      [Token(Token = "0x6011CC9"), Address(RVA = "0x3F9DB74", Offset = "0x3F9DB74", VA = "0x3F9DB74")] set
      {
      }
    }

    [Token(Token = "0x17003CD1")]
    public Action OnClickToPositive
    {
      [Token(Token = "0x6011CCA"), Address(RVA = "0x3F9DB94", Offset = "0x3F9DB94", VA = "0x3F9DB94")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011CCB"), Address(RVA = "0x3F9DB9C", Offset = "0x3F9DB9C", VA = "0x3F9DB9C")] set
      {
      }
    }

    [Token(Token = "0x17003CD2")]
    public Action OnClickToClose
    {
      [Token(Token = "0x6011CCC"), Address(RVA = "0x3F9DBA4", Offset = "0x3F9DBA4", VA = "0x3F9DBA4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011CCD"), Address(RVA = "0x3F9DBAC", Offset = "0x3F9DBAC", VA = "0x3F9DBAC")] set
      {
      }
    }

    [Token(Token = "0x17003CD3")]
    public Action OnClickToRemove
    {
      [Token(Token = "0x6011CCE"), Address(RVA = "0x3F9DBB4", Offset = "0x3F9DBB4", VA = "0x3F9DBB4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011CCF"), Address(RVA = "0x3F9DBBC", Offset = "0x3F9DBBC", VA = "0x3F9DBBC")] set
      {
      }
    }

    [Token(Token = "0x17003CD4")]
    public float CloseTweenDuration
    {
      [Token(Token = "0x6011CD0"), Address(RVA = "0x3F9DBC4", Offset = "0x3F9DBC4", VA = "0x3F9DBC4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6011CD1")]
    [Address(RVA = "0x3F9DC40", Offset = "0x3F9DC40", VA = "0x3F9DC40")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011CD2")]
    [Address(RVA = "0x3F9DDF0", Offset = "0x3F9DDF0", VA = "0x3F9DDF0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011CD3")]
    [Address(RVA = "0x3F9DE94", Offset = "0x3F9DE94", VA = "0x3F9DE94", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011CD4")]
    [Address(RVA = "0x3F9DF24", Offset = "0x3F9DF24", VA = "0x3F9DF24")]
    protected DialogStatus GetDialogStatus(SubQuestData subQuestData) => (DialogStatus) null;

    [Token(Token = "0x6011CD5")]
    [Address(RVA = "0x3F9E76C", Offset = "0x3F9E76C", VA = "0x3F9E76C")]
    public void SetSubQuestData(int subQuestID, bool autoMove = false)
    {
    }

    [Token(Token = "0x6011CD6")]
    [Address(RVA = "0x3F9F18C", Offset = "0x3F9F18C", VA = "0x3F9F18C")]
    public void RewardClear()
    {
    }

    [Token(Token = "0x6011CD7")]
    [Address(RVA = "0x3F9F2AC", Offset = "0x3F9F2AC", VA = "0x3F9F2AC")]
    private bool CannotProceed(IFreeMapProceedCondition proceedCondition) => new bool();

    [Token(Token = "0x6011CD8")]
    [Address(RVA = "0x3F9F52C", Offset = "0x3F9F52C", VA = "0x3F9F52C")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x6011CD9")]
    [Address(RVA = "0x3F9F578", Offset = "0x3F9F578", VA = "0x3F9F578", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011CDA")]
    [Address(RVA = "0x3F9F688", Offset = "0x3F9F688", VA = "0x3F9F688")]
    public void OnClickRemove()
    {
    }

    [Token(Token = "0x6011CDB")]
    [Address(RVA = "0x3F9EF10", Offset = "0x3F9EF10", VA = "0x3F9EF10")]
    private string GetLimitText(int beginID, int endID) => (string) null;

    [Token(Token = "0x6011CDC")]
    [Address(RVA = "0x3F9F6A4", Offset = "0x3F9F6A4", VA = "0x3F9F6A4", Slot = "4")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6011CDD")]
    [Address(RVA = "0x3F9F728", Offset = "0x3F9F728", VA = "0x3F9F728")]
    public SubQuestDetailPopup()
    {
    }
  }
}
