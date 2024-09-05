// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SortieLimitPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using QuestPrepare;
using System;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200325F")]
  public class SortieLimitPopup : MonoBehaviour
  {
    [Token(Token = "0x400D780")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SortileItem baseItem;
    [Token(Token = "0x400D781")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x400D784")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<SortieLimitPopup.ViewType, string> titleTextMap;
    [Token(Token = "0x400D785")]
    [FieldOffset(Offset = "0x40")]
    private List<SortileItem> sortileItems;
    [Token(Token = "0x400D786")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<SortieLimitPopup.ViewType, List<Tuple<bool, string>>> createListMap;

    [Token(Token = "0x17004155")]
    public Action OnConfirmAction
    {
      [Token(Token = "0x6013A57"), Address(RVA = "0x461C8D0", Offset = "0x461C8D0", VA = "0x461C8D0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013A58"), Address(RVA = "0x461C8D8", Offset = "0x461C8D8", VA = "0x461C8D8")] set
      {
      }
    }

    [Token(Token = "0x17004156")]
    public Action OnCancelAction
    {
      [Token(Token = "0x6013A59"), Address(RVA = "0x461C8E0", Offset = "0x461C8E0", VA = "0x461C8E0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013A5A"), Address(RVA = "0x461C8E8", Offset = "0x461C8E8", VA = "0x461C8E8")] set
      {
      }
    }

    [Token(Token = "0x6013A5B")]
    [Address(RVA = "0x4616390", Offset = "0x4616390", VA = "0x4616390")]
    public void Open(
      OrganizationTeam team,
      int menberNum,
      BattleSortieRestrictionsCheck battleSortieRestrictionsCheck,
      BattleForcedSortieCheck battleForcedSortieCheck)
    {
    }

    [Token(Token = "0x6013A5C")]
    [Address(RVA = "0x461CA14", Offset = "0x461CA14", VA = "0x461CA14")]
    private void CreateForcedSortieData(BattleForcedSortieCheck battleForcedSortieCheck)
    {
    }

    [Token(Token = "0x6013A5D")]
    [Address(RVA = "0x46202DC", Offset = "0x46202DC", VA = "0x46202DC")]
    private string GetSubComparisonText(
      BattleSortieRestrictionsData sortieRestrictionsData)
    {
      return (string) null;
    }

    [Token(Token = "0x6013A5E")]
    [Address(RVA = "0x462047C", Offset = "0x462047C", VA = "0x462047C")]
    private string GetInOutText(
      BattleSortieRestrictionsMainComparisonTypeEnum typeEnum,
      string inText,
      string outText)
    {
      return (string) null;
    }

    [Token(Token = "0x6013A5F")]
    [Address(RVA = "0x46204F4", Offset = "0x46204F4", VA = "0x46204F4")]
    private string GetComparisonText(
      BattleSortieRestrictionsMainComparisonTypeEnum typeEnum)
    {
      return (string) null;
    }

    [Token(Token = "0x6013A60")]
    [Address(RVA = "0x4620658", Offset = "0x4620658", VA = "0x4620658")]
    private bool IsSubComparisonSuccess(
      BattleSortieRestrictionsSubComparisonTypeEnum typeEnum,
      int comprationValue,
      List<bool> successDataList)
    {
      return new bool();
    }

    [Token(Token = "0x6013A61")]
    [Address(RVA = "0x461D5D8", Offset = "0x461D5D8", VA = "0x461D5D8")]
    private void CreateSortieRestrictionsData(
      OrganizationTeam team,
      int menberNum,
      BattleSortieRestrictionsCheck battleSortieRestrictionsCheck)
    {
    }

    [Token(Token = "0x6013A62")]
    [Address(RVA = "0x46200D4", Offset = "0x46200D4", VA = "0x46200D4")]
    private void CreateItem()
    {
    }

    [Token(Token = "0x6013A63")]
    [Address(RVA = "0x461C8F0", Offset = "0x461C8F0", VA = "0x461C8F0")]
    private void Delete()
    {
    }

    [Token(Token = "0x6013A64")]
    [Address(RVA = "0x4620FBC", Offset = "0x4620FBC", VA = "0x4620FBC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6013A65")]
    [Address(RVA = "0x4620FC0", Offset = "0x4620FC0", VA = "0x4620FC0")]
    public void OnClickToCancel()
    {
    }

    [Token(Token = "0x6013A66")]
    [Address(RVA = "0x4620FDC", Offset = "0x4620FDC", VA = "0x4620FDC")]
    public SortieLimitPopup()
    {
    }

    [Token(Token = "0x2003260")]
    public enum ViewType
    {
      [Token(Token = "0x400D788")] ForceSortie,
      [Token(Token = "0x400D789")] Guest,
      [Token(Token = "0x400D78A")] Limit,
      [Token(Token = "0x400D78B")] Support,
    }
  }
}
