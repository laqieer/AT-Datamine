// Decompiled with JetBrains decompiler
// Type: Alonedite.AlonediteSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Alonedite
{
  [Token(Token = "0x200286A")]
  [CreateAssetMenu(menuName = "Home/Alonedite Settings Asset")]
  public class AlonediteSettingsAsset : ScriptableObject
  {
    [Token(Token = "0x400AC46")]
    [FieldOffset(Offset = "0x18")]
    public List<int> characterStyleIdList;
    [Token(Token = "0x400AC47")]
    [FieldOffset(Offset = "0x20")]
    public int weaponId;

    [Token(Token = "0x600FEA0")]
    [Address(RVA = "0x40F02E0", Offset = "0x40F02E0", VA = "0x40F02E0")]
    public AlonediteSettingsAsset()
    {
    }
  }
}
