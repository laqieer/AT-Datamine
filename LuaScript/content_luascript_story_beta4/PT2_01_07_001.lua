-- このluaスクリプトは、PT2_01_07_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:おはようございます<br>ノワール様
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはようございます、ギネマウアさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あれ？<br>ギネヴィアは一緒じゃないんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010007")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:殿下は準備に忙しいようでして
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:準備？<br>なんの…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010009")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:特別補講にございます<br>ノワール様とディナタン様、マルディサント様の
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:えっ？<br>特別補講を受けるような成績はとってない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010011")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…とはいえないかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:本日の放課後、お二方を連れて<br>ログレス郊外の平原までお越しください
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっと、あの、内容を教えてほし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010014")


	--★★ギネマウア★★:…来ていただけますよね？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:は、はいっ<br>行かせていただきます！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_07_0010016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "喜び")
-- ▲直接出力

	--★★ギネマウア★★:それでは、お待ちしております
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT2_01_07_0010017")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（今日の放課後か…忘れないようにしないとな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_07_0010018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
