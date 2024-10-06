// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApHeader.ApHeaderPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery.ApHeader
{
  [Token(Token = "0x200397B")]
  public class ApHeaderPresenter : MonoBehaviour
  {
    [Token(Token = "0x400FB28")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ApHeaderView _view;
    [Token(Token = "0x400FB29")]
    [FieldOffset(Offset = "0x20")]
    private ApHeaderModel _model;

    [Token(Token = "0x17004A72")]
    public Action<int> OnUpdatedAp
    {
      [Token(Token = "0x601698A"), Address(RVA = "0x42EFDFC", Offset = "0x42EFDFC", VA = "0x42EFDFC")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601698B"), Address(RVA = "0x42EFE18", Offset = "0x42EFE18", VA = "0x42EFE18")] set
      {
      }
    }

    [Token(Token = "0x601698C")]
    [Address(RVA = "0x42EC598", Offset = "0x42EC598", VA = "0x42EC598")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601698D")]
    [Address(RVA = "0x42EC714", Offset = "0x42EC714", VA = "0x42EC714")]
    public void ApplyCurrentAp()
    {
    }

    [Token(Token = "0x601698E")]
    [Address(RVA = "0x42F2E58", Offset = "0x42F2E58", VA = "0x42F2E58")]
    private void Update()
    {
    }

    [Token(Token = "0x601698F")]
    [Address(RVA = "0x42F2E8C", Offset = "0x42F2E8C", VA = "0x42F2E8C")]
    public ApHeaderPresenter()
    {
    }
  }
}
