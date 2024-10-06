-- このluaスクリプトは、MA_01B900_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_003)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
load_image("103020030", "content_still_10302003_image", "103020030_StillImage")
load_sound("VO_story01")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101041","001","101041001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マルディサント", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…ざけんな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_190002")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:マァル
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_190003")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力

	--★★マルディサント★★:ざけんなよおお…<br>まじでえええ…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_190005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:優しかったよね<br>ずっと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_190006")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:ずっと騙してやがったのか<br>アタシたちのこと
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_190007")


	--★★ディナタン★★:…ウソをついていたようにも見えなかった<br>きっとどれも、モルガン先生の本当で──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_190008")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力

	--★★マルディサント★★:あれが仮にウソでも構やしねえ<br>アタシにとっちゃ大好きな人に変わりねえ…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_190009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん…<br>それで、それで少しだけ、ね…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_190010")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:母さんに似てたんだ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_190011")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
 --フェードアウト
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 --エフェクト開始
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103020030", 0.0, 0.0, 0.0) --回想スチルを表示
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★モルガン★★:わたしはうまく動けないから
	Talk(Actor003,"CHRNAME_MORGAN","simple","N","MA_01B900_190013")


	--★★モルガン★★:些細なことでしか<br>学園の子たちの力になれないけど
	Talk(Actor003,"CHRNAME_MORGAN","simple","N","MA_01B900_191001")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:抗うすべ、選び抜く道、その先の平和に…<br>ノワールくん――貴方の武器が要るわ
	Talk(Actor003,"CHRNAME_MORGAN","simple","N","MA_01B900_190015")

	change_face(Actor003,"Smile")

	--★★モルガン★★:ふんばろうねっ<br>どんなに辛いことがあっても
	Talk(Actor003,"CHRNAME_MORGAN","simple","N","MA_01B900_190017")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103020030", "content_still_10302003_image", "103020030_StillImage")
preload_sound("VO_story01")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101041","001","101041001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
