-- このluaスクリプトは、MA_01B900_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor001,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor006")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:わ、たし、が………？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_260002")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ユーサーと妖精ニニアンの罪咎<br>王家を揺るがす穢れの元凶が産んだ子供
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260003")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:ディナタンが…<br>人と、妖精のあいだの………！？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_260005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ゆえに最後まで明かされず<br>師匠の記憶の奥底に封じられた真実
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260006")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:………こ、口外しては、ダメだ…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_260007")


	--★★ガラハッド★★:アーサー王の正体も<br>ディナタンが禁忌の末の子であることも…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_260008")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力

	--★★ランスロット★★:なんとしても<br>アーサーを殺さなければならなかった
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260009")


	--★★ランスロット★★:アーサーがバルバロイの王として<br>表に現れれば終わりだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260010")


	--★★ランスロット★★:バルバロイとしても脅威だろうが<br>それ以上に…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:ユーサー王から継がれたログレス国と<br>彼への信頼と忠誠で構築された騎士の学び舎だ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_260012")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:このブリテン唯一、対バルバロイの砦<br>その根幹が揺らいでしまう…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_260013")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ランスロット★★:俺がアーサーを<br>殺さなければならなかったんだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:………
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_260016")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力

	--★★ランスロット★★:足踏みをしては<br>いけなかった
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B900_260018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
