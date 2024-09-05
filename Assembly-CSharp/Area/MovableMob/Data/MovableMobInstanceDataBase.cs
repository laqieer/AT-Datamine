// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableMobInstanceDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Instance;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283B")]
  public abstract class MovableMobInstanceDataBase
  {
    [Token(Token = "0x170037AD")]
    public int InstanceDataID
    {
      [Token(Token = "0x600FD46"), Address(RVA = "0x442E114", Offset = "0x442E114", VA = "0x442E114")] get
      {
        return new int();
      }
      [Token(Token = "0x600FD47"), Address(RVA = "0x442E11C", Offset = "0x442E11C", VA = "0x442E11C")] protected set
      {
      }
    }

    [Token(Token = "0x600FD48")]
    [Address(RVA = "0x442B880", Offset = "0x442B880", VA = "0x442B880")]
    public void SetInstanceDataID(int id)
    {
    }

    [Token(Token = "0x600FD49")]
    public abstract MovableMobType GetMobType();

    [Token(Token = "0x600FD4A")]
    public abstract MovableMobInstanceBase CreateInstance(
      MovableMobRouteHandler owner,
      IMovableMobAnchor startAnchor,
      Transform player);

    [Token(Token = "0x600FD4B")]
    [Address(RVA = "0x442E124", Offset = "0x442E124", VA = "0x442E124")]
    protected MovableMobInstanceDataBase()
    {
    }
  }
}
