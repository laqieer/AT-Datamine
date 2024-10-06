// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReincarnation_Popup_Confirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A97")]
  public class StyleReincarnation_Popup_Confirm : MonoBehaviour
  {
    [Token(Token = "0x4010143")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x4010144")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BtnFullScreen btnFullScreen;
    [Token(Token = "0x4010145")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] statusDialogKindGameObject;
    [Token(Token = "0x4010146")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text textReincarnation;
    [Token(Token = "0x4010147")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text textReincarnation_PinAveZero;
    [Token(Token = "0x4010148")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x4010149")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton decisionButton;
    [Token(Token = "0x401014A")]
    [FieldOffset(Offset = "0x50")]
    private StyleReincarnation_Popup_Confirm.eResult result;
    [Token(Token = "0x401014B")]
    [FieldOffset(Offset = "0x54")]
    public bool isExecution;

    [Token(Token = "0x6017091")]
    [Address(RVA = "0x2CDF86C", Offset = "0x2CDF86C", VA = "0x2CDF86C")]
    public void Initialized()
    {
    }

    [Token(Token = "0x6017092")]
    [Address(RVA = "0x2CDF9DC", Offset = "0x2CDF9DC", VA = "0x2CDF9DC")]
    public void Open()
    {
    }

    [Token(Token = "0x6017093")]
    [Address(RVA = "0x2CDFB24", Offset = "0x2CDFB24", VA = "0x2CDFB24")]
    private void Close()
    {
    }

    [Token(Token = "0x6017094")]
    [Address(RVA = "0x2CDFBE0", Offset = "0x2CDFBE0", VA = "0x2CDFBE0")]
    public void SetStatusDialogKind(
      StyleReincarnation_Popup_Confirm.eStatusDialogKind kind)
    {
    }

    [Token(Token = "0x6017095")]
    [Address(RVA = "0x2CDFD28", Offset = "0x2CDFD28", VA = "0x2CDFD28")]
    public void ReplaceText(
      StyleReincarnation_Popup_Confirm.eStatusDialogKind kind,
      string replaceText)
    {
    }

    [Token(Token = "0x6017096")]
    [Address(RVA = "0x2CDFCC4", Offset = "0x2CDFCC4", VA = "0x2CDFCC4")]
    private void ClearMessage()
    {
    }

    [Token(Token = "0x6017097")]
    [Address(RVA = "0x2CDFF74", Offset = "0x2CDFF74", VA = "0x2CDFF74")]
    public StyleReincarnation_Popup_Confirm.eResult GetResult()
    {
      return new StyleReincarnation_Popup_Confirm.eResult();
    }

    [Token(Token = "0x6017098")]
    [Address(RVA = "0x2CDFE8C", Offset = "0x2CDFE8C", VA = "0x2CDFE8C")]
    private static string ReplaceDollarString(string src, params string[] replaceStrings)
    {
      return (string) null;
    }

    [Token(Token = "0x6017099")]
    [Address(RVA = "0x2CDFAA4", Offset = "0x2CDFAA4", VA = "0x2CDFAA4")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601709A")]
    [Address(RVA = "0x2CDFFA4", Offset = "0x2CDFFA4", VA = "0x2CDFFA4")]
    public StyleReincarnation_Popup_Confirm()
    {
    }

    [Token(Token = "0x2003A98")]
    public enum eStatusDialogKind
    {
      [Token(Token = "0x401014D")] Reincarnation,
      [Token(Token = "0x401014E")] Reincarnation_PinAveZero,
      [Token(Token = "0x401014F")] MemorySave,
      [Token(Token = "0x4010150")] Reincarnation_Memory,
    }

    [Token(Token = "0x2003A99")]
    public enum eResult
    {
      [Token(Token = "0x4010152")] Non,
      [Token(Token = "0x4010153")] Decision,
      [Token(Token = "0x4010154")] Cancel,
    }
  }
}
