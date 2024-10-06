// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableBuildSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Prop;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C9")]
  [Serializable]
  public sealed class StoryAreaMovableBuildSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005585")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005586")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005587")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int unitID;
    [Token(Token = "0x4005588")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string animationName;
    [Token(Token = "0x4005589")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int propID_A;
    [Token(Token = "0x400558A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string propAttach_A;
    [Token(Token = "0x400558B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public StoryIKSettingEnum propIK_A;
    [Token(Token = "0x400558C")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public float propIKPosWeight_A;
    [Token(Token = "0x400558D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public float propIKRotWeight_A;
    [Token(Token = "0x400558E")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int propID_B;
    [Token(Token = "0x400558F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string propAttach_B;

    [Token(Token = "0x17000F5C")]
    public int Key
    {
      [Token(Token = "0x60065C9"), Address(RVA = "0x4D1ED4C", Offset = "0x4D1ED4C", VA = "0x4D1ED4C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065CA")]
    [Address(RVA = "0x4D1ED54", Offset = "0x4D1ED54", VA = "0x4D1ED54", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065CB")]
    [Address(RVA = "0x4D1F1C0", Offset = "0x4D1F1C0", VA = "0x4D1F1C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F5D")]
    public PropSettingData PropDataA
    {
      [Token(Token = "0x60065CC"), Address(RVA = "0x4D1F2E4", Offset = "0x4D1F2E4", VA = "0x4D1F2E4")] get
      {
        return new PropSettingData();
      }
    }

    [Token(Token = "0x17000F5E")]
    public PropSettingData PropDataB
    {
      [Token(Token = "0x60065CD"), Address(RVA = "0x4D1F300", Offset = "0x4D1F300", VA = "0x4D1F300")] get
      {
        return new PropSettingData();
      }
    }

    [Token(Token = "0x60065CE")]
    [Address(RVA = "0x4D1F318", Offset = "0x4D1F318", VA = "0x4D1F318")]
    public PropSettingData[] GetProps(bool validOnly = false) => (PropSettingData[]) null;

    [Token(Token = "0x60065CF")]
    [Address(RVA = "0x4D1F530", Offset = "0x4D1F530", VA = "0x4D1F530")]
    public StoryAreaMovableBuildSettingData()
    {
    }
  }
}
