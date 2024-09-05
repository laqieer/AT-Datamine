// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Manager.FreeMapUIManager`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Clip;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Manager
{
  [Token(Token = "0x2001683")]
  public class FreeMapUIManager<T> : 
    IFreeMapUIManager,
    IFreeMapUIVisible,
    IFreeMapButtonManageHandler,
    IFreeMapRegistUI<T>
    where T : FreeMapUIBase
  {
    [Token(Token = "0x4006534")]
    [FieldOffset(Offset = "0x0")]
    protected List<T> drawUIList;
    [Token(Token = "0x4006535")]
    [FieldOffset(Offset = "0x0")]
    protected List<T> hideUIListInDrawUIList;
    [Token(Token = "0x4006536")]
    [FieldOffset(Offset = "0x0")]
    protected bool isVisibleAll;

    [Token(Token = "0x170013A1")]
    protected FreeMapUICanvas uiCanvas
    {
      [Token(Token = "0x6007F05")] get => (FreeMapUICanvas) null;
      [Token(Token = "0x6007F06")] private set
      {
      }
    }

    [Token(Token = "0x170013A2")]
    public RectTransform CanvasRectTransform
    {
      [Token(Token = "0x6007F07")] get => (RectTransform) null;
    }

    [Token(Token = "0x170013A3")]
    public virtual List<T> DrawUIList
    {
      [Token(Token = "0x6007F08")] get => (List<T>) null;
    }

    [Token(Token = "0x6007F09")]
    public FreeMapUIManager(FreeMapUICanvas uiCanvas)
    {
    }

    [Token(Token = "0x6007F0A")]
    public void AddDrawUI(T target)
    {
    }

    [Token(Token = "0x6007F0B")]
    public IEnumerator WaitForUIBinding() => (IEnumerator) null;

    [Token(Token = "0x6007F0C")]
    public void AttachAfterBinding(UITransformAvoidHandler correctiongHandler)
    {
    }

    [Token(Token = "0x6007F0D")]
    public virtual void Update(Camera usingCamera, FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007F0E")]
    public virtual FreeMapUIBase Get(FreeMapUIParamBase param) => (FreeMapUIBase) null;

    [Token(Token = "0x6007F0F")]
    public virtual FreeMapUIBase RemoveUI(FreeMapUIParamBase param) => (FreeMapUIBase) null;

    [Token(Token = "0x6007F10")]
    public virtual FreeMapUIBase RemoveUI(int objectID) => (FreeMapUIBase) null;

    [Token(Token = "0x6007F11")]
    public virtual FreeMapUIBase RemoveUI(InstanceID instanceID) => (FreeMapUIBase) null;

    [Token(Token = "0x6007F12")]
    public T PullOutUI(InstanceID instanceID) => (T) null;

    [Token(Token = "0x6007F13")]
    public T PullOutUI(int objectID) => (T) null;

    [Token(Token = "0x6007F14")]
    public virtual void ReleaseUIAll()
    {
    }

    [Token(Token = "0x6007F15")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6007F16")]
    public void SetAllUIVisible(bool flag)
    {
    }

    [Token(Token = "0x6007F17")]
    protected virtual void OnBeforeSetAllUIVisible(bool flag)
    {
    }

    [Token(Token = "0x6007F18")]
    protected virtual bool OnVisibleTerms(T item) => new bool();

    [Token(Token = "0x6007F19")]
    public bool IsShowActionIconUIAll() => new bool();

    [Token(Token = "0x6007F1A")]
    public bool IsShowTransitionUIAll() => new bool();

    [Token(Token = "0x6007F1B")]
    public virtual void ChangeUI(
      FreeMapCommonElement commonElement,
      FreeMapUIParamBase from,
      FreeMapUIParamBase to,
      string buttonObjectName,
      string spriteAtlasAssetBundleName,
      string spriteAtlasAssetName)
    {
    }

    [Token(Token = "0x6007F1C")]
    public T FindIcon(InstanceID instanceID) => (T) null;

    [Token(Token = "0x6007F1D")]
    public TCast FindIcon<TCast>(InstanceID instanceID) where TCast : FreeMapUIBase => (TCast) null;

    [Token(Token = "0x6007F1E")]
    public FreeMapUITransformHolder FindTransformHolder(InstanceID instanceID)
    {
      return (FreeMapUITransformHolder) null;
    }

    [Token(Token = "0x6007F1F")]
    public FreeMapUITransformHolder FindTransformHolder(int objectID)
    {
      return (FreeMapUITransformHolder) null;
    }

    [Token(Token = "0x6007F20")]
    public virtual void InvokeButtonEvent(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007F21")]
    public void AdaptationRangeClip(FreeMapUIRangeClipHandler handler)
    {
    }
  }
}
