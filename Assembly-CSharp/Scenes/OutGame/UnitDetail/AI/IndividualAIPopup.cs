// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AI.IndividualAIPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AI
{
  [Token(Token = "0x20032ED")]
  public class IndividualAIPopup : PopupBase
  {
    [Token(Token = "0x400DBD8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private AIDescriptionItem baseItem;
    [Token(Token = "0x400DBD9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private AITab tabBase;
    [Token(Token = "0x400DBDA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform tabParent;
    [Token(Token = "0x400DBDB")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Scrollbar scrollbar;
    [Token(Token = "0x400DBDC")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform scrollParent;
    [Token(Token = "0x400DBDE")]
    [FieldOffset(Offset = "0xB8")]
    private List<AITab> aiTabs;
    [Token(Token = "0x400DBDF")]
    [FieldOffset(Offset = "0xC0")]
    private List<AIDescriptionItem> aIDescriptionItems;
    [Token(Token = "0x400DBE0")]
    [FieldOffset(Offset = "0xC8")]
    private APIUnitAi unitAiApi;
    [Token(Token = "0x400DBE1")]
    [FieldOffset(Offset = "0xD0")]
    private Style style;
    [Token(Token = "0x400DBE2")]
    [FieldOffset(Offset = "0xD8")]
    private bool isConnectApi;
    [Token(Token = "0x400DBE3")]
    [FieldOffset(Offset = "0xDC")]
    private int aiTypeId;

    [Token(Token = "0x17004327")]
    public Action UpdateUnit
    {
      [Token(Token = "0x601402E"), Address(RVA = "0x234B798", Offset = "0x234B798", VA = "0x234B798")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601402F"), Address(RVA = "0x234B7A0", Offset = "0x234B7A0", VA = "0x234B7A0")] set
      {
      }
    }

    [Token(Token = "0x6014030")]
    [Address(RVA = "0x234B7A8", Offset = "0x234B7A8", VA = "0x234B7A8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014031")]
    [Address(RVA = "0x234BAC0", Offset = "0x234BAC0", VA = "0x234BAC0")]
    private IEnumerator initializeListPos() => (IEnumerator) null;

    [Token(Token = "0x6014032")]
    [Address(RVA = "0x234BB50", Offset = "0x234BB50", VA = "0x234BB50")]
    public void SetData(Style style)
    {
    }

    [Token(Token = "0x6014033")]
    [Address(RVA = "0x234C824", Offset = "0x234C824", VA = "0x234C824")]
    public void OnCategoryChange(AIRoleData aIRoleData)
    {
    }

    [Token(Token = "0x6014034")]
    [Address(RVA = "0x234CA74", Offset = "0x234CA74", VA = "0x234CA74")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x6014035")]
    [Address(RVA = "0x234CAB0", Offset = "0x234CAB0", VA = "0x234CAB0")]
    private IEnumerator ConnectApi(int aITypeId) => (IEnumerator) null;

    [Token(Token = "0x6014036")]
    [Address(RVA = "0x234CB50", Offset = "0x234CB50", VA = "0x234CB50")]
    public IndividualAIPopup()
    {
    }
  }
}
