-- このluaスクリプトは、PT4_01_06_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:クリスティーナさん？寮にいるなんて珍しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:あら、ノワールちゃんちょっとお邪魔してるわよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:寮生の誰かに用事？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:そう。返却期限を過ぎても本を返してくれない困った子がいてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだったのか呼んで来ようか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:ありがと。でも大丈夫よちょうどさっき返してもらったところだから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:クリスティーナさんってずいぶん生徒の扱いに慣れてるよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:そうかしら？自分では考えたことなかったけど…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020009")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:私、賑やかな子たちが集まるグループにいたことがあって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:そこにいた先輩に人との付き合い方を教わったことがあるの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:その人のおかげかもしれないわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ～どんな人だったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ガサツで大雑把でデリカシーの欠片もないけど仲間や家族のことをすごく大事にする人だったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020014")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:その人は今どこに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0020015")


	--★★クリスティーナ★★:さあ？根無し草のような生きかたをする人だったから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:意外に近くにいたりするかもしれないけどねふふっ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT4_01_06_0020017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
