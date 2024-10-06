-- このluaスクリプトは、PT3_01B_12_003.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:ノワール、あの…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_12_003002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フィエナ？どうしたんだ？<br>なにか俺に相談か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★フィエナ★★:えっと…<br>ギネヴィア王妃とマーリンさんのこと…ごめんね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_12_003004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナが謝ることじゃないだろ<br>ふたりとも元気だったし、なにも問題はないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それに、ギネヴィアもマーリンさんも<br>フィエナのことを恨んだりしてないと思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フィエナ★★:そうかな…？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_12_003007")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:むしろ、ふたりをなによりも元気づけられるのは<br>フィエナの元気な笑顔だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:「ごめんなさい」って<br>謝るんじゃなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:「スノードン山ではありがとう」って<br>言ってやってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_12_003010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:…うん！ありがと、ノワール！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_12_003011")

-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
