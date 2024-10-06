// Decompiled with JetBrains decompiler
// Type: Scenes.Story.EquipList.EquipItemListParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.EquipList
{
  [Token(Token = "0x2002F15")]
  public class EquipItemListParameter : ChangeSceneParameter
  {
    [Token(Token = "0x17003E62")]
    public EquipItemListParameter.EquipListType ListType
    {
      [Token(Token = "0x6012661"), Address(RVA = "0x2304410", Offset = "0x2304410", VA = "0x2304410")] get
      {
        return new EquipItemListParameter.EquipListType();
      }
      [Token(Token = "0x6012662"), Address(RVA = "0x2304418", Offset = "0x2304418", VA = "0x2304418")] private set
      {
      }
    }

    [Token(Token = "0x6012663")]
    [Address(RVA = "0x2304420", Offset = "0x2304420", VA = "0x2304420")]
    public EquipItemListParameter(EquipItemListParameter.EquipListType listType)
    {
    }

    [Token(Token = "0x2002F16")]
    public enum EquipListType
    {
      [Token(Token = "0x400CA12")] Weapon,
      [Token(Token = "0x400CA13")] Accesory,
      [Token(Token = "0x400CA14")] Mind,
      [Token(Token = "0x400CA15")] UnitTrust,
    }
  }
}
