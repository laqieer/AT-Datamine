// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapUIBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Clip;
using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x200169C")]
  public abstract class FreeMapUIBase
  {
    [Token(Token = "0x4006586")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapUITransformHolder iconHolder;
    [Token(Token = "0x400658C")]
    [FieldOffset(Offset = "0x38")]
    protected UITransformAvoidHandler transformAvoidHandler;

    [Token(Token = "0x170013BE")]
    public FreeMapUITransformHolder IconHolder
    {
      [Token(Token = "0x6007FB6"), Address(RVA = "0x41F03C4", Offset = "0x41F03C4", VA = "0x41F03C4")] get
      {
        return (FreeMapUITransformHolder) null;
      }
    }

    [Token(Token = "0x170013BF")]
    public Coroutine BindAssetCoroutine
    {
      [Token(Token = "0x6007FB7"), Address(RVA = "0x41F03CC", Offset = "0x41F03CC", VA = "0x41F03CC")] get
      {
        return (Coroutine) null;
      }
      [Token(Token = "0x6007FB8"), Address(RVA = "0x41F03D4", Offset = "0x41F03D4", VA = "0x41F03D4")] protected set
      {
      }
    }

    [Token(Token = "0x170013C0")]
    public MonoBehaviour BindCoroutineHandler
    {
      [Token(Token = "0x6007FB9"), Address(RVA = "0x41F03DC", Offset = "0x41F03DC", VA = "0x41F03DC")] get
      {
        return (MonoBehaviour) null;
      }
      [Token(Token = "0x6007FBA"), Address(RVA = "0x41F03E4", Offset = "0x41F03E4", VA = "0x41F03E4")] protected set
      {
      }
    }

    [Token(Token = "0x170013C1")]
    public virtual float CurrentDistance
    {
      [Token(Token = "0x6007FBB"), Address(RVA = "0x41F03EC", Offset = "0x41F03EC", VA = "0x41F03EC", Slot = "4")] get
      {
        return new float();
      }
      [Token(Token = "0x6007FBC"), Address(RVA = "0x41F03F4", Offset = "0x41F03F4", VA = "0x41F03F4", Slot = "5")] protected set
      {
      }
    }

    [Token(Token = "0x170013C2")]
    public abstract FreeMapUIDirection CurrentDirection { [Token(Token = "0x6007FBD")] get; }

    [Token(Token = "0x170013C3")]
    public bool IsShown
    {
      [Token(Token = "0x6007FBE"), Address(RVA = "0x41F03FC", Offset = "0x41F03FC", VA = "0x41F03FC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007FBF"), Address(RVA = "0x41F0404", Offset = "0x41F0404", VA = "0x41F0404")] protected set
      {
      }
    }

    [Token(Token = "0x170013C4")]
    public InstanceID IconHolderObjectID
    {
      [Token(Token = "0x6007FC0"), Address(RVA = "0x41F0410", Offset = "0x41F0410", VA = "0x41F0410")] get
      {
        return new InstanceID();
      }
    }

    [Token(Token = "0x170013C5")]
    public IFreeMapUIClip ClipController
    {
      [Token(Token = "0x6007FC1"), Address(RVA = "0x41F0434", Offset = "0x41F0434", VA = "0x41F0434")] get
      {
        return (IFreeMapUIClip) null;
      }
      [Token(Token = "0x6007FC2"), Address(RVA = "0x41F043C", Offset = "0x41F043C", VA = "0x41F043C")] protected set
      {
      }
    }

    [Token(Token = "0x170013C6")]
    public UITransformIconAvoidElementContainer IconAvoidElement
    {
      [Token(Token = "0x6007FC3"), Address(RVA = "0x41F0444", Offset = "0x41F0444", VA = "0x41F0444")] get
      {
        return (UITransformIconAvoidElementContainer) null;
      }
      [Token(Token = "0x6007FC4"), Address(RVA = "0x41F044C", Offset = "0x41F044C", VA = "0x41F044C")] protected set
      {
      }
    }

    [Token(Token = "0x170013C7")]
    public abstract bool IsValid { [Token(Token = "0x6007FC5")] get; }

    [Token(Token = "0x6007FC6")]
    public abstract void SetAsLastSibling();

    [Token(Token = "0x6007FC7")]
    protected abstract void OnUpdate(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      FreeMapPlayerInstance player,
      bool isUpdateClip);

    [Token(Token = "0x6007FC8")]
    public abstract void ShowUI();

    [Token(Token = "0x6007FC9")]
    public abstract void HideUI();

    [Token(Token = "0x6007FCA")]
    public abstract void ChangeUI(
      FreeMapUIParamBase fromParam,
      FreeMapUIParamBase toParam,
      Sprite sprite,
      UnityAction buttonAction,
      string buttonObjectName);

    [Token(Token = "0x6007FCB")]
    protected abstract void OnDestroyUI();

    [Token(Token = "0x6007FCC")]
    public abstract void ChangeSprite(
      FreeMapUIParamBase targetParam,
      string targetObjectName,
      Sprite sprite);

    [Token(Token = "0x6007FCD")]
    [Address(RVA = "0x41F0454", Offset = "0x41F0454", VA = "0x41F0454")]
    public void AdaptationRangeClip(FreeMapUIRangeClipHandler handler)
    {
    }

    [Token(Token = "0x6007FCE")]
    [Address(RVA = "0x41F051C", Offset = "0x41F051C", VA = "0x41F051C")]
    public void InitializeAvoidHandler(UITransformAvoidHandler correctiongHandler)
    {
    }

    [Token(Token = "0x6007FCF")]
    [Address(RVA = "0x41F0524", Offset = "0x41F0524", VA = "0x41F0524")]
    public void BaseInitialize(FreeMapUITransformHolder iconHolder, IFreeMapUIClip uiClip)
    {
    }

    [Token(Token = "0x6007FD0")]
    [Address(RVA = "0x41F0530", Offset = "0x41F0530", VA = "0x41F0530")]
    public void SetUIClip(IFreeMapUIClip uiClip)
    {
    }

    [Token(Token = "0x6007FD1")]
    [Address(RVA = "0x41F0538", Offset = "0x41F0538", VA = "0x41F0538")]
    public void Update(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      FreeMapPlayerInstance player,
      bool isUpdateClip)
    {
    }

    [Token(Token = "0x6007FD2")]
    [Address(RVA = "0x41F061C", Offset = "0x41F061C", VA = "0x41F061C")]
    public void DestroyUI()
    {
    }

    [Token(Token = "0x6007FD3")]
    [Address(RVA = "0x41F065C", Offset = "0x41F065C", VA = "0x41F065C", Slot = "15")]
    public virtual void RemoveUI(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6007FD4")]
    [Address(RVA = "0x41F056C", Offset = "0x41F056C", VA = "0x41F056C")]
    private void UpdateCurrentDistance(Camera usingCamera)
    {
    }

    [Token(Token = "0x6007FD5")]
    [Address(RVA = "0x41F06FC", Offset = "0x41F06FC", VA = "0x41F06FC")]
    protected FreeMapUIBase()
    {
    }
  }
}
