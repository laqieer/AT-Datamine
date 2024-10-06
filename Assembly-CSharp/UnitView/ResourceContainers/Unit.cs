// Decompiled with JetBrains decompiler
// Type: UnitView.ResourceContainers.Unit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnitView.UI.Test;
using UnityEngine;

#nullable disable
namespace UnitView.ResourceContainers
{
  [Token(Token = "0x20003C8")]
  [Serializable]
  public class Unit
  {
    [Token(Token = "0x400163D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name;
    [Token(Token = "0x400163E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitInfo unitInfo;
    [Token(Token = "0x400163F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject unitModel;
    [Token(Token = "0x4001640")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject riddenUnitModel;
    [Token(Token = "0x4001641")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Unit.BackgroundData bg;

    [Token(Token = "0x17000246")]
    public string Name
    {
      [Token(Token = "0x60015F1"), Address(RVA = "0x24851DC", Offset = "0x24851DC", VA = "0x24851DC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000247")]
    public UnitInfo UnitInfo
    {
      [Token(Token = "0x60015F2"), Address(RVA = "0x24851E4", Offset = "0x24851E4", VA = "0x24851E4")] get
      {
        return (UnitInfo) null;
      }
    }

    [Token(Token = "0x17000248")]
    public GameObject UnitModel
    {
      [Token(Token = "0x60015F3"), Address(RVA = "0x24851EC", Offset = "0x24851EC", VA = "0x24851EC")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17000249")]
    public GameObject RiddenUnitModel
    {
      [Token(Token = "0x60015F4"), Address(RVA = "0x24851F4", Offset = "0x24851F4", VA = "0x24851F4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700024A")]
    public Unit.BackgroundData BackGround
    {
      [Token(Token = "0x60015F5"), Address(RVA = "0x24851FC", Offset = "0x24851FC", VA = "0x24851FC")] get
      {
        return (Unit.BackgroundData) null;
      }
    }

    [Token(Token = "0x60015F6")]
    [Address(RVA = "0x2485204", Offset = "0x2485204", VA = "0x2485204")]
    public void DebugLog()
    {
    }

    [Token(Token = "0x60015F7")]
    [Address(RVA = "0x2485208", Offset = "0x2485208", VA = "0x2485208")]
    public Unit()
    {
    }

    [Token(Token = "0x20003C9")]
    [Serializable]
    public class BackgroundData
    {
      [Token(Token = "0x4001642")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Sprite unit;

      [Token(Token = "0x1700024B")]
      public Sprite Unit
      {
        [Token(Token = "0x60015F8"), Address(RVA = "0x2485258", Offset = "0x2485258", VA = "0x2485258")] get
        {
          return (Sprite) null;
        }
      }

      [Token(Token = "0x60015F9")]
      [Address(RVA = "0x2485260", Offset = "0x2485260", VA = "0x2485260")]
      public BackgroundData()
      {
      }
    }
  }
}
