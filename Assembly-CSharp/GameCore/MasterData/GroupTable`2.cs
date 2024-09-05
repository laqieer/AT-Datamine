// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GroupTable`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001407")]
  public class GroupTable<TKey, TEntity>
  {
    [Token(Token = "0x4005CF4")]
    [FieldOffset(Offset = "0x0")]
    private Func<TEntity, TKey> keySelectror;
    [Token(Token = "0x4005CF5")]
    [FieldOffset(Offset = "0x0")]
    private Func<TEntity, bool> validation;
    [Token(Token = "0x4005CF6")]
    [FieldOffset(Offset = "0x0")]
    private Dictionary<TKey, List<TEntity>> groupedTable;

    [Token(Token = "0x60070F9")]
    public void Initialize(Func<TEntity, TKey> keySelectror, Func<TEntity, bool> validation = null)
    {
    }

    [Token(Token = "0x60070FA")]
    public void Add(TEntity entity)
    {
    }

    [Token(Token = "0x60070FB")]
    public List<TEntity> GetGroupedList(TKey key) => (List<TEntity>) null;

    [Token(Token = "0x60070FC")]
    public GroupTable()
    {
    }
  }
}
