-- このluaスクリプトは、PT3_01C_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モルドレッド<br>こんなところでなにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_002003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力

	--★★モルドレッド★★:あァ？<br>うるせぇな、なにもしてねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002004")

	PlayAction(Actor002,"to  Std_Angry")

	--★★モルドレッド★★:っていうかよ！<br>なんでどいつもこいつもなにもしてねえんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002005")


	--★★モルドレッド★★:ハロウィンだの<br>パレードだのと浮かれてる状況か？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("モルドレッド", "悲しみ")
-- ▲直接出力

	--★★モルドレッド★★:またアーサーのヤロウが<br>攻めてきたらどうするつもりなんだ！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こんな状況だからこそ<br>みんな明るく振る舞おうとしてるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★モルドレッド★★:チッ…！<br>付き合いきれねえぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT3_01C_11_002009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
