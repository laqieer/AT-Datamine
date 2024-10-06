-- このluaスクリプトは、MA_01B110_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-130,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_No")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:自殺行為にほかなりません
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410002")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,15,1)
-- ▲直接出力

	--★★ケイ★★:マーリン、私が賛成したのだ<br>リリアーナとエクセリアの処遇については
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410003")


	--★★ケイ★★:彼女らを学園で泳がせることで<br>こちらにも利がなくはない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")

	--★★ケイ★★:彼女らに恩を売ったところで<br>そう簡単に情報をしゃべるとは思えないが…
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410005")


	--★★ケイ★★:ガラハッドやフィエナの信頼を得るには十分<br>かつての同胞が監禁状態では探索に身も入るまい
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410006")


	--★★ケイ★★:反逆の意志あれば<br>監視役が報せてくれるはずだ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410007")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:王のもとにはすべて平等…と<br>お考えなのでしょうね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-30,1)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:贔屓は良くないかなあと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410011")


	--★★マーリン★★:国民も学園生徒も騎士も<br>家族も敵も、偏らぬ感情で処遇を決められる
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410013")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力

	--★★マーリン★★:ですがそれはときに<br>親しき者の心を締め付けます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410015")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
set_rot(Actor003,{0,15,0})
set_common_look_at(Actor003,Actor001)
-- ▲直接出力

	--★★ランスロット★★:…そのつもりでいますよ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_410016")

	change_face(Actor003,"Anger")

	--★★マーリン★★:エクセリアとリリアーナの目的は明らかです<br>ランスロット卿としてもそれは不本意では？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410017")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ランスロット★★:王の御身を守護する、彼の意志も尊重する<br>継承者の劔としての責務も果たす
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_410018")


	--★★ランスロット★★:家族のことも守り切ってみせます<br>そのために培った力ですから
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_410020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★マーリン★★:…もっとも強き者は<br>己の脆さには無関心と見えますね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410021")


	--★★ケイ★★:マーリン<br>ランスロットも覚悟のうえであろう…
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410022")


	--★★マーリン★★:…その覚悟は、ランスロット様…<br>ノワール様をも苦しめるとおわかりですか？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B110_410023")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
turn_chara(Actor003,-30,1)
change_face(Actor003,"Surprise")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★アーサー★★:…ッ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410025")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ケイ★★:…我が王、いかがされた？
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★アーサー★★:…いや、なんでもない！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410028")

	change_face(Actor002,"Smile")

	--★★アーサー★★:昼に食べたホットドッグが胃にもたれたようだ<br>すまん！続けてくれ、義兄さん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410029")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor003,"Sad")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:…そういうことに、したいのだな？
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01B110_410030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:………
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_410032")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor001)
Hide(Actor003)
Hide(Actor004)
change_face(Actor002,"Normal")
setup_small_camera_start(Camera002)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★アーサー★★:………はぁ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410034")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor001,Camera001,EntryData110101_01_01,CameraAssetBundleName110101_01,CameraPos110101_01_101)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:下手な嘘だったな<br>お前にしては
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B110_410036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:上手な嘘なぞ<br>つけた試しがないよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410038")

	change_face(Actor002,"Normal")

	--★★アーサー★★:然るべきときが来たら<br>助けを求めてお前に叫ぶよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★アーサー★★:そのときは<br>ひとおもいにやってくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_410042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
