// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemUnEquipableStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200044F")]
  public class ItemUnEquipableStatus
  {
    [Token(Token = "0x40017DE")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ItemUnEquipableStatus.UnEquipableMessage Default;

    [Token(Token = "0x170002E0")]
    public ItemUnEquipableStatus.UnEquipableMessage Message
    {
      [Token(Token = "0x6001875"), Address(RVA = "0x2490F14", Offset = "0x2490F14", VA = "0x2490F14")] get
      {
        return new ItemUnEquipableStatus.UnEquipableMessage();
      }
      [Token(Token = "0x6001876"), Address(RVA = "0x2490F1C", Offset = "0x2490F1C", VA = "0x2490F1C")] private set
      {
      }
    }

    [Token(Token = "0x170002E1")]
    public bool IsUnEquipable
    {
      [Token(Token = "0x6001877"), Address(RVA = "0x2490F24", Offset = "0x2490F24", VA = "0x2490F24")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001878"), Address(RVA = "0x2490F2C", Offset = "0x2490F2C", VA = "0x2490F2C")] private set
      {
      }
    }

    [Token(Token = "0x6001879")]
    [Address(RVA = "0x248FFC8", Offset = "0x248FFC8", VA = "0x248FFC8")]
    public ItemUnEquipableStatus()
    {
    }

    [Token(Token = "0x600187A")]
    [Address(RVA = "0x2490058", Offset = "0x2490058", VA = "0x2490058")]
    public ItemUnEquipableStatus(ItemUnEquipableStatus.UnEquipableMessage message)
    {
    }

    [Token(Token = "0x600187B")]
    [Address(RVA = "0x2490F38", Offset = "0x2490F38", VA = "0x2490F38")]
    public void UnEquipable(ItemUnEquipableStatus.UnEquipableMessage message)
    {
    }

    [Token(Token = "0x600187C")]
    [Address(RVA = "0x2490F48", Offset = "0x2490F48", VA = "0x2490F48")]
    public void Clear()
    {
    }

    [Token(Token = "0x600187D")]
    [Address(RVA = "0x2490F54", Offset = "0x2490F54", VA = "0x2490F54")]
    static ItemUnEquipableStatus()
    {
    }

    [Token(Token = "0x2000450")]
    public struct UnEquipableMessage
    {
      [Token(Token = "0x170002E2")]
      public readonly string Text
      {
        [Token(Token = "0x600187E"), Address(RVA = "0x2490FB4", Offset = "0x2490FB4", VA = "0x2490FB4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600187F")]
      [Address(RVA = "0x2490FBC", Offset = "0x2490FBC", VA = "0x2490FBC")]
      public UnEquipableMessage(string text)
      {
      }
    }
  }
}
