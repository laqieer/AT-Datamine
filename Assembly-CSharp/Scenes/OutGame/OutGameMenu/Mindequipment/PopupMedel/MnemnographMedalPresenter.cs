// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.MnemnographMedalPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003C06")]
  public class MnemnographMedalPresenter : MonoBehaviour
  {
    [Token(Token = "0x40109F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MnemnographMedalView _view;
    [Token(Token = "0x40109F3")]
    [FieldOffset(Offset = "0x30")]
    private MnemnographMedalModel _model;

    [Token(Token = "0x17004CA9")]
    public Action Closure
    {
      [Token(Token = "0x601797E"), Address(RVA = "0x237E6AC", Offset = "0x237E6AC", VA = "0x237E6AC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601797F"), Address(RVA = "0x237E6B4", Offset = "0x237E6B4", VA = "0x237E6B4")] set
      {
      }
    }

    [Token(Token = "0x17004CAA")]
    public Action<ConversionContext> OnSuccessConvertion
    {
      [Token(Token = "0x6017980"), Address(RVA = "0x237DB48", Offset = "0x237DB48", VA = "0x237DB48")] get
      {
        return (Action<ConversionContext>) null;
      }
      [Token(Token = "0x6017981"), Address(RVA = "0x237DB88", Offset = "0x237DB88", VA = "0x237DB88")] set
      {
      }
    }

    [Token(Token = "0x17004CAB")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x6017982"), Address(RVA = "0x237E6BC", Offset = "0x237E6BC", VA = "0x237E6BC")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x6017983"), Address(RVA = "0x237E6C4", Offset = "0x237E6C4", VA = "0x237E6C4")] set
      {
      }
    }

    [Token(Token = "0x6017984")]
    [Address(RVA = "0x237DBBC", Offset = "0x237DBBC", VA = "0x237DBBC")]
    public void Initialize(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6017985")]
    [Address(RVA = "0x237E8B4", Offset = "0x237E8B4", VA = "0x237E8B4")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6017986")]
    [Address(RVA = "0x237E8D0", Offset = "0x237E8D0", VA = "0x237E8D0")]
    private void OnConversion()
    {
    }

    [Token(Token = "0x6017987")]
    [Address(RVA = "0x237E8FC", Offset = "0x237E8FC", VA = "0x237E8FC")]
    public MnemnographMedalPresenter()
    {
    }
  }
}
