// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContentCharacterPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003722")]
  public class ContentCharacterPresenter : InfiniteCellBase
  {
    [Token(Token = "0x400F0BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ContentCharacterView _view;
    [Token(Token = "0x400F0C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CoverHealPresenter _coverHeal;
    [Token(Token = "0x400F0C1")]
    [FieldOffset(Offset = "0x38")]
    private ContentCharacterModel _model;
    [Token(Token = "0x400F0C2")]
    [FieldOffset(Offset = "0x40")]
    private Coroutine _calcLostRecoveryTime;
    [Token(Token = "0x400F0C3")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x400F0C4")]
    [FieldOffset(Offset = "0x50")]
    private AssetSpawnOperation<Sprite> _emblemOperationItem;
    [Token(Token = "0x400F0C5")]
    [FieldOffset(Offset = "0x58")]
    private AssetSpawnOperation<Sprite> _characterOperationItem;

    [Token(Token = "0x170047D7")]
    public bool IsValid
    {
      [Token(Token = "0x6015B7A"), Address(RVA = "0x1D8A154", Offset = "0x1D8A154", VA = "0x1D8A154")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170047D8")]
    public Character Character
    {
      [Token(Token = "0x6015B7B"), Address(RVA = "0x1D8AC40", Offset = "0x1D8AC40", VA = "0x1D8AC40")] get
      {
        return (Character) null;
      }
    }

    [Token(Token = "0x6015B7C")]
    [Address(RVA = "0x1D8AC5C", Offset = "0x1D8AC5C", VA = "0x1D8AC5C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6015B7D")]
    [Address(RVA = "0x1D8ACEC", Offset = "0x1D8ACEC", VA = "0x1D8ACEC")]
    public void Initialize(ContentCharacterModel characterModel)
    {
    }

    [Token(Token = "0x6015B7E")]
    [Address(RVA = "0x1D8AD08", Offset = "0x1D8AD08", VA = "0x1D8AD08")]
    public void Initialize(AssetCachedSpawner spawner, ContentCharacterModel characterModel)
    {
    }

    [Token(Token = "0x6015B7F")]
    [Address(RVA = "0x1D8BAFC", Offset = "0x1D8BAFC", VA = "0x1D8BAFC")]
    public void InitializeForMargin()
    {
    }

    [Token(Token = "0x6015B80")]
    [Address(RVA = "0x1D8A164", Offset = "0x1D8A164", VA = "0x1D8A164")]
    public void OperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6015B81")]
    [Address(RVA = "0x1D8BB84", Offset = "0x1D8BB84", VA = "0x1D8BB84")]
    private void OnClickCharacter()
    {
    }

    [Token(Token = "0x6015B82")]
    [Address(RVA = "0x1D8BBB8", Offset = "0x1D8BBB8", VA = "0x1D8BBB8")]
    private void OnClickLostComebackButton()
    {
    }

    [Token(Token = "0x6015B83")]
    [Address(RVA = "0x1D8BBEC", Offset = "0x1D8BBEC", VA = "0x1D8BBEC")]
    private void OnHeal(int recoveryCount)
    {
    }

    [Token(Token = "0x6015B84")]
    [Address(RVA = "0x1D8BC20", Offset = "0x1D8BC20", VA = "0x1D8BC20")]
    private void ChangeState()
    {
    }

    [Token(Token = "0x6015B85")]
    [Address(RVA = "0x1D8BF58", Offset = "0x1D8BF58", VA = "0x1D8BF58")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015B86")]
    [Address(RVA = "0x1D8BFA0", Offset = "0x1D8BFA0", VA = "0x1D8BFA0")]
    public ContentCharacterPresenter()
    {
    }
  }
}
