// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CoverHealPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003727")]
  public class CoverHealPresenter : MonoBehaviour
  {
    [Token(Token = "0x400F0E6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CoverHealView _view;
    [Token(Token = "0x400F0E7")]
    [FieldOffset(Offset = "0x20")]
    private CoverHealModel _model;

    [Token(Token = "0x6015BB3")]
    [Address(RVA = "0x1D8B8A8", Offset = "0x1D8B8A8", VA = "0x1D8B8A8")]
    public void Initialize(CoverHealModel model)
    {
    }

    [Token(Token = "0x6015BB4")]
    [Address(RVA = "0x1D8BF40", Offset = "0x1D8BF40", VA = "0x1D8BF40")]
    public void ChangeState()
    {
    }

    [Token(Token = "0x6015BB5")]
    [Address(RVA = "0x1D8C89C", Offset = "0x1D8C89C", VA = "0x1D8C89C")]
    public CoverHealPresenter()
    {
    }
  }
}
