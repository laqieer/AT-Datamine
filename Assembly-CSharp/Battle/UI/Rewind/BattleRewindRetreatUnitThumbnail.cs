// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindRetreatUnitThumbnail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002466")]
  public class BattleRewindRetreatUnitThumbnail : MonoBehaviour
  {
    [Token(Token = "0x4009C23")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x4009C24")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x4009C25")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ActiveObjectContainers rareStarImages;
    [Token(Token = "0x4009C26")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image elementIconImage;
    [Token(Token = "0x4009C27")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ActiveObjectContainers fpIconImages;
    [Token(Token = "0x4009C28")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image lostImage;

    [Token(Token = "0x600DF41")]
    [Address(RVA = "0x201780C", Offset = "0x201780C", VA = "0x201780C")]
    public void Initialize(
      BattleRewindRetreatUnitThumbnail.InitializeParameter parameter)
    {
    }

    [Token(Token = "0x600DF42")]
    [Address(RVA = "0x2018E6C", Offset = "0x2018E6C", VA = "0x2018E6C")]
    public BattleRewindRetreatUnitThumbnail()
    {
    }

    [Token(Token = "0x2002467")]
    public class InitializeParameter
    {
      [Token(Token = "0x4009C29")]
      [FieldOffset(Offset = "0x10")]
      public Sprite ThumbnailImage;
      [Token(Token = "0x4009C2A")]
      [FieldOffset(Offset = "0x18")]
      public Sprite ElementIcon;
      [Token(Token = "0x4009C2B")]
      [FieldOffset(Offset = "0x20")]
      public int Level;
      [Token(Token = "0x4009C2C")]
      [FieldOffset(Offset = "0x24")]
      public int Rarity;
      [Token(Token = "0x4009C2D")]
      [FieldOffset(Offset = "0x28")]
      public int Fp;

      [Token(Token = "0x600DF43")]
      [Address(RVA = "0x2017804", Offset = "0x2017804", VA = "0x2017804")]
      public InitializeParameter()
      {
      }
    }
  }
}
