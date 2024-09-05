// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUIManageHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.Scriptable;
using FreeMap.UI.Control.Clip;
using FreeMap.UI.Control.Position;
using FreeMap.UI.Entity;
using FreeMap.UI.Manager;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015FE")]
  public class FreeMapUIManageHandler
  {
    [Token(Token = "0x4006443")]
    [FieldOffset(Offset = "0x40")]
    private List<IFreeMapUIManager> UIManagerList;
    [Token(Token = "0x4006444")]
    [FieldOffset(Offset = "0x48")]
    private List<IFreeMapButtonManageHandler> UIButtonManageHandlerList;
    [Token(Token = "0x4006446")]
    [FieldOffset(Offset = "0x58")]
    private FreeMapUICanvas freeMapUICanvas;

    [Token(Token = "0x17001331")]
    public FreeMapUIManager<FreeMapUIBase> DefaultUIManager
    {
      [Token(Token = "0x6007C70"), Address(RVA = "0x21A1850", Offset = "0x21A1850", VA = "0x21A1850")] get
      {
        return (FreeMapUIManager<FreeMapUIBase>) null;
      }
      [Token(Token = "0x6007C71"), Address(RVA = "0x21A1858", Offset = "0x21A1858", VA = "0x21A1858")] private set
      {
      }
    }

    [Token(Token = "0x17001332")]
    public FreeMapPassiveMessageManager PassiveMessageManager
    {
      [Token(Token = "0x6007C72"), Address(RVA = "0x21A1860", Offset = "0x21A1860", VA = "0x21A1860")] get
      {
        return (FreeMapPassiveMessageManager) null;
      }
      [Token(Token = "0x6007C73"), Address(RVA = "0x21A1868", Offset = "0x21A1868", VA = "0x21A1868")] private set
      {
      }
    }

    [Token(Token = "0x17001333")]
    public FreeMapUISiblingHandler SibilingHandler
    {
      [Token(Token = "0x6007C74"), Address(RVA = "0x21A1870", Offset = "0x21A1870", VA = "0x21A1870")] get
      {
        return (FreeMapUISiblingHandler) null;
      }
      [Token(Token = "0x6007C75"), Address(RVA = "0x21A1878", Offset = "0x21A1878", VA = "0x21A1878")] private set
      {
      }
    }

    [Token(Token = "0x17001334")]
    public FreeMapUIRangeClipHandler RangeClipHandler
    {
      [Token(Token = "0x6007C76"), Address(RVA = "0x21A1880", Offset = "0x21A1880", VA = "0x21A1880")] get
      {
        return (FreeMapUIRangeClipHandler) null;
      }
      [Token(Token = "0x6007C77"), Address(RVA = "0x21A1888", Offset = "0x21A1888", VA = "0x21A1888")] private set
      {
      }
    }

    [Token(Token = "0x17001335")]
    public FreeMapTransitionTitleModel TransitionTitle
    {
      [Token(Token = "0x6007C78"), Address(RVA = "0x21A1890", Offset = "0x21A1890", VA = "0x21A1890")] get
      {
        return (FreeMapTransitionTitleModel) null;
      }
      [Token(Token = "0x6007C79"), Address(RVA = "0x21A1898", Offset = "0x21A1898", VA = "0x21A1898")] private set
      {
      }
    }

    [Token(Token = "0x17001336")]
    public FreeMapTransitionTitleUtility TransitionTitlePresenter
    {
      [Token(Token = "0x6007C7A"), Address(RVA = "0x21A18A0", Offset = "0x21A18A0", VA = "0x21A18A0")] get
      {
        return (FreeMapTransitionTitleUtility) null;
      }
      [Token(Token = "0x6007C7B"), Address(RVA = "0x21A18A8", Offset = "0x21A18A8", VA = "0x21A18A8")] private set
      {
      }
    }

    [Token(Token = "0x17001337")]
    public UITransformAvoidHandler TransformAvoidHandler
    {
      [Token(Token = "0x6007C7C"), Address(RVA = "0x21A18B0", Offset = "0x21A18B0", VA = "0x21A18B0")] get
      {
        return (UITransformAvoidHandler) null;
      }
      [Token(Token = "0x6007C7D"), Address(RVA = "0x21A18B8", Offset = "0x21A18B8", VA = "0x21A18B8")] private set
      {
      }
    }

    [Token(Token = "0x6007C7E")]
    [Address(RVA = "0x21A18C0", Offset = "0x21A18C0", VA = "0x21A18C0")]
    public FreeMapUIManageHandler(RectTransform canvasRectTransform)
    {
    }

    [Token(Token = "0x6007C7F")]
    [Address(RVA = "0x21A1DB4", Offset = "0x21A1DB4", VA = "0x21A1DB4")]
    private void SetSibilingHandler()
    {
    }

    [Token(Token = "0x6007C80")]
    [Address(RVA = "0x21A1EAC", Offset = "0x21A1EAC", VA = "0x21A1EAC")]
    public void SetupTransitionTitle(FreeMapResourceLoader resourceLoader, Transform parent)
    {
    }

    [Token(Token = "0x6007C81")]
    [Address(RVA = "0x21A1FD4", Offset = "0x21A1FD4", VA = "0x21A1FD4")]
    public IEnumerator WaitForUIBinding() => (IEnumerator) null;

    [Token(Token = "0x6007C82")]
    [Address(RVA = "0x21A2064", Offset = "0x21A2064", VA = "0x21A2064")]
    public void RegistAvoidElement(IAvoidRectTransfromAccessor target)
    {
    }

    [Token(Token = "0x6007C83")]
    [Address(RVA = "0x21A2184", Offset = "0x21A2184", VA = "0x21A2184")]
    public void SetupRange(FreeMapPlacementObject scriptable, Transform parent)
    {
    }

    [Token(Token = "0x6007C84")]
    [Address(RVA = "0x21A22AC", Offset = "0x21A22AC", VA = "0x21A22AC")]
    public void Update(Camera usingCamera, FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007C85")]
    [Address(RVA = "0x21A2620", Offset = "0x21A2620", VA = "0x21A2620")]
    public void InvokeButtonEvent(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007C86")]
    [Address(RVA = "0x21A27D0", Offset = "0x21A27D0", VA = "0x21A27D0")]
    public void ReleaseUIAll()
    {
    }

    [Token(Token = "0x6007C87")]
    [Address(RVA = "0x21A283C", Offset = "0x21A283C", VA = "0x21A283C")]
    public void Destroy()
    {
    }
  }
}
