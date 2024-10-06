// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033E9")]
  public class QuestSelectList : MonoBehaviour
  {
    [Token(Token = "0x400E199")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400E19A")]
    [FieldOffset(Offset = "0x20")]
    private List<QuestSelectListItem> items;

    [Token(Token = "0x601466C")]
    [Address(RVA = "0x188976C", Offset = "0x188976C", VA = "0x188976C")]
    public void Initialize(
      GameObject target,
      IList<QuestInfo> questList,
      Action<int> questDetailAction,
      Action<int> questSelectAction,
      Action<int> lockQuestSelectAction = null,
      int? initQuestId = null)
    {
    }

    [Token(Token = "0x601466D")]
    [Address(RVA = "0x188B604", Offset = "0x188B604", VA = "0x188B604")]
    public void DeactiveList()
    {
    }

    [Token(Token = "0x601466E")]
    [Address(RVA = "0x1889D28", Offset = "0x1889D28", VA = "0x1889D28")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601466F")]
    [Address(RVA = "0x188BA70", Offset = "0x188BA70", VA = "0x188BA70")]
    public void ScrollToQuest(int questId)
    {
    }

    [Token(Token = "0x6014670")]
    [Address(RVA = "0x188BBE8", Offset = "0x188BBE8", VA = "0x188BBE8")]
    public QuestSelectList()
    {
    }
  }
}
