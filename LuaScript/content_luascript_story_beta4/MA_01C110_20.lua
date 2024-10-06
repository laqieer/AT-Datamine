-- このluaスクリプトは、MA_01C110_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:兄さん、あのね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ディナタン、どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_200005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あの森から戻ってから<br>ブライアンさんのことが気になって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200006")


	--★★ディナタン★★:ちゃんとお別れ言ってなかったなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200007")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも気になるけど<br>森でのことが全然思い出せないの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺もだ<br>なにか大切なことを忘れている気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_200009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:でも、もしかしたら、みんな<br>同じ思いを抱えているのかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_200010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そうだね…<br>私たち、忘れちゃうから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200011")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今度の休みの日<br>リムニーナ村まで行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_200012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:リムニーナ村？<br>ロジーの里じゃなくて？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_200013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そう、リムニーナ村だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_200014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
