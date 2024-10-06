-- このluaスクリプトは、CO_101064_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:ノワールさん、お疲れ様でした<br>今日はこのあたりにして大聖堂に戻りましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020002")

	change_face(Actor002,"Surprise")

	--★★リアム★★:…ん？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（男）★★:リアム！<br>おい、てめえリアムだろ！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020005")

	change_face(Actor002,"Normal")

	--★★リアム★★:確かに、私は司祭のリアムですが――
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020006")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リアム★★:お前…！<br>いや、貴方は…キース
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020008")

	PlayAction(Actor003,"to  Std_Joy")

	--★★市民（男）★★:おかしな恰好してっからわからなかったぜ<br>昔の仲間が知ったら大笑いだぞ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020010")


	--★★市民（男）★★:やっぱりお前もあの噂を聞きつけてきたのか？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（知り合いか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_08020013")

	change_face(Actor002,"Normal")

	--★★リアム★★:あの噂とは…どの噂でしょう？<br>それに私はこの街の大聖堂に仕える司祭です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020015")

	PlayAction(Actor003,"to  Std_Worry")

	--★★市民（男）★★:なんだその口調？もうちょい再会を喜べよ<br>まぁいいや
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020016")


	--★★市民（男）★★:最近『黒牙団』を名乗る輩が<br>幅を利かせてるって噂があってよ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020017")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★リアム★★:黒牙団が…？<br>俺た…いえ、あのチームはもうないはずでは
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）★★:てめえも知ってのとおり<br>傭兵どもの襲撃でオレたち黒牙団は壊滅
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020019")


	--★★市民（男）★★:お前が行方知れずになったことをきっかけに<br>他のメンバーも散り散りになっちまった
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020020")


	--★★市民（男）★★:ところが最近になって
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020021")


	--★★市民（男）★★:黒牙団が<br>ログレス周辺で暴れ始めたって噂が流れてきた
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020022")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（男）★★:正直言ってマユツバだが<br>またアイツらに会えるかもしれねえ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020023")


	--★★市民（男）★★:そう思ってこの街にやってきてみたら<br>てめえに会えたってワケだ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020024")


	--★★リアム★★:他にも貴方のような方が？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（男）★★:ロッシーとヨッシーも来てるみてえだぜ<br>「観光してくる」つってどっか行ったけどな
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020026")

	change_face(Actor002,"Normal")

	--★★リアム★★:ですが、あのチームがなくなったのは確かです<br>再結成したとも聞いていません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020028")

	PlayAction(Actor003,"to  Std_Worry")

	--★★市民（男）★★:おそらくだがよ、再結成じゃねえんだ<br>オレたちとはまったく別の連中が
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020029")


	--★★市民（男）★★:黒牙団の名前を騙って<br>このあたりで悪さを働いてんだ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020030")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リアム★★:なんですって？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020032")

	PlayAction(Actor003,"to  Std_Angry")

	--★★市民（男）★★:許せねぇんだ、オレは
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020033")


	--★★市民（男）★★:黒牙団はオレらの家だ<br>見ず知らずのヤツらに乗っ取られてたまるか！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020034")


	--★★市民（男）★★:なあ、リアム<br>またオレたちとバカやんねえか？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020036")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（男）★★:一緒にニセモンをぶっ潰してよ<br>黒牙団を取り戻そうぜ！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020037")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★リアム★★:お断りします
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020039")

	PlayAction(Actor003,"to  Std_Surp")

	--★★市民（男）★★:なんだって…？
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020040")


	--★★リアム★★:私はこの街の大聖堂につとめる司祭リアムです<br>それ以外の何者でもありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020041")


	--★★市民（男）★★:なっ…！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020042")


	--★★市民（男）★★:ふざけんじゃねぇ！！<br>それでも黒牙団のリーダーかよ！！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020043")


	--★★市民（男）★★:看板に泥塗られて知らねえ顔するなんてよ<br>随分軟弱になったもんだなオイ！！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020044")


	--★★市民（男）★★:見損なったぜっ…！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_08020046")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:もう死んだんですよ。そいつは
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020048")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あの…リアムさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08020050")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:ああ、ノワールさん<br>…失礼。恥ずかしい所をお見せしました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020052")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:いや、俺はいいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08020053")


	--★★ノワール★★:今のって、昔の知り合い…だよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08020054")

	change_face(Actor002,"Normal")

	--★★リアム★★:ここでは街の方の目があります<br>大聖堂に行きましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08020056")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ8_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
