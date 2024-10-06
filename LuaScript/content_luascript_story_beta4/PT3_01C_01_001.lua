-- このluaスクリプトは、PT3_01C_01_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力

	--★★リオネス★★:ノワール、最近元気がないな
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001001")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やあ、リオネス<br>そうだな、さすがに今はちょっと余裕がないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "悩む")
-- ▲直接出力

	--★★リオネス★★:無理する必要はないと思うぞ<br>悲しいときはめいっぱい悲しいむべきだ
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:リオネス…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リオネス★★:あたしも<br>大事な人を亡くした気持ちはよくわかる
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:リオネスも…あるのか？<br>その…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リオネス★★:こんな時代だ。なにも失わずに<br>いられるやつなんて少ないと思うぞ？
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "悩む")
-- ▲直接出力

	--★★リオネス★★:でも、こんな時代だからこそ<br>生きてるあたしがやらなきゃならないことがある
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★リオネス★★:覚えていること、だ
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力

	--★★リオネス★★:生きているあたしが<br>あいつらのことを覚えている限り
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001013")


	--★★リオネス★★:あたしのなかで、あいつらは死んでない<br>一緒に生きているんだ
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001014")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:…強いな、リオネスは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_001015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:うん<br>強いんだ、リオネスは
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","PT3_01C_01_001016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
