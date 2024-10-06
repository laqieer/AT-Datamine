-- このluaスクリプトは、PT2_01_05_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
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
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ケイ", "挨拶")
-- ▲直接出力

	--★★ケイ★★:帰ったか
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…またあんたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:監視なら不要だ<br>俺は戦いを前に逃げるような真似はしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:勘違いするな<br>私はねぎらいに来たのだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070008")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ねぎらい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070009")

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:今回の戦いは敵の数が定かではない<br>一歩間違えば命を落とす…
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ケイ★★:いや、一歩間違えばどころの話ではないな<br>命を棄てに行くというほうが正しいかもしれない
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070011")


	--★★ケイ★★:そんな戦いに<br>身を投じてくれると言ってくれた…
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070012")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ケイ、あんた…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070013")


	--★★ケイ★★:本隊に参加してくれる生徒の皆に
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070014")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:は？<br>本隊に参加する生徒？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:そうだ。今回、ランスロットの率いる本隊には<br>学園の生徒も動員されることになっている
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:そのうちの何名かが<br>この寮で生活していてな
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へ、へえ、そうなのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:紅茶も飲み終えたし<br>そろそろ彼らの部屋へ行くとしよう
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070019")


	--★★ケイ★★:そういえば当日<br>貴公は別動隊に参加するのだったな
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:せいぜい頑張りたまえ
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT2_01_05_0070021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>いわれなくても、そうするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0070022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
