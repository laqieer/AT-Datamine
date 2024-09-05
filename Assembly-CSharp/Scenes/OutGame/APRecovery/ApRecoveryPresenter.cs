// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery.ApHeader;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003963")]
  public class ApRecoveryPresenter : MonoBehaviour
  {
    [Token(Token = "0x400FAC7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ApRecoveryView _view;
    [Token(Token = "0x400FAC8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ApHeaderPresenter _apHeader;
    [Token(Token = "0x400FAC9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400FACF")]
    [FieldOffset(Offset = "0x58")]
    private ApRecoveryModel _model;

    [Token(Token = "0x17004A37")]
    public Action OnRecoverySuccess
    {
      [Token(Token = "0x60168DC"), Address(RVA = "0x42EFA90", Offset = "0x42EFA90", VA = "0x42EFA90")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60168DD"), Address(RVA = "0x42EFA98", Offset = "0x42EFA98", VA = "0x42EFA98")] set
      {
      }
    }

    [Token(Token = "0x17004A38")]
    public Action OnRecoveryError
    {
      [Token(Token = "0x60168DE"), Address(RVA = "0x42EFAA0", Offset = "0x42EFAA0", VA = "0x42EFAA0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60168DF"), Address(RVA = "0x42EFAA8", Offset = "0x42EFAA8", VA = "0x42EFAA8")] set
      {
      }
    }

    [Token(Token = "0x17004A39")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x60168E0"), Address(RVA = "0x42EE934", Offset = "0x42EE934", VA = "0x42EE934")] set
      {
      }
    }

    [Token(Token = "0x17004A3A")]
    public Action Closure
    {
      [Token(Token = "0x60168E1"), Address(RVA = "0x42EFAB0", Offset = "0x42EFAB0", VA = "0x42EFAB0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60168E2"), Address(RVA = "0x42EFAB8", Offset = "0x42EFAB8", VA = "0x42EFAB8")] set
      {
      }
    }

    [Token(Token = "0x17004A3B")]
    public Action OnBackKeyAction
    {
      [Token(Token = "0x60168E3"), Address(RVA = "0x42EFAC0", Offset = "0x42EFAC0", VA = "0x42EFAC0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60168E4"), Address(RVA = "0x42EEE20", Offset = "0x42EEE20", VA = "0x42EEE20")] set
      {
      }
    }

    [Token(Token = "0x17004A3C")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x60168E5"), Address(RVA = "0x42EFADC", Offset = "0x42EFADC", VA = "0x42EFADC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60168E6"), Address(RVA = "0x42EFAE4", Offset = "0x42EFAE4", VA = "0x42EFAE4")] set
      {
      }
    }

    [Token(Token = "0x17004A3D")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x60168E7"), Address(RVA = "0x42EFAEC", Offset = "0x42EFAEC", VA = "0x42EFAEC")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x60168E8"), Address(RVA = "0x42EFAF4", Offset = "0x42EFAF4", VA = "0x42EFAF4")] set
      {
      }
    }

    [Token(Token = "0x60168E9")]
    [Address(RVA = "0x42EEA38", Offset = "0x42EEA38", VA = "0x42EEA38")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60168EA")]
    [Address(RVA = "0x42EFE34", Offset = "0x42EFE34", VA = "0x42EFE34")]
    private void OnRecoveryByItem()
    {
    }

    [Token(Token = "0x60168EB")]
    [Address(RVA = "0x42EFF00", Offset = "0x42EFF00", VA = "0x42EFF00")]
    private void OnRecoveryByCoin()
    {
    }

    [Token(Token = "0x60168EC")]
    [Address(RVA = "0x42F0050", Offset = "0x42F0050", VA = "0x42F0050")]
    public ApRecoveryPresenter()
    {
    }
  }
}
