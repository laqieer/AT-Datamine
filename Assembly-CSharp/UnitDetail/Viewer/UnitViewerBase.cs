// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004B5")]
  [Serializable]
  public abstract class UnitViewerBase
  {
    [Token(Token = "0x40018E1")]
    protected const float CrossFadeDuration = 0.5f;
    [Token(Token = "0x40018E6")]
    [FieldOffset(Offset = "0x30")]
    protected Coroutine activeCoroutine;
    [Token(Token = "0x40018E7")]
    [FieldOffset(Offset = "0x38")]
    private List<Coroutine> subCoroutineList;

    [Token(Token = "0x1700033E")]
    protected UnitViewerController UnitViewerController
    {
      [Token(Token = "0x6001A85"), Address(RVA = "0x2C27538", Offset = "0x2C27538", VA = "0x2C27538")] get
      {
        return (UnitViewerController) null;
      }
      [Token(Token = "0x6001A86"), Address(RVA = "0x2C27540", Offset = "0x2C27540", VA = "0x2C27540")] private set
      {
      }
    }

    [Token(Token = "0x1700033F")]
    protected ViewerSettingTable Setting
    {
      [Token(Token = "0x6001A87"), Address(RVA = "0x2C27548", Offset = "0x2C27548", VA = "0x2C27548")] get
      {
        return (ViewerSettingTable) null;
      }
      [Token(Token = "0x6001A88"), Address(RVA = "0x2C27550", Offset = "0x2C27550", VA = "0x2C27550")] private set
      {
      }
    }

    [Token(Token = "0x17000340")]
    protected float LastTapTime
    {
      [Token(Token = "0x6001A89"), Address(RVA = "0x2C27558", Offset = "0x2C27558", VA = "0x2C27558")] get
      {
        return new float();
      }
      [Token(Token = "0x6001A8A"), Address(RVA = "0x2C27560", Offset = "0x2C27560", VA = "0x2C27560")] set
      {
      }
    }

    [Token(Token = "0x17000341")]
    protected Vector2 LastTapPosition
    {
      [Token(Token = "0x6001A8B"), Address(RVA = "0x2C27568", Offset = "0x2C27568", VA = "0x2C27568")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001A8C"), Address(RVA = "0x2C27570", Offset = "0x2C27570", VA = "0x2C27570")] set
      {
      }
    }

    [Token(Token = "0x6001A8D")]
    [Address(RVA = "0x2C27578", Offset = "0x2C27578", VA = "0x2C27578")]
    public void Initialize(UnitViewerController unitViewerController, ViewerSettingTable setting)
    {
    }

    [Token(Token = "0x6001A8E")]
    [Address(RVA = "0x2C27588", Offset = "0x2C27588", VA = "0x2C27588", Slot = "4")]
    protected virtual void InitializeImpl()
    {
    }

    [Token(Token = "0x6001A8F")]
    [Address(RVA = "0x2C2758C", Offset = "0x2C2758C", VA = "0x2C2758C", Slot = "5")]
    public virtual void Show()
    {
    }

    [Token(Token = "0x6001A90")]
    [Address(RVA = "0x2C275B8", Offset = "0x2C275B8", VA = "0x2C275B8", Slot = "6")]
    public virtual void Hide()
    {
    }

    [Token(Token = "0x6001A91")]
    [Address(RVA = "0x2C275C8", Offset = "0x2C275C8", VA = "0x2C275C8", Slot = "7")]
    public virtual void Reset(Action callback = null)
    {
    }

    [Token(Token = "0x6001A92")]
    [Address(RVA = "0x2C275CC", Offset = "0x2C275CC", VA = "0x2C275CC", Slot = "8")]
    public virtual void ResetImmediate()
    {
    }

    [Token(Token = "0x6001A93")]
    [Address(RVA = "0x2C275D0", Offset = "0x2C275D0", VA = "0x2C275D0", Slot = "9")]
    public virtual void OnSwipe()
    {
    }

    [Token(Token = "0x6001A94")]
    [Address(RVA = "0x2C275D4", Offset = "0x2C275D4", VA = "0x2C275D4", Slot = "10")]
    public virtual void OnFlick()
    {
    }

    [Token(Token = "0x6001A95")]
    [Address(RVA = "0x2C275D8", Offset = "0x2C275D8", VA = "0x2C275D8", Slot = "11")]
    public virtual void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001A96")]
    [Address(RVA = "0x2C275DC", Offset = "0x2C275DC", VA = "0x2C275DC", Slot = "12")]
    public virtual void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001A97")]
    [Address(RVA = "0x2C275E0", Offset = "0x2C275E0", VA = "0x2C275E0", Slot = "13")]
    public virtual void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001A98")]
    [Address(RVA = "0x2C275E4", Offset = "0x2C275E4", VA = "0x2C275E4", Slot = "14")]
    public virtual void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001A99")]
    [Address(RVA = "0x2C275E8", Offset = "0x2C275E8", VA = "0x2C275E8", Slot = "15")]
    public virtual void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001A9A")]
    [Address(RVA = "0x2C275EC", Offset = "0x2C275EC", VA = "0x2C275EC", Slot = "16")]
    public virtual void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001A9B")]
    [Address(RVA = "0x2C275F0", Offset = "0x2C275F0", VA = "0x2C275F0", Slot = "17")]
    public virtual void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001A9C")]
    [Address(RVA = "0x2C275F4", Offset = "0x2C275F4", VA = "0x2C275F4", Slot = "18")]
    public virtual void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001A9D")]
    [Address(RVA = "0x2C275F8", Offset = "0x2C275F8", VA = "0x2C275F8", Slot = "19")]
    public virtual void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001A9E")]
    [Address(RVA = "0x2C275FC", Offset = "0x2C275FC", VA = "0x2C275FC", Slot = "20")]
    public virtual void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001A9F")]
    protected abstract void ShowTransition();

    [Token(Token = "0x6001AA0")]
    protected abstract void HideTransition();

    [Token(Token = "0x6001AA1")]
    [Address(RVA = "0x2C26C68", Offset = "0x2C26C68", VA = "0x2C26C68")]
    protected void StartMultiCoroutine(IEnumerable<IEnumerator> ienumerators, Action callback = null)
    {
    }

    [Token(Token = "0x6001AA2")]
    [Address(RVA = "0x2C27600", Offset = "0x2C27600", VA = "0x2C27600")]
    private IEnumerator StartMultiCoroutineImpl(
      IEnumerable<IEnumerator> ienumerators,
      Action callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001AA3")]
    [Address(RVA = "0x2C263BC", Offset = "0x2C263BC", VA = "0x2C263BC")]
    protected void SetActiveCoroutine(IEnumerator coroutine)
    {
    }

    [Token(Token = "0x6001AA4")]
    [Address(RVA = "0x2C26F68", Offset = "0x2C26F68", VA = "0x2C26F68")]
    protected UnitViewerBase()
    {
    }
  }
}
