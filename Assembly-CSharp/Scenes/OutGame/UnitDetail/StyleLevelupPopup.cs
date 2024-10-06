// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.StyleLevelupPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032D6")]
  public class StyleLevelupPopup : PopupBase
  {
    [Token(Token = "0x400DB35")]
    private const string TWEEN_CONTENT_STOCK_KEY = "Contents_Stock";
    [Token(Token = "0x400DB36")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private StyleLevelupSoulContent contentBase;
    [Token(Token = "0x400DB37")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DB38")]
    [FieldOffset(Offset = "0x98")]
    private bool isConnectApi;
    [Token(Token = "0x400DB39")]
    [FieldOffset(Offset = "0xA0")]
    private UniqueID uniqueID;
    [Token(Token = "0x400DB3A")]
    [FieldOffset(Offset = "0xA8")]
    private APIUnitUnit_levelUp styleLevelupApi;
    [Token(Token = "0x400DB3B")]
    [FieldOffset(Offset = "0xB0")]
    private int styleLv;
    [Token(Token = "0x400DB3C")]
    [FieldOffset(Offset = "0xB4")]
    private int maxStyleLevel;
    [Token(Token = "0x400DB3D")]
    [FieldOffset(Offset = "0xB8")]
    private Style backupStyle;

    [Token(Token = "0x17004303")]
    public Action UpdateUnit
    {
      [Token(Token = "0x6013F82"), Address(RVA = "0x234499C", Offset = "0x234499C", VA = "0x234499C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013F83"), Address(RVA = "0x23449A4", Offset = "0x23449A4", VA = "0x23449A4")] set
      {
      }
    }

    [Token(Token = "0x6013F84")]
    [Address(RVA = "0x23449AC", Offset = "0x23449AC", VA = "0x23449AC")]
    public void SetData(Style style)
    {
    }

    [Token(Token = "0x6013F85")]
    [Address(RVA = "0x2344A58", Offset = "0x2344A58", VA = "0x2344A58")]
    public void OnClickToConnectApi()
    {
    }

    [Token(Token = "0x6013F86")]
    [Address(RVA = "0x2344A98", Offset = "0x2344A98", VA = "0x2344A98")]
    private IEnumerator ConnectApi() => (IEnumerator) null;

    [Token(Token = "0x6013F87")]
    [Address(RVA = "0x2344B28", Offset = "0x2344B28", VA = "0x2344B28")]
    public void ResetData()
    {
    }

    [Token(Token = "0x6013F88")]
    [Address(RVA = "0x2344B48", Offset = "0x2344B48", VA = "0x2344B48")]
    public StyleLevelupPopup()
    {
    }
  }
}
