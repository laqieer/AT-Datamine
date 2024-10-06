-- このluaスクリプトは、PT2_01B_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("104000160", "content_still_10400016_image", "104000160_StillImage")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ずいぶんと遅い到着じゃないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ボクを待たせるなんて<br>キミは自分の立場がわかっているのかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010006")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:やあ、パーシヴァル<br>今日は道案内を頼むよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:道案内ぃ？<br>なにを勘違いしているんだ、キミは
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010008")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:今回の遠征はボクが聖杯を手にし<br>英雄への道を駆け上がる物語の序章だ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:キミはその証人のひとりに過ぎない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:なんだかよくわからないけど<br>まあそれでいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0010011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:パーシヴァル様、これを
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010012")

-- ▼直接出力
ShowImageItem("104000160")
wait_time(1.0)
HideImageItem()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor001,"Surprise")

	--★★パーシヴァル★★:あっ！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","N","PT2_01B_10_0010013")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それは？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","PT2_01B_10_0010014")

	close_cutin()
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:パーシヴァル様が<br>今日のために用意されていた旅のしおりです
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ディンドラン★★:みなさまのぶんも…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010016")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ち、違う！<br>これはその、アレだ！そんなんじゃない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010017")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:アレってなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力

	--★★パーシヴァル★★:アレはアレだ！<br>いちいち追求しなくていい！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010019")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:ふふっ<br>パー坊…いえ、パーシヴァル様は
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010020")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:今回の遠征を<br>とても楽しみにされていらっしゃいました
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディンドラン★★:ちょっとハシャぎ過ぎてしまうかもしれませんが<br>大目に見てあげてくださいね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","PT2_01B_10_0010022")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:おい、そこ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:はい<br>わかっているつもりです…なんとなくですけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0010024")


	--★★パーシヴァル★★:おい、わかるな！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")

	--★★パーシヴァル★★:ギー…！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0010026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000160", "content_still_10400016_image", "104000160_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
