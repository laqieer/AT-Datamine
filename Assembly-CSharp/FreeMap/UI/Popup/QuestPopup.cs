// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001636")]
  [RequireComponent(typeof (UITimelineController), typeof (CanvasGroup), typeof (QuestUI))]
  public class QuestPopup : PopupBase
  {
    [Token(Token = "0x40064DC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private QuestUI questUI;
    [Token(Token = "0x40064DD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x40064DE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x1700137A")]
    public IQuestUIEvent QuestUIEvent
    {
      [Token(Token = "0x6007DF0"), Address(RVA = "0x21AC368", Offset = "0x21AC368", VA = "0x21AC368")] set
      {
      }
    }

    [Token(Token = "0x6007DF1")]
    [Address(RVA = "0x21AC384", Offset = "0x21AC384", VA = "0x21AC384")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6007DF2")]
    [Address(RVA = "0x21AC468", Offset = "0x21AC468", VA = "0x21AC468")]
    public void Show()
    {
    }

    [Token(Token = "0x6007DF3")]
    [Address(RVA = "0x21AC488", Offset = "0x21AC488", VA = "0x21AC488")]
    public void Hide()
    {
    }

    [Token(Token = "0x6007DF4")]
    [Address(RVA = "0x21AC4A8", Offset = "0x21AC4A8", VA = "0x21AC4A8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6007DF5")]
    [Address(RVA = "0x21AC56C", Offset = "0x21AC56C", VA = "0x21AC56C")]
    public void ShowOpenAsync()
    {
    }

    [Token(Token = "0x6007DF6")]
    [Address(RVA = "0x21AC58C", Offset = "0x21AC58C", VA = "0x21AC58C")]
    public IEnumerator ShowOpenCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6007DF7")]
    [Address(RVA = "0x21AC61C", Offset = "0x21AC61C", VA = "0x21AC61C", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6007DF8")]
    [Address(RVA = "0x21AC6E4", Offset = "0x21AC6E4", VA = "0x21AC6E4")]
    public void Set(IQuestDataSetter questDataSetter)
    {
    }

    [Token(Token = "0x6007DF9")]
    [Address(RVA = "0x21AC83C", Offset = "0x21AC83C", VA = "0x21AC83C")]
    public void Set(QuestUIStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6007DFA")]
    [Address(RVA = "0x21AC88C", Offset = "0x21AC88C", VA = "0x21AC88C")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6007DFB")]
    [Address(RVA = "0x21AC908", Offset = "0x21AC908", VA = "0x21AC908")]
    public QuestPopup()
    {
    }
  }
}
