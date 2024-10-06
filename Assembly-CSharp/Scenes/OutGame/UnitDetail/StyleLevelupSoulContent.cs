// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.StyleLevelupSoulContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032D8")]
  public class StyleLevelupSoulContent : StyleLevelupContentBase
  {
    [Token(Token = "0x400DB42")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text stockValue;
    [Token(Token = "0x400DB43")]
    [FieldOffset(Offset = "0x80")]
    private int tmpExp;
    [Token(Token = "0x400DB44")]
    [FieldOffset(Offset = "0x84")]
    private int tmpSoul;
    [Token(Token = "0x400DB45")]
    [FieldOffset(Offset = "0x88")]
    private int nowMaxSoul;

    [Token(Token = "0x6013F8F")]
    [Address(RVA = "0x2344DD0", Offset = "0x2344DD0", VA = "0x2344DD0", Slot = "4")]
    public override void Initialize(Style style, int maxLevel)
    {
    }

    [Token(Token = "0x6013F90")]
    [Address(RVA = "0x2344F1C", Offset = "0x2344F1C", VA = "0x2344F1C")]
    private void UpdateStockView()
    {
    }

    [Token(Token = "0x6013F91")]
    [Address(RVA = "0x2344FE8", Offset = "0x2344FE8", VA = "0x2344FE8", Slot = "10")]
    public override APIUnitUnit_levelUpRequest GetRequestData(string styleUniqueId)
    {
      return (APIUnitUnit_levelUpRequest) null;
    }

    [Token(Token = "0x6013F92")]
    [Address(RVA = "0x2345060", Offset = "0x2345060", VA = "0x2345060", Slot = "6")]
    public override void OnClickToMaxUse()
    {
    }

    [Token(Token = "0x6013F93")]
    [Address(RVA = "0x2345148", Offset = "0x2345148", VA = "0x2345148", Slot = "7")]
    public override void OnClickToAddLevelButton()
    {
    }

    [Token(Token = "0x6013F94")]
    [Address(RVA = "0x234535C", Offset = "0x234535C", VA = "0x234535C", Slot = "8")]
    public override void OnClickToSubLevelButton()
    {
    }

    [Token(Token = "0x6013F95")]
    [Address(RVA = "0x2345408", Offset = "0x2345408", VA = "0x2345408", Slot = "5")]
    public override void OnLevelUpValueChange(float val)
    {
    }

    [Token(Token = "0x6013F96")]
    [Address(RVA = "0x23451A4", Offset = "0x23451A4", VA = "0x23451A4")]
    private void LevelupExp(int nextLv, int addExp = 1)
    {
    }

    [Token(Token = "0x6013F97")]
    [Address(RVA = "0x2345468", Offset = "0x2345468", VA = "0x2345468", Slot = "9")]
    public override void ResetData()
    {
    }

    [Token(Token = "0x6013F98")]
    [Address(RVA = "0x23454B0", Offset = "0x23454B0", VA = "0x23454B0")]
    public StyleLevelupSoulContent()
    {
    }
  }
}
