// Decompiled with JetBrains decompiler
// Type: StaqData.BattleItemset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FE8")]
  public class BattleItemset
  {
    [Token(Token = "0x4008820")]
    private const int ItemLimit = 15;
    [Token(Token = "0x4008823")]
    [FieldOffset(Offset = "0x28")]
    private Expendable[] expendables;

    [Token(Token = "0x14000131")]
    internal event BattleItemset.UpdateDelegate OnUpdateEvent
    {
      [Token(Token = "0x600BD8C"), Address(RVA = "0x1E59CA8", Offset = "0x1E59CA8", VA = "0x1E59CA8")] add
      {
      }
      [Token(Token = "0x600BD8D"), Address(RVA = "0x1E59D44", Offset = "0x1E59D44", VA = "0x1E59D44")] remove
      {
      }
    }

    [Token(Token = "0x17002741")]
    public int Idx
    {
      [Token(Token = "0x600BD8E"), Address(RVA = "0x1E59DE0", Offset = "0x1E59DE0", VA = "0x1E59DE0")] get
      {
        return new int();
      }
      [Token(Token = "0x600BD8F"), Address(RVA = "0x1E59DE8", Offset = "0x1E59DE8", VA = "0x1E59DE8")] private set
      {
      }
    }

    [Token(Token = "0x17002742")]
    public string Name
    {
      [Token(Token = "0x600BD90"), Address(RVA = "0x1E59DF0", Offset = "0x1E59DF0", VA = "0x1E59DF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BD91"), Address(RVA = "0x1E59DF8", Offset = "0x1E59DF8", VA = "0x1E59DF8")] private set
      {
      }
    }

    [Token(Token = "0x17002743")]
    public IReadOnlyList<Expendable> Expendables
    {
      [Token(Token = "0x600BD92"), Address(RVA = "0x1E59E00", Offset = "0x1E59E00", VA = "0x1E59E00")] get
      {
        return (IReadOnlyList<Expendable>) null;
      }
    }

    [Token(Token = "0x600BD93")]
    [Address(RVA = "0x1E59E08", Offset = "0x1E59E08", VA = "0x1E59E08")]
    private BattleItemset()
    {
    }

    [Token(Token = "0x600BD94")]
    [Address(RVA = "0x1E59E60", Offset = "0x1E59E60", VA = "0x1E59E60")]
    public void Rename(string name)
    {
    }

    [Token(Token = "0x600BD95")]
    [Address(RVA = "0x1E59E8C", Offset = "0x1E59E8C", VA = "0x1E59E8C")]
    public void Equip(Expendable expendable)
    {
    }

    [Token(Token = "0x600BD96")]
    [Address(RVA = "0x1E59FA8", Offset = "0x1E59FA8", VA = "0x1E59FA8")]
    public void UnEquip(Expendable expendable)
    {
    }

    [Token(Token = "0x600BD97")]
    [Address(RVA = "0x1E5A19C", Offset = "0x1E5A19C", VA = "0x1E5A19C")]
    private void ApplyExpendables(List<Expendable> srcExpendables)
    {
    }

    [Token(Token = "0x600BD98")]
    [Address(RVA = "0x1E5A370", Offset = "0x1E5A370", VA = "0x1E5A370")]
    private void ResetExpendables()
    {
    }

    [Token(Token = "0x600BD99")]
    [Address(RVA = "0x1E5A3D8", Offset = "0x1E5A3D8", VA = "0x1E5A3D8")]
    public static BattleItemset CreateEmptyItemSet(int index) => (BattleItemset) null;

    [Token(Token = "0x600BD9A")]
    [Address(RVA = "0x1E5A45C", Offset = "0x1E5A45C", VA = "0x1E5A45C")]
    public static BattleItemset CreateByServerData(PlayerItemsetType entity)
    {
      return (BattleItemset) null;
    }

    [Token(Token = "0x600BD9B")]
    [Address(RVA = "0x1E5A608", Offset = "0x1E5A608", VA = "0x1E5A608")]
    public static BattleItemset CreateByDummyData(int index, string name, int[] items)
    {
      return (BattleItemset) null;
    }

    [Token(Token = "0x2001FE9")]
    internal delegate void UpdateDelegate(string name, Expendable[] expendables);
  }
}
