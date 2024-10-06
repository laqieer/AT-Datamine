// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002407")]
  public sealed class FieldUnitListElement : IFieldUnitListElement, IDisposable
  {
    [Token(Token = "0x4009A04")]
    [FieldOffset(Offset = "0x10")]
    private FieldUnitListManager fieldUnitListManager;
    [Token(Token = "0x4009A05")]
    [FieldOffset(Offset = "0x18")]
    private BattleCore core;
    [Token(Token = "0x4009A06")]
    [FieldOffset(Offset = "0x20")]
    private UnitParameterData _unitParam;
    [Token(Token = "0x4009A07")]
    [FieldOffset(Offset = "0x28")]
    private bool _dead;
    [Token(Token = "0x4009A08")]
    [FieldOffset(Offset = "0x30")]
    private FieldUnitListConnect _connect;

    [Token(Token = "0x17002F72")]
    public UnitParameterData UnitParam
    {
      [Token(Token = "0x600DCC9"), Address(RVA = "0x1E21FC0", Offset = "0x1E21FC0", VA = "0x1E21FC0")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17002F73")]
    public FieldUnitListViewElement ViewElement
    {
      [Token(Token = "0x600DCCA"), Address(RVA = "0x1E21FC8", Offset = "0x1E21FC8", VA = "0x1E21FC8", Slot = "4")] get
      {
        return (FieldUnitListViewElement) null;
      }
      [Token(Token = "0x600DCCB"), Address(RVA = "0x1E21FD0", Offset = "0x1E21FD0", VA = "0x1E21FD0", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x17002F74")]
    public Sprite FrontUnitThumbnail
    {
      [Token(Token = "0x600DCCC"), Address(RVA = "0x1E21FD8", Offset = "0x1E21FD8", VA = "0x1E21FD8")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600DCCD"), Address(RVA = "0x1E21FE0", Offset = "0x1E21FE0", VA = "0x1E21FE0")] set
      {
      }
    }

    [Token(Token = "0x17002F75")]
    private float Spacing
    {
      [Token(Token = "0x600DCCE"), Address(RVA = "0x1E21FE8", Offset = "0x1E21FE8", VA = "0x1E21FE8")] get
      {
        return new float();
      }
      [Token(Token = "0x600DCCF"), Address(RVA = "0x1E21FF0", Offset = "0x1E21FF0", VA = "0x1E21FF0")] set
      {
      }
    }

    [Token(Token = "0x17002F76")]
    private int GridPosX
    {
      [Token(Token = "0x600DCD0"), Address(RVA = "0x1E21FF8", Offset = "0x1E21FF8", VA = "0x1E21FF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600DCD1"), Address(RVA = "0x1E22000", Offset = "0x1E22000", VA = "0x1E22000")] set
      {
      }
    }

    [Token(Token = "0x17002F77")]
    private int GridPosY
    {
      [Token(Token = "0x600DCD2"), Address(RVA = "0x1E22008", Offset = "0x1E22008", VA = "0x1E22008")] get
      {
        return new int();
      }
      [Token(Token = "0x600DCD3"), Address(RVA = "0x1E22010", Offset = "0x1E22010", VA = "0x1E22010")] set
      {
      }
    }

    [Token(Token = "0x600DCD4")]
    [Address(RVA = "0x1E22018", Offset = "0x1E22018", VA = "0x1E22018")]
    public FieldUnitListElement(
      FieldUnitListManager fieldUnitListManager,
      BattleCore core,
      UnitParameterData unitParam,
      FieldUnitListConnect connect,
      float spacing)
    {
    }

    [Token(Token = "0x600DCD5")]
    [Address(RVA = "0x1E220A8", Offset = "0x1E220A8", VA = "0x1E220A8", Slot = "7")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600DCD6")]
    [Address(RVA = "0x1E220B0", Offset = "0x1E220B0", VA = "0x1E220B0")]
    public void SetDead(bool value)
    {
    }

    [Token(Token = "0x600DCD7")]
    [Address(RVA = "0x1E220BC", Offset = "0x1E220BC", VA = "0x1E220BC")]
    public void SetUnitParam(UnitParameterData data)
    {
    }

    [Token(Token = "0x600DCD8")]
    [Address(RVA = "0x1E220C4", Offset = "0x1E220C4", VA = "0x1E220C4")]
    public void SetUnitNumber(int num)
    {
    }

    [Token(Token = "0x600DCD9")]
    [Address(RVA = "0x1E220A0", Offset = "0x1E220A0", VA = "0x1E220A0")]
    public void SetGridPosition(int posX, int posY)
    {
    }

    [Token(Token = "0x600DCDA")]
    [Address(RVA = "0x1E22214", Offset = "0x1E22214", VA = "0x1E22214", Slot = "6")]
    public float GetHeight() => new float();

    [Token(Token = "0x600DCDB")]
    [Address(RVA = "0x1E22314", Offset = "0x1E22314", VA = "0x1E22314")]
    public void SelectUnit()
    {
    }

    [Token(Token = "0x600DCDC")]
    [Address(RVA = "0x1E22554", Offset = "0x1E22554", VA = "0x1E22554")]
    private bool IsChangeSelectUnit() => new bool();

    [Token(Token = "0x600DCDD")]
    [Address(RVA = "0x1E22610", Offset = "0x1E22610", VA = "0x1E22610")]
    public void PlayTweenAnimation(string groupID, bool stopPlayingAnim, UnityAction callback)
    {
    }

    [Token(Token = "0x600DCDE")]
    [Address(RVA = "0x1E226BC", Offset = "0x1E226BC", VA = "0x1E226BC")]
    public void SetActive(FieldUnitListViewElement.IconType iconType, bool display)
    {
    }

    [Token(Token = "0x600DCDF")]
    [Address(RVA = "0x1E22740", Offset = "0x1E22740", VA = "0x1E22740")]
    public void SetThumbnailSprite(FieldUnitListViewElement.IconType iconType, Sprite sprite)
    {
    }

    [Token(Token = "0x600DCE0")]
    [Address(RVA = "0x1E22790", Offset = "0x1E22790", VA = "0x1E22790")]
    public void SetHpGauge(
      FieldUnitListViewElement.IconType iconType,
      float currentHp,
      float maxHp)
    {
    }

    [Token(Token = "0x600DCE1")]
    [Address(RVA = "0x1E227F0", Offset = "0x1E227F0", VA = "0x1E227F0")]
    public void SetBadStatus(
      FieldUnitListViewElement.IconType iconType,
      BattleBadStatusData badStatus)
    {
    }

    [Token(Token = "0x600DCE2")]
    [Address(RVA = "0x1E22968", Offset = "0x1E22968", VA = "0x1E22968")]
    public void SetStockCounter(
      FieldUnitListViewElement.IconType iconType,
      StockCounterData stockCounterData,
      int currentStockCounter,
      bool isAnimationDelay)
    {
    }

    [Token(Token = "0x600DCE3")]
    [Address(RVA = "0x1E22A50", Offset = "0x1E22A50", VA = "0x1E22A50")]
    public void Refresh()
    {
    }
  }
}
