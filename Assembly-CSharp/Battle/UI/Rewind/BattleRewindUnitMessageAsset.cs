// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindUnitMessageAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002468")]
  [CreateAssetMenu(menuName = "staq/Battle/UI/Rewind/Retreat Unit Message Asset")]
  public class BattleRewindUnitMessageAsset : ScriptableObject
  {
    [Token(Token = "0x4009C2E")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("撤退ユニット情報メッセージリスト")]
    [SerializeField]
    public List<BattleRewindUnitMessageData> Messages;

    [Token(Token = "0x600DF44")]
    [Address(RVA = "0x2018E74", Offset = "0x2018E74", VA = "0x2018E74")]
    public BattleRewindUnitMessageAsset()
    {
    }
  }
}
