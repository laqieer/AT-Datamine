// Decompiled with JetBrains decompiler
// Type: FreeMap.FreeMapStatusChangeHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Data;
using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Data;
using FreeMap.UI.Element;
using FreeMap.UI.Entity;
using FreeMap.UI.Manager;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015E8")]
  public class FreeMapStatusChangeHandler : IFreeMapLocationControll
  {
    [Token(Token = "0x40063FD")]
    private const string DefaultSpriteAssetBundleName = "content_spriteatlas_advmap";
    [Token(Token = "0x40063FE")]
    private const string DefaultSpriteAssetName = "Adv_Map_ActionIc";
    [Token(Token = "0x40063FF")]
    private const string ButtonObjectName = "ActionIc_Set";
    [Token(Token = "0x4006400")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapLocationHolder locationHolder;
    [Token(Token = "0x4006401")]
    [FieldOffset(Offset = "0x18")]
    private Transform instanceParent;
    [Token(Token = "0x4006402")]
    [FieldOffset(Offset = "0x20")]
    private FreeMapUIManager<FreeMapUIBase> uiManager;
    [Token(Token = "0x4006403")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapPassiveMessageManager passiveMessageManager;
    [Token(Token = "0x4006404")]
    [FieldOffset(Offset = "0x30")]
    private FreeMapCommonElement currentCommonElement;
    [Token(Token = "0x4006405")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapIconEventControlElement iconButtonControlElement;
    [Token(Token = "0x4006406")]
    [FieldOffset(Offset = "0x40")]
    private int currentAreaID;
    [Token(Token = "0x4006407")]
    [FieldOffset(Offset = "0x48")]
    private FreeMapUISiblingHandler sibilingHandler;
    [Token(Token = "0x4006408")]
    [FieldOffset(Offset = "0x50")]
    private UITransformAvoidHandler uiTransformAvoidHandler;
    [Token(Token = "0x4006409")]
    [FieldOffset(Offset = "0x58")]
    private MovableMobManager movableMobManager;

    [Token(Token = "0x1700131F")]
    private ActionIconUIAssetData uIAssetData
    {
      [Token(Token = "0x6007BFC"), Address(RVA = "0x22A5FF4", Offset = "0x22A5FF4", VA = "0x22A5FF4")] get
      {
        return (ActionIconUIAssetData) null;
      }
    }

    [Token(Token = "0x17001320")]
    private List<IFreeMapUIManager> UIManagerList
    {
      [Token(Token = "0x6007BFD"), Address(RVA = "0x22A604C", Offset = "0x22A604C", VA = "0x22A604C")] get
      {
        return (List<IFreeMapUIManager>) null;
      }
    }

    [Token(Token = "0x14000107")]
    public event FreeMapStatusChangeHandler.Refresh OnRefresh
    {
      [Token(Token = "0x6007BFE"), Address(RVA = "0x22A6180", Offset = "0x22A6180", VA = "0x22A6180")] add
      {
      }
      [Token(Token = "0x6007BFF"), Address(RVA = "0x22A621C", Offset = "0x22A621C", VA = "0x22A621C")] remove
      {
      }
    }

    [Token(Token = "0x6007C00")]
    [Address(RVA = "0x22A62B8", Offset = "0x22A62B8", VA = "0x22A62B8")]
    public FreeMapStatusChangeHandler(
      FreeMapCommonElement commonElement,
      FreeMapLocationHolder locationHolder,
      Transform instanceParent,
      Action<int> noticeNextSequenceMethod,
      FreeMapBackGroundTemporarySceneLoader backGroundSceneReloadHandler,
      MovableMobManager mobManager)
    {
    }

    [Token(Token = "0x6007C01")]
    [Address(RVA = "0x22A63C8", Offset = "0x22A63C8", VA = "0x22A63C8")]
    public void SetAreaID(int toAreaID)
    {
    }

    [Token(Token = "0x6007C02")]
    [Address(RVA = "0x22A63D0", Offset = "0x22A63D0", VA = "0x22A63D0")]
    public bool IsLoaded(int toAreaID) => new bool();

    [Token(Token = "0x6007C03")]
    [Address(RVA = "0x22A63E0", Offset = "0x22A63E0", VA = "0x22A63E0", Slot = "4")]
    public void RefreshInstance()
    {
    }

    [Token(Token = "0x6007C04")]
    [Address(RVA = "0x22A8370", Offset = "0x22A8370", VA = "0x22A8370")]
    public void RemoveInstance(int targetAreaID, InstanceID instanceID)
    {
    }

    [Token(Token = "0x6007C05")]
    [Address(RVA = "0x22A8388", Offset = "0x22A8388", VA = "0x22A8388")]
    public void RemoveInstance(InstanceID instanceID)
    {
    }

    [Token(Token = "0x6007C06")]
    [Address(RVA = "0x22A7AC8", Offset = "0x22A7AC8", VA = "0x22A7AC8")]
    private void OnRemoveSceneInstance(InstanceID instanceID)
    {
    }

    [Token(Token = "0x6007C07")]
    [Address(RVA = "0x22A83E4", Offset = "0x22A83E4", VA = "0x22A83E4", Slot = "5")]
    public bool UIExists(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6007C08")]
    [Address(RVA = "0x22A8424", Offset = "0x22A8424", VA = "0x22A8424")]
    public void AddUI(FreeMapUIParamBase addParam)
    {
    }

    [Token(Token = "0x6007C09")]
    [Address(RVA = "0x22A84B8", Offset = "0x22A84B8", VA = "0x22A84B8")]
    public void AddUI(int targetAreaID, FreeMapUIParamBase addParam)
    {
    }

    [Token(Token = "0x6007C0A")]
    [Address(RVA = "0x22A80DC", Offset = "0x22A80DC", VA = "0x22A80DC")]
    private void OnAddUI(FreeMapUIParamBase addParam)
    {
    }

    [Token(Token = "0x6007C0B")]
    [Address(RVA = "0x22A8530", Offset = "0x22A8530", VA = "0x22A8530")]
    public void ChangeUI(
      int targetAreaID,
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam)
    {
    }

    [Token(Token = "0x6007C0C")]
    [Address(RVA = "0x22A85AC", Offset = "0x22A85AC", VA = "0x22A85AC")]
    private void OnChangeUI(FreeMapUIParamBase fromParam, FreeMapUIParamBase toParam)
    {
    }

    [Token(Token = "0x6007C0D")]
    [Address(RVA = "0x22A8820", Offset = "0x22A8820", VA = "0x22A8820")]
    public bool RemoveUI(FreeMapUIParamBase removeParam, bool isRemoveParam = true) => new bool();

    [Token(Token = "0x6007C0E")]
    [Address(RVA = "0x22A8884", Offset = "0x22A8884", VA = "0x22A8884")]
    public bool RemoveUI(int targetAreaID, FreeMapUIParamBase param, bool isRemoveParam = true)
    {
      return new bool();
    }

    [Token(Token = "0x6007C0F")]
    [Address(RVA = "0x22A7B4C", Offset = "0x22A7B4C", VA = "0x22A7B4C")]
    private void OnRemoveSceneUI(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007C10")]
    [Address(RVA = "0x22A8940", Offset = "0x22A8940", VA = "0x22A8940")]
    private void RemoveCircleCollider(InstanceID instanceID)
    {
    }

    [Token(Token = "0x20015E9")]
    public delegate void Refresh(LocationData location, FreeMapInstanceHolder instanceHolder);
  }
}
