// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnhanceSlayArmorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027BC")]
  public class EnhanceSlayArmorData : ModifierEffectData
  {
    [Token(Token = "0x400A956")]
    [FieldOffset(Offset = "0x94")]
    private EnhanceSlayArmorData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x17003584")]
    public Dictionary<int, string> ParameterTextMap
    {
      [Token(Token = "0x600F83C"), Address(RVA = "0x1EDFE2C", Offset = "0x1EDFE2C", VA = "0x1EDFE2C")] get
      {
        return (Dictionary<int, string>) null;
      }
    }

    [Token(Token = "0x17003585")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F83D"), Address(RVA = "0x1EDFE34", Offset = "0x1EDFE34", VA = "0x1EDFE34", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F83E")]
    [Address(RVA = "0x1EDC3B4", Offset = "0x1EDC3B4", VA = "0x1EDC3B4")]
    public static EnhanceSlayArmorData Create(EffectSource source) => (EnhanceSlayArmorData) null;

    [Token(Token = "0x600F83F")]
    [Address(RVA = "0x1EDFE90", Offset = "0x1EDFE90", VA = "0x1EDFE90")]
    protected EnhanceSlayArmorData(EffectSource source)
    {
    }

    [Token(Token = "0x600F840")]
    [Address(RVA = "0x1EDFF88", Offset = "0x1EDFF88", VA = "0x1EDFF88", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F841")]
    [Address(RVA = "0x1EDFFE8", Offset = "0x1EDFFE8", VA = "0x1EDFFE8", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x20027BD")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x17003586")]
      public int ValueType
      {
        [Token(Token = "0x600F842"), Address(RVA = "0x1EE016C", Offset = "0x1EE016C", VA = "0x1EE016C", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F843"), Address(RVA = "0x1EE0174", Offset = "0x1EE0174", VA = "0x1EE0174")] set
        {
        }
      }

      [Token(Token = "0x17003587")]
      public int Heavy
      {
        [Token(Token = "0x600F844"), Address(RVA = "0x1EE017C", Offset = "0x1EE017C", VA = "0x1EE017C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F845"), Address(RVA = "0x1EE0184", Offset = "0x1EE0184", VA = "0x1EE0184")] set
        {
        }
      }

      [Token(Token = "0x17003588")]
      public int Light
      {
        [Token(Token = "0x600F846"), Address(RVA = "0x1EE018C", Offset = "0x1EE018C", VA = "0x1EE018C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F847"), Address(RVA = "0x1EE0194", Offset = "0x1EE0194", VA = "0x1EE0194")] set
        {
        }
      }

      [Token(Token = "0x17003589")]
      public int Normal
      {
        [Token(Token = "0x600F848"), Address(RVA = "0x1EE019C", Offset = "0x1EE019C", VA = "0x1EE019C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F849"), Address(RVA = "0x1EE01A4", Offset = "0x1EE01A4", VA = "0x1EE01A4")] set
        {
        }
      }
    }
  }
}
