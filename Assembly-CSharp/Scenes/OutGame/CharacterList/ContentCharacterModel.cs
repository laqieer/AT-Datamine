// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContentCharacterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003720")]
  public class ContentCharacterModel
  {
    [Token(Token = "0x400F0B6")]
    [FieldOffset(Offset = "0x58")]
    private Character _character;
    [Token(Token = "0x400F0B7")]
    [FieldOffset(Offset = "0x60")]
    private int _index;
    [Token(Token = "0x400F0B8")]
    [FieldOffset(Offset = "0x64")]
    private bool _isEnogthLostRecoveryCoin;
    [Token(Token = "0x400F0B9")]
    [FieldOffset(Offset = "0x68")]
    private int _lostRecoveryCount;
    [Token(Token = "0x400F0BA")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner _spawner;

    [Token(Token = "0x6015B4D")]
    [Address(RVA = "0x1D86EAC", Offset = "0x1D86EAC", VA = "0x1D86EAC")]
    public ContentCharacterModel(Character character, int index, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x170047C6")]
    public Character Character
    {
      [Token(Token = "0x6015B4E"), Address(RVA = "0x1D8A378", Offset = "0x1D8A378", VA = "0x1D8A378")] get
      {
        return (Character) null;
      }
    }

    [Token(Token = "0x170047C7")]
    public int Index
    {
      [Token(Token = "0x6015B4F"), Address(RVA = "0x1D8A380", Offset = "0x1D8A380", VA = "0x1D8A380")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170047C8")]
    public AssetCachedSpawner Spawner
    {
      [Token(Token = "0x6015B50"), Address(RVA = "0x1D8A388", Offset = "0x1D8A388", VA = "0x1D8A388")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x170047C9")]
    public int LpMax
    {
      [Token(Token = "0x6015B51"), Address(RVA = "0x1D8A390", Offset = "0x1D8A390", VA = "0x1D8A390")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170047CA")]
    public bool IsEnogthLostRecoveryCoin
    {
      [Token(Token = "0x6015B52"), Address(RVA = "0x1D8A418", Offset = "0x1D8A418", VA = "0x1D8A418")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170047CB")]
    public int LostRecoveryCount
    {
      [Token(Token = "0x6015B53"), Address(RVA = "0x1D8A420", Offset = "0x1D8A420", VA = "0x1D8A420")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170047CC")]
    public Func<IEnumerator> OnRecoveryTimeOver
    {
      [Token(Token = "0x6015B54"), Address(RVA = "0x1D8A428", Offset = "0x1D8A428", VA = "0x1D8A428")] get
      {
        return (Func<IEnumerator>) null;
      }
      [Token(Token = "0x6015B55"), Address(RVA = "0x1D8A430", Offset = "0x1D8A430", VA = "0x1D8A430")] set
      {
      }
    }

    [Token(Token = "0x170047CD")]
    public Action<TimeSpan> OnUpdateRecoveryTime
    {
      [Token(Token = "0x6015B56"), Address(RVA = "0x1D8A438", Offset = "0x1D8A438", VA = "0x1D8A438")] get
      {
        return (Action<TimeSpan>) null;
      }
      [Token(Token = "0x6015B57"), Address(RVA = "0x1D8A440", Offset = "0x1D8A440", VA = "0x1D8A440")] set
      {
      }
    }

    [Token(Token = "0x170047CE")]
    public Action<int, bool> OnUpdateRecoveryNeedCoin
    {
      [Token(Token = "0x6015B58"), Address(RVA = "0x1D8A448", Offset = "0x1D8A448", VA = "0x1D8A448")] get
      {
        return (Action<int, bool>) null;
      }
      [Token(Token = "0x6015B59"), Address(RVA = "0x1D8A450", Offset = "0x1D8A450", VA = "0x1D8A450")] set
      {
      }
    }

    [Token(Token = "0x170047CF")]
    public Action OnChangeState
    {
      [Token(Token = "0x6015B5A"), Address(RVA = "0x1D8A458", Offset = "0x1D8A458", VA = "0x1D8A458")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015B5B"), Address(RVA = "0x1D8A460", Offset = "0x1D8A460", VA = "0x1D8A460")] set
      {
      }
    }

    [Token(Token = "0x170047D0")]
    public Action OnClickCharacter
    {
      [Token(Token = "0x6015B5C"), Address(RVA = "0x1D8A468", Offset = "0x1D8A468", VA = "0x1D8A468")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015B5D"), Address(RVA = "0x1D8A470", Offset = "0x1D8A470", VA = "0x1D8A470")] set
      {
      }
    }

    [Token(Token = "0x170047D1")]
    public Action OnClickLostRecovery
    {
      [Token(Token = "0x6015B5E"), Address(RVA = "0x1D8A478", Offset = "0x1D8A478", VA = "0x1D8A478")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015B5F"), Address(RVA = "0x1D8A480", Offset = "0x1D8A480", VA = "0x1D8A480")] set
      {
      }
    }

    [Token(Token = "0x170047D2")]
    public Action<int> OnHeal
    {
      [Token(Token = "0x6015B60"), Address(RVA = "0x1D8A488", Offset = "0x1D8A488", VA = "0x1D8A488")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6015B61"), Address(RVA = "0x1D8A490", Offset = "0x1D8A490", VA = "0x1D8A490")] set
      {
      }
    }

    [Token(Token = "0x170047D3")]
    public Action<bool> OnSelected
    {
      [Token(Token = "0x6015B62"), Address(RVA = "0x1D8A498", Offset = "0x1D8A498", VA = "0x1D8A498")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6015B63"), Address(RVA = "0x1D8A4A0", Offset = "0x1D8A4A0", VA = "0x1D8A4A0")] set
      {
      }
    }

    [Token(Token = "0x170047D4")]
    public bool IsSelected
    {
      [Token(Token = "0x6015B64"), Address(RVA = "0x1D8A4A8", Offset = "0x1D8A4A8", VA = "0x1D8A4A8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015B65"), Address(RVA = "0x1D8A4B0", Offset = "0x1D8A4B0", VA = "0x1D8A4B0")] private set
      {
      }
    }

    [Token(Token = "0x6015B66")]
    [Address(RVA = "0x1D8A4BC", Offset = "0x1D8A4BC", VA = "0x1D8A4BC")]
    public int GetLP() => new int();

    [Token(Token = "0x6015B67")]
    [Address(RVA = "0x1D8A4D8", Offset = "0x1D8A4D8", VA = "0x1D8A4D8")]
    public ContentState GetState() => new ContentState();

    [Token(Token = "0x6015B68")]
    [Address(RVA = "0x1D8A514", Offset = "0x1D8A514", VA = "0x1D8A514")]
    public bool IsLost() => new bool();

    [Token(Token = "0x6015B69")]
    [Address(RVA = "0x1D8A52C", Offset = "0x1D8A52C", VA = "0x1D8A52C")]
    public StyleData GetDefaultStyleMaster() => (StyleData) null;

    [Token(Token = "0x6015B6A")]
    [Address(RVA = "0x1D8A5D8", Offset = "0x1D8A5D8", VA = "0x1D8A5D8")]
    public IEnumerator UpdateLostRecoveryTime() => (IEnumerator) null;

    [Token(Token = "0x6015B6B")]
    [Address(RVA = "0x1D878C0", Offset = "0x1D878C0", VA = "0x1D878C0")]
    public bool IsLostRevive() => new bool();

    [Token(Token = "0x6015B6C")]
    [Address(RVA = "0x1D87C2C", Offset = "0x1D87C2C", VA = "0x1D87C2C")]
    public void ChangeState()
    {
    }

    [Token(Token = "0x6015B6D")]
    [Address(RVA = "0x1D8A784", Offset = "0x1D8A784", VA = "0x1D8A784")]
    public void ClickCharacter()
    {
    }

    [Token(Token = "0x6015B6E")]
    [Address(RVA = "0x1D8A7A0", Offset = "0x1D8A7A0", VA = "0x1D8A7A0")]
    public void LostRecovery()
    {
    }

    [Token(Token = "0x6015B6F")]
    [Address(RVA = "0x1D8A7BC", Offset = "0x1D8A7BC", VA = "0x1D8A7BC")]
    public void Heal(int recoveryCount)
    {
    }

    [Token(Token = "0x6015B70")]
    [Address(RVA = "0x1D87478", Offset = "0x1D87478", VA = "0x1D87478")]
    public void Select(bool isSelect)
    {
    }

    [Token(Token = "0x6015B71")]
    [Address(RVA = "0x1D8A7D8", Offset = "0x1D8A7D8", VA = "0x1D8A7D8")]
    private void SetLostRecoveryTime(in TimeSpan timeSpan)
    {
    }

    [Token(Token = "0x6015B72")]
    [Address(RVA = "0x1D8A668", Offset = "0x1D8A668", VA = "0x1D8A668")]
    private DateTime LostRecoveryTargetAt() => new DateTime();

    [Token(Token = "0x6015B73")]
    [Address(RVA = "0x1D8A7F8", Offset = "0x1D8A7F8", VA = "0x1D8A7F8")]
    private static int LostRecoveryNeedCoin(in TimeSpan lostRecoveryTime) => new int();
  }
}
