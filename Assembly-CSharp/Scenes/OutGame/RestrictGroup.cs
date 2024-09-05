// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.RestrictGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200325D")]
  internal class RestrictGroup : MonoBehaviour
  {
    [Token(Token = "0x400D778")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject line;
    [Token(Token = "0x400D779")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RestrictContent restrictContent;
    [Token(Token = "0x400D77A")]
    [FieldOffset(Offset = "0x28")]
    private List<string> restricts;

    [Token(Token = "0x6013A4B")]
    [Address(RVA = "0x460C648", Offset = "0x460C648", VA = "0x460C648")]
    public bool SetRestrictInfo(QuestInfo questInfo) => new bool();

    [Token(Token = "0x6013A4C")]
    [Address(RVA = "0x461A168", Offset = "0x461A168", VA = "0x461A168")]
    private void CreateSortieRestrictionsData(
      IReadOnlyList<BattleSortieRestrictionsData> sortieRestrictionsList)
    {
    }

    [Token(Token = "0x6013A4D")]
    [Address(RVA = "0x461BDE8", Offset = "0x461BDE8", VA = "0x461BDE8")]
    private string GetSubComparisonText(
      BattleSortieRestrictionsData sortieRestrictionsData)
    {
      return (string) null;
    }

    [Token(Token = "0x6013A4E")]
    [Address(RVA = "0x461BF04", Offset = "0x461BF04", VA = "0x461BF04")]
    private string GetInOutText(
      BattleSortieRestrictionsMainComparisonTypeEnum typeEnum,
      string inText = "限定",
      string outText = "以外")
    {
      return (string) null;
    }

    [Token(Token = "0x6013A4F")]
    [Address(RVA = "0x461BF7C", Offset = "0x461BF7C", VA = "0x461BF7C")]
    private string GetComparisonText(
      BattleSortieRestrictionsMainComparisonTypeEnum typeEnum)
    {
      return (string) null;
    }

    [Token(Token = "0x6013A50")]
    [Address(RVA = "0x461C020", Offset = "0x461C020", VA = "0x461C020")]
    public RestrictGroup()
    {
    }
  }
}
