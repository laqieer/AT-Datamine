// Decompiled with JetBrains decompiler
// Type: Battle.UI.ItemListItemTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023E4")]
  [RequireComponent(typeof (UITweenGroup))]
  public sealed class ItemListItemTween : TweenWrapper
  {
    [Token(Token = "0x400993F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private string showDefaultName;
    [Token(Token = "0x4009940")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HideInInspector]
    private string showChangeName;
    [Token(Token = "0x4009941")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HideInInspector]
    private string showUselessName;
    [Token(Token = "0x4009942")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HideInInspector]
    private string showEquippedName;

    [Token(Token = "0x600DBFC")]
    [Address(RVA = "0x2152CA8", Offset = "0x2152CA8", VA = "0x2152CA8")]
    public void Show(ItemListItemTween.ViewType type)
    {
    }

    [Token(Token = "0x600DBFD")]
    [Address(RVA = "0x2152DCC", Offset = "0x2152DCC", VA = "0x2152DCC", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600DBFE")]
    [Address(RVA = "0x2152DD0", Offset = "0x2152DD0", VA = "0x2152DD0")]
    public ItemListItemTween()
    {
    }

    [Token(Token = "0x20023E5")]
    public enum ViewType
    {
      [Token(Token = "0x4009944")] Default,
      [Token(Token = "0x4009945")] Change,
      [Token(Token = "0x4009946")] Useless,
      [Token(Token = "0x4009947")] Equipped,
    }
  }
}
