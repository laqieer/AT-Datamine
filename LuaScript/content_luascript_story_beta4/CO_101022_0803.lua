-- このluaスクリプトは、CO_101022_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:黒幕がいるっていうのはわかったけど結局誰だったのかまでははっきりしないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030002")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そんなもんだ。あんなトカゲの尻尾に自分の正体をバラす方が珍しいぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ウワサの調査は終わったって言えるかもしれないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030005")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:問題はむしろこれからだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08030006")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:逃げるなら今のうちだぜ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08030008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:しないさ、そんなこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ここまで来たんだ最後まで付き合う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:放っておくと、あんたひとりで暴れるだけ暴れて満足しそうだからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030011")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お目付け役が必要だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力

	--★★モルドレッド★★:はは！言うじゃねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08030014")


	--★★モルドレッド★★:頼りにしてるぜ？ノワール
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08030015")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
