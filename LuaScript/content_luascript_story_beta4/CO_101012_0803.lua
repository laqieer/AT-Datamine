-- このluaスクリプトは、CO_101012_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★トリスタン★★:作曲を頼みたいって？このボクに？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030002")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:だ、駄目ですか…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08030003")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:…別に、駄目じゃないよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:キミが療養院を手伝ってくれてるおかげで<br>イゾルデもだいぶ助かってるみたいだし
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:そもそも曲作りはイゾルデの発案みたいだから<br>特別に少しくらいなら手伝ってあげてもいいよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030006")


	--★★トリスタン★★:ただ…
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ただ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08030009")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:…少し前に学園が襲撃されたときにさ<br>事故でボクの竪琴が壊されちゃったんだ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030010")


	--★★トリスタン★★:馴染みの楽器屋なら直してくれると思うけど<br>いろいろ立て込んでて修理に行けてなくてね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:あの竪琴がないと気晴らしもできやしない<br>ほんと嫌になるよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:じゃあ、俺たちが代わりに行って<br>修理してもらってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08030013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:そう？悪いね<br>楽器屋はコーンウォールにあるから
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101012_08030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:よし。行こう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08030015")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ8_4")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
