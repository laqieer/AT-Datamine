// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery.ApHeader;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003950")]
  public class ApRecoveryHeader : MonoBehaviour
  {
    [Token(Token = "0x400FA77")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ApHeaderPresenter _header;
    [Token(Token = "0x400FA78")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton _recoveryButton;
    [Token(Token = "0x400FA79")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("AP回復ポップアップを表示する基準座標です。\nAPボタンのImgを設定してください")]
    private Transform _popupBase;
    [Token(Token = "0x400FA7A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Vector2 _contentOffset;
    [Token(Token = "0x400FA7E")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x17004A14")]
    public bool Initialized
    {
      [Token(Token = "0x6016867"), Address(RVA = "0x42EC3BC", Offset = "0x42EC3BC", VA = "0x42EC3BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016868"), Address(RVA = "0x42EC3C4", Offset = "0x42EC3C4", VA = "0x42EC3C4")] private set
      {
      }
    }

    [Token(Token = "0x17004A15")]
    public Action OnRecoverySuccess
    {
      [Token(Token = "0x6016869"), Address(RVA = "0x42EC3D0", Offset = "0x42EC3D0", VA = "0x42EC3D0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601686A"), Address(RVA = "0x42EC3D8", Offset = "0x42EC3D8", VA = "0x42EC3D8")] set
      {
      }
    }

    [Token(Token = "0x17004A16")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x601686B"), Address(RVA = "0x42EC3E0", Offset = "0x42EC3E0", VA = "0x42EC3E0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601686C"), Address(RVA = "0x42EC3E8", Offset = "0x42EC3E8", VA = "0x42EC3E8")] set
      {
      }
    }

    [Token(Token = "0x601686D")]
    [Address(RVA = "0x42EC3F0", Offset = "0x42EC3F0", VA = "0x42EC3F0")]
    public void Initialize(AssetCachedSpawner cachedSpawner = null, Action action = null)
    {
    }

    [Token(Token = "0x601686E")]
    [Address(RVA = "0x42EC6F4", Offset = "0x42EC6F4", VA = "0x42EC6F4")]
    public void ApplyCurentAp()
    {
    }

    [Token(Token = "0x601686F")]
    [Address(RVA = "0x42EC72C", Offset = "0x42EC72C", VA = "0x42EC72C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6016870")]
    [Address(RVA = "0x42EC73C", Offset = "0x42EC73C", VA = "0x42EC73C")]
    public void OnClickApButton()
    {
    }

    [Token(Token = "0x6016871")]
    [Address(RVA = "0x42EC744", Offset = "0x42EC744", VA = "0x42EC744")]
    public void OnClickApButton(Action successAction = null)
    {
    }

    [Token(Token = "0x6016872")]
    [Address(RVA = "0x42EC918", Offset = "0x42EC918", VA = "0x42EC918")]
    public ApRecoveryHeader()
    {
    }
  }
}
