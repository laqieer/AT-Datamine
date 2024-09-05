// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailStateHandlerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnityEngine;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A2")]
  public class UnitDetailStateHandlerBase : MonoBehaviour
  {
    [Token(Token = "0x17000325")]
    protected UnitDetailSubScene SubScene
    {
      [Token(Token = "0x60019E4"), Address(RVA = "0x2C24458", Offset = "0x2C24458", VA = "0x2C24458")] get
      {
        return (UnitDetailSubScene) null;
      }
      [Token(Token = "0x60019E5"), Address(RVA = "0x2C24460", Offset = "0x2C24460", VA = "0x2C24460")] private set
      {
      }
    }

    [Token(Token = "0x17000326")]
    protected UnitDetailInfo UnitDetailInfo
    {
      [Token(Token = "0x60019E6"), Address(RVA = "0x2C24468", Offset = "0x2C24468", VA = "0x2C24468")] get
      {
        return (UnitDetailInfo) null;
      }
      [Token(Token = "0x60019E7"), Address(RVA = "0x2C24470", Offset = "0x2C24470", VA = "0x2C24470")] private set
      {
      }
    }

    [Token(Token = "0x60019E8")]
    [Address(RVA = "0x2C24478", Offset = "0x2C24478", VA = "0x2C24478")]
    public void Initialize(UnitDetailSubScene subScene)
    {
    }

    [Token(Token = "0x60019E9")]
    [Address(RVA = "0x2C2448C", Offset = "0x2C2448C", VA = "0x2C2448C")]
    public void UpdateUnit(UnitDetailInfo info)
    {
    }

    [Token(Token = "0x60019EA")]
    [Address(RVA = "0x2C244A0", Offset = "0x2C244A0", VA = "0x2C244A0")]
    public void DeckUnitUpdate()
    {
    }

    [Token(Token = "0x60019EB")]
    [Address(RVA = "0x2C244B0", Offset = "0x2C244B0", VA = "0x2C244B0", Slot = "4")]
    public virtual void Show()
    {
    }

    [Token(Token = "0x60019EC")]
    [Address(RVA = "0x2C244B4", Offset = "0x2C244B4", VA = "0x2C244B4", Slot = "5")]
    public virtual void Hide()
    {
    }

    [Token(Token = "0x60019ED")]
    [Address(RVA = "0x2C244B8", Offset = "0x2C244B8", VA = "0x2C244B8", Slot = "6")]
    public virtual void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x60019EE")]
    [Address(RVA = "0x2C244BC", Offset = "0x2C244BC", VA = "0x2C244BC", Slot = "7")]
    public virtual void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x60019EF")]
    [Address(RVA = "0x2C244C0", Offset = "0x2C244C0", VA = "0x2C244C0", Slot = "8")]
    public virtual void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x60019F0")]
    [Address(RVA = "0x2C244C4", Offset = "0x2C244C4", VA = "0x2C244C4", Slot = "9")]
    public virtual void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x60019F1")]
    [Address(RVA = "0x2C244C8", Offset = "0x2C244C8", VA = "0x2C244C8", Slot = "10")]
    public virtual void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x60019F2")]
    [Address(RVA = "0x2C244CC", Offset = "0x2C244CC", VA = "0x2C244CC", Slot = "11")]
    public virtual void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x60019F3")]
    [Address(RVA = "0x2C244D0", Offset = "0x2C244D0", VA = "0x2C244D0", Slot = "12")]
    public virtual void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x60019F4")]
    [Address(RVA = "0x2C244D4", Offset = "0x2C244D4", VA = "0x2C244D4", Slot = "13")]
    public virtual void OnPinch(float delta)
    {
    }

    [Token(Token = "0x60019F5")]
    [Address(RVA = "0x2C244D8", Offset = "0x2C244D8", VA = "0x2C244D8", Slot = "14")]
    public virtual void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x60019F6")]
    [Address(RVA = "0x2C244DC", Offset = "0x2C244DC", VA = "0x2C244DC", Slot = "15")]
    public virtual void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x60019F7")]
    [Address(RVA = "0x2C244E0", Offset = "0x2C244E0", VA = "0x2C244E0", Slot = "16")]
    public virtual void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x60019F8")]
    [Address(RVA = "0x2C244E4", Offset = "0x2C244E4", VA = "0x2C244E4", Slot = "17")]
    public virtual void OnClickMenuButton()
    {
    }

    [Token(Token = "0x60019F9")]
    [Address(RVA = "0x2C24500", Offset = "0x2C24500", VA = "0x2C24500", Slot = "18")]
    protected virtual void InitializeImpl()
    {
    }

    [Token(Token = "0x60019FA")]
    [Address(RVA = "0x2C24504", Offset = "0x2C24504", VA = "0x2C24504", Slot = "19")]
    protected virtual void UpdateUnitImpl()
    {
    }

    [Token(Token = "0x60019FB")]
    [Address(RVA = "0x2C24508", Offset = "0x2C24508", VA = "0x2C24508", Slot = "20")]
    protected virtual void DeckUnitUpdateImpl()
    {
    }

    [Token(Token = "0x60019FC")]
    [Address(RVA = "0x2C2450C", Offset = "0x2C2450C", VA = "0x2C2450C", Slot = "21")]
    public virtual void UpdateCheckEquipmentParam(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x60019FD")]
    [Address(RVA = "0x2C24510", Offset = "0x2C24510", VA = "0x2C24510")]
    public void SendBackSubScene()
    {
    }

    [Token(Token = "0x60019FE")]
    [Address(RVA = "0x2C2452C", Offset = "0x2C2452C", VA = "0x2C2452C", Slot = "22")]
    public virtual void OnBack()
    {
    }

    [Token(Token = "0x60019FF")]
    [Address(RVA = "0x2C24530", Offset = "0x2C24530", VA = "0x2C24530")]
    public UnitDetailStateHandlerBase()
    {
    }
  }
}
