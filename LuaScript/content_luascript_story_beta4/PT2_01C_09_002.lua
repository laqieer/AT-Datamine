-- このluaスクリプトは、PT2_01C_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラグネルにフレン？<br>ふたりで朝からなにをやってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0020002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:おはよう、ノワール
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01C_09_0020003")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:おはよー、ノワールくん！<br>ラグネルちゃんにね、手芸を教わりに来たんだ
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:フレンが手芸…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0020005")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フレン★★:なにその顔、失礼しちゃうなあ！<br>私だって女の子なんだから手芸くらい…
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:やったことあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0020007")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★フレン★★:ないけど！
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020008")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:たはは…
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01C_09_0020009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フレン★★:ロ、ローラがやってるのを<br>見ていたことはあるからっ！
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フレン★★:だからね。ローラが途中まで作っていたものを<br>完成させておいてあげようと思って
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020011")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:ローラが戻ってくるまでに
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いいお姉さんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_09_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:フレンちゃん、ゆっくりはしてられないよ？<br>ローラちゃん、すぐ戻ってこられるかもだし！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01C_09_0020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ラグネル★★:スパルタでいくからね！？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01C_09_0020015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フレン★★:はいっ、先生！
	Talk(Actor003,"CHRNAME_FREN","speech","L","PT2_01C_09_0020016")

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
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
