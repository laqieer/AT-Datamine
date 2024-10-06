// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.UnlockConditionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E7C")]
  public class UnlockConditionView : MonoBehaviour
  {
    [Token(Token = "0x400C779")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentItem conditionQuestItem;
    [Token(Token = "0x400C77A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentItem commuRankTotalItem;
    [Token(Token = "0x400C77B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LayoutElement commuRankParentLayout;
    [Token(Token = "0x400C77C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ContentItem commuRankItemBase;
    [Token(Token = "0x400C77D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int commuRankBaseHeight;
    [Token(Token = "0x400C77E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ContentItem totalRankItem;
    [Token(Token = "0x400C77F")]
    [FieldOffset(Offset = "0x48")]
    private List<ContentItem> commuItemList;
    [Token(Token = "0x400C780")]
    [FieldOffset(Offset = "0x50")]
    private Action<int> onClickReleaseCommuAction;

    [Token(Token = "0x60122B0")]
    [Address(RVA = "0x458712C", Offset = "0x458712C", VA = "0x458712C")]
    public void Set(StoryObliviaeQuestData questData, Action<int> onClickReleaseCommuAction)
    {
    }

    [Token(Token = "0x60122B1")]
    [Address(RVA = "0x4590E30", Offset = "0x4590E30", VA = "0x4590E30")]
    public void OnClickToReleaseConditionButton(int commuId)
    {
    }

    [Token(Token = "0x60122B2")]
    [Address(RVA = "0x4590E4C", Offset = "0x4590E4C", VA = "0x4590E4C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60122B3")]
    [Address(RVA = "0x4591004", Offset = "0x4591004", VA = "0x4591004")]
    public UnlockConditionView()
    {
    }
  }
}
