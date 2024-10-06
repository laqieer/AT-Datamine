// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.DamageRankingInfinitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using Scenes.OutGame.StyleRanking;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029B6")]
  internal class DamageRankingInfinitCell : InfiniteCellBase
  {
    [Token(Token = "0x400B1AE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb thumb;
    [Token(Token = "0x400B1AF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RankingView rankingView;
    [Token(Token = "0x400B1B0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PersonalEmblemThumb emblemThumb;
    [Token(Token = "0x400B1B1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI playerNameText;
    [Token(Token = "0x400B1B2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [Token(Token = "0x400B1B3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject myCursorObj;

    [Token(Token = "0x17003929")]
    private DamageRankingCellResource Resource
    {
      [Token(Token = "0x601060D"), Address(RVA = "0x4884E70", Offset = "0x4884E70", VA = "0x4884E70")] get
      {
        return (DamageRankingCellResource) null;
      }
    }

    [Token(Token = "0x601060E")]
    [Address(RVA = "0x4884EF8", Offset = "0x4884EF8", VA = "0x4884EF8", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x601060F")]
    [Address(RVA = "0x4885078", Offset = "0x4885078", VA = "0x4885078")]
    public DamageRankingInfinitCell()
    {
    }
  }
}
