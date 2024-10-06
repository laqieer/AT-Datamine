// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CoverHealModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003725")]
  public class CoverHealModel
  {
    [Token(Token = "0x400F0DE")]
    [FieldOffset(Offset = "0x48")]
    private ContentCharacterModel _character;
    [Token(Token = "0x400F0DF")]
    [FieldOffset(Offset = "0x50")]
    private bool _isPressLpRecovery;
    [Token(Token = "0x400F0E0")]
    [FieldOffset(Offset = "0x54")]
    private float _pressLpRecoveryCount;
    [Token(Token = "0x400F0E1")]
    [FieldOffset(Offset = "0x58")]
    private readonly int _lpRecoverySoulCount;
    [Token(Token = "0x400F0E2")]
    [FieldOffset(Offset = "0x5C")]
    private int _lp;

    [Token(Token = "0x6015B98")]
    [Address(RVA = "0x1D8B530", Offset = "0x1D8B530", VA = "0x1D8B530")]
    public CoverHealModel(ContentCharacterModel character)
    {
    }

    [Token(Token = "0x170047D9")]
    public Action OnDownHealButton
    {
      [Token(Token = "0x6015B99"), Address(RVA = "0x1D8C124", Offset = "0x1D8C124", VA = "0x1D8C124")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015B9A"), Address(RVA = "0x1D8C12C", Offset = "0x1D8C12C", VA = "0x1D8C12C")] set
      {
      }
    }

    [Token(Token = "0x170047DA")]
    public Action OnUpHealButton
    {
      [Token(Token = "0x6015B9B"), Address(RVA = "0x1D8C134", Offset = "0x1D8C134", VA = "0x1D8C134")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015B9C"), Address(RVA = "0x1D8C13C", Offset = "0x1D8C13C", VA = "0x1D8C13C")] set
      {
      }
    }

    [Token(Token = "0x170047DB")]
    public Action<int> OnHeal
    {
      [Token(Token = "0x6015B9D"), Address(RVA = "0x1D8C144", Offset = "0x1D8C144", VA = "0x1D8C144")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6015B9E"), Address(RVA = "0x1D8C14C", Offset = "0x1D8C14C", VA = "0x1D8C14C")] set
      {
      }
    }

    [Token(Token = "0x170047DC")]
    public Action<int, int, bool> OnCostUpdate
    {
      [Token(Token = "0x6015B9F"), Address(RVA = "0x1D8C154", Offset = "0x1D8C154", VA = "0x1D8C154")] get
      {
        return (Action<int, int, bool>) null;
      }
      [Token(Token = "0x6015BA0"), Address(RVA = "0x1D8C15C", Offset = "0x1D8C15C", VA = "0x1D8C15C")] set
      {
      }
    }

    [Token(Token = "0x170047DD")]
    public Action<int, int> OnLpUpdate
    {
      [Token(Token = "0x6015BA1"), Address(RVA = "0x1D8C164", Offset = "0x1D8C164", VA = "0x1D8C164")] get
      {
        return (Action<int, int>) null;
      }
      [Token(Token = "0x6015BA2"), Address(RVA = "0x1D8C16C", Offset = "0x1D8C16C", VA = "0x1D8C16C")] set
      {
      }
    }

    [Token(Token = "0x170047DE")]
    public Action<float> OnGaugeUpdate
    {
      [Token(Token = "0x6015BA3"), Address(RVA = "0x1D8C174", Offset = "0x1D8C174", VA = "0x1D8C174")] get
      {
        return (Action<float>) null;
      }
      [Token(Token = "0x6015BA4"), Address(RVA = "0x1D8C17C", Offset = "0x1D8C17C", VA = "0x1D8C17C")] set
      {
      }
    }

    [Token(Token = "0x170047DF")]
    public Action OnGaugeEnd
    {
      [Token(Token = "0x6015BA5"), Address(RVA = "0x1D8C184", Offset = "0x1D8C184", VA = "0x1D8C184")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015BA6"), Address(RVA = "0x1D8C18C", Offset = "0x1D8C18C", VA = "0x1D8C18C")] set
      {
      }
    }

    [Token(Token = "0x170047E0")]
    public int LpMax
    {
      [Token(Token = "0x6015BA7"), Address(RVA = "0x1D8C194", Offset = "0x1D8C194", VA = "0x1D8C194")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6015BA8")]
    [Address(RVA = "0x1D8C1AC", Offset = "0x1D8C1AC", VA = "0x1D8C1AC")]
    public void DownHealButton()
    {
    }

    [Token(Token = "0x6015BA9")]
    [Address(RVA = "0x1D8C294", Offset = "0x1D8C294", VA = "0x1D8C294")]
    public IEnumerator PressHealButton() => (IEnumerator) null;

    [Token(Token = "0x6015BAA")]
    [Address(RVA = "0x1D8C324", Offset = "0x1D8C324", VA = "0x1D8C324")]
    public void UpHealButton()
    {
    }

    [Token(Token = "0x6015BAB")]
    [Address(RVA = "0x1D8C3DC", Offset = "0x1D8C3DC", VA = "0x1D8C3DC")]
    public void ChangeState()
    {
    }

    [Token(Token = "0x6015BAC")]
    [Address(RVA = "0x1D8C23C", Offset = "0x1D8C23C", VA = "0x1D8C23C")]
    public int PossessionSoulNum() => new int();
  }
}
