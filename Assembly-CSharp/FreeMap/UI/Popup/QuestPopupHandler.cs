// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestPopupHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200163A")]
  public class QuestPopupHandler
  {
    [Token(Token = "0x40064E6")]
    [FieldOffset(Offset = "0x10")]
    private QuestPopup popup;
    [Token(Token = "0x40064E7")]
    [FieldOffset(Offset = "0x18")]
    private QuestUIStateHandler questUIHandler;
    [Token(Token = "0x40064E8")]
    [FieldOffset(Offset = "0x20")]
    private IQuestDataSetter questDataSetter;
    [Token(Token = "0x40064E9")]
    [FieldOffset(Offset = "0x28")]
    private IQuestUIEvent uiEvent;
    [Token(Token = "0x40064EA")]
    [FieldOffset(Offset = "0x30")]
    private Transform parent;
    [Token(Token = "0x40064EB")]
    [FieldOffset(Offset = "0x38")]
    private bool initialized;

    [Token(Token = "0x17001381")]
    public Transform Transform
    {
      [Token(Token = "0x6007E09"), Address(RVA = "0x21ACC14", Offset = "0x21ACC14", VA = "0x21ACC14")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x6007E0A")]
    [Address(RVA = "0x21ACC30", Offset = "0x21ACC30", VA = "0x21ACC30")]
    public QuestPopupHandler()
    {
    }

    [Token(Token = "0x6007E0B")]
    [Address(RVA = "0x21ACCD0", Offset = "0x21ACCD0", VA = "0x21ACCD0")]
    public QuestPopupHandler(Transform parent)
    {
    }

    [Token(Token = "0x6007E0C")]
    [Address(RVA = "0x21ACCF8", Offset = "0x21ACCF8", VA = "0x21ACCF8")]
    public void Set(IQuestDataSetter questDataSetter)
    {
    }

    [Token(Token = "0x6007E0D")]
    [Address(RVA = "0x21ACD00", Offset = "0x21ACD00", VA = "0x21ACD00")]
    public void Set(IQuestUIEvent uiEvent)
    {
    }

    [Token(Token = "0x6007E0E")]
    [Address(RVA = "0x21ACD08", Offset = "0x21ACD08", VA = "0x21ACD08")]
    public void Set(QuestUIStateHandler questUIHandler)
    {
    }

    [Token(Token = "0x6007E0F")]
    [Address(RVA = "0x21ACD10", Offset = "0x21ACD10", VA = "0x21ACD10")]
    public void Initialize(MonoBehaviour loadworker, Loader<QuestPopup> loader, Action callback)
    {
    }

    [Token(Token = "0x6007E10")]
    [Address(RVA = "0x21ACDBC", Offset = "0x21ACDBC", VA = "0x21ACDBC")]
    public IEnumerator InitializeCoroutine(Loader<QuestPopup> loader, Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007E11")]
    [Address(RVA = "0x21ACE60", Offset = "0x21ACE60", VA = "0x21ACE60")]
    public void Open()
    {
    }

    [Token(Token = "0x6007E12")]
    [Address(RVA = "0x21ACED8", Offset = "0x21ACED8", VA = "0x21ACED8")]
    public void Close()
    {
    }

    [Token(Token = "0x6007E13")]
    [Address(RVA = "0x21ACF90", Offset = "0x21ACF90", VA = "0x21ACF90")]
    public bool IsInitialized() => new bool();
  }
}
