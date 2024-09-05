// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.StyleLevelupContentBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail
{
  [Token(Token = "0x20032D3")]
  public abstract class StyleLevelupContentBase : MonoBehaviour
  {
    [Token(Token = "0x400DB1E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Image charaImage;
    [Token(Token = "0x400DB1F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected StyleLevelupContentBase.LvTextGroup beforeLvTextGroup;
    [Token(Token = "0x400DB20")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected StyleLevelupContentBase.LvTextGroup afterLvTextGroup;
    [Token(Token = "0x400DB21")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Slider levelupSlider;
    [Token(Token = "0x400DB22")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Text expText;
    [Token(Token = "0x400DB23")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected Slider expSlider;
    [Token(Token = "0x400DB24")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton reduceButton;
    [Token(Token = "0x400DB25")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton addButton;
    [Token(Token = "0x400DB26")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton maxUseButton;
    [Token(Token = "0x400DB27")]
    [FieldOffset(Offset = "0x60")]
    protected int maxLevel;
    [Token(Token = "0x400DB28")]
    [FieldOffset(Offset = "0x68")]
    protected Style style;
    [Token(Token = "0x400DB29")]
    [FieldOffset(Offset = "0x70")]
    protected int tmpLevel;

    [Token(Token = "0x17004301")]
    public int AfterLevel
    {
      [Token(Token = "0x6013F71"), Address(RVA = "0x2343D28", Offset = "0x2343D28", VA = "0x2343D28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004302")]
    public bool IsLevelMax
    {
      [Token(Token = "0x6013F72"), Address(RVA = "0x2343D68", Offset = "0x2343D68", VA = "0x2343D68")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013F73")]
    [Address(RVA = "0x2343D7C", Offset = "0x2343D7C", VA = "0x2343D7C", Slot = "4")]
    public virtual void Initialize(Style style, int maxLevel)
    {
    }

    [Token(Token = "0x6013F74")]
    [Address(RVA = "0x234419C", Offset = "0x234419C", VA = "0x234419C")]
    protected int GetAddExp(int nextLevel) => new int();

    [Token(Token = "0x6013F75")]
    [Address(RVA = "0x2344340", Offset = "0x2344340", VA = "0x2344340")]
    protected void UpdateUI(int addExp)
    {
    }

    [Token(Token = "0x6013F76")]
    [Address(RVA = "0x23446BC", Offset = "0x23446BC", VA = "0x23446BC")]
    protected void SetLevelupSliderData(int level)
    {
    }

    [Token(Token = "0x6013F77")]
    public abstract void OnLevelUpValueChange(float val);

    [Token(Token = "0x6013F78")]
    public abstract void OnClickToMaxUse();

    [Token(Token = "0x6013F79")]
    public abstract void OnClickToAddLevelButton();

    [Token(Token = "0x6013F7A")]
    public abstract void OnClickToSubLevelButton();

    [Token(Token = "0x6013F7B")]
    public abstract void ResetData();

    [Token(Token = "0x6013F7C")]
    public abstract APIUnitUnit_levelUpRequest GetRequestData(string styleUniqueId);

    [Token(Token = "0x6013F7D")]
    [Address(RVA = "0x234478C", Offset = "0x234478C", VA = "0x234478C")]
    protected StyleLevelupContentBase()
    {
    }

    [Token(Token = "0x20032D4")]
    [Serializable]
    public class LvTextGroup
    {
      [Token(Token = "0x400DB2A")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text lvText;
      [Token(Token = "0x400DB2B")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Text lvMaxText;

      [Token(Token = "0x6013F7E")]
      [Address(RVA = "0x2344124", Offset = "0x2344124", VA = "0x2344124")]
      public void Set(int lv, int lvMax)
      {
      }

      [Token(Token = "0x6013F7F")]
      [Address(RVA = "0x2344794", Offset = "0x2344794", VA = "0x2344794")]
      public LvTextGroup()
      {
      }
    }
  }
}
