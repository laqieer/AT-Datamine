// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BaseMaster`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E5")]
  public abstract class BaseMaster<TEntity> where TEntity : IMasterDataEntity, new()
  {
    [Token(Token = "0x4005CDA")]
    [FieldOffset(Offset = "0x0")]
    public Dictionary<int, TEntity> entities;

    [Token(Token = "0x170010BC")]
    public int DataCount
    {
      [Token(Token = "0x6006FAC")] get => new int();
    }

    [Token(Token = "0x6006FAD")]
    public virtual void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006FAE")]
    protected virtual TEntity LoadEntity(IMasterDataReader reader) => (TEntity) null;

    [Token(Token = "0x6006FAF")]
    public TEntity Get(int key) => (TEntity) null;

    [Token(Token = "0x6006FB0")]
    public bool Compare(BaseMaster<TEntity> other) => new bool();

    [Token(Token = "0x6006FB1")]
    protected BaseMaster()
    {
    }
  }
}
